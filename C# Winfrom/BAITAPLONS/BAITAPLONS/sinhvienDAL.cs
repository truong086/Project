using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPLONS
{
    // Thực hiện các phương thức thêm sửa xóa
    internal class sinhvienDAL
    {
        // Gọi lại chuỗi kết nối từ class "DataConnection"
        DataConnection dc;

        SqlDataAdapter da;
        SqlCommand cmd; // Sử dụng đối tượng này để thêm sinh viên, bằng câu lệnh "insert into"

        // // Tạo ra 1 hàm tạo, để khởi tạo chuỗi kết nối
        public sinhvienDAL()
        {
            dc = new DataConnection();
        }

        // ----------------------------------------------------------CODE PHẦN THÔNG TIN SINH VIÊN----------------------------------------------

        // Tạo 1 phương thức để lấy ra tất cả dữ liệu trong bảng sinh viên
        public DataTable getAllsinhvien()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from sinhvien";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }

        public DataTable getAllsinhvienCNTT()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select sinhvien.msv, sinhvien.hoten, sinhvien.diachi, sinhvien.gioitinh, lop.malop, lop.tenlop, nganh.manganh, nganh.tennganh from ((lop left join sinhvien on lop.malop = sinhvien.malop) left join nganh on nganh.manganh = lop.manganh) where makhoa = 113";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }


        public DataTable getAllsinhviendb()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from dacbiet";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }

        public DataTable getAllsinhvienk14()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from SinhVienK14";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }

        // Sinh viên khóa 16
        public DataTable getAllsinhvienk16()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from SinhVienK16";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }

        public DataTable getAllsinhvienk15()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from SinhVienK15";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }
        public DataTable chuadonghocphi()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select sinhvien.msv, sinhvien.madoituong, sinhvien.malop, sinhvien.hoten, sinhvien.ngaysinh, sinhvien.diachi, sinhvien.gioitinh from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv not in (select phieuthu.msv from phieuthu)";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }

        /*public DataTable chuadonghocphis()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from chuadongHocPhis";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }*/

        // Hàm thêm sinh viên, sử dụng "bool" để thêm sinh viên, nếu thêm thành công thì sẽ trả về true, nếu không thêm thành công thì sẽ trả về false
        // Tạo 1 phương thức để thêm sinh viên
        public bool AddSinhVien(tbsinhvien sv)
        {
            // Tạo câu lệnh sql thêm sinh viên
            string sql = "insert into sinhvien(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@masv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh)";
            // Gọi lại chuỗi kết nối CSDL
            SqlConnection con = dc.getConnection();

            // Sử dụng tr, catch để bắt lỗi nếu xảy ra lỗi
            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();
                 
                // Thêm các tham số cho trường dữ liệu sql, để thêm dữ liệu vào database
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv; // sử dụng hàm "Parameters.Add" để thêm dữ liệu
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng chuỗi kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false; // Nếu thêm không thành công thì trả về false
            }
            return true; // Nếu thêm thành công thì trả về true
        }


        // Thêm dữ liệu sinh viên khóa 14
        public bool AddSinhVienk14(tbsinhvien sv)
        {
            // Tạo câu lệnh sql thêm sinh viên
            string sql = "insert into SinhVienK14(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@masv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh)";
            // Gọi lại chuỗi kết nối CSDL
            SqlConnection con = dc.getConnection();

            // Sử dụng tr, catch để bắt lỗi nếu xảy ra lỗi
            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Thêm các tham số cho trường dữ liệu sql, để thêm dữ liệu vào database
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv; // sử dụng hàm "Parameters.Add" để thêm dữ liệu
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng chuỗi kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false; // Nếu thêm không thành công thì trả về false
            }
            return true; // Nếu thêm thành công thì trả về true
        }

        // Add sinh viên khóa 13
        public bool AddSinhVienk16(tbsinhvien sv)
        {
            // Tạo câu lệnh sql thêm sinh viên
            string sql = "insert into SinhVienK16(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@masv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh)";
            // Gọi lại chuỗi kết nối CSDL
            SqlConnection con = dc.getConnection();

            // Sử dụng tr, catch để bắt lỗi nếu xảy ra lỗi
            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Thêm các tham số cho trường dữ liệu sql, để thêm dữ liệu vào database
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv; // sử dụng hàm "Parameters.Add" để thêm dữ liệu
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng chuỗi kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false; // Nếu thêm không thành công thì trả về false
            }
            return true; // Nếu thêm thành công thì trả về true
        }

        // Thêm dữ liệu sinh viên khóa 15
        public bool AddSinhVienk15(tbsinhvien sv)
        {
            // Tạo câu lệnh sql thêm sinh viên
            string sql = "insert into SinhVienK15(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@masv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh)";
            // Gọi lại chuỗi kết nối CSDL
            SqlConnection con = dc.getConnection();

            // Sử dụng tr, catch để bắt lỗi nếu xảy ra lỗi
            try
            {
                
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Thêm các tham số cho trường dữ liệu sql, để thêm dữ liệu vào database
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv; // sử dụng hàm "Parameters.Add" để thêm dữ liệu
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng chuỗi kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false; // Nếu thêm không thành công thì trả về false
            }
            return true; // Nếu thêm thành công thì trả về true
        }

        // Thêm dữ liệu các sinh viên đặc biệt
        public bool AddSinhViendb(tbsinhvien sv)
        {
            // Tạo câu lệnh sql thêm sinh viên
            string sql = "insert into dacbiet(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh) values (@masv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh)";
            // Gọi lại chuỗi kết nối CSDL
            SqlConnection con = dc.getConnection();

            // Sử dụng tr, catch để bắt lỗi nếu xảy ra lỗi
            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Thêm các tham số cho trường dữ liệu sql, để thêm dữ liệu vào database
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv; // sử dụng hàm "Parameters.Add" để thêm dữ liệu
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng chuỗi kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false; // Nếu thêm không thành công thì trả về false
            }
            return true; // Nếu thêm thành công thì trả về true
        }

        // Add lịch sử
        public bool AddLichsu(tbsinhvien sv)
        {
            // Tạo câu lệnh sql thêm sinh viên
            string sql = "insert into lichsu(msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh, id_taikhoan) values (@masv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh, @id_taikhoan)";
            // Gọi lại chuỗi kết nối CSDL
            SqlConnection con = dc.getConnection();

            // Sử dụng tr, catch để bắt lỗi nếu xảy ra lỗi
            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Thêm các tham số cho trường dữ liệu sql, để thêm dữ liệu vào database
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv; // sử dụng hàm "Parameters.Add" để thêm dữ liệu
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.Parameters.Add("@id_taikhoan", SqlDbType.Int).Value = sv.id_taikhoan;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng chuỗi kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false; // Nếu thêm không thành công thì trả về false
            }
            return true; // Nếu thêm thành công thì trả về true
        }

        // Tạo 1 phương thức để sửa thông tin sinh viên
        public bool UpdateSinhVien(tbsinhvien sv)
        {
            string sql = "update sinhvien set msv = @masv, madoituong = @madoituong, malop = @malop, hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh where masvtt = @masvtt or msv = @masv";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masvtt;
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Update sinh viên đặc biệt
        public bool UpdateSinhViendb(tbsinhvien sv)
        {
            string sql = "update dacbiet set msv = @masv, madoituong = @madoituong, malop = @malop, hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh where msv = @masv";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Update sinh viên khóa 14
        public bool UpdateSinhVienk14(tbsinhvien sv)
        {
            string sql = "update SinhVienK14 set msv = @masv, madoituong = @madoituong, malop = @malop, hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh where msv = @masv";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Update sinh viên khóa 13
        public bool UpdateSinhVienk16(tbsinhvien sv)
        {
            string sql = "update SinhVienK16 set msv = @masv, madoituong = @madoituong, malop = @malop, hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh where msv = @masv or masvtt = @masvtt";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masvtt;
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Update sinh viên khóa 15
        public bool UpdateSinhVienk15(tbsinhvien sv)
        {
            string sql = "update SinhVienK15 set msv = @masv, madoituong = @madoituong, malop = @malop, hoten = @hoten, ngaysinh = @ngaysinh, diachi = @diachi, gioitinh = @gioitinh where msv = @masv or masvtt = @masvtt";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masvtt;
                cmd.Parameters.Add("@masv", SqlDbType.Int).Value = sv.masv;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malop;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = sv.hoten;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = sv.ngaysinh;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachi;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = sv.gioitinh;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để xóa sinh viên
        public bool DeleteSinhVien(tbsinhvien sv)
        {
            string sql = "delete sinhvien where msv = @msv or masvtt = @masvtt";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masvtt;
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        // Cách 2: Phương thức xóa thông tin sinh vien ra khỏi bảng chưa đóng học phí, from(dadonghocphi)
        /*public bool DeleteSinhVienchdp(tbsinhvien sv)
        {
            string sql = "delete chuadongHocPhis where masvtt = @masvtt";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masinhvien;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }*/

        // Xóa sinh viên khóa 14
        public bool DeleteSinhVienk14(tbsinhvien sv)
        {
            string sql = "delete SinhVienK14 where msv = @msv";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool DeleteSinhVienk15(tbsinhvien sv)
        {
            string sql = "delete from SinhVienK15 where msv = @msv or masvtt = @masvtt";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masvtt;
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        // Xóa sinh viên khóa 13
        public bool DeleteSinhVienk16(tbsinhvien sv)
        {
            string sql = "delete from SinhVienK16 where msv = @msv or masvtt = @masvtt";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@masvtt", SqlDbType.Int).Value = sv.masvtt;
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        /*public bool DeleteSinhVienk152()
        {
            string sql = "delete SinhVienK15 where malop <> 5 and malop <> 6 and malop <> 8 and malop <> 12";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }*/

        // Xóa sinh viên đặc biệt
        public bool DeleteSinhViendb(tbsinhvien sv)
        {
            string sql = "delete from dacbiet where msv = @msv";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        // Xóa lịch sử
        public bool DeleteLichsu(tbsinhvien sv)
        {
            string sql = "delete from lichsu where msv = @msv";
            SqlConnection con = dc.getConnection(); // Gọi lại chuỗi kết nối CSDL

            try
            {
                cmd = new SqlCommand(sql, con); // Nếu là thêm dữ liệu thì phải dùng hàm "SqlCommand()", để chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Vì là câu lệnh xóa nên chỉ cần chuyền vào 1 tham số là "masv"(mã sinh viên)
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.ExecuteNonQuery(); // Muốn thực thi câu lệnh ở lớp Command này thì phải thêm thuộc tính "ExecuteNonQuery()" này vào thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        // Phương thức tìm kiếm sinh viên
        public DataTable FindSinhVien(string sv) // Phương thức này trả về 1 kiểu "DataTable"
        {
            string sql = "select * from sinhvien where hoten like N'%" + sv + "%' or malop like N'%" + sv + "%'"; // Thêm chữ "N" sau điều kiện tìm kiếm "like" để tìm kiếm được tiếng việt
            // Tạo kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, con); // Chuyền 2 tham số vào là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con" để xử lý dữ liệu
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ "SqlDataAdapter" vào "DataTable"
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để đổ dữ liệu ra
            // Đóng kết nối
            con.Close();
            return dt;
        }

        // Tìm kiếm sinh viên khóa 14
        public DataTable FindSinhVienk14(string sv) // Phương thức này trả về 1 kiểu "DataTable"
        {
            string sql = "select * from SinhVienK14 where hoten like N'%" + sv + "%' or malop like N'%" + sv + "%'"; // Thêm chữ "N" sau điều kiện tìm kiếm "like" để tìm kiếm được tiếng việt
            // Tạo kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, con); // Chuyền 2 tham số vào là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con" để xử lý dữ liệu
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ "SqlDataAdapter" vào "DataTable"
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để đổ dữ liệu ra
            // Đóng kết nối
            con.Close();
            return dt;
        }

        // Tìm kiếm sinh viên khóa 15
        public DataTable FindSinhVienk15(string sv) // Phương thức này trả về 1 kiểu "DataTable"
        {
            string sql = "select * from SinhVienK15 where hoten like N'%" + sv + "%' or malop like N'%" + sv + "%'"; // Thêm chữ "N" sau điều kiện tìm kiếm "like" để tìm kiếm được tiếng việt
            // Tạo kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, con); // Chuyền 2 tham số vào là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con" để xử lý dữ liệu
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ "SqlDataAdapter" vào "DataTable"
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để đổ dữ liệu ra
            // Đóng kết nối
            con.Close();
            return dt;
        }

        // Tìm kiếm sinh viên khóa 13
        public DataTable FindSinhVienk16(string sv) // Phương thức này trả về 1 kiểu "DataTable"
        {
            string sql = "select * from SinhVienK16 where hoten like N'%" + sv + "%' or malop like N'%" + sv + "%'"; // Thêm chữ "N" sau điều kiện tìm kiếm "like" để tìm kiếm được tiếng việt
            // Tạo kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, con); // Chuyền 2 tham số vào là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con" để xử lý dữ liệu
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ "SqlDataAdapter" vào "DataTable"
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để đổ dữ liệu ra
            // Đóng kết nối
            con.Close();
            return dt;
        }
        // Tìm kiếm sinh viên đặc biệt
        public DataTable FindSinhVienkdb(string sv) // Phương thức này trả về 1 kiểu "DataTable"
        {
            string sql = "select * from dacbiet where hoten like N'%" + sv + "%' or malop like N'%" + sv + "%'"; // Thêm chữ "N" sau điều kiện tìm kiếm "like" để tìm kiếm được tiếng việt
            // Tạo kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, con); // Chuyền 2 tham số vào là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con" để xử lý dữ liệu
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ "SqlDataAdapter" vào "DataTable"
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để đổ dữ liệu ra
            // Đóng kết nối
            con.Close();
            return dt;
        }

        // Tìm kiếm sinh viên học công nghệ thông tin
        public DataTable FindSinhVienCNTT(string sv) // Phương thức này trả về 1 kiểu "DataTable"
        {
            string sql = "select sinhvien.msv, sinhvien.hoten, sinhvien.diachi, sinhvien.gioitinh, lop.malop, lop.tenlop, nganh.manganh, nganh.tennganh from ((lop left join sinhvien on lop.malop = sinhvien.malop) left join nganh on nganh.manganh = lop.manganh) where makhoa = 113 and sinhvien.hoten like N'%" + sv + "%' or sinhvien.malop like N'%" + sv + "%'"; // Thêm chữ "N" sau điều kiện tìm kiếm "like" để tìm kiếm được tiếng việt
            // Tạo kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, con); // Chuyền 2 tham số vào là: câu lệnh "sql" và chuỗi kết nối đến CSDL là "con" để xử lý dữ liệu
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ "SqlDataAdapter" vào "DataTable"
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để đổ dữ liệu ra
            // Đóng kết nối
            con.Close();
            return dt;
        }


        // ----------------------------------------------------------CODE PHẦN TÀI KHOẢN NGÂN HÀNG SINH VIÊN ----------------------------------------
        public DataTable taikhoansv()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ sinh viên
            string sql = "select * from taikhoannganhangSV";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }
        public bool AddTaiKHoanSV(tbsinhvien sv)
        {
            string sql = "insert into taikhoannganhangSV(msv, tennganhang, chinhanh, sotaikhoan, tentaikhoan, ngaytao) values (@msv, @tennganhang, @chinhanh, @sotaikhoan, @tentaikhoan, @ngaytao)";
            // Gọi lại câu lệnh kết nối đến CSDL từ lớp class "DataConnection"
            SqlConnection con = dc.getConnection();
            // Để vào try, catch phòng trường hợp phát sinh lỗi
            try
            {
                // Muốn thêm dữ liệu hoặc sửa hoặc xóa dữ liệu thì phải dùng câu lệnh "SqlCommand" để xử lý
                cmd = new SqlCommand(sql, con);
                // Mở kết nối
                con.Open();

                // Thêm các tham số cho trường dữ liệu, để thêm dữ liệu vào database
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masvvv; // Sử dụng hàm "Parameters" để thêm dữ liệu
                cmd.Parameters.Add("@tennganhang", SqlDbType.NVarChar).Value = sv.tennganhang;
                cmd.Parameters.Add("@chinhanh", SqlDbType.NVarChar).Value = sv.tenchinhanh;
                cmd.Parameters.Add("@sotaikhoan", SqlDbType.NVarChar).Value = sv.sotaikhoan;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = sv.tentaikhoan;
                cmd.Parameters.Add("@ngaytao", SqlDbType.NVarChar).Value = sv.ngayvao;
                cmd.ExecuteNonQuery(); // Muốn thêm, sửa, xóa dữ liệu thì phải có câu lệnh này mới thực thi được
                // Đóng kết nối
                con.Close() ;
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool EditTK(tbsinhvien sv)
        {
            // Tạo cậu lệnh sql
            string sql = "update taikhoannganhangSV set msv = @msv, tennganhang = @tennganhang, chinhanh = @chinhanh, sotaikhoan = @sotaikhoan, tentaikhoan = @tentaikhoan, ngaytao = @ngaytao where manganhang = @manganhang";
            // Gọi lại câu lệnh kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng câu lệnh "SqlCommand" để xử lý
                cmd = new SqlCommand (sql, con);
                // Mở kết nối
                con.Open();

                // Tạo các trường dữ liệu, để thêm dữ liệu vào database
                cmd.Parameters.Add("@manganhang", SqlDbType.Int).Value = sv.mataikhoann;
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masvvv;
                cmd.Parameters.Add("@tennganhang", SqlDbType.NVarChar).Value = sv.tennganhang;
                cmd.Parameters.Add("@chinhanh", SqlDbType.NVarChar).Value = sv.tenchinhanh;
                cmd.Parameters.Add("@sotaikhoan", SqlDbType.NVarChar).Value = sv.sotaikhoan;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = sv.tentaikhoan;
                cmd.Parameters.Add("@ngaytao", SqlDbType.NVarChar).Value = sv.ngayvao;
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool EditTT(tbsinhvien sv)
        {
            // Tạo cậu lệnh sql
            string sql = "update sinhvien set thongbao = @thongbao where msv = @msv";
            // Gọi lại câu lệnh kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng câu lệnh "SqlCommand" để xử lý
                cmd = new SqlCommand(sql, con);
                // Mở kết nối
                con.Open();

                // Tạo các trường dữ liệu, để thêm dữ liệu vào database
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masv;
                cmd.Parameters.Add("@thongbao", SqlDbType.NVarChar).Value = sv.thongbao;
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteTK(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "delete taikhoannganhangSV where manganhang = @manganhang";
            // Gọi lại câu lệnh kết nối đến CSDL từ lớp "DataConnection"
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng câu lệnh "SqlCommand" để xử lý
                cmd = new SqlCommand(sql, con);
                con.Open(); // Mở kết nối
                // tạo trường dữ liệu để xóa dữ liệu, muốn xóa dữ liệu thì chỉ cần chuyền 1 trường dữ liệu đó mà "manganhang" nghĩa là (id)
                cmd.Parameters.Add("@manganhang", SqlDbType.Int).Value = sv.mataikhoann;
                cmd.ExecuteNonQuery();

                // Đóng kết nối
                con.Close();

            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public DataTable TimKiemTkNH(string sv)
        {
            // Tạo câu lệnh Sql
            string sql = "select * from taikhoannganhangSV where msv like N'%" + sv + "%' or tentaikhoan like N'%" + sv + "%'";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection conn = dc.getConnection();
            // Khởi tạo lớp "SqlDataAdapter"
            da = new SqlDataAdapter(sql, conn); // Chuyền vào 2 tham số là: câu lệnh "sql" và chuỗi kết nối đến CSDl "conn" để xử lý
            // Mở kết nối
            conn.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable, Khởi tạo 1 lớp DataTable
            DataTable dt = new DataTable();
            // Dùng hàm "Fill()" để lấy dữ liệu ra
            da.Fill(dt);
            // Đóng kết nối
            conn.Close();
            return dt;
        }

        //--------------------------------------------------------CODE PHẦN PHIẾU THU-------------------------------------------------
        // Tạo 1 phương thức hiển thị danh sách phiếu thu
        public DataTable getAllPT()
        {
            // Tạo câu lệnh sql
            string sql = "select * from phieuthu";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Mở kết nối
            con.Open();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        // Tạo 1 phương thức để thêm phiếu thu
        public bool AddPT(tbsinhvien sv)
        {
            // tạo câu lệnh sql
            string sql = "insert into phieuthu(msv, mamonhoc, tenkhoanthu, namhoc, hocky, ngaythu, sotien, hinhthuc, mataikhoannganhangSV, mataikhoannhantienHP) values (@msv, @mamonhoc, @tenkhoanthu, @namhoc, @hocky, @ngaythu, @sotien, @hinhthuc, @mataikhoannganhangSV, @mataikhoannhantienHP)";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL "con"
                con.Open(); // Mở kết nối

                //cmd.Parameters.Add("@maphieuthu", SqlDbType.Int).Value = sv.maphieuthu;
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masvv;
                cmd.Parameters.Add("@mamonhoc", SqlDbType.Int).Value = sv.mamonhoc;
                cmd.Parameters.Add("@tenkhoanthu", SqlDbType.NVarChar).Value = sv.tenkhoanthu;
                cmd.Parameters.Add("@namhoc", SqlDbType.NVarChar).Value = sv.namhoc;
                cmd.Parameters.Add("@hocky", SqlDbType.NVarChar).Value = sv.hocky;
                cmd.Parameters.Add("@ngaythu", SqlDbType.NVarChar).Value = sv.ngaythu;
                cmd.Parameters.Add("@sotien", SqlDbType.Float).Value = sv.sotien;
                cmd.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = sv.hinhthuc;
                cmd.Parameters.Add("@mataikhoannganhangSV", SqlDbType.Int).Value = sv.mataikhoanSV;
                cmd.Parameters.Add("@mataikhoannhantienHP", SqlDbType.Int).Value = sv.mataikhoanNT;
                cmd.ExecuteNonQuery(); // Phải có thêm câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để sửa thông tin phiếu thu
        public bool EditPT(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            // string sql = "update phieuthu set maphieuthu = @maphieuthu, msv = @msv, mamonhoc = @mamonhoc, tenkhoanthu = @tenkhoanthu, namhoc = @namhoc, hocky = @hocky, ngaythu = @ngaythu, sotien = @sotien, hinhthuc = @hinhthuc, mataikhoannganhangSV = @mataikhoannganhangSV, mataikhoannhantienHP = @mataikhoannhantienHP where maphieuthutt = @maphieuthutt";
            string sql = "update phieuthu set msv = @msv, mamonhoc = @mamonhoc, tenkhoanthu = @tenkhoanthu, namhoc = @namhoc, hocky = @hocky, ngaythu = @ngaythu, sotien = @sotien, hinhthuc = @hinhthuc, mataikhoannganhangSV = @mataikhoannganhangSV, mataikhoannhantienHP = @mataikhoannhantienHP where maphieuthu = @maphieuthu";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL "con"
                con.Open(); // Mở kết nối

                //cmd.Parameters.Add("@maphieuthutt", SqlDbType.Int).Value = sv.mapttt;
                cmd.Parameters.Add("@maphieuthu", SqlDbType.Int).Value = sv.maphieuthu;
                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = sv.masvv;
                cmd.Parameters.Add("@mamonhoc", SqlDbType.Int).Value = sv.mamonhoc;
                cmd.Parameters.Add("@tenkhoanthu", SqlDbType.NVarChar).Value = sv.tenkhoanthu;
                cmd.Parameters.Add("@namhoc", SqlDbType.NVarChar).Value = sv.namhoc;
                cmd.Parameters.Add("@hocky", SqlDbType.NVarChar).Value = sv.hocky;
                cmd.Parameters.Add("@ngaythu", SqlDbType.NVarChar).Value = sv.ngaythu;
                cmd.Parameters.Add("@sotien", SqlDbType.Float).Value = sv.sotien;
                cmd.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = sv.hinhthuc;
                cmd.Parameters.Add("@mataikhoannganhangSV", SqlDbType.Int).Value = sv.mataikhoanSV;
                cmd.Parameters.Add("@mataikhoannhantienHP", SqlDbType.Int).Value = sv.mataikhoanNT;
                cmd.ExecuteNonQuery(); // Phải thêm câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để Xóa phiếu thu
        public bool DeletePT(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "delete phieuthu where maphieuthu = @maphieuthu";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL "con"
                // Mở kết nối
                con.Open();

                // Nếu muốn xóa chỉ cần chuyền vào 1 tham số là mã phiếu thu(maphieuthu)
                cmd.Parameters.Add("@maphieuthu", SqlDbType.Int).Value = sv.maphieuthu;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close(); 
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để tìm kiếm phiếu thu
        public DataTable TimkiemPT(string sv)
        {
            // Tạo câu lệnh sql
            string sql = "select * from phieuthu where maphieuthu like N'%" + sv + "%' or msv like N'" + sv + "%'";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }


        //--------------------------------------------------------CODE PHẦN TÀI KHOẢN NHẬN TIỀN HỌC PHÍ--------------------------------------------------------
        // khai báo 1 phương thức để hiển thị tất cả tài khoản nhận tiền học phí
        public DataTable getAllNT()
        {
            // Tạo câu lệnh sql
            string sql = "select * from taikhoannhantienHP";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
            con.Open(); // Mở kết nối
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        // Khởi tạo 1 phương thức để thêm tài khoản nhận tiền học phí
        public bool AddNT(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "insert into taikhoannhantienHP(tennganhhang, tenchinhanh, sotaikhoanNT, tentaikhoanNT, ngaytao) values (@tennganhang, @tenchinhanh, @sotaikhoanNT, @tentaikhoanNT, @ngaytao)";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL "con"
                con.Open(); // Mở kết nối

                // Khai báo các trường dữ liệu để add dữ liệu vào database
                cmd.Parameters.Add("@tennganhang", SqlDbType.NVarChar).Value = sv.tennganhangHT;
                cmd.Parameters.Add("@tenchinhanh", SqlDbType.NVarChar).Value = sv.tenchinhanhHT;
                cmd.Parameters.Add("@sotaikhoanNT", SqlDbType.NVarChar).Value = sv.sotaikhoanHT;
                cmd.Parameters.Add("@tentaikhoanNT", SqlDbType.NVarChar).Value = sv.tentaikhoanHT;
                cmd.Parameters.Add("@ngaytao", SqlDbType.NVarChar).Value = sv.ngayvaoHT;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // tạo 1 phương thức để sửa tài khoản nhận tiền
        public bool EditNT(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "update taikhoannhantienHP set tennganhhang = @tennganhang, tenchinhanh = @tenchinhanh, sotaikhoanNT = @sotaikhoanNT, tentaikhoanNT = @tentaikhoanNT, ngaytao = @ngaytao where mataikhoannhantien = @mataikhoannhantien";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                con.Open(); // Mở kết nối

                // Khai báo các trường dữ liệu để update dữ liệu và database
                cmd.Parameters.Add("@mataikhoannhantien", SqlDbType.Int).Value = sv.mataikhoanHT;
                cmd.Parameters.Add("@tennganhang", SqlDbType.NVarChar).Value = sv.tennganhangHT;
                cmd.Parameters.Add("@tenchinhanh", SqlDbType.NVarChar).Value = sv.tenchinhanhHT;
                cmd.Parameters.Add("@sotaikhoanNT", SqlDbType.NVarChar).Value = sv.sotaikhoanHT;
                cmd.Parameters.Add("@tentaikhoanNT", SqlDbType.NVarChar).Value = sv.tentaikhoanHT;
                cmd.Parameters.Add("@ngaytao", SqlDbType.NVarChar).Value = sv.ngayvaoHT;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();

            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để xóa dữ liệu
        public bool DeleteNT(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "delete taikhoannhantienHP where mataikhoannhantien = @mataikhoannhantien";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền 2 tham số vào là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Khai báo trường dữ liệu để xóa dữ liệu, muốn xóa dữ liệu thì chỉ cần khai báo 1 trường duy nhất là mã tài khoản nhận tiền(mataikhoannhantien)
                cmd.Parameters.Add("@mataikhoannhantien", SqlDbType.Int).Value = sv.mataikhoanHT;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để tìm kiếm tài khoản nhận tiền
        public DataTable TimkiemNT(string sv)
        {
            // Tạo câu lệnh sql
            string sql = "select * from taikhoannhantienHP where mataikhoannhantien like N'%" + sv + "%' or sotaikhoanNT like N'%" + sv + "%'";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào Datatable
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close();
            return dt;
        }



        //-----------------------------------------------------------CODE PHẦN TÀI KHOẢN---------------------------------------------------------
        // Tạo 1 phương thức để hiển thị toàn bộ tài khoản
        public DataTable getAllTKSV()
        {
            // Tạo câu lệnh sql
            string sql = "select * from taikhoan";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào Datatable
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        // Tạo 1 phương thức để thêm thài khoản sinh viên
        public bool AddTKSV(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "insert into taikhoan(tentaikhoan, matkhau, capquyen) values (@tentaikhoan, @matkhau, @capquyen)";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng dùng hàm "SqlCommand()" để sử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Khai báo các trường dữ liệu để thêm dữ liệu vào database
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.Int).Value = sv.tentaikhoanDN;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = sv.matkhau;
                cmd.Parameters.Add("@capquyen", SqlDbType.Int).Value = sv.capquyen;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để sửa thông tin tài khoản sinh viên
        public bool EditTKSV(tbsinhvien sv)
        {
            string sql = "update taikhoan set tentaikhoan = @tentaikhoan, matkhau = @matkhau, capquyen = @capquyen where mataikhoantt = @mataikhoantt or tentaikhoan = @tentaikhoan";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý dữ liệu
                cmd = new SqlCommand (sql, con);
                // Mở kết nối
                con.Open();

                // Khai báo các trường dữ liệu để chuyền dữ liệu vào Database
                cmd.Parameters.Add("@mataikhoantt", SqlDbType.Int).Value = sv.mataikhoantt;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.Int).Value = sv.tentaikhoanDN;
                cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = sv.matkhau;
                cmd.Parameters.Add("@capquyen", SqlDbType.NVarChar).Value = sv.capquyen;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để xóa dữ liệu
        public bool DeleteTKSV(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "delete taikhoan where tentaikhoan = @tentaikhoan";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();

            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý dữ liệu
                cmd = new SqlCommand(sql, con); // Khởi tạo hàm "SqlCommand" và chuyền vào 2 tham số để xử lý là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Tạo trường dữ liệu để xóa dữ liệu database, muốn xóa dữ liệu thì chỉ cần chuyền vào 1 tham số duy nhất là tên tài khoản(tentaikhoan)
                //cmd.Parameters.Add("@mataikhoantt", SqlDbType.Int).Value = sv.mataikhoantt;
                cmd.Parameters.Add("@tentaikhoan", SqlDbType.Int).Value = sv.tentaikhoanDN;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để tìm kiếm tài khoản sinh viên
        public DataTable TimkiemTKSV(string sv)
        {
            // Tạo câu lệnh sql
            string sql = "select * from taikhoan where tentaikhoan like N'%" + sv + "%' or capquyen like N'%" + sv + "%'";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdepter
            da = new SqlDataAdapter(sql, con);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }


        //-----------------------------------------------------CODE phần lớp---------------------------------------------------------
        // Tạo 1 phương thức để hiển thị toàn bộ thông tin lớp học
        public DataTable getAllLop()
        {
            // Tạo câu lệnh sql
            string sql = "select * from lop";
            //Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra\
            con.Close(); // Đóng kết nối
            return dt;
        }

        // Tạo 1 phương thức để thêm thông tin lớp học
        public bool AddLop(tbsinhvien sv)
        {
            // tạo câu lệnh sql
            string sql = "insert into lop(malop, manganh, tenlop, GVCNlop, khoahoc) values (@malop, @manganh, @tenlop, @GVCNlop, @khoahoc)";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDl là "con"
                // Mở kết nối
                con.Open();

                // Khai báo các trường dữ liệu để thêm dữ liệu vào Database
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malopp;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganh;
                cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = sv.tenlop;
                cmd.Parameters.Add("@GVCNlop", SqlDbType.NVarChar).Value = sv.GVCNlop;
                cmd.Parameters.Add("@khoahoc", SqlDbType.NVarChar).Value = sv.khoahoc;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để sửa thông tin lớp học
        public bool EditLop(tbsinhvien sv)
        {
            // tạo câu lệnh sql
            string sql = "update lop set malop = @malop, manganh = @manganh, tenlop = @tenlop, GVCNlop = @GVCNlop, khoahoc = @khoahoc where maloptt = @maloptt";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý
                cmd = new SqlCommand (sql, con); // Chuyền vào 2 tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                // Mở kết nối
                con.Open();

                // Khai báo các trường dữ liệu để update dữ liệu vào database
                cmd.Parameters.Add("@maloptt", SqlDbType.Int).Value = sv.maloptt;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = sv.malopp;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganh;
                cmd.Parameters.Add("@tenlop", SqlDbType.NVarChar).Value = sv.tenlop;
                cmd.Parameters.Add("@GVCNlop", SqlDbType.NVarChar).Value = sv.GVCNlop;
                cmd.Parameters.Add("@khoahoc", SqlDbType.NVarChar).Value = sv.khoahoc;
                cmd.ExecuteNonQuery(); // Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để xóa thông tin lớp học
        public bool DeleteLop(tbsinhvien sv)
        {
            // tạo câu lệnh sql
            string sql = "delete from lop where maloptt = @maloptt";
            // Gọi lại chuỗi kết nối đến CSDl
            SqlConnection con = dc.getConnection();
            try
            {
                // Muốn thêm, sửa, xóa dữ liệu thì dùng hàm "SqlCommand()" để xử lý
                cmd = new SqlCommand(sql, con); // Chuyền 2 vào tham số là: Câu lệnh "sql" và chuỗi kết nối đến CSDL là "con"
                con.Open();

                // Khai báo trường dữ liệu để xoa, muốn xóa thì chỉ cần chuyền vào 1 trường dữ liệu duy nhất là mã lớp(malop)
                cmd.Parameters.Add("@maloptt", SqlDbType.Int).Value = sv.maloptt;
                cmd.ExecuteNonQuery(); //Phải có câu lệnh này thì mới thực thi được

                // Đóng kết nối
                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // tạo 1 phương thức để tìm kiếm thông tin lớp học
        public DataTable TimkiemLop(string sv)
        {
            // Tạo câu lệnh sql
            string sql = "select * from lop where malop like N'%" + sv + "%' or manganh like N'%" + sv + "%'";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            // Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        //------------------------------------------CODE PHẦN KHOA--------------------------------------------------------
        // Tạo 1 phương thức để hiển thị thông tin khoa
        public DataTable getAllKhoa()
        {
            // Tạo câu lệnh sql
            string sql = "select * from khoa";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            //Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        // Tạo 1 hàm để thêm thông tin khoa
        public bool AddKhoa(tbsinhvien sv)
        {
            // Tạo câu lệnh sql
            string sql = "insert into khoa(makhoa, tenkhoa, GVCNkhoa) values (@makhoa, @tenkhoa, @GVCNkhoa)";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                // Mở kết nối
                con.Open();

                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoa;
                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = sv.tenkhoa;
                cmd.Parameters.Add("@GVCNkhoa", SqlDbType.NVarChar).Value = sv.GVCNkhoa;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để sửa thông tin khoa
        public bool EditKhoa(tbsinhvien sv)
        {
            string sql = "update khoa set makhoa = @makhoa, tenkhoa = @tenkhoa, GVCNkhoa = @GVCNkhoa where makhoa = @makhoa or makhoatt = @makhoatt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@makhoatt", SqlDbType.Int).Value = sv.makhoatt;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoa;
                cmd.Parameters.Add("@tenkhoa", SqlDbType.NVarChar).Value = sv.tenkhoa;
                cmd.Parameters.Add("@GVCNkhoa", SqlDbType.NVarChar).Value = sv.GVCNkhoa;
                cmd.ExecuteReader();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để xóa thông tin khoa
        public bool DeleteKhoa(tbsinhvien sv)
        {
            string sql = "delete khoa where makhoa = @makhoa or makhoatt = @makhoatt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand (sql, con);
                con.Open();

                cmd.Parameters.Add("@makhoatt", SqlDbType.Int).Value = sv.makhoatt;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoa;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để tìm kiếm thông tin khoa
        public DataTable TimkiemKhoa(string sv)
        {
            string sql = "select * from khoa where makhoa like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //-----------------------------------------------CODE PHẦN NGÀNH--------------------------------------------------------------
        // Khai báo 1 phương thức để hiển thị toàn bộ dữ liệu
        public DataTable getAllNganh()
        {
            string sql = "select * from nganh";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Hiển thị dữ liệu khoa cntt
        public DataTable getAllKhoacntt()
        {
            // Tạo câu lệnh sql
            string sql = "select * from nganhcntt1";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            //Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        public DataTable getAllKhoadulich()
        {
            // Tạo câu lệnh sql
            string sql = "select * from nganhdulich";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            //Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        public DataTable getAllKhoaluat()
        {
            // Tạo câu lệnh sql
            string sql = "select * from nganhluat";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            //Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }

        public DataTable getAllKhoaqtkd()
        {
            // Tạo câu lệnh sql
            string sql = "select * from nganhQTKD";
            // Gọi lại chuỗi kết nối đến CSDL
            SqlConnection con = dc.getConnection();
            //Khởi tạo lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable(); // Khởi tạo lớp DataTable
            da.Fill(dt); // Dùng hàm "Fill()" để lấy dữ liệu ra
            con.Close(); // Đóng kết nối
            return dt;
        }
        // Khởi tạo 1 phương thức để thêm dữ liệu ngành
        public bool AddNganh(tbsinhvien sv)
        {
            string sql = "insert into nganh(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AddNganhcntt(tbsinhvien sv)
        {
            string sql = "insert into nganhcntt1(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AddNganhdulich(tbsinhvien sv)
        {
            string sql = "insert into nganhdulich(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AddNganhluat(tbsinhvien sv)
        {
            string sql = "insert into nganhluat(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AddNganhqtkd(tbsinhvien sv)
        {
            string sql = "insert into nganhQTKD(manganh, makhoa, tennganh) values (@manganh, @makhoa, @tennganh)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // Tạo 1 phương thức để sửa thông tin ngành
        public bool EditNganh(tbsinhvien sv)
        {
            string sql = "update nganh set manganh = @manganh, makhoa = @makhoa, tennganh = @tennganh where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool EditNganhcntt(tbsinhvien sv)
        {
            string sql = "update nganhcntt1 set manganh = @manganh, makhoa = @makhoa, tennganh = @tennganh where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public bool EditNganhdulich(tbsinhvien sv)
        {
            string sql = "update nganhdulich set manganh = @manganh, makhoa = @makhoa, tennganh = @tennganh where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool EditNganhluat(tbsinhvien sv)
        {
            string sql = "update nganhluat set manganh = @manganh, makhoa = @makhoa, tennganh = @tennganh where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool EditNganhqtkd(tbsinhvien sv)
        {
            string sql = "update nganhQTKD set manganh = @manganh, makhoa = @makhoa, tennganh = @tennganh where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@makhoa", SqlDbType.Int).Value = sv.makhoaa;
                cmd.Parameters.Add("@tennganh", SqlDbType.NVarChar).Value = sv.tennganh;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        // Tạo 1 phương thức để xóa thông tin ngành
        public bool DeleteNganh(tbsinhvien sv)
        {
            string sql = "delete nganh where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand (sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteNganhcntt(tbsinhvien sv)
        {
            string sql = "delete nganhcntt1 where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteNganhdulich(tbsinhvien sv)
        {
            string sql = "delete nganhdulich where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteNganhluat(tbsinhvien sv)
        {
            string sql = "delete nganhluat where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool DeleteNganhqtkd(tbsinhvien sv)
        {
            string sql = "delete nganhQTKD where manganh = @manganh or manganhtt = @manganhtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@manganh", SqlDbType.Int).Value = sv.manganhh;
                cmd.Parameters.Add("@manganhtt", SqlDbType.Int).Value = sv.manganhtt;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để tìm kiếm ngành
        public DataTable TimkiemNganh(string sv)
        {
            string sql = "select * from nganh where manganh like N'%" + sv + "%' or makhoa like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable TimkiemNganhcntt(string sv)
        {
            string sql = "select * from nganhcntt1 where manganh like N'%" + sv + "%' or makhoa like N'%" + sv + "%' or tennganh like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable TimkiemNganhdulich(string sv)
        {
            string sql = "select * from nganhdulich where manganh like N'%" + sv + "%' or makhoa like N'%" + sv + "%' or tennganh like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public DataTable TimkiemNganhluat(string sv)
        {
            string sql = "select * from nganhluat where manganh like N'%" + sv + "%' or makhoa like N'%" + sv + "%' or tennganh like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable TimkiemNganhqtkd(string sv)
        {
            string sql = "select * from nganhQTKD where manganh like N'%" + sv + "%' or makhoa like N'%" + sv + "%' or tennganh like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        //--------------------------------------------------------------CODE PHẦN ĐỐI TƯỢNG--------------------------------------------------------
        // Khởi tạo 1 phương thức để hiển thị tất cả dữ liệu ở bảng đối tượng
        public DataTable getAllDoituong()
        {
            string sql = "select * from doituong";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Khởi tạo 1 phương thức để thêm thông tin đối tượng
        public bool AddDoituong(tbsinhvien sv)
        {
            string sql = "insert into doituong(madoituong, tendoituong) values (@madoituong, @tendoituong)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@tendoituong", SqlDbType.NVarChar).Value = sv.tendoituong;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Khởi tạo 1 phương thức để sửa thông tin đối tượng
        public bool EditDoituong(tbsinhvien sv)
        {
            string sql = "update doituong set madoituong = @madoituong, tendoituong = @tendoituong where madoituongtt = @madoituongtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand (sql, con);
                con.Open();

                cmd.Parameters.Add("@madoituongtt", SqlDbType.Int).Value = sv.madoituongtt;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = sv.madoituong;
                cmd.Parameters.Add("@tendoituong", SqlDbType.NVarChar).Value = sv.tendoituong;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Khởi tạo 1 phương thức để xóa dữ liệu đối tượng
        public bool DeleteDoituong(tbsinhvien sv)
        {
            string sql = "delete doituong where madoituongtt = @madoituongtt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@madoituongtt", SqlDbType.Int).Value = sv.madoituongtt;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public DataTable TimkiemDoituong(string sv)
        {
            string sql = "select * from doituong where madoituong like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        //-----------------------------------------------CODE PHẦN MÔN HỌC-------------------------------------------------------
        // Tạo 1 phương thức để hiển thị toàn bộ danh sách môn học
        public DataTable getAllMonhoc()
        {
            string sql = "select * from monhoc";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Tạo 1 phương thức để thêm thông tin môn học
        public bool AddMonhoc(tbsinhvien sv)
        {
            string sql = "insert into monhoc(mamonhoc, tenmonhoc) values (@mamonhoc, @tenmonhoc)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@mamonhoc", SqlDbType.Int).Value = sv.mamonhocc;
                cmd.Parameters.Add("@tenmonhoc", SqlDbType.NVarChar).Value = sv.tenmonhoc;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để sửa thông tin môn học
        public bool EditMonhoc(tbsinhvien sv)
        {
            string sql = "update monhoc set mamonhoc = @mamonhoc, tenmonhoc = @tenmonhoc where mamonhoctt = @mamonhoctt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@mamonhoctt", SqlDbType.Int).Value = sv.mamonhoctt;
                cmd.Parameters.Add("@mamonhoc", SqlDbType.Int).Value = sv.mamonhocc;
                cmd.Parameters.Add("@tenmonhoc", SqlDbType.NVarChar).Value = sv.tenmonhoc;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để xóa thông tin môn học
        public bool DelelteMonhoc(tbsinhvien sv)
        {
            string sql = "delete from monhoc where mamonhoctt = @mamonhoctt";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@mamonhoctt", SqlDbType.Int).Value = sv.mamonhoctt;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        // Tạo 1 phương thức để tìm kiếm thông tin môn học
        public DataTable TimkiemMonhoc(string sv)
        {
            string sql = "select * from monhoc where mamonhoc like N'%" + sv + "%' or tenmonhoc like N'%" + sv + "%'";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }


        //======================================================CODE PHẦN THẮC MẮC===========================================
        
        // Tạo 1 phương thức để hiển thị dữ liệu trong bàng "thacmac"
        public DataTable getAllThacMac()
        {
            string sql = "select * from thacmac";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Tạo 1 phương thức để thêm dữ liệu vào bảng "thacmac"
        public bool AddThacMac(tbsinhvien sv)
        {
            string sql = "insert into thacmac(msv_id, lop_id, khoahoc, email, sodienthoai, diachi, noidung, trangthai) values (@msv_id, @lop_id, @khoahoc, @email, @sodienthoai, @diachi, @noidung, @trangthai)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@msv_id", SqlDbType.Int).Value = sv.msv_id;
                cmd.Parameters.Add("@lop_id", SqlDbType.Int).Value = sv.lop_id;
                cmd.Parameters.Add("@khoahoc", SqlDbType.NVarChar).Value = sv.khoahocTM;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = sv.emailTM;
                cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = sv.sodienthoai;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachiTM;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = sv.noidung;
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = sv.trangthaiTM;
                cmd.ExecuteNonQuery();

                con.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool EditThacMac(tbsinhvien sv)
        {
            string sql = "update thacmac set msv_id = @msv_id, lop_id = @lop_id, khoahoc = @khoahoc, email = @email, sodienthoai = @sodienthoai, diachi = @diachi, noidung = @noidung, trangthai = @trangthai where maduynhat = @maduynhat";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@maduynhat", SqlDbType.Int).Value = sv.idTM;
                cmd.Parameters.Add("@msv_id", SqlDbType.Int).Value = sv.msv_id;
                cmd.Parameters.Add("@lop_id", SqlDbType.Int).Value = sv.lop_id;
                cmd.Parameters.Add("@khoahoc", SqlDbType.NVarChar).Value = sv.khoahocTM;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = sv.emailTM;
                cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = sv.sodienthoai;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = sv.diachiTM;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = sv.noidung;
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = sv.trangthaiTM;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool DeleteThacMac(tbsinhvien sv)
        {
            string sql = "delete from thacmac where maduynhat = @maduynhat";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@maduynhat", SqlDbType.Int).Value = sv.idTM;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        //====================================================CODE PHẦN PHẢN HỒI===========================================

        // Tạo 1 phương thức để hiển thị dữ liệu ở bảng "phanhoi"
        public DataTable getAllPhanHoi(tbsinhvien sv)
        {
            string sql = "select * from phanhoi where msv_id = " + sv.msv_idPH + "";
            SqlConnection con = dc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

        // Tạo 1 phương thức để thêm dữ liệu vào bảng "phanhoi"
        public bool AddPhanHoi(tbsinhvien sv)
        {

            string sql = "insert into phanhoi(tentaikhoan, email, sodienthoai, chucvu, noidung, trangthai, msv_id) values (@tentaikhoan, @email, @sodienthoai, @chucvu, @noidung, @trangthai, @msv_id)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@tentaikhoan", SqlDbType.NVarChar).Value = sv.tentaikhoanPH;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = sv.emailPH;
                cmd.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = sv.sodienthoaiPH;
                cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = sv.chucvu;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = sv.noidungPH;
                cmd.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = sv.trangthai;
                cmd.Parameters.Add("@msv_id", SqlDbType.Int).Value = sv.msv_idPH;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return true;
        }

        // ====================================================CODE PHẦN LỊCH SỬ==========================================
        // Hiển thị dữ liệu ở bảng lịch sử
        public DataTable getAllLichsu()
        {
            // Tạo câu  lệnh sql để lấy ra toàn bộ lịch sử ở bảng "lichsu"
            string sql = "select * from lichsu";
            // Tạp kết nối đến sql, vì đã có file class chuỗi kết nối đến sql nên giờ chỉ gọi lại và sử dụng hàm "getConnect()" để lấy dữ liệu
            SqlConnection con = dc.getConnection();
            // Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con); // Chuyền vào 2 dữ liệu là "sql" và chuỗi kết nối "con" để xử lý
            // Mở kết nối
            con.Open();
            // Đổ dữ liệu từ SqlDataAdapter vào DataTabel
            DataTable dt = new DataTable();
            da.Fill(dt); // Dùng hàm "Fill()" để lấy ra  dữ liệu
            // Đóng kết nối
            con.Close();
            return dt; // Trả về 1 DataTable
        }

        public bool AddLichSu(tbsinhvien tb)
        {
            string sql = "insert into lichsu (msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh, mota, id_taikhoan) values (@msv, @madoituong, @malop, @hoten, @ngaysinh, @diachi, @gioitinh, @mota, @id_taikhoan)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = tb.masvLS;
                cmd.Parameters.Add("@madoituong", SqlDbType.Int).Value = tb.madoituongLS;
                cmd.Parameters.Add("@malop", SqlDbType.Int).Value = tb.malopLS;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tb.hotenLS;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar).Value = tb.ngaysinhLS;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = tb.diachiLS;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = tb.gioitinhLS;
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = tb.mota;
                cmd.Parameters.Add("@id_taikhoan", SqlDbType.Int).Value = tb.id_taikhoanLS;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool AddLichSuTK(tbsinhvien tb)
        {
            string sql = "insert into lichsu (msv, mota, id_taikhoan) values (@msv, @mota, @id_taikhoan)";
            SqlConnection con = dc.getConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@msv", SqlDbType.Int).Value = tb.masvLS;
                cmd.Parameters.Add("@mota", SqlDbType.NVarChar).Value = tb.mota;
                cmd.Parameters.Add("@id_taikhoan", SqlDbType.Int).Value = tb.id_taikhoanLS;
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}