using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LuongBL
    {
        private static LuongBL instance;
        public static LuongBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LuongBL();
                }
                return instance;
            }
        }
        public DataTable getEmployeeID()
        {
            return LuongDA.Instance.getEmployeeID();
        }

    }
}
