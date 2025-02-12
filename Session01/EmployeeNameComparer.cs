using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class EmployeeNameComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            //X is Null
            //Y is Null
            //X.Name Is Null
            //Y.Name Is Null
            // X > Y => +Ve
            // X < Y => -Ve
            // X = Y => 0

            //if (x is null || x.Name is null)
            //    return -1;
            //else if (y is null || y.Name is null)
            //    return 1;
            //else
            //    return x.Name.CompareTo(y.Name);

            return x?.Name?.CompareTo(y?.Name) ?? -1;
        }
    }
}
