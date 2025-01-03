using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment02.Inheritance
{
    internal class Parent
    {
        #region Properties
        public int x { get; set; }
        public int y { get; set; }
        #endregion
        public Parent(int _x,int _y)
        {
            x= _x;
            y= _y;
        }
        public override string ToString() 
        { 
            return $"({x} , {y})";
        }
        public int product()
        {
            return x * y;
        }
    }
}
