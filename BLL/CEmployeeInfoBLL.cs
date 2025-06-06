using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CEmployeeInfoBLL
    {
        public static CEmployee getEmployeebyEmployeeID(string employeeID)
        {
            return DataAccess.CEmployeeInfoDAL.Instance.getEmployeebyEmployeeID(employeeID);
        }
        public static CRole getRolebyEmployeeID(string employeeID)
        {
            return DataAccess.CEmployeeInfoDAL.Instance.getRolebyEmployeeID(employeeID);
        }
        public static CDepartment getDepartmentbyDepartmentID(string departmentID)
        {
            return DataAccess.CEmployeeInfoDAL.Instance.getDepartmentbyDepartmentID(departmentID);
        }
        public static List<CEmployeeBelongToProject> getProjectIDbyEmployeeID(string employeeID)
        {
            return DataAccess.CEmployeeInfoDAL.Instance.getProjectIDbyEmployeeID(employeeID);
        }
        public static CProject getProjectbyProjectID(string projectID)
        {
            return DataAccess.CEmployeeInfoDAL.Instance.getProjectbyProjectID(projectID);
        }
        public static List<CEmployeePhoneNumber> getPhoneNumberbyEmployeeID(string employeeID)
        {
            return DataAccess.CEmployeeInfoDAL.Instance.getPhoneNumberbyEmployeeID(employeeID);
        }
    }
}
