using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Interface
{
    class Program
    {

        static DanhSachNhanVien dsNhanVien()
        {
            Console.WriteLine("\t*************************************");
            Console.Write("\t Nhập vào số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            DanhSachNhanVien ds = new DanhSachNhanVien();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\n\t Nhập vào nhân viên thứ: {0}",i);
                ds.Nhap();
            }
            return ds;
        }

        static void showMenu()
        {
            Console.WriteLine("\n\t Phím 0 để thoát");
            Console.WriteLine("\t Phím 1 để nhập vào nhân viên");
            Console.WriteLine("\t Phím 2 để xuất vào nhân viên");
            Console.WriteLine("\t Phím 3 để tính tổng quỹ lương");
            Console.WriteLine("\t Phím 4 để tìm nhân viên");
            Console.WriteLine("\t Phím 5 để xóa nhân viên");
            Console.WriteLine("\t Phím 6 để sửa nhân viên");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            DanhSachNhanVien ds = new DanhSachNhanVien();
            DanhSachNhanVien DS = null;
            while (true)
            {
                showMenu();
                Console.WriteLine("\t*************************************");

                Console.Write("\t Nhập vào options: ");
                int options = int.Parse(Console.ReadLine());
                switch (options)
                {
                    case 0:
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        DS = dsNhanVien();
                        break;
                    case 2:
                        DS.Xuat();
                        break;
                    case 3:
                        DS.tongQuyLuong();
                        break;
                    case 4:
                        DS.Tim();
                        break;
                    case 5:
                        DS.Xoa();
                        break;
                    case 6:
                        DS.Sua();
                        break;

                    default:
                        break;
                }
                Console.ReadLine();

            }





            //NhanVienBienChe nvbc = new NhanVienBienChe();
            //NhanVienHopDong nvhd = new NhanVienHopDong();
            //nvhd.Nhap();
            //nvhd.Xuat();
            //Console.ReadLine();
        }
    }
}
