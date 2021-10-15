//////////////////////////////////////
//              Hani                //
//          Tiny Turtle             //
//////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Wave.Wave_Class
{
    class WaveControl
    {
        // متغیر های سراسری
        protected Wave_Class.WaveOutPlayer m_Player;
        protected Wave_Class.FifoStream m_Fifo = new Wave_Class.FifoStream();
        protected System.IO.FileStream file;
        public bool IsPlay = false;
        protected byte[] m_PlayBuffer = new byte[8000];
        public Info info;

        // Delegate
        public delegate void Filler(IntPtr data, int size,byte[] PlayBuffer);
        public event Filler BufferFiller;

        public struct Info
        {
            public int PlayThisByte;
            public string File_description;
            public int Size_of_file;
            public string WAV_description;
            public string Format_description;
            public int Size_of_WAVE;
            public int WAVE_type;
            public int channel;
            public int Samples_per_second;
            public int Bytes_per_second;
            public int Block_alignment;
            public int Bits_per_sample;
            public string Data_description;
            public int Size_of_data;
        }

        // توابع

        /// <summary>
        /// Stop Music
        /// </summary>
        public void Stop()
        {
            if (m_Player != null)
            {
                m_Fifo.Flush();
                m_Fifo.Close();
                try
                {
                    m_Player.Dispose();
                    if (file != null)
                    {
                        file.Close();
                        file = null;
                    }
                }
                finally
                {
                    m_Player = null;
                }
                IsPlay = false;
            }
        }

        /// <summary>
        /// Play Music
        /// </summary>
        /// <param name="File">آدرس آهنگ</param>
        /// <param name="Rate">Rate</param>
        /// <returns></returns>
        public bool Start(string File, int Rate)
        {
            Stop();
            try
            {
                if (System.IO.File.Exists(File))
                {
                    file = System.IO.File.Open(File, System.IO.FileMode.Open);

                    if (file == null)
                    {
                        System.Windows.Forms.MessageBox.Show("No File", "Warning");
                        return false;
                    }
                    else
                    {
                        SetInfo(file);
                        Wave_Class.WaveFormat fmt = new Wave_Class.WaveFormat(Rate, info.Bits_per_sample, info.channel);
                        m_Player = new Wave_Class.WaveOutPlayer(-1, fmt, 5000, 16, new Wave_Class.BufferFillEventHandler(Filler1));
                        IsPlay = true;
                        return true;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No File");
                    return false;
                }
            }
            catch
            {
                Stop();
                return false;
            }
        }

        /// <summary>
        /// Play Music
        /// </summary>
        /// <param name="File">آدرس آهنگ</param>
        /// <returns></returns>
        public bool Start(string File)
        {
            Stop();
            try
            {
                if (System.IO.File.Exists(File))
                {
                    file = System.IO.File.Open(File, System.IO.FileMode.Open);

                    if (file == null)
                    {
                        System.Windows.Forms.MessageBox.Show("No File", "Warning");
                        return false;
                    }
                    else
                    {
                        SetInfo(file);
                        Wave_Class.WaveFormat fmt = new Wave_Class.WaveFormat(info.Samples_per_second, info.Bits_per_sample, info.channel);
                        m_Player = new Wave_Class.WaveOutPlayer(-1, fmt, 5000, 16, new Wave_Class.BufferFillEventHandler(Filler1));
                        IsPlay = true;
                        return true;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No File");
                    return false;
                }
            }
            catch
            {
                Stop();
                return false;
            }
        }


        /// <summary>
        /// اجرای آهنگ همراه با انتخاب تعداد و طول بافر
        /// </summary>
        /// <param name="File">آدرس آهنگ</param>
        /// <param name="BufferSize">طول بافر</param>
        /// <param name="BufferCount">تعداد بافر</param>
        /// <returns></returns>
        public bool Start(string File , int BufferSize , int BufferCount)
        {
            Stop();
            try
            {
                if (System.IO.File.Exists(File))
                {
                    file = System.IO.File.Open(File, System.IO.FileMode.Open);

                    if (file == null)
                    {
                        System.Windows.Forms.MessageBox.Show("No File", "Warning");
                        return false;
                    }
                    else
                    {
                        SetInfo(file);
                        Wave_Class.WaveFormat fmt = new Wave_Class.WaveFormat(info.Samples_per_second, info.Bits_per_sample, info.channel);
                        m_Player = new Wave_Class.WaveOutPlayer(-1, fmt, BufferSize, BufferCount, new Wave_Class.BufferFillEventHandler(Filler1));
                        IsPlay = true;
                        return true;
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No File");
                    return false;
                }
            }
            catch
            {
                Stop();
                return false;
            }
        }

        /// <summary>
        /// Start Music
        /// </summary>
        /// <param name="BufferCount">تعداد بافر</param>
        /// <returns></returns>
        public bool Start(int BufferCount, int BufferSize, int Rate, int BitPerSample, int channel)
        {
            Stop();
            try
            {
                Wave_Class.WaveFormat fmt = new Wave_Class.WaveFormat(Rate, BitPerSample, channel);
                m_Player = new Wave_Class.WaveOutPlayer(-1, fmt, BufferSize, BufferCount, new Wave_Class.BufferFillEventHandler(Filler2));
                IsPlay = true;
                return true;
            }
            catch
            {
                Stop();
                return false;
            }
        }

        /// <summary>
        /// تابع پر کردن بافر بدون فایل
        /// </summary>
        /// <param name="data"></param>
        /// <param name="size"></param>
        private void Filler2(IntPtr data, int size)
        {
            info.PlayThisByte += size;
            if (BufferFiller != null) BufferFiller(data, size, m_PlayBuffer);
            System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
        }


        /// <summary>
        /// تابع پر کردن بافر به وسیله ی فایل
        /// </summary>
        /// <param name="data"></param>
        /// <param name="size"></param>
        private void Filler1(IntPtr data, int size)
        {
            file.Read(m_PlayBuffer, 0, size);
            info.PlayThisByte += size;
            if (BufferFiller != null) BufferFiller(data, size,m_PlayBuffer);
            System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size);
        }

        /// <summary>
        /// قرار دادن اطلاعات در استراکچر 
        /// </summary>
        /// <param name="File">اشاره گر فایل</param>
        private void SetInfo(FileStream File)
        {
            info = new Info();
            byte[] byte_info = new byte[44];
            File.Read(byte_info, 0, 44);

            // پیدا کردن توشیحات فایل
            for (int i = 0; i < 4; i++)
                info.File_description += (char)byte_info[i];

            /// برای اینکه عدد هست به شکل زیر می خونیمش
            ///هر بایت ما 8 بیت است
            ///برای اینکه عدد رو به دست بیاریم هر کدوم رو باید نسب به مکانش * 8 شیفت بدیم
            /// 1   2   3 ====> 1 << 0 + 2 << 8 + 3 << 16 =================>> 123
            /// info.Size_of_file = (byte_info[7] << 24) +(byte_info[6] << 16 )+ (byte_info[5] << 8 )+( byte_info[4] << 0) ;
            for (int i = 4; i < 8; i++)
                info.Size_of_file += (byte_info[i] << (8 * (i - 4)));

            for (int i = 8; i < 12; i++)
                info.WAV_description += (char)byte_info[i];

            for (int i = 12; i < 16; i++)
                info.Format_description += (char)byte_info[i];

            for (int i = 16; i < 20; i++)
                info.Size_of_WAVE += (byte_info[i] << (8 * (i - 16)));

            // Wave Format
            for (int i = 20; i < 22; i++)
                info.WAVE_type += (byte_info[i] << (8 * (i - 20)));

            /// Chanel
            /// 1 == Mono
            /// 2 == Stero
            for (int i = 22; i < 24; i++)
                info.channel += (byte_info[i] << (8 * (i - 22)));

            //Samples per second
            for (int i = 24; i < 28; i++)
                info.Samples_per_second += (byte_info[i] << (8 * (i - 24)));

            //Bytes per second
            for (int i = 28; i < 32; i++)
                info.Bytes_per_second += (byte_info[i] << (8 * (i - 24)));

            //Block_alignment
            for (int i = 32; i < 34; i++)
                info.Block_alignment += (byte_info[i] << (8 * (i - 32)));

            //Bits_per_sample
            for (int i = 34; i < 36; i++)
                info.Bits_per_sample += (byte_info[i] << (8 * (i - 34)));

            //Data_description
            for (int i = 36; i < 40; i++)
                info.Data_description += (char)byte_info[i];

            for (int i = 40; i < 44; i++)
                info.Size_of_data += (byte_info[i] << (8 * (i - 40)));
        }
    }
}