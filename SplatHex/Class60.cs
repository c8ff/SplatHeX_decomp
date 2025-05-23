using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SplatHex;
internal class Class60 : IDisposable {
    public delegate void MBU(IntPtr intptr_0, bool bool_0);
    private bool sD7m;
    private IntPtr SD70;
    private MBU HD7I;
    [SpecialName]
    public bool method_0() {
        return sD7m;
    }

    [DllImport("kernel32.dll")]
    private static extern bool CreateTimerQueueTimer(ref IntPtr intptr_0, IntPtr intptr_1, MBU mbu_0, IntPtr intptr_2, uint uint_0, uint uint_1, uint uint_2);
    [DllImport("kernel32.dll")]
    private static extern bool DeleteTimerQueueTimer(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2);
    public void BD77(uint uint_0, uint uint_1, MBU mbu_0) {
        if (!sD7m) {
            HD7I = mbu_0;
            bool flag;
            if (!(flag = CreateTimerQueueTimer(ref SD70, IntPtr.Zero, HD7I, IntPtr.Zero, uint_0, uint_1, 0u))) {
                jD7i(Class13.TDgQ);
            }

            sD7m = flag;
        }
    }

    public void nD7P() {
        if (sD7m) {
            bool flag;
            if (!(flag = DeleteTimerQueueTimer(IntPtr.Zero, SD70, IntPtr.Zero)) && Marshal.GetLastWin32Error() != Class13.NDgF) {
                jD7i(Class13.lDgL);
            }

            sD7m = !flag;
        }
    }

    private void jD7i(string string_0) {
        throw new Exception(string.Format(Class13.wDgJ, string_0, Marshal.GetLastWin32Error()));
    }

    public void Dispose() {
        nD7P();
    }

    internal static bool WU9() {
        return true;
    }
}