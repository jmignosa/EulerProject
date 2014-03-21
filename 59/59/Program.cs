using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace _59
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            StreamReader sr = new StreamReader(@".\\cipher1.txt");
            string []cipherread;
            string readline="";
            List<int> ciphertext = new List<int>();
            sw.Start();
            char a,b,c;
            string decrypted = "";
            int sum=0;

            while (sr.Peek() != -1)
            {
                readline = sr.ReadLine();
            }
            cipherread = readline.Split(',') ;
            sr.Close();
            foreach (var number in cipherread)
            {
                ciphertext.Add(Int32.Parse(number));
            }
            for (a='a';a<'z'+1;a++)
                for (b = 'a'; b < 'z' + 1; b++)
                    for (c = 'a'; c < 123; c++)
                    {
                        decrypted = "";sum=0;
                        for (int n = 0; n < ciphertext.Count;n++ )
                        {
                            char[] key = { a, b, c };
                            sum += ciphertext[n] ^ key[n % 3];
                            if ((ciphertext[n] ^ key[n % 3]) == 7)
                                continue;
                            decrypted+=(char)(ciphertext[n]^key[n%3]);                           
                        }
                        if (decrypted.ToLower().Contains("gospel"))
                        {
                            sw.Stop();
                            Console.WriteLine("Key {0}  {1}  {2} elapsed time {3} ms", a, b, c,sw.ElapsedMilliseconds);
                            Console.WriteLine(decrypted);
                            Console.WriteLine("sum of ascii chars is {0}", sum);
                            return;
                        }
                        
                    }

        }
    }
}
