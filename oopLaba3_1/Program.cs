using System;

namespace oopLaba3_1
{
    class Program
    {
        static string Low(string str)
        {
            str = str.ToLower();

            return str;
        }
        static void text1(string str)
        {
            string[] text = str.Split(' ','\t',',','.');
             
            foreach( string word in text)
            {
                
                int numberofletters = Convert.ToInt32(word.Length) ;
                if (numberofletters % 2 == 0)
                {
                    
                    Console.WriteLine("У словi {0}  парна кiлькiсть букв {1} ", word, numberofletters);

                    
                }
                
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть рядок");
            string str = Console.ReadLine();

        
           string y= Low(str);
           Console.WriteLine("Отриманий рядяк\t" + y);
           text1(str);

        }
    }
}
