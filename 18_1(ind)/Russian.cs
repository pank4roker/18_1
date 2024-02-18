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
    class Russian:Human
    {
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Russian() { }
        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="Name"> имя </param>
        public Russian(string Name)
        {
            this.Name = Name;
        }
        /// <summary>
        /// Переопределенный метод приветствия
        /// </summary>
        /// <param name="name"> имя </param>
        public override void Hello(string name)
        {
            WriteLine($"Привет {name}");
        }
       
    }
}
