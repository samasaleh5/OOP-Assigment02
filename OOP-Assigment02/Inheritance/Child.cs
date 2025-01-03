using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment02.Inheritance
{
    internal class Child:Parent
    {
        public int z {  get; set; }

        //child constructor by default chain parameterless constructor of parent
        public Child(int _x, int _y, int _z):base(_x,_y)
        {
            z= _z; 
        }
        public new int product()
        {
            return base.product() * z;
        }
        public override string ToString()
        {
            return $"({x} , {y} , {z})";
        }
         

    }
}
