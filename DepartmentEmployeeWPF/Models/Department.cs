using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeWPF
{
    public class Department
    {
       
     

        List<Employee> emplList = new List<Employee>()
        {
             new Employee()
             {
                 FirstName = "Василий",
                 SecondName = "Генадьевич",
                 Position = "Генеральный директор",
                 Age = 55
             },

              new Employee()
             {
                 FirstName = "Екатерина",
                 SecondName = "Викторовна",
                 Position = "Секретарь",
                 Age = 22
             },

               new Employee()
             {
                 FirstName = "Тимур",
                 SecondName = "Фархатович",
                 Position = "Программист",
                 Age = 33
             },

                 new Employee()
             {
                 FirstName = "Татьяна",
                 SecondName = "Себитовна",
                 Position = "Директор департамента",
                 Age = 40
             }

        };

    }
}
