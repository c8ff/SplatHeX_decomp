using System.Net;
using System.Net.NetworkInformation;

namespace SplatHex;
internal class Class72 {
    private IPAddress yDQn;
    public Class72(IPAddress ipaddress_0) {
        yDQn = ipaddress_0;
    }

    public void iDQ8() {
        try {
            _ = new Ping().Send(yDQn).Status;
        } catch (PingException) {
        }
    }

    internal static bool pU3() {
        return true;
    }

    internal static bool RUV() {
        return false;
    }
}