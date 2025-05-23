using System.Text;

namespace SplatHex;
public interface H7m {
    byte[] Value { get; set; }

    uint Index { get; set; }

    new string ToString();
    string ToString(Encoding encoding_0);
}