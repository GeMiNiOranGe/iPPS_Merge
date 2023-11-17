using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
   public class ChamCongBL
    {
        private static ChamCongBL instance;
        public static ChamCongBL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChamCongBL();
                }
                return instance;
            }
        }

       public List<ChamCong> getAttendanceList()
        {
            return ChamCongDA.Instance.showAttendanceList();
        }
       public DataTable getEmployeeID()
        {
            return ChamCongDA.Instance.getEmployeeID();
        }
       public bool updateAttendanceBL(string manv,DateTime thang,byte songaydilam,byte songaynghibhxh,byte songaynghikhonglydo)
        {
            return ChamCongDA.Instance.updateAttendace(manv,thang,songaydilam,songaynghibhxh,songaynghikhonglydo);
        }
       public bool insertAttendanceBL(string macc,string manv,DateTime thang,byte songaydilam,byte songaynghibhxh,byte songaynghikhonglydo)
        {
            return ChamCongDA.Instance.insertAttendance(macc,manv,thang,songaydilam,songaynghibhxh,songaynghikhonglydo);
        }
       
    }
}
