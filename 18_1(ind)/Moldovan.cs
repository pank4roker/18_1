using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace _18_1_ind_
{
    /// <summary>
    /// Производный класс от абстрактного класса человек 
    /// </summary>
    class Moldovan:Human
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Moldovan() { }
        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="Name"> имя </param>
        public Moldovan(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// Переопределенный метод приветствия
        /// </summary>
        /// <param name="name"> имя </param>
        public override void Hello(string name)
        {
            WriteLine($"Буна зиа {name}");
        }
       
    }
}
