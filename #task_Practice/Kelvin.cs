using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _task_Practice
{
    internal class Kelvin
    {
        #region implict
        public Kelvin(int temp)
        {
            this.temp = temp;
        }

        public int temp {  get; set; }

        public static implicit operator Selsi(Kelvin temperatur)
        {
            return new Selsi(temperatur.temp - 273);
        }
        #endregion
        //public static explicit operator Selsi(Kelvin temperatur)
        //{
        //    return new Selsi(temperatur.temp - 273);
        //}



    }
}
