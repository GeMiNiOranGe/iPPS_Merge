namespace Pepro.DTOs
{
    public class HoGD
    {
        private string maHoGD;
        private string maNV1;
        private string maNV2;

        public string MaHoGD
        {
            get { return maHoGD; }
            set { maHoGD = value; }
        }
        public string MaNV1
        {
            get { return maNV1; }
            set { maNV1 = value; }
        }
        public string MaNV2
        {
            get { return maNV2; }
            set { maNV2 = value; }
        }
        public HoGD(string mahgd,string manv1,string manv2)
        {
            this.maHoGD = mahgd;
            this.maNV1 = manv1;
            this.maNV2= manv2;
        }
    }
}
