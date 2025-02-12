using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class Employee :IEquatable<Employee> ,IComparable<Employee>
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
            #region Is Operator

            // Is Use To Check And Casting
            // True Obj Is Employee Or Obj Inherit From Employee
            // False Obj Is Not Employee


            //return obj is Employee employee &&
            //     employee.Id == Id && employee.Salary == Salary && Name == employee.Name; 
            #endregion

            #region As Operator


            Employee? employee = obj as Employee;

            if (employee is not null)
                return employee.Id == Id && employee.Name == Name && employee.Salary == Salary;
            else
                return false;
            #endregion
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        public bool Equals(Employee? employee)
        {
            if (employee is not null)
                return employee.Id == Id && employee.Name == Name && employee.Salary == Salary;
            else
                return false;
        }

        public int CompareTo(Employee? emp)
        {
            //Compare Based Salary
            if (emp is null)
                return 1;
            else
                return Salary.CompareTo(emp.Salary);

        }



        #endregion


        #region Methods
        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }


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
