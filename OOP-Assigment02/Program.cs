﻿using OOP_Assigment02.Inheritance;

namespace OOP_Assigment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Getter/Setter&Indexer
            PhoneBook note =new PhoneBook(3);
            //note.AddPerson(0, "sama", 123);
            //note.AddPerson(1, "saleh", 456);
            //note.AddPerson(2, "hanfy", 789);
            //note["sama"] = 2155200;
            //Console.WriteLine(note["sama"]);
            //Console.WriteLine(note.GetPersonNumber("saleh"));
            //note.SetPersonNumber("sama", 215);
            //Console.WriteLine(note.GetPersonNumber("sama"));
            //Console.WriteLine(note[2]);
            #endregion
            #region class
            //Car C1;//declare for reference c1 from type car 4byte in stack
            //can refer to object from type Car
            //or object drom another class [inheriting from car]
            //CLR will allocate 4byte in stack but 0 byte in heap not refer to any object
            //C1 = new Car(1, "BMW");
            // New: will made
            //1-Allocate Requried Numbers of bytes at heap 16 byte
            //2-Initalize the allocated bytes with default values of datatype zeros or null
            //3-Calling user defiend constructor [if exist]
            //4-Assign reference c1 to allocated object at heap
            // Console.WriteLine(C1.ToString());
            //New in struct
            //just for selection  of constructor for initialization 

            #endregion
            #region inheritance
            //Parent p = new Parent(1, 2);
            //Console.WriteLine(p);
            //Console.WriteLine(p.product());
            //Child c = new Child(1, 2, 3);
            //Console.WriteLine(c);
            //Console.WriteLine(c.product());
            #endregion
            //Part02
            #region Question1-2
            //try
            //{
            //    HiringDate hireDate = new HiringDate(21, 5, 2020);
            //    Employee emp = new Employee(1, "Sama", "F", 95000.90m, hireDate, SecurityLevel.Developer);
            //    Console.WriteLine(emp);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion
            #region Question3
            try
            {
                Employee[] EmpArr = new Employee[3];
                EmpArr[0]=new Employee(1, "Sama", "F", 95000.90m, new HiringDate(1, 2, 2020), SecurityLevel.DBA);
                EmpArr[1] = new Employee(5, "Saleh", "M", 100000.87m, new HiringDate(14, 6, 2017), SecurityLevel.Guest);
                EmpArr[2] = new Employee(9, "zeiad", "z", 20000.09m, new HiringDate(30, 2, 2001), SecurityLevel.SecurityOfficer);

                foreach (var emp in EmpArr)
                {
                    Console.WriteLine(emp);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            #endregion

        }
    }
}
