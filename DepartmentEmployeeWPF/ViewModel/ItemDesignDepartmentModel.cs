using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentEmployeeWPF
{
    public class ItemDesignDepartmentModel : ItemDepartmentViewModel
    {
        #region Singlton

        public static ItemDesignDepartmentModel Instance => new ItemDesignDepartmentModel();

        #endregion
        public ItemDesignDepartmentModel()
        {

            NameDepartment = "Микрософт старт";
            Detail = "Многообещающий предприятие с большим количеством сотрудников.";
            NumperOfEmpl = 40000;
                // in futer picture Photo = "";


           
        }
        
    }
}
