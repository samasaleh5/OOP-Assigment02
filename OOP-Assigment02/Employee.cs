using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assigment02


{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value == "M" || value == "F")
                    gender = value;
                else
                    Console.WriteLine("Gender must be either 'M' Or 'F' .");
            }
        }
        public decimal Salary{ set; get; }
        public DateTime HireDate { get; set; }
        public SecurityLevel SecurityPrivilege {  get; set; }
        public Employee(int id,string name,string gender,decimal salary,DateTime hireDate,SecurityLevel securityPrivilege)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecurityPrivilege = securityPrivilege;
        }
        public override string ToString()
        {
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, Salary: {3}, Hire Date: {4}, Security Level: {5}",
                            Id,
                            Name,
                            Gender,
                            Salary.ToString("C", CultureInfo.CurrentCulture),
                            HireDate.ToString("d"),
                            SecurityPrivilege);
            
        }
    }
}