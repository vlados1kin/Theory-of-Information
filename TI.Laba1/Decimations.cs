using System.Text;

namespace TI.Laba1;

public class Decimations
{
    private const string Letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
    private static int _n = Letters.Length;
    private static int _k;
    private static int _m; // число, обратное числу k по модулю n
    
    public static string? Encrypt(string? src, string? key)
    {
        if (src == string.Empty || key == string.Empty || src == null || key == null)
            return "Ключ или текст не может быть пустым";
        
        if (!int.TryParse(key, out _k))
            return $"Ключ \"{key}\" не является числом";
        
        if (!Coprime(_n, _k))
            return $"Числа \"{key}\" и \"{_n}\" не взаимно простые";
        
        var dest = new StringBuilder(src.ToLower());
        var i = 0;
        while (i < dest.Length) 
        {
            if (Letters.Contains(dest[i]))
                dest[i] = Letters[Letters.IndexOf(dest[i]) * _k % _n];
            i++;
        }
        return dest.ToString();
    }

    public static string? Decrypt(string? src, string? key)
    {
        if (src == string.Empty || key == string.Empty || src == null || key == null)
            return "Ключ или текст не может быть пустым";

        if (!int.TryParse(key, out _k))
            return $"Ключ \"{key}\" не является числом";
        
        if (!Coprime(_n, _k))
            return $"Числа \"{key}\" и \"{_n}\" не взаимно простые";
        
        _m = 0;
        while (_k * _m % _n != 1) _m++;
        
        var dest = new StringBuilder(src.ToLower());
        var i = 0;
        while (i < dest.Length)
        {
            if (Letters.Contains(dest[i]))
                dest[i] = Letters[(Letters.IndexOf(dest[i]) + _n) * _m % _n];
            i++;
        }
        return dest.ToString();
    }

    private static bool Coprime(int n, int k)
    {
        while (n > 0 && k > 0)
            if (n > k)
                n %= k;
            else
                k %= n;
        return n + k == 1;
    }
}