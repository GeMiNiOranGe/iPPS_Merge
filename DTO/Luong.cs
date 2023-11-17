using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Luong
    {
        private string maluong;
        private DateTime thoidiem;
        private int luongcb;
        private string manl;
        private string mabl;
        private byte? macc;
        private int tn;
        private string manv;
        public string MaLuong
        {
            get { return maluong; }
            set { maluong = value; }
        }
        public DateTime ThoiDiem
        {
            get { return thoidiem; }
            set { thoidiem = value; }
        }
        public int LuongCB
        {
            get { return luongcb; }
            set { luongcb = value; }
        }
        public string MaNgachLuong
        {
            get { return manl; }
            set { manl = value; }
        }
        public string MaBacLuong
        {
            get { return mabl; }
            set { mabl = value; }
        }
        public byte? SoNgayCong
        {
            get { return macc; }
            set { macc = value; }
        }
        public int TienNha
        {
            get { return tn; }
            set { tn = value; }
        }
        public string MaNhanVien
        {
            get { return manv; }
            set { manv = value; }
        }
       
        public Luong(string maluong,DateTime thoidiem,int luongcb,string manl,string mabl,byte? macc,int tiennha,string manv)
        {
            this.maluong= maluong;
            this.thoidiem= thoidiem;
            this.luongcb= luongcb;
            this.manl= manl;
            this.mabl= mabl;
            this.macc= macc;
            this.tn= tiennha;
            this.manv= manv;

        }
    
    }
}
