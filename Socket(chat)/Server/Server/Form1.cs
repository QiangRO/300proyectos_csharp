using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    /// <summary>
    /// This is a simple TCP based client.
    /// </summary>
    public partial class FrmMain : Form
    {
        int localPort = 5150;// Port number for the destination
        int sendCount = 1;// Number of times to send the response
        int bufferSize = 4096;// Size of the send and receive buffers
        IPAddress localAddress = IPAddress.Any;
        SocketType sockType;
        ProtocolType sockProtocol;
        int rc;
        Socket clientSocket;
        byte[] receiveBuffer, sendBuffer;




        Socket serverSocket = null;

        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Thread clientThread = new Thread(new ThreadStart(RunServer));
            clientThread.Start();
        }

        /// <summary>
        /// This routine repeatedly copies a string message into a byte array until filled.
        /// </summary>
        /// <param name="dataBuffer">Byte buffer to fill with string message</param>
        /// <param name="message">String message to copy</param>
        public static void FormatBuffer(byte[] dataBuffer, string message)
        {
            byte[] byteMessage = System.Text.Encoding.ASCII.GetBytes(message);
            int index = 0;


            // Make sure another byte of data buffer became zero
            while (index < byteMessage.Length)
            {
                for (int j = 0; j < dataBuffer.Length; j++)
                {

                    if (index >= byteMessage.Length)
                    {
                        dataBuffer[j] = 0;
                    }
                    else
                    {
                        dataBuffer[j] = byteMessage[index];
                        index++;
                    }                    
                }
            }
        }


        /// <summary>
        /// it creates a listening socket and waits to accept a client
        /// connection. Once a client connects, it waits to receive a "request" message. The
        /// request is terminated by the client shutting down the connection. After the request is
        /// received, the server sends a response followed by shutting down its connection and 
        /// closing the socket. 
        /// </summary>
        private void RunServer()
        {
            // Local interface to bind to
            localAddress = IPAddress.Parse("127.0.0.1");

            receiveBuffer = new byte[bufferSize];
            sendBuffer = new byte[bufferSize];



            // Specified TCP 
            sockType = SocketType.Stream;
            sockProtocol = ProtocolType.Tcp;

            try
            {
                IPEndPoint localEndPoint = new IPEndPoint(localAddress, localPort);
                //IPEndPoint senderAddress = new IPEndPoint(localAddress, 0);



                // Create the server socket
                serverSocket = new Socket(localAddress.AddressFamily, sockType, sockProtocol);

                // Bind the socket to the local interface specified
                serverSocket.Bind(localEndPoint);
                string StrMessage = sockProtocol.ToString() + " server socket bound to " + localEndPoint.ToString();
                StatusLabel1.Text = StrMessage;

                // If TCP socket, set the socket to listening
                serverSocket.Listen(1);
            }
            catch (SocketException err)
            {
                StatusLabel1.Text = "Socket error occured: " + err.Message;
            }
            finally
            {
                // Close the socket if necessary
                //if (serverSocket != null)
                //    serverSocket.Close();
            }

            try
            {
                // Service clients in a loop
                while (true)
                {
                    // Wait for a client connection
                    clientSocket = serverSocket.Accept();

                    StatusLabel1.Text = "Accepted connection from: " + clientSocket.RemoteEndPoint.ToString();
                    if (clientSocket != null)
                        BtnSnd.Enabled = true;


                    while (true)
                    {
                        rc = clientSocket.Receive(receiveBuffer);

                        StatusLabel1.Text = "Read " + rc + " bytes";
                        if (rc > 0)
                            TxtbxRcv.Text += System.Text.Encoding.ASCII.GetString(receiveBuffer);

                        if (rc == 0)
                            break;
                    }
                }
            }
            catch (SocketException err)
            {
                StatusLabel1.Text = err.Message;
                clientSocket.Close();
                BtnSnd.Enabled = false;
            }
        }

        private void BtnSnd_Click(object sender, EventArgs e)
        {
            // Text message to put into the send buffer
            string textMessage = TxtbxSnd.Text.Trim();

            // Format the string message into the send buffer
            FormatBuffer(sendBuffer, textMessage + "\r\n");

            try
            {
                // Send the indicated number of response messages
                if (serverSocket != null)
                    for (int i = 0; i < sendCount; i++)
                    {
                        rc = clientSocket.Send(sendBuffer);

                        StatusLabel1.Text = "Sent " + rc + " bytes";
                    }
            }
            catch(Exception err)
            {
                StatusLabel1.Text = err.Message;
            }
            TxtbxSnd.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            try
            {
                // Shutdown the client connection
                if (clientSocket != null)
                {
                    clientSocket.Shutdown(SocketShutdown.Send);
                    clientSocket.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in exiting \n" + err.Message);
            }
            Application.ExitThread();
            System.Environment.Exit(System.Environment.ExitCode);
            Application.Exit();
        }

        
        private void TxtbxSnd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSnd_Click(null, null);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnExit_Click(null, null);
        }
    }
}
