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
    public class DienBL
    {
        private static DienBL instance;
        public static DienBL Instance
        {
            get => instance ?? (instance = new DienBL());
        }
        public List<Dien> loadDienBL()
        {
            return DienDA.Instance.loadDien();
        }
        public DataTable showHouseHoldID()
        {
            return DienDA.Instance.getHGD();
        }
        public bool deleteDienBL(string mad)
        {
            return DienDA.Instance.deleteDien(mad);
        }
        public bool insertDienBL(string mad,string maho,DateTime thang,int hesothangtruoc,int hesohientai,string donvi)
        {
            return DienDA.Instance.insertDien(mad, maho, thang, hesothangtruoc, hesohientai, donvi);
        }
        public bool CheckMaDienExistsBL(string maD)
        {
           return DienDA.Instance.CheckMaDienExists(maD);
        }
        public bool updateDienBL(string maD, DateTime thang, int hesothangtruoc, int hesohientai, string donvi)
        {
            return DienDA.Instance.updateDien(maD,thang,hesothangtruoc,hesohientai,donvi);
        }
       
    }
}
