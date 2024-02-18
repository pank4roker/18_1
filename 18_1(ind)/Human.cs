using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1_ind_
{
    /// <summary>
    /// Абстрактный класс описывающий человека 
    /// </summary>
    abstract class Human
    {
        /// <summary>
        /// Свойство имени
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Абстрактный метод приветсвия
        /// </summary>
        /// <param name="name"></param>
        public abstract void Hello(string name);
    }
}
