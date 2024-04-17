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
    public class KTXBL
    {
        private static KTXBL instance;
        public static KTXBL Instance
        {
            get => instance ?? (instance = new KTXBL());
        }
        public List<HoGD> showHouseholdlist()
        {
            return KTXDA.Instance.loadHouseHoldList();
        }
        public DataTable getHouseHoldList(string maHGD)
        {
            return KTXDA.Instance.getHouseHoldData(maHGD);
        }
        public DataTable getEmployeeID1()
        {
            return KTXDA.Instance.getEmployeeID1();
        }
        public DataTable getEmployeeID2()
        {
            return KTXDA.Instance.getEmployeeID2();
        }
        public bool checkHouseHoldList(string manv)
        {
            return KTXDA.Instance.checkEmployeeID(manv);
        }
        public bool checkEmployeeID(string manv1,string manv2)
        {
            return KTXDA.Instance.checkEmployeeID(manv1,manv2);
        }
        public bool checkHouseHoldID(string mahgd)
        {
            return KTXDA.Instance.checkHouseHoldID(mahgd);
        }
        public bool insertHouHoldList(string maHGD,string maNV1,string maNV2)
        {
            return KTXDA.Instance.insertHouseHold(maHGD,maNV1,maNV2);
        }
        public bool updateEmployee(string maHGD,string maNV2)
        {
            return KTXDA.Instance.updateEmployee(maHGD,maNV2);
        }
        public bool canAddEmployeeinList(string maNV1)
        {
            return KTXDA.Instance.canaddEmployeeinHouseHold(maNV1);
        }
    }
}
