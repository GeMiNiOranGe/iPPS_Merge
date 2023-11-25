using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Dien
    {
        private string maDien;
        private string maHGD;
        private DateTime Month;
        private int HeSoThangTruoc;
        private int HeSoHienTai;
        private string donvi;
        public string MaDien
        {
            get { return maDien; }
            set { maDien = value; }
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
        public int HeSoDienThangTruoc
        {
            get { return HeSoThangTruoc; }
            set { HeSoThangTruoc = value; }
        }
        public int HeSoDienHienTai
        {
            get { return HeSoHienTai; }
            set { HeSoHienTai = value; }
        }
        public string DonVi
        {
            get { return donvi; }
            set { donvi = value; }
        }
        public Dien(string mad,string mahgd,DateTime thang,int hesodienthangtruoc,int hesodienhientai,string dv)
        {
            this.MaDien = mad;
            this.maHGD= mahgd;
            this.Thang = thang;
            this.HeSoThangTruoc= hesodienthangtruoc;
            this.HeSoDienHienTai=hesodienhientai;
            this.DonVi = dv;
        }
    }
}
