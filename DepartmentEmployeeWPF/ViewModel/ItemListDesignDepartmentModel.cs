using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeWPF
{
    public class ItemListDesignDepartmentModel : ItemListDepartmentViewModel
    {
        #region Singlton

        public static ItemListDesignDepartmentModel Instance => new ItemListDesignDepartmentModel(); 

        #endregion

        public ItemListDesignDepartmentModel()
        {
            Items = new List<ItemDepartmentViewModel>
               {
                   new ItemDepartmentViewModel
                   {
                        NameDepartment = "Микрософт старт",
                        Detail = "Многообещающий предприятие с большим количеством сотрудников.",
                        NumperOfEmpl = 40000
            // in futer picture Photo = "";

           
                    },

                   new ItemDepartmentViewModel
                   {
                        NameDepartment = "LidarDigits",
                        Detail = "Департамент по работе с инновациямми в автомобилестроении.",
                        NumperOfEmpl = 20000
                   }
               };
        }
    }
}
