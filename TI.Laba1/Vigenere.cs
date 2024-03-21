using System.Text;

namespace TI.Laba1;

public class Vigenere
{
    private const string Letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    private static int _n = Letters.Length;
    private static string? _key;
    private static string? _src;

    public static string? Encrypt(string? src, string? key)
    {
        if (src == string.Empty || key == string.Empty || src == null || key == null)
            return "Ключ или текст не может быть пустым";

        src = src.ToLower();
        key = key.ToLower();

        var sb = new StringBuilder();
        foreach (char c in src)
            if (Letters.Contains(c))
                sb.Append(c);
        _src = sb.ToString();

        sb.Clear();
        foreach (char c in key)
            if (Letters.Contains(c))
                sb.Append(c);
        _key = sb.ToString();
        
        if (_src == string.Empty || _key == string.Empty)
            return "Ключ или текст состоит из недопустимых символов";
        
        if (_key.Length < _src.Length)
            _key += _src.Substring(0, _src.Length - _key.Length);
        
        var dest = new StringBuilder(src);
        var i = 0;
        var idx = 0;
        while (i < dest.Length) 
        {
            if (Letters.Contains(dest[i]))
                dest[i] = Letters[(Letters.IndexOf(dest[i]) + Letters.IndexOf(_key[idx++])) % _n];
            i++;
        }
        return dest.ToString();
    }

    public static string? Decrypt(string? src, string? key)
    {
        if (src == string.Empty || key == string.Empty || src == null || key == null)
            return "Ключ или текст не может быть пустым";

        src = src.ToLower();
        key = key.ToLower();

        var sb = new StringBuilder();
        foreach (char c in src)
            if (Letters.Contains(c))
                sb.Append(c);
        _src = sb.ToString();

        sb.Clear();
        foreach (char c in key)
            if (Letters.Contains(c))
                sb.Append(c);
        _key = sb.ToString();
        
        if (_src == string.Empty || _key == string.Empty)
            return "Ключ или текст состоит из недопустимых символов";
        
        // if (_key.Length < _src.Length)
        //     _key += _src.Substring(0, _src.Length - _key.Length);
        
        var dest = new StringBuilder(src);
        var i = 0;
        var idx = 0;
        while (i < dest.Length) 
        {
            if (Letters.Contains(dest[i]))
            {
                dest[i] = Letters[(Letters.IndexOf(dest[i]) - Letters.IndexOf(_key[idx++]) + _n) % _n];
                if (_key.Length < _src.Length)
                    _key += dest[i];
            }
            i++;
        }
        return dest.ToString();
    }
}