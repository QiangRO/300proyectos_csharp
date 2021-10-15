using System;
using System.Runtime.InteropServices;

namespace DictionaryFromHamze.Win32
{
    public delegate int WindowProcDelegate(IntPtr hw, IntPtr uMsg, IntPtr wParam, IntPtr lParam);


    /// <summary>
    /// Windows User32 DLL declarations
    /// </summary>
    public class User32
    {
        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetClipboardViewer(IntPtr hWnd);

        [DllImport("User32.dll", CharSet = CharSet.Unicode)]
        public static extern bool ChangeClipboardChain(
            IntPtr hWndRemove,  // handle to window to remove
            IntPtr hWndNewNext  // handle to next window
            );
        
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// move the form with mouse click imports
        /// </summary>
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(int hwnd, int wMsg, int wParam, object lParam);
        public static int WM_NCLBUTTONDOWN = 161;

    }
    /// <summary>
    /// Windows Event Messages Reqiered for this project
    /// </summary>
    public enum Msgs
    {
        WM_DRAWCLIPBOARD = 0x0308,
        WM_CHANGECBCHAIN = 0x030D
    }

}
