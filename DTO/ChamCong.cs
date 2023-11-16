using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCong
    {
        private string macc;
        private DateTime thang;
        private byte? songaytrongthang;
        private byte? songaynghiBHXH;
        private byte? songaynghikhonglydo;
        private string manv;
        
        public string MaCC
        {
            get { return macc; }
            set { macc = value; }
        }
        public DateTime Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public byte? SoNgayTrongThang
        {
            get { return songaytrongthang; }
            set { songaytrongthang = value;}
        }
        public byte? SoNgayNghiBHXH
        {
            get { return songaynghiBHXH; }
            set { songaynghiBHXH = value; }
        }
        public byte? SoNgayNghiKhongLyDo
        {
            get { return songaynghikhonglydo; }
            set { songaynghikhonglydo = value; }
        }
        public string MaNV
        {
            get { return manv; }
            set { manv = value; }
        }
        public ChamCong(string macc,DateTime thang, byte? songaytrongthang, byte? songaynghibhxh, byte? songaynghikhonglydo,string manv)
        {
            this.macc = macc;
            this.thang = thang;
            this.songaytrongthang = songaytrongthang;
            this.songaynghiBHXH = songaynghibhxh;
            this.songaynghikhonglydo=songaynghikhonglydo;
            this.manv = manv;
        }
    }
}
