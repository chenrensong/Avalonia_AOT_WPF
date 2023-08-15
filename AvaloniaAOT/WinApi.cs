using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaAOT
{
    public static unsafe class WinApi
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static unsafe extern bool DestroyWindow(IntPtr hwnd);
    }
}
