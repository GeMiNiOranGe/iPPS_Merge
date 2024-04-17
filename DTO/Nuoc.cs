using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nuoc
    {
        private string maNuoc;
        private string maHGD;
        private DateTime Month;
        private int HeSoThangTruoc;
        private int HeSoHienTai;
        private string donvi;
        public string MaNuoc
        {
            get { return maNuoc; }
            set { maNuoc = value; }
        }
        public string MaHGD
        {
            get { return maHGD; }
            set { maHGD = value; }
        }
        public DateTime Thang
        {
            get { return Month; }
            set { Month = value; }
        }
        public int HESONUOCTHANGTRUOC
        {
            get { return HeSoThangTruoc; }
            set { HeSoThangTruoc = value; }
        }
        public int HESONUOCHIENTAI
        {
            get { return HeSoHienTai; }
            set { HeSoHienTai = value; }
        }
        public string DVN
        {
            get { return donvi; }
            set { donvi = value; }
        }
        public Nuoc(string man, string mahgd, DateTime thang, int hesodienthangtruoc, int hesodienhientai, string dv)
        {
            this.maNuoc = man;
            this.maHGD = mahgd;
            this.Month = thang;
            this.HeSoThangTruoc = hesodienthangtruoc;
            this.HeSoHienTai = hesodienhientai;
            this.donvi = dv;
        }
    }
}
