using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Abstr
{
    /// <summary>
    /// Абстрактный наследуемый класс
    /// </summary>
    abstract class AClass2:AClass
    {
        /// <summary>
        /// Метод cуммы
        /// </summary>
        /// <param name="a">1 число</param>
        /// <param name="b">2 число</param>
        /// <returns>сумму a и b</returns>
        public abstract int Sum(int a, int b);
        
    }
}
