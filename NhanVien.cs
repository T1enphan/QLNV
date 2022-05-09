using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Interface
{
    abstract class NhanVien
    {
        string hoTen;
        string namSinh;
        string gioiTinh;
        string cmnd;
        string maNV;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NamSinh { get => namSinh; set => namSinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        public NhanVien(string hoTen, string namSinh, string gioiTinh, string cmnd, string maNV)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.cmnd = cmnd;
            this.maNV = maNV;
        }

        public NhanVien() { }

        public virtual void Nhap()
        {
            Console.Write("\t Nhập vào mã nhân viên: ");
            MaNV = Console.ReadLine();
            Console.Write("\t Nhập vào họ tên: ");
            HoTen = Console.ReadLine();
            Console.Write("\t Nhập vào năm sinh: ");
            NamSinh = Console.ReadLine();
            Console.Write("\t Nhập vào giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.Write("\t Nhập vào số CMND: ");
            Cmnd = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\t Mã nhân viên: {0}",MaNV);
            Console.WriteLine("\t Họ tên: {0}", HoTen);
            Console.WriteLine("\t Năm sinh: {0}", NamSinh);
            Console.WriteLine("\t Giới tính: {0}", GioiTinh);
            Console.WriteLine("\t Số CMND: {0}", Cmnd);
        }

        public abstract double ThucLinh();
    }
}
