using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Gammit
{
    class NativeMethods
    {
        [DllImport("User32.dll")]
        static public extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("User32.dll")]
        static public extern int ReleaseDC(IntPtr hWnd, IntPtr hdc);
    }
}
