using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koos_tehtu
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Valisid krüpteeri");
                Console.WriteLine("Sisesta tekst: ");
                //var text = Console.ReadLine();

                var alphabet = new char[] {'A', 'B','C','D','E','F'}
                var encryptedalphabet = new char[] { 'D', 'E', 'F', 'A', 'B', 'C'}
                string encrypt = "abc";
                string raw = "";

                

                for (int i = 0, i < encrypt.Length, i++)
                {

                    for (int j = 0, j< alphabet.Length, j++)
                    {
                        if (encrypt[i] == alphabet[j])
                        {
                            raw += encryptedalphabet[j];
                        }
                    }

                    var index = alphabet.ToList().IndexOf(encrypt[i]);
                    raw += encryptedalphabet[i];
                   


                    Console.WriteLine((int)encrypt);

                    var asciiCode = (int)raw[1];
                    var crypted = asciiCode + 3;
                    encrypt += (char)crypted;

                    
                    //encrypt[0] = a
                    //encrypt[1] = b
                    //encrypt[2] = c

                    if (encrypt[i] == 'a')
                    {
                        raw += 'c';
                    }
                        
                }
            }
            else if(input.Key == ConsoleKey.D1)
            {
                Console.WriteLine("Valisid dekrüpteeri");
            }
            else
            {
                Console.WriteLine("Sellist valikut pole");
            }

        }
    }
}
