using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstr
 {
    internal class Program
     {
    static void Main(string[] args)
         {
        DerivedClass derivedclass = new DerivedClass();
        derivedclass.Method();
        Write("Введите 1 число: ");
        int a = Convert.ToInt32(ReadLine());
        Write("Введите 1 число: ");
        int b = Convert.ToInt32(ReadLine());
        Write($"Cумма равна: {derivedclass.Sum(a, b)}");
            WriteLine();
        Write("Введите имя: ");
        string hi = ReadLine();
        derivedclass.Hi(hi);
        derivedclass.Hello(hi);
        ReadKey();

    

        }
    }
}
