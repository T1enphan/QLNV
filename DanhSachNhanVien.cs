using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanVien_Interface
{
    class DanhSachNhanVien
    {
        Dictionary<string, NhanVien> ds = new Dictionary<string, NhanVien>();

        public void Nhap()
        {
            while (true)
            {
                Console.WriteLine("\n\t************** Nhập vào DS nhân viên **************");
                Console.WriteLine("\t Phím 0 để thoát");
                Console.WriteLine("\t Phím C để nhập vào nhân viên biên chế");
                Console.WriteLine("\t Phím D để nhập vào nhân viên hợp đồng");
                Console.Write("\t Nhập vào option: ");
                string options = Console.ReadLine().ToUpper();
                if (options == "0") break;
                if (options == "C")
                {
                    try
                    {
                        NhanVien nvbc = new NhanVienBienChe();
                        nvbc.Nhap();
                        ds.Add(nvbc.MaNV, nvbc);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\t************** Trùng mã vui lòng nhập lại **************");

                    }
                }

                if (options == "D")
                {
                    try
                    {
                        NhanVien nvhd = new NhanVienHopDong();
                        nvhd.Nhap();
                        ds.Add(nvhd.MaNV, nvhd);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("\t************** Trùng mã vui lòng nhập lại **************");
                    }
                }
            }
        }

        public void Xuat()
        {
            Console.WriteLine("\t************** ******************* **************");
            foreach (NhanVien item in ds.Values)
                item.Xuat();
        }

        public void tongQuyLuong()
        {
            Console.WriteLine("\t************** Tổng số lương **************");
            double tong = 0;
            foreach(NhanVien item in ds.Values)
            {
                tong = tong + item.ThucLinh();
            }
            Console.WriteLine("\n\t--Tổng quỹ lương : {0}", tong);
        }

        public void Tim()
        {
            Console.WriteLine("\t************** Tìm nhân viên **************");
            Console.Write("\n\t Nhập vào mã nhân viên cần tìm: ");
            string tim = Console.ReadLine();
            if (ds.ContainsKey(tim))
            {  
                Console.WriteLine("\n\t Thông tin nhân viên có mã {0}", tim);
                foreach(NhanVien item in ds.Values)
                {
                    if(tim == item.MaNV)
                    item.Xuat();
                }
            }
            else
            {
                Console.WriteLine("\t************** Không có nhân viên cần sửa **************");

            }
        }

        public void Xoa()
        {
            Console.WriteLine("\t************** Xóa nhân viên **************");
            Console.Write("\n\t Nhập vào mã nhân viên cần xóa: ");
            string xoa = Console.ReadLine();
            if (ds.ContainsKey(xoa))
            {
                Console.WriteLine("\t************** Danh sách nhân viên vừa xóa **************");
                Console.WriteLine("\n\t Thông tin nhân viên có mã {0}", xoa);
                ds.Remove(xoa);
                Xuat();
            }
            else
            {
                Console.WriteLine("\t************** Không có nhân viên cần xóa **************");
            }
        }

        public void Sua()
        {
            Console.WriteLine("\t************** Sửa nhân viên **************");
            int p = 0;
            Console.Write("\n\t Nhập vào mã nhân viên cần sửa: ");
            string tim = Console.ReadLine();
            foreach(NhanVien item in ds.Values)
            {
                if (item.MaNV == tim)
                {
                    p = 1;
                    Console.WriteLine("\t************** Cập nhật nhân viên vừa cập nhật **************");
                    while (true)
                    {
                        try
                        {
                            item.Nhap();
                            ds.Remove(tim);
                            ds.Add(item.MaNV, item);
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("\t************** Nhập trùng mã vui lòng nhập lại **************");
                        }
                    }
                    break;
                }
                else p = 0;
                if(p == 0)
                {
                    Console.WriteLine("\t************** Không có nhân viên cần cập nhật **************");

                }
            } 
        }

    }
}
