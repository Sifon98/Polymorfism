using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Polymorfism
{
    internal class Person
    {
        private int age;
        private string fname;
        private string lname;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException(String.Format("Age can't be a negative number."));
                else
                    age = value;
            }
        }
        public string Fname
        {
            get { return fname; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                    throw new ArgumentException(String.Format("Firstname must be at least two letters but no more than ten letters."));
                else
                    fname = value;
            }
        }
        public string Lname
        {
            get { return lname; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw new ArgumentException(String.Format("Firstname must be at least three letters but no more than fifteen letters."));
                else
                    lname = value;
            }
        }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }
    }

    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFname(Person pers, string fname)
        {
            pers.Fname = fname;
        }
        public void SetLname(Person pers, string lname)
        {
            pers.Lname = lname;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }

        public void CreatePerson(Person pers, int age, string fname, string lname, double height, double weight)
        {
            pers.Age = age;
            pers.Fname = fname;
            pers.Lname = lname;
            pers.Height = height;
            pers.Weight = weight;
        }

        public string GetPerson(Person pers)
        {
            return $"Age: {pers.Age}, Firstname: {pers.Fname}, Lastname: {pers.Lname}, Height: {pers.Height}, Weight: {pers.Weight}";
        }
    }
}