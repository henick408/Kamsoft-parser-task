using System.Text;

namespace Kamsoft.Util;


public class StringBase64Decoder {
    public string Decode(string base64String) {
        byte[] base64EncodedBytes = Convert.FromBase64String(base64String);
        return Encoding.UTF8.GetString(base64EncodedBytes);
    }

    public bool TryDecode(string content, out string decoded) {

        decoded = string.Empty;

        if (string.IsNullOrWhiteSpace(content)) {
            return false;
        }

        try {
            byte[] bytes = Convert.FromBase64String(content);
            decoded = Encoding.UTF8.GetString(bytes);
            return true;
        }
        catch (FormatException) {
            return false;
        }

    }
}