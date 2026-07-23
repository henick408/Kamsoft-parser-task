using System.Text;

namespace Kamsoft.Util;


public class StringBase64Decoder {
    public string Decode(string base64String) {
        byte[] base64EncodedBytes = Convert.FromBase64String(base64String);
        return Encoding.UTF8.GetString(base64EncodedBytes);
    }
}