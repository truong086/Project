using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPLONS
{
    internal class sinhvienBLL
    {
        // Đây là lớp xử lý nghiệp vụ, lớp xử lý nghiệp vụ này có thể chuyển đổi nó sang dang "DataTable" cho giao diện Win form, hoặc chuyển đối sang XML cho giao diện mobile hoặc giao diện Web

        // Khởi tạo lớp "sinhvienDAL"
        sinhvienDAL dalSV;

        // Tạo 1 hàm tạo lớp "sinhvienBLL" để khởi tạo đối tượng lớp "sinhvienDAL"
        public sinhvienBLL()
        {
            dalSV = new sinhvienDAL(); // Khởi tawoj đối tượng lớp "sinhvienDAL"
        }

        // Viết lại các phương thức lớp "sinhvienDAL"
        public DataTable getAllsinhvien()
        {
            return dalSV.getAllsinhvien(); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }

        public DataTable getAllsinhvienCNTT()
        {
            return dalSV.getAllsinhvienCNTT();
        }
        public DataTable chuadonghocphi()
        {
            return dalSV.chuadonghocphi();
        }

        /*public DataTable chuadonghocphis()
        {
            return dalSV.chuadonghocphis();
        }*/

        /*public bool DeleteSinhVienchdp(tbsinhvien sv)
        {
            return dalSV.DeleteSinhVienchdp(sv);
        }*/
        public DataTable getAllsinhvien14()
        {
            return dalSV.getAllsinhvienk14(); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }

        public DataTable getAllsinhvienk16()
        {
            return dalSV.getAllsinhvienk16(); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }

        public DataTable getAllsinhvienk15()
        {
            return dalSV.getAllsinhvienk15();
        }
        public DataTable getAllsinhviendb()
        {
            return dalSV.getAllsinhviendb();
        }

        public DataTable getAllLichsu()
        {
            return dalSV.getAllLichsu();
        }
        public bool AddSinhVien(tbsinhvien sv)
        {
            return dalSV.AddSinhVien(sv); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }
        public bool AddSinhVienk14(tbsinhvien sv)
        {
            return dalSV.AddSinhVienk14(sv);
        }
        public bool AddSinhVienk15(tbsinhvien sv)
        {
            return dalSV.AddSinhVienk15(sv);
        }

        public bool AddSinhVienk16(tbsinhvien sv)
        {
            return dalSV.AddSinhVienk16(sv);
        }

        public bool AddSinhViendb(tbsinhvien sv)
        {
            return dalSV.AddSinhViendb(sv);
        }

        public bool AddLichsu(tbsinhvien sv)
        {
            return dalSV.AddLichsu(sv);
        }
        
        public bool UpdateSinhVien(tbsinhvien sv)
        {
            return dalSV.UpdateSinhVien(sv); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }

        public bool EditTT(tbsinhvien sv)
        {
            return dalSV.EditTT(sv); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }

        public bool UpdateSinhVienk14(tbsinhvien sv)
        {
            return dalSV.UpdateSinhVienk14(sv);
        }

        public bool UpdateSinhVienk15(tbsinhvien sv)
        {
            return dalSV.UpdateSinhVienk15(sv);
        }

        public bool UpdateSinhVienk16(tbsinhvien sv)
        {
            return dalSV.UpdateSinhVienk16(sv);
        }

        public bool UpdateSinhViendb(tbsinhvien sv)
        {
            return dalSV.UpdateSinhViendb(sv);
        }

        public bool DeleteSinhVien(tbsinhvien sv)
        {
            return dalSV.DeleteSinhVien(sv); // Gọi lại các phương thức ở lớp "sinhvienDAL"
        }

        public bool DeleteSinhViendb(tbsinhvien sv)
        {
            return dalSV.DeleteSinhViendb(sv);
        }

        public bool DeleteSinhVienk14(tbsinhvien sv)
        {
            return dalSV.DeleteSinhVienk14(sv);
        }

        public bool DeleteSinhVienk15(tbsinhvien sv)
        {
            return dalSV.DeleteSinhVienk15(sv);
        }

        public bool DeleteSinhVienk16(tbsinhvien sv)
        {
            return dalSV.DeleteSinhVienk16(sv);
        }

        public bool DeleteLichsu(tbsinhvien sv)
        {
            return dalSV.DeleteLichsu(sv);
        }

        /*public bool DeleteSinhVienk152()
        {
            return dalSV.DeleteSinhVienk152();
        }*/

        public DataTable FindSinhVien(string sv)
        {
            return dalSV.FindSinhVien(sv);
        }

        public DataTable FindSinhVienk14(string sv)
        {
            return dalSV.FindSinhVienk14(sv);
        }

        public DataTable FindSinhVienk15(string sv)
        {
            return dalSV.FindSinhVienk15(sv);
        }
        public DataTable FindSinhVienk16(string sv)
        {
            return dalSV.FindSinhVienk16(sv);
        }

        public DataTable FindSinhVienkdb(string sv)
        {
            return dalSV.FindSinhVienkdb(sv);
        }

        public DataTable FindSinhVienCNTT(string sv)
        {
            return dalSV.FindSinhVienCNTT(sv);
        }

        public DataTable taikhoansv()
        {
            return dalSV.taikhoansv();
        }
        public bool AddTaiKHoanSV(tbsinhvien sv)
        {
            return dalSV.AddTaiKHoanSV(sv);
        }
        public bool EditTK(tbsinhvien sv)
        {
            return dalSV.EditTK(sv);
        }
        public bool DeleteTK(tbsinhvien sv)
        {
            return dalSV.DeleteTK(sv);
        }

        public DataTable TimKiemTkNH(string sv)
        {
            return dalSV.TimKiemTkNH(sv);
        }

        public DataTable getAllPT()
        {
            return dalSV.getAllPT();
        }

        public bool AddPT(tbsinhvien sv)
        {
            return dalSV.AddPT(sv);
        }

        public bool EditPT(tbsinhvien sv)
        {
            return dalSV.EditPT(sv);
        }

        public bool DeletePT(tbsinhvien sv)
        {
            return dalSV.DeletePT(sv);
        }

        public DataTable TimkiemPT(string sv)
        {
            return dalSV.TimkiemPT(sv);
        }

        public DataTable getAllNT()
        {
            return dalSV.getAllNT();
        }

        public bool AddNT(tbsinhvien sv)
        {
            return dalSV.AddNT(sv);
        }

        public bool EditNT(tbsinhvien sv)
        {
            return dalSV.EditNT(sv);
        }

        public bool DeleteNT(tbsinhvien sv)
        {
            return dalSV.DeleteNT(sv);
        }

        public DataTable TimkiemNT(string sv)
        {
            return dalSV.TimkiemNT(sv);
        }

        public DataTable getAllTKSV()
        {
            return dalSV.getAllTKSV();
        }

        public bool AddTKSV(tbsinhvien sv)
        {
            return dalSV.AddTKSV(sv);
        }

        public bool EditTKSV(tbsinhvien sv)
        {
            return dalSV.EditTKSV(sv);
        }

        public bool DeleteTKSV(tbsinhvien sv)
        {
            return dalSV.DeleteTKSV(sv);
        }

        public DataTable TimkiemTKSV(string sv)
        {
            return dalSV.TimkiemTKSV(sv);
        }

        public DataTable getAllLop()
        {
            return dalSV.getAllLop();
        }

        public bool AddLop(tbsinhvien sv)
        {
            return dalSV.AddLop(sv);
        }

        public bool EditLop(tbsinhvien sv)
        {
            return dalSV.EditLop(sv);
        }

        public bool DeleteLop(tbsinhvien sv)
        {
            return dalSV.DeleteLop(sv);
        }

        public DataTable TimkiemLop(string sv)
        {
            return dalSV.TimkiemLop(sv);
        }

        public DataTable getAllKhoa()
        {
            return dalSV.getAllKhoa();
        }

        public bool AddKhoa(tbsinhvien sv)
        {
            return dalSV.AddKhoa(sv);
        }

        public bool EditKhoa(tbsinhvien sv)
        {
            return dalSV.EditKhoa(sv);
        }

        public bool DeleteKhoa(tbsinhvien sv)
        {
            return dalSV.DeleteKhoa(sv);
        }


        public DataTable TimkiemKhoa(string sv)
        {
            return dalSV.TimkiemKhoa(sv);
        }

        public DataTable getAllNganh()
        {
            return dalSV.getAllNganh();
        }

        public DataTable getAllKhoacntt()
        {
            return dalSV.getAllKhoacntt();
        }

        public DataTable getAllKhoadulich()
        {
            return dalSV.getAllKhoadulich();
        }
        public DataTable getAllKhoaluat()
        {
            return dalSV.getAllKhoaluat();
        }

        public DataTable getAllKhoaqtkd()
        {
            return dalSV.getAllKhoaqtkd();
        }
        public bool AddNganh(tbsinhvien sv)
        {
            return dalSV.AddNganh(sv);
        }

        public bool AddNganhcntt(tbsinhvien sv)
        {
            return dalSV.AddNganhcntt(sv);
        }

        public bool AddNganhdulich(tbsinhvien sv)
        {
            return dalSV.AddNganhdulich(sv);
        }

        public bool AddNganhluat(tbsinhvien sv)
        {
            return dalSV.AddNganhluat(sv);
        }

        public bool AddNganhqtkd(tbsinhvien sv)
        {
            return dalSV.AddNganhqtkd(sv);
        }
        public bool EditNganh(tbsinhvien sv)
        {
            return dalSV.EditNganh(sv);
        }

        public bool EditNganhcntt(tbsinhvien sv)
        {
            return dalSV.EditNganhcntt(sv);
        }

        public bool EditNganhdulich(tbsinhvien sv)
        {
            return dalSV.EditNganhdulich(sv);
        }

        public bool EditNganhluat(tbsinhvien sv)
        {
            return dalSV.EditNganhluat(sv);
        }

        public bool EditNganhqtkd(tbsinhvien sv)
        {
            return dalSV.EditNganhqtkd(sv);
        }
        public bool DeleteNganh(tbsinhvien sv)
        {
            return dalSV.DeleteNganh(sv);
        }

        public bool DeleteNganhcntt(tbsinhvien sv)
        {
            return dalSV.DeleteNganhcntt(sv);
        }

        public bool DeleteNganhdulich(tbsinhvien sv)
        {
            return dalSV.DeleteNganhdulich(sv);
        }

        public bool DeleteNganhluat(tbsinhvien sv)
        {
            return dalSV.DeleteNganhluat(sv);
        }
        public bool DeleteNganhqtkd(tbsinhvien sv)
        {
            return dalSV.DeleteNganhqtkd(sv);
        }
        public DataTable TimkiemNganh(string sv)
        {
            return dalSV.TimkiemNganh(sv);
        }

        public DataTable TimkiemNganhcntt(string sv)
        {
            return dalSV.TimkiemNganhcntt(sv);
        }

        public DataTable TimkiemNganhdulich(string sv)
        {
            return dalSV.TimkiemNganhdulich(sv);
        }

        public DataTable TimkiemNganhluat(string sv)
        {
            return dalSV.TimkiemNganhluat(sv);
        }

        public DataTable TimkiemNganhqtkd(string sv)
        {
            return dalSV.TimkiemNganhqtkd(sv);
        }
        public DataTable getAllDoituong()
        {
            return dalSV.getAllDoituong();
        }

        public bool AddDoituong(tbsinhvien sv)
        {
            return dalSV.AddDoituong(sv);
        }

        public bool EditDoituong(tbsinhvien sv)
        {
            return dalSV.EditDoituong(sv);
        }

        public bool DeleteDoituong(tbsinhvien sv)
        {
            return dalSV.DeleteDoituong(sv);
        }

        public DataTable TimkiemDoituong(string sv)
        {
            return dalSV.TimkiemDoituong(sv);
        }

        public DataTable getAllMonhoc()
        {
            return dalSV.getAllMonhoc();
        }

        public bool AddMonhoc(tbsinhvien sv)
        {
            return dalSV.AddMonhoc(sv);
        }

        public bool EditMonhoc(tbsinhvien sv)
        {
            return dalSV.EditMonhoc(sv);
        }

        public bool DeleteMonhoc(tbsinhvien sv)
        {
            return dalSV.DelelteMonhoc(sv);
        }

        public DataTable TimkiemMonhoc(string sv)
        {
            return dalSV.TimkiemMonhoc(sv);
        }

        public DataTable getAllThacMac()
        {
            return dalSV.getAllThacMac();
        }

        public bool AddThacMac(tbsinhvien sv)
        {
            return dalSV.AddThacMac(sv);
        }

        public DataTable getAllPhanHoi(tbsinhvien sv)
        {
            return dalSV.getAllPhanHoi(sv);
        }

        public bool AddPhanHoi(tbsinhvien sv)
        {
            return dalSV.AddPhanHoi(sv);
        }

        public bool EditThacMac(tbsinhvien sv)
        {
            return dalSV.EditThacMac(sv);
        }

        public bool DeleteThacMac(tbsinhvien sv)
        {
            return dalSV.DeleteThacMac(sv);
        }

        public bool AddLichSu(tbsinhvien sv)
        {
            return dalSV.AddLichSu(sv);
        }

        public bool AddLichSuTK(tbsinhvien sv)
        {
            return dalSV.AddLichSuTK(sv);
        }
    }
}
