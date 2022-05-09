using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Interface
{
    class NhanVienBienChe : NhanVien, IPhuCap
    {
        float heSoLuong;
        float luongCoBan;

        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public float LuongCoBan { get => luongCoBan; set => luongCoBan = value; }

        public NhanVienBienChe(): base()
        {

        }

        public NhanVienBienChe(string hoTen, string namSinh, string gioiTinh, string cmnd, string maNV, float heSoLuong, float luongCoBan)
            : base(hoTen, namSinh, gioiTinh, cmnd, maNV)
        {
            this.heSoLuong = heSoLuong;
            this.luongCoBan = luongCoBan;
        }

        public double phuCap()
        {
            return LuongCoBan / 10;
        }

        public override double ThucLinh()
        {
            return heSoLuong * luongCoBan + phuCap();
        }


        public override void Nhap()
        {
            Console.WriteLine("\n\t************** Nhập vào nhân viên biên chế **************");
            base.Nhap();
            Console.Write("\t Nhập vào hệ số lương: ");
            HeSoLuong = float.Parse(Console.ReadLine());
            Console.Write("\t Nhập vào lương cơ bản: ");
            LuongCoBan = float.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            Console.WriteLine("\t************** Thông tin nhân viên biên chế **************");
            base.Xuat();
            Console.WriteLine("\t Hệ số lương: {0}", HeSoLuong);
            Console.WriteLine("\t Lương cơ bản: {0}", LuongCoBan);
            Console.WriteLine("\t Phụ cấp: {0}", phuCap());
            Console.WriteLine("\t Thực lĩnh: {0}", ThucLinh());
        }
    }
}
