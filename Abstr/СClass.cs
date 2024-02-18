using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr
{
    /// <summary>
    /// Абстрактный метод наследуемый от AClass
    /// </summary>
    abstract class СClass:AClass2
    {
        /// <summary>
        /// Метод приветствия 
        /// </summary>
        /// <param name="hi"> приветсвие </param>
        public abstract void Hi(string hi);

    }
}
