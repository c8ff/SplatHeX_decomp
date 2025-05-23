using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SplatHex;
internal class Class54 {
    private TcpClient iD71;
    private object TD7W;
    [CompilerGenerated]
    private string YD7w;
    [CompilerGenerated]
    private int VD7N;
    [SpecialName]
    [CompilerGenerated]
    public string method_0() {
        return YD7w;
    }

    [SpecialName]
    [CompilerGenerated]
    private void method_1(string string_0) {
        YD7w = string_0;
    }

    [SpecialName]
    [CompilerGenerated]
    public int method_2() {
        return VD7N;
    }

    [SpecialName]
    [CompilerGenerated]
    private void method_3(int int_0) {
        VD7N = int_0;
    }

    public Class54(string string_0, int int_0) {
        method_1(string_0);
        method_3(int_0);
        iD71 = null;
        TD7W = null;
    }

    public void ED7R() {
        try {
            dD7C();
        } catch (Exception) {
        }

        iD71 = new TcpClient();
        iD71.NoDelay = true;
        IAsyncResult asyncResult = iD71.BeginConnect(method_0(), method_2(), null, null);
        WaitHandle asyncWaitHandle = asyncResult.AsyncWaitHandle;
        try {
            if (!asyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(Class13.yDg7), exitContext: false)) {
                iD71.Close();
                throw new IOException(Class13.PDgP, new TimeoutException());
            }

            iD71.EndConnect(asyncResult);
        } finally {
            asyncWaitHandle.Close();
        }

        TD7W = iD71.GetStream();
        ((Stream)TD7W).ReadTimeout = Class13.oDgi;
        ((Stream)TD7W).WriteTimeout = Class13.WDgm;
    }

    public void dD7C() {
        try {
            if (iD71 == null) {
                throw new IOException(Class13.KDg0, new NullReferenceException());
            }

            iD71.Close();
        } catch (Exception) {
        } finally {
            iD71 = null;
        }
    }

    public void XD7K() {
        if (TD7W == null) {
            throw new IOException(Class13.lDgI, new NullReferenceException());
        }

        ((Stream)TD7W).Flush();
    }

    public void CD7U(byte[] byte_0, uint uint_0, ref uint uint_1) {
        try {
            int num = 0;
            if (TD7W == null) {
                throw new IOException(Class13.iDgR, new NullReferenceException());
            }

            uint_1 = 0u;
            while (uint_0 != 0) {
                int num2 = ((Stream)TD7W).Read(byte_0, num, (int)uint_0);
                if (num2 >= 0) {
                    uint_1 += (uint)num2;
                    num += num2;
                    uint_0 -= (uint)num2;
                    continue;
                }

                break;
            }
        } catch (ObjectDisposedException innerException) {
            throw new IOException(Class13.eDgC, innerException);
        }
    }

    public void rD7T(byte[] byte_0, int int_0, ref uint uint_0) {
        try {
            if (TD7W == null) {
                throw new IOException(Class13.tDgK, new NullReferenceException());
            }

            ((Stream)TD7W).Write(byte_0, 0, int_0);
            if (int_0 >= 0) {
                uint_0 = (uint)int_0;
            } else {
                uint_0 = 0u;
            }

            ((Stream)TD7W).Flush();
        } catch (ObjectDisposedException innerException) {
            throw new IOException(Class13.qDgU, innerException);
        }
    }
}