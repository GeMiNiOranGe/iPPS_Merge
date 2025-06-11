using Pepro.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepro.Business
{
    public class DepartmentBusiness
    {
        private DepartmentData departData;
        public DepartmentBusiness()
        {
            departData = new DepartmentData();
        }
        public DataTable GetDepartments()
        {
            return departData.GetDepartments();
        }
        public DataTable GetAllDepartments()
        {
            return departData.getAllDepartments();
        }
    }
}
