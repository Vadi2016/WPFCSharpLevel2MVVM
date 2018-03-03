using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeWPF
{
    public class Employee
    {
       

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Position { get; set; }

        public int Age { get; set; }

        List<Department> depList = new List<Department>()
        {
            new Department()
            {
                
            },

             new Department()
            {
                
            }
        };

    }
}
