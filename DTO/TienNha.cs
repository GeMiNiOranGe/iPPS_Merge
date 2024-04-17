using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TienNha
    {
        private string mantt;
        private string mahgd;
        private DateTime thang;
        private int tiennha;
        private int hesodienhientai;
        private int hesonuochientai;
        private int phivesinhanninhtrattu;
        private int? tongtien;
        public string MaNTT
        {
            get { return mantt; }
            set { mantt = value; }
        }
        public string MaHGD
        {
            get { return mahgd; }
            set { mahgd = value; }
        }
        public DateTime Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int TienNhaCoDinh
        {
            get { return tiennha; }
            set { tiennha = value; }
        }
        public int HeSoDien
        {
            get { return hesodienhientai; }
            set {  hesodienhientai = value;}
        }
        public int HeSoNuoc
        {
            get { return hesonuochientai; }
            set { hesonuochientai = value; }
        }
        public int PhiVSANTT
        {
            get { return phivesinhanninhtrattu; }
            set { phivesinhanninhtrattu = value; }
        }
        public int? TongTienNha
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public TienNha(string mantt,string mahgd,DateTime thang,int tiennha,int hesodien,int hesonuoc,int tienantt,int? tongtien)
        {
            this.mantt = mantt;
            this.mahgd = mahgd;
            this.thang = thang;
            this.tiennha = tiennha;
            this.hesodienhientai= hesodien;
            this.hesonuochientai=hesonuoc;
            this.phivesinhanninhtrattu = tienantt;
            this.tongtien=tongtien;

        }
    }
}
