using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01.Test
{

    internal class Emp : IEquatable<Emp>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }


        public Emp(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public bool Equals(Emp? emp)
        {
            if (emp is not null)
            {
                return Id == emp.Id && Name == emp.Name && Salary == emp.Salary;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id , Name , Salary);
        }

        //static public bool operator == (Emp right , Emp left)
        //{
        //    return right.Equals(left);
        //}
        // static public bool operator != (Emp right , Emp left)
        //{
        //    return !(right.Equals(left));
        //}


    }
}
