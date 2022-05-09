using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Interface
{
    class NhanVienHopDong : NhanVien, IPhuCap
    {
        float mucLuong;

        public float MucLuong { get => mucLuong; set => mucLuong = value; }

        public NhanVienHopDong() : base()
        {

        }

        public NhanVienHopDong(string hoTen, string namSinh, string gioiTinh, string cmnd, string maNV, float mucLuong)
                : base(hoTen, namSinh, gioiTinh, cmnd, maNV)
        {
            this.mucLuong = mucLuong;
        }

        public double phuCap()
        {
            return mucLuong / 10;
        }
        public override double ThucLinh()
        {
            return mucLuong + phuCap();
        }

        public override void Nhap()
        {
            Console.WriteLine("\n\t************** Nhập vào nhân viên hợp đồng **************");
            base.Nhap();
            Console.Write("\t Nhập vào mức lương: ");
            MucLuong = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("\t************** Thông tin nhân viên hợp đồng **************");
            base.Xuat();
            Console.WriteLine("\t Mức lương: {0}", MucLuong);
            Console.WriteLine("\t Phụ cấp: {0}", phuCap());
            Console.WriteLine("\t Thực lĩnh: {0}", ThucLinh());
        }
    }
}
