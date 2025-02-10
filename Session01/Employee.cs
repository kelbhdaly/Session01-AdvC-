using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Employee
    {

        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        #endregion
        #region Constructors

        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        #endregion


        #region Operators Overloading

        static public bool operator == (Employee left, Employee right)
        {
            //return left.Id == right.Id && left.Name == right.Name && left.Salary == right.Salary;
            return left.Equals(right);
        }
        static public bool operator !=(Employee left, Employee right)
        {
            //return left.Id != right.Id || left.Name != right.Name || left.Salary != right.Salary;
            return !(left == right);
        }


       
        #endregion
    }
}
