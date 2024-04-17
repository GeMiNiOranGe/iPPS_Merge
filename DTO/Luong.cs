using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO {
    public class Luong {
        private string manv;
        private int luongcb;
        private decimal hesobl;
        private decimal hesophucap;
        private byte songaydilam;
        private byte songaynghibhxh;
        private byte songaynghikhongphep;
        private int tiennha;
        private int? tongluong;
        private DateTime thoidiem;

        public string MaNhanVien { get { return manv; } set { manv = value; } }
        public int LuongCoBan { get { return luongcb; } set { luongcb = value; } }
        public decimal HeSoBacLuong { get { return hesobl; } set { hesobl = value; } }
        public decimal HeSoPhuCapChucVu { get { return hesophucap; } set { hesophucap = value; } }
        public byte SoNgayDiLam { get { return songaydilam; } set { songaydilam = value; } }
        public byte SoNgayNghiBHXH { get { return songaynghibhxh; } set { songaynghibhxh = value; } }
        public byte SoNgayNghiKhongLyDo { get { return songaynghikhongphep; } set { songaynghikhongphep = value; } }
        public int TienNha { get { return tiennha; } set { tiennha = value; } }
        public int? TongLuong { get { return tongluong; } set { tongluong = value; } }
        public DateTime ThoiDiem { get { return thoidiem; } set { thoidiem = value; } }

        public Luong(string manv, int lcb, decimal hsbl, decimal hspc, byte songaydilam, byte songaynghibhxh, byte songaynghikhongphep, int tiennha, int? tongluong, DateTime thoidiem) {
            this.manv = manv;
            this.luongcb = lcb;
            this.hesobl = hsbl;
            this.hesophucap = hspc;
            this.songaydilam = songaydilam;
            this.songaynghibhxh = songaynghibhxh;
            this.songaynghikhongphep = songaynghikhongphep;
            this.tiennha = tiennha;
            this.tongluong = tongluong;
            this.thoidiem = thoidiem;
        }
    }
}
