using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tunnitöö_Caesar
{
    class Program
    {
        
    
        static void Main(string[] args)
        {
            Console.Write("Sisesta sõna või lause: ");
            string input2 = Console.ReadLine();
            string input = input2.ToLower();
            System.IO.File.WriteAllText(@"C:\WriteText.txt", input);
            string text = System.IO.File.ReadAllText(@"C:\WriteText.txt");
            var array = text.ToCharArray();
            var array2 = new Char[array.Length];
            Console.Write("Sisesta nr 1 kui soovid krüpteerida, sisesta nr 2 kui soovid dekrüpteerida: ");
            var valik = Console.ReadKey();
            Console.WriteLine();
            int sisend2 = int.Parse(valik.KeyChar.ToString());
            bool krüpteerimine = false;
            bool dekrüpteerimine = false;
            if (sisend2 == 1)
            {
                krüpteerimine = true;
            }
            if (sisend2 == 2)
            {
                dekrüpteerimine = true;
            }


            Char ch1 = 'a';
            Char ch2 = 'b';
            Char ch3 = 'c';
            Char ch4 = 'd';
            Char ch5 = 'e';
            Char ch6 = 'f';
            Char ch7 = 'g';
            Char ch8 = 'h';
            Char ch9 = 'i';
            Char ch10 = 'j';
            Char ch11 = 'k';
            Char ch12 = 'l';
            Char ch13 = 'm';
            Char ch14 = 'n';
            Char ch15 = 'o';
            Char ch16 = 'p';
            Char ch17 = 'q';
            Char ch18 = 'r';
            Char ch19 = 's';
            Char ch20 = 'š';
            Char ch21 = 'z';
            Char ch22 = 'ž';
            Char ch23 = 't';
            Char ch24 = 'u';
            Char ch25 = 'v';
            Char ch26 = 'w';
            Char ch27 = 'õ';
            Char ch28 = 'ä';
            Char ch29 = 'ö';
            Char ch30 = 'ü';
            Char ch31 = 'x';
            Char ch32 = 'y';


            //Console.WriteLine("Testimise eesmärgil:");
            //foreach (char ch in array)
            //{
            //    Console.WriteLine(ch);
            //}

            while (krüpteerimine)
            {

                Console.WriteLine("Alustasid krüpteerimist");

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == ch1)
                    {
                        array2[i] = ch4;
                    }

                    if (array[i] == ch2)
                    {
                        array2[i] = ch5;
                    }

                    if (array[i] == ch3)
                    {
                        array2[i] = ch6;
                    }

                    if (array[i] == ch4)
                    {
                        array2[i] = ch7;
                    }

                    if (array[i] == ch5)
                    {
                        array2[i] = ch8;
                    }

                    if (array[i] == ch6)
                    {
                        array2[i] = ch9;
                    }

                    if (array[i] == ch7)
                    {
                        array2[i] = ch10;
                    }

                    if (array[i] == ch8)
                    {
                        array2[i] = ch11;
                    }

                    if (array[i] == ch9)
                    {
                        array2[i] = ch12;
                    }

                    if (array[i] == ch10)
                    {
                        array2[i] = ch13;
                    }

                    if (array[i] == ch11)
                    {
                        array2[i] = ch14;
                    }

                    if (array[i] == ch12)
                    {
                        array2[i] = ch15;
                    }

                    if (array[i] == ch13)
                    {
                        array2[i] = ch16;
                    }

                    if (array[i] == ch14)
                    {
                        array2[i] = ch17;
                    }

                    if (array[i] == ch15)
                    {
                        array2[i] = ch18;
                    }

                    if (array[i] == ch16)
                    {
                        array2[i] = ch19;
                    }

                    if (array[i] == ch17)
                    {
                        array2[i] = ch20;
                    }

                    if (array[i] == ch18)
                    {
                        array2[i] = ch21;
                    }

                    if (array[i] == ch19)
                    {
                        array2[i] = ch22;
                    }

                    if (array[i] == ch20)
                    {
                        array2[i] = ch23;
                    }

                    if (array[i] == ch21)
                    {
                        array2[i] = ch24;
                    }

                    if (array[i] == ch22)
                    {
                        array2[i] = ch25;
                    }

                    if (array[i] == ch23)
                    {
                        array2[i] = ch26;
                    }

                    if (array[i] == ch24)
                    {
                        array2[i] = ch27;
                    }

                    if (array[i] == ch25)
                    {
                        array2[i] = ch28;
                    }

                    if (array[i] == ch26)
                    {
                        array2[i] = ch29;
                    }

                    if (array[i] == ch27)
                    {
                        array2[i] = ch30;
                    }

                    if (array[i] == ch28)
                    {
                        array2[i] = ch31;
                    }

                    if (array[i] == ch29)
                    {
                        array2[i] = ch32;
                    }

                    if (array[i] == ch30)
                    {
                        array2[i] = ch1;
                    }

                    if (array[i] == ch31)
                    {
                        array2[i] = ch2;
                    }

                    if (array[i] == ch32)
                    {
                        array2[i] = ch3;
                    }
                    
                }
                break;
            }
            while (dekrüpteerimine)
            {
                Console.WriteLine("Alustasid dekrüpteerimist");
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch4)
                    {
                        array2[i] = ch1;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch5)
                    {
                        array2[i] = ch2;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch6)
                    {
                        array2[i] = ch3;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch7)
                    {
                        array2[i] = ch4;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch8)
                    {
                        array2[i] = ch5;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch9)
                    {
                        array2[i] = ch6;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch10)
                    {
                        array2[i] = ch7;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch11)
                    {
                        array2[i] = ch8;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch12)
                    {
                        array2[i] = ch9;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch13)
                    {
                        array2[i] = ch10;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch14)
                    {
                        array2[i] = ch11;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch15)
                    {
                        array2[i] = ch12;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch16)
                    {
                        array2[i] = ch13;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch17)
                    {
                        array2[i] = ch14;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch18)
                    {
                        array2[i] = ch15;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch19)
                    {
                        array2[i] = ch16;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch20)
                    {
                        array2[i] = ch17;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch21)
                    {
                        array2[i] = ch18;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch22)
                    {
                        array2[i] = ch19;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch23)
                    {
                        array2[i] = ch20;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch24)
                    {
                        array2[i] = ch21;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch25)
                    {
                        array2[i] = ch22;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch26)
                    {
                        array2[i] = ch23;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch27)
                    {
                        array2[i] = ch24;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch28)
                    {
                        array2[i] = ch25;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch29)
                    {
                        array2[i] = ch26;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch30)
                    {
                        array2[i] = ch27;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch31)
                    {
                        array2[i] = ch28;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch32)
                    {
                        array2[i] = ch29;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch1)
                    {
                        array2[i] = ch30;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch2)
                    {
                        array2[i] = ch31;
                    }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == ch3)
                    {
                        array2[i] = ch32;
                    }
            
                break;
            }

            //    foreach (char ch in array)
            //{

            //    if (ch == ch3)
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            array[i] = ch8;
            //        }
            //    if (ch == ch4)
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            array[i] = ch9;
            //        }
            //    if (ch == ch5)
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            array[i] = ch3;
            //        }
            //    if (ch == ch1)
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            array[i] = ch10;
            //        }
            //    if (ch == ch7)
            //        for (int i = 0; i < array.Length; i++)
            //        {
            //            array[i] = ch5;
            //        }
            //}

            string restOfArray = string.Join("", array2);
            Console.Write("Krüpteeritud tulemus: ");
            Console.WriteLine(restOfArray);
            System.IO.File.WriteAllText(@"C:\WriteText2.txt", restOfArray);

            Console.ReadLine();
        }
    }
}
