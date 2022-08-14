using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Singer
    {
        //fiedls
        private string _name;
        private string _surname;
        private int _age;

        //props
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length < 101)
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value.Length < 101)
                {
                    _surname = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value<171)
                {
                    _age = value;
                }
            }

        }
    }
}
