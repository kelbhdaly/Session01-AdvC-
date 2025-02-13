using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session01
{
    internal class EmployeeIdComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            // X Is null =>-1
            // Y Is null => 1
            //X.name is null => -1
            //y.name is null =>1
            //X.name > y.name => 1
            //X.name < y.name => -1
            //X.name == y.name => 0

            //if (x is null || x.Name is null) return -1;
            //else if (y is null || y.Name is null) return 1;
            //else
            //    return x.Name.CompareTo(y.Name);


            return x?.Name?.CompareTo(y?.Name) ?? -1;
        }
    }
}
