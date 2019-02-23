using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
  //the swimmer class will generate the swimmer object by taking the a given data in the constractor 
      public class Swimmer : IComparable
        {
            public string fullName { set; get; }
            public string sex { set; get; }
            public int age { set; get; }
            public double time { set; get; }
            public Swimmer(string fullName, string sex, string age, string time)
            {
                this.fullName = fullName;
                this.sex = sex;
                this.age = Convert.ToInt32(age);
                this.time = Convert.ToDouble(time);
            }
    //this will make a sort for with an age
            public int CompareTo(object obj)
            {
                return (this.sex).CompareTo(((Swimmer)obj).sex);
            }
        }
    }
