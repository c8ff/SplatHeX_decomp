using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SplatHex;
internal class Class121 {
    private TcpClient QDU;
    private object WDT;
    [CompilerGenerated]
    private string TD1;
    [CompilerGenerated]
    private int aDW;
    [SpecialName]
    [CompilerGenerated]
    public string YDm() {
        return TD1;
    }

    [SpecialName]
    [CompilerGenerated]
    private void DD0(string string_0) {
        TD1 = string_0;
    }

    [SpecialName]
    [CompilerGenerated]
    public int eDR() {
        return aDW;
    }

    [SpecialName]
    [CompilerGenerated]
    private void hDC(int int_0) {
        aDW = int_0;
    }

    public Class121(string string_0, int int_0) {
        DD0(string_0);
        hDC(int_0);
        QDU = null;
        WDT = null;
    }

    public void dDL() {
        try {
            IDJ();
        } catch (Exception) {
        }

        QDU = new TcpClient();
        QDU.NoDelay = true;
        IAsyncResult asyncResult = QDU.BeginConnect(YDm(), eDR(), null, null);
        WaitHandle asyncWaitHandle = asyncResult.AsyncWaitHandle;
        try {
            if (!asyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5.0), exitContext: false)) {
                QDU.Close();
                throw new IOException("Connection timeout.", new TimeoutException());
            }

            QDU.EndConnect(asyncResult);
        } finally {
            asyncWaitHandle.Close();
        }

        WDT = QDU.GetStream();
        ((Stream)WDT).ReadTimeout = 10000;
        ((Stream)WDT).WriteTimeout = 10000;
    }

    public void IDJ() {
        try {
            if (QDU == null) {
                throw new IOException("Not connected.", new NullReferenceException());
            }

            QDU.Close();
        } catch (Exception) {
        } finally {
            QDU = null;
        }
    }

    public void lD7() {
        if (WDT == null) {
            throw new IOException("Not connected.", new NullReferenceException());
        }

        ((Stream)WDT).Flush();
    }

    public void GDP(byte[] byte_0, uint uint_0, ref uint uint_1) {
        try {
            int num = 0;
            if (WDT == null) {
                throw new IOException("Not connected.", new NullReferenceException());
            }

            uint_1 = 0u;
            while (uint_0 != 0) {
                int num2 = ((Stream)WDT).Read(byte_0, num, (int)uint_0);
                if (num2 >= 0) {
                    uint_1 += (uint)num2;
                    num += num2;
                    uint_0 -= (uint)num2;
                    continue;
                }

                break;
            }
        } catch (ObjectDisposedException innerException) {
            throw new IOException("Connection closed.", innerException);
        }
    }

    public void EDi(byte[] byte_0, int int_0, ref uint uint_0) {
        try {
            if (WDT == null) {
                throw new IOException("Not connected.", new NullReferenceException());
            }

            ((Stream)WDT).Write(byte_0, 0, int_0);
            if (int_0 >= 0) {
                uint_0 = (uint)int_0;
            } else {
                uint_0 = 0u;
            }

            ((Stream)WDT).Flush();
        } catch (ObjectDisposedException innerException) {
            throw new IOException("Connection closed.", innerException);
        }
    }
}