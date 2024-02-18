using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstr
{
    /// <summary>
    /// Обысный класс наследуемый от CClass
    /// </summary>
    class DerivedClass:СClass
    {
        /// <summary>
        /// Переопределнный абстрактный метод из AClass
        /// </summary>
        public override void Method()
        {
            WriteLine("Метод Method из AClass");
        }
        /// <summary>
        /// Переопределнный абстрактный метод из AClass1
        /// </summary>
        /// <param name="a"> 1 число</param>
        /// <param name="b"> 2 число </param>
        /// <returns>сумма</returns>
        public override int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Переопределнный абстрактный метод из CClass
        /// </summary>
        /// <param name="hi"> приыетствие </param>
        public override void Hi(string hi)
        {
            WriteLine($"Привет {hi}");
        }
        public void Hello(string hi)
        {
            WriteLine($"Привет {hi}");
        }
    }
}
