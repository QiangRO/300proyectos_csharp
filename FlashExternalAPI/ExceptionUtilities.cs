using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vml.FLVPlayer
{
	/// <summary>
	/// Summary description for ExceptionUtilities.
	/// </summary>
	public sealed class ExceptionUtilities
	{
        private const string EventLogSource = "FLVPlayer";

        private static bool _eventLogInitialized;
        private static EventLog _eventLog;

        static ExceptionUtilities()
        {
            InitializeEventLog();
            _eventLog = new EventLog("Application");
            _eventLog.Source = ExceptionUtilities.EventLogSource;
        }

		private ExceptionUtilities(){}

        public static void DisplayException(Exception ex)
        {
            ExceptionUtilities.DisplayException("An unknown error occurred.", ex);
        }

        public static void DisplayException(string message)
        {
            MessageBox.Show(message, "Exception Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void DisplayException(string message, Exception ex)
        {
            LogException(message, ex);
            MessageBox.Show(message + "\n\nBelow are the details of the exception:\n\n" + ex.ToString(), "Exception Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void InitializeEventLog()
        {
            if(!ExceptionUtilities._eventLogInitialized)
            {
                if(!EventLog.SourceExists(ExceptionUtilities.EventLogSource))
                {
                    EventLog.CreateEventSource(ExceptionUtilities.EventLogSource, "Application");
                }

                ExceptionUtilities._eventLogInitialized = true;
            }
        }

        public static void LogException(Exception ex)
        {
            LogException(null, ex);
        }

        public static void LogException(string message, Exception ex)
        {
            try
            {
                string entryMessage;

                if(message != null && message.Length > 0)
                {
                    entryMessage = string.Format("{0}\n\n{1}\n{2}", message, ex.Message, ex.StackTrace);
                }
                else
                {
                    entryMessage = string.Format("{0}\n{2}", ex.Message, ex.StackTrace);
                }

                ExceptionUtilities._eventLog.WriteEntry(entryMessage);
            }
            // Just to be safe since we are logging
            catch(Exception exception){}
        }
	}
}
