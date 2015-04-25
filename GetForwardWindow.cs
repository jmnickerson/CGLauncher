using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CGLauncher
{
    class GetForwardWindow
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        public static bool IsActive(IntPtr handle)
        {
            IntPtr activeHandle = GetForegroundWindow();
            return (activeHandle == handle);
        }
    }
}
