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
   public class TienNhaBL
    {
        private static TienNhaBL instance;
        public static TienNhaBL Instance
        {
            get => instance ?? (instance = new TienNhaBL());
        }
        public List<TienNha> loadTienNhaBL()
        {
            return TienNhaDA.Instance.loadTienNhaList();
        }
        public DataTable getMaHGD()
        {
            return TienNhaDA.Instance.getMaHGD();
        }
        public bool calculateTienNha(string mantt)
        {
            return TienNhaDA.Instance.calculateTienNha(mantt);
        }
        public int getTongTien(string mantt)
        {
            return TienNhaDA.Instance.GetTongTienByMANTT(mantt);
        }
        public bool updateTienNha(string mantt,DateTime thang,int tiennha,int tienantt)
        {
            return TienNhaDA.Instance.updateTienNha(mantt,thang,tiennha,tienantt);
        }
      

    }
}
