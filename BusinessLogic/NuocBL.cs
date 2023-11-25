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
    public class NuocBL
    {
        private static NuocBL instance;
        public static NuocBL Instance
        {
            get => instance ?? (instance = new NuocBL());
        }
        public List<Nuoc> loadNuocBL()
        {
            return NuocDA.Instance.loadNuoc();
        }
        public DataTable showHouseHold()
        {
            return NuocDA.Instance.getHGD();
        }
        public bool insertNuocBL(string maN, string maGD, DateTime Thang, int hsThangTruoc, int hsHienTai, string DonVi)
        {
            return NuocDA.Instance.insertNuoc(maN,maGD,Thang,hsThangTruoc,hsHienTai,DonVi);
        }
        public bool updateNuocBL(string maN, DateTime thang, int hesothangtruoc, int hesohientai, string donvi)
        {
            return NuocDA.Instance.updateNuoc(maN,thang,hesothangtruoc,hesohientai,donvi);
        }
        public bool deleteNuocBL(string maN)
        {
            return NuocDA.Instance.deleteNuoc(maN);
        }
        public bool checkMaNuocExist(string maN)
        {
            return NuocDA.Instance.CheckMaNuocExists(maN);
        }
        
    }
}
