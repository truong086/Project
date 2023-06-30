using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPLONS
{
    internal class tbsinhvien
    {
        // Ánh xạ lại để lấy ra tất cả các thuộc tính ở bảng "sinhvien" trong sql
        public int masvtt { get; set; }
        public int masv { set; get; }
        public int madoituong { set; get; }
        public int malop { set; get; }
        public string hoten { set; get; }
        public string ngaysinh { get; set; }
        public string diachi { set; get; }
        public string gioitinh { set; get; }
        public int masinhvien { set; get; }
        public string thongbao { set; get; }
        public int id_taikhoan { set; get; }
        public string luudanhsach { set; get; }
        public override string ToString()
        {
            return masvtt + "-" + masv + "-" + madoituong + "-" + malop + "-" + hoten + "-" + ngaysinh + "-" + diachi + "-" + gioitinh;
        }

        // Bảng phiếu thu
        public int mapttt { set; get; }
        public int maphieuthu { set; get; }
        public int masvv { set; get; }
        public int mamonhoc { get; set; }
        public string tenkhoanthu { get; set; }
        public string namhoc { get; set; }
        public string hocky { set; get; }
        public string ngaythu { set; get; }
        public float sotien { set; get; }
        public string hinhthuc { set; get; }
        public int mataikhoanSV { set; get; }
        public int mataikhoanNT { set; get; }

        // Bảng lớp
        public int maloptt { set; get; }
        public int malopp { set; get; }
        public int manganh { set; get; }
        public string tenlop { set; get; }
        public string GVCNlop { set; get; }
        public string khoahoc { set; get; }

        // Bảng khoa
        public int makhoatt { set; get; }
        public int makhoa { set; get; }
        public string tenkhoa { set; get; }
        public string GVCNkhoa { set; get; }

        // Bảng ngành
        public int manganhtt { set; get; }
        public int manganhh { set; get; }
        public int makhoaa { set; get; }
        public string tennganh { set; get; }

        // Bảng đối tượng
        public int madoituongtt { set; get; }
        public int madoituongg { set; get; }
        public string tendoituong { set; get; }

        // Tài khoản ngân hàng sinh viên
        public int mataikhoann { set; get; }
        public int masvvv { set; get; }
        public string tennganhang { set; get; }
        public string tenchinhanh { set; get; }
        public string sotaikhoan { set; get; }
        public string tentaikhoan { set; get; }
        public string ngayvao { set; get; }

        // Bảng tài khoản nhận tiền học phí
        public int mataikhoanHT { set; get; }
        public string tennganhangHT { set; get; }
        public string tenchinhanhHT { set; get; }
        public string sotaikhoanHT { set; get; }
        public string tentaikhoanHT { set; get; }
        public string ngayvaoHT { set; get; }

        // Bảng tài khoản
        public int mataikhoantt { set; get; }
        public int tentaikhoanDN { set; get; }
        public string matkhau { set; get; }
        public int capquyen { set; get; }

        // Bảng môn học
        public int mamonhoctt { set; get; }
        public int mamonhocc { set; get; }
        public string tenmonhoc { set; get; }

        // Bảng thắc mắc
        public int idTM { set; get; }
        public int msv_id { set; get; }
        public int lop_id { set; get; }
        public string khoahocTM { set; get; }
        public string emailTM { set; get; }
        public string sodienthoai { set; get; }
        public string diachiTM { set; get; }
        public string noidung { set; get; }
        public string trangthaiTM { set; get; }

        // Bảng phản hồi
        public int idPH { set; get; }
        public string tentaikhoanPH { set; get; }
        public string emailPH { set; get; }
        public string sodienthoaiPH { set; get; }
        public string chucvu { set; get; }
        public string noidungPH { set; get; }
        public int msv_idPH { set; get; }
        public string trangthai { set; get; }

        // Bảng lịch sử
        public int masvttLS { set; get; }
        public int masvLS { set; get; }
        public int madoituongLS { set; get; }
        public int malopLS { set; get; }
        public string hotenLS { set; get; }
        public string ngaysinhLS { set; get; }
        public string diachiLS { set; get; }
        public string gioitinhLS { set; get; }
        public string mota { set; get; }
        public int id_taikhoanLS { set; get; }

    }
}
