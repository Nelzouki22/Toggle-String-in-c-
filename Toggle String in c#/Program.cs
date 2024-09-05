using System;

class Program
{
    static void Main()
    {
        // قراءة السلسلة النصية
        string S = Console.ReadLine();

        // تغيير حالة الأحرف
        char[] result = new char[S.Length];
        for (int i = 0; i < S.Length; i++)
        {
            if (char.IsLower(S[i]))
            {
                result[i] = char.ToUpper(S[i]);
            }
            else if (char.IsUpper(S[i]))
            {
                result[i] = char.ToLower(S[i]);
            }
        }

        // طباعة السلسلة الناتجة
        Console.WriteLine(new string(result));
    }
}

