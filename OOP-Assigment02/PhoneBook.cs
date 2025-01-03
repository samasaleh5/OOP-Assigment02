using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace OOP_Assigment02
{
    #region By Setter/Getter
    struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get { return size; }
        }

        public long GetPersonNumber(string name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                        return numbers[i];
                }
            }
            return -1;
        }
        public void SetPersonNumber(string Name, long Number)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        numbers[i] = Number;
                        return;
                    }

                }
            }
        }

        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        public void AddPerson(int position, string Name, long Num)
        {
            if (names is not null && numbers is not null)
            {
                if (position >= 0 && position < size)
                {
                    names[position] = Name;
                    numbers[position] = Num;
                }
            }
        }

        #endregion
        #region Indexer
        //special type of property "This"
        public long this[string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                            return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = value;
                            return;
                        }

                    }
                }

            }
        }
        public string this[int position] 
        {
            get
            { 
                return $"{position} :: {names[position]} :: {numbers[position]}";
            }
        }
        #endregion
    }
}


