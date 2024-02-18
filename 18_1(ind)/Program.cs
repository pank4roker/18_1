using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Console;

namespace _18_1_ind_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Human> human = new List<Human>();
            bool flag = true;
            while (flag)
            {
                Write("Enter the first letter of the language you would prefer Moldovan(M)/Russian(R) or English(E): ");
                string language = ReadLine();
                WriteLine();
                switch (language.ToLower())
                {
                    case "m":
                        Write("Интродуче це нуме: ");
                        string name1 = ReadLine();
                        Moldovan moldovan1 = new Moldovan();
                        moldovan1.Hello(name1);
                        WriteLine();
                        break;
                    case "r":
                        Write("Введите имя: ");
                        string name2 = ReadLine();
                        Russian russian = new Russian();
                        russian.Hello(name2);
                        WriteLine();
                        break;
                    case "e":
                        Write("Enter the name: ");
                        string name3 = ReadLine();
                        Englishman englishman = new Englishman();
                        englishman.Hello(name3);
                        WriteLine();
                        break;
                    default:
                        WriteLine("You entered wrong letter!");
                        flag = false;
                        break;

                }
            }
           
            ReadKey();
        }
    }
}
