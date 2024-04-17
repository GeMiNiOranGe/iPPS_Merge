using DataAccess;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class LuongBL {
        private static LuongBL instance;
        public static LuongBL Instance {
            get => instance ?? (instance = new LuongBL());
        }

        public DataTable getEmployeeID() {
            return LuongDA.Instance.getEmployeeID();
        }

        public DataTable getSalaryScale() {
            return LuongDA.Instance.getSalaryScale();
        }

        public bool updateSalaryInfo(string manv, int luongcb, DateTime thoidiem) {
            return LuongDA.Instance.updateSalaryInfo(manv, luongcb, thoidiem);
        }

        public bool deleteSalaryInfo(string manv) {
            return LuongDA.Instance.deleteSalaryInfo(manv);
        }
    }
}
