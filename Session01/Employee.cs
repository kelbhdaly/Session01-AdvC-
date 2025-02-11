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

        static public bool operator ==(Employee left, Employee right)
        {
            //return left.Id == right.Id && left.Name == right.Name && left.Salary == right.Salary;
            return left.Equals(right);
        }
        static public bool operator !=(Employee left, Employee right)
        {
            //return left.Id != right.Id || left.Name != right.Name || left.Salary != right.Salary;
            return !(left == right);
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id == employee.Id &&
                   Name == employee.Name &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }



        #endregion


        #region Methods
        //public override string ToString()
        //{
        //    return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        //}


        //public override bool Equals(object? obj)
        //{
        //    Employee? employee = obj as Employee;
        //    if (employee is not null )
        //    {
        //        return this.Id == employee.Id && this.Name == employee.Name && this.Salary == employee.Salary ;
        //    }
        //    else
        //        return false ;
        //}



        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id, Name, Salary);  
        //}
        #endregion
    }
}
