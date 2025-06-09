using Pepro.DataAccess;
using Pepro.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepro.Business
{
    public class CEmployeeInfoBLL
    {
        public static CEmployee getEmployeebyEmployeeID(string employeeID)
        {
            return CEmployeeInfoDAL.Instance.getEmployeebyEmployeeID(employeeID);
        }
        public static CRole getRolebyEmployeeID(string employeeID)
        {
            return CEmployeeInfoDAL.Instance.getRolebyEmployeeID(employeeID);
        }
        public static CDepartment getDepartmentbyDepartmentID(string departmentID)
        {
            return CEmployeeInfoDAL.Instance.getDepartmentbyDepartmentID(departmentID);
        }
        public static List<CEmployeeBelongToProject> getProjectIDbyEmployeeID(string employeeID)
        {
            return CEmployeeInfoDAL.Instance.getProjectIDbyEmployeeID(employeeID);
        }
        public static CProject getProjectbyProjectID(string projectID)
        {
            return CEmployeeInfoDAL.Instance.getProjectbyProjectID(projectID);
        }
        public static List<CEmployeePhoneNumber> getPhoneNumberbyEmployeeID(string employeeID)
        {
            return CEmployeeInfoDAL.Instance.getPhoneNumberbyEmployeeID(employeeID);
        }
    }
}
