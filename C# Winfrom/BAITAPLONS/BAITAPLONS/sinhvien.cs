using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BAITAPLONS.QLHocPhiDataSet;

namespace BAITAPLONS
{
    public partial class sinhvien : Form
    {
        sinhvienBLL bll;
        DataConnection ds;

        SqlDataAdapter da;
        string matutt = "", tentaikhoan = "", matkhau = "", capquyen = "", masvtts1 = "", msvs1 = "", madoituongs1 = "", malops1 = "", hotens1 = "", ngaysinhs1 = "", diachis1 = "", gioitinhs1 = "", maloptts1 = "", malopss1 = "", manganhs1 = "", tenlops1 = "", GVCNlops1 = "", khoahocs1 = "";
        // Muốn hiển thị danh sách sinh viên lên form thì phải truy cập vào class "sinhvienBLL" tạo ra 1 đối tượng
        sinhvienBLL bllsv;
        public sinhvien(string matutt, string tentaikhoan, string matkhau, string capquyen, string masvtt, string msv, string madoituong, string malop, string hoten, string ngaysinh, string diachi, string gioitinh, string maloptt, string malops, string manganhs1, string tenlop, string GVCNlop, string khoahoc)
        {
            
            InitializeComponent();

            bll = new sinhvienBLL();
            // Khởi tạo lớp trong hàm tạo của lớp "FormMai"
            bllsv = new sinhvienBLL();
            this.matutt = matutt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
            this.masvtts1 = masvtt;
            this.msvs1 = msv;
            this.madoituongs1 = madoituong;
            this.malops1 = malop;
            this.hotens1 = hoten;
            this.ngaysinhs1 = ngaysinh;
            this.diachis1 = diachi;
            this.gioitinhs1 = gioitinh;
            this.maloptts1 = maloptt;
            this.malopss1 = malops;
            this.manganhs1 = manganhs1;
            this.tenlops1 = tenlop;
            this.GVCNlops1 = GVCNlop;
            this.khoahocs1 = khoahoc;
            ds = new DataConnection();
        }

        // Viết thêm 1 phương thức hiển thị tất cả sinh viên ra
        public void ShowAllSinhVien()
        {
            // Khai báo 1 đối tượng lớp "DataTable". vì là trả về 1 kiểu dữ liệu "DataTable" nên phải khai báo 1 "DataTable"
            DataTable dt = bllsv.getAllsinhvien();
            dataGridView1.DataSource = dt;
        }

        private void sinhvien_Load(object sender, EventArgs e)
        {
            /*
            string sql = "select sinhvien.masvtt, sinhvien.msv, sinhvien.madoituong, sinhvien.malop, sinhvien.hoten, sinhvien.ngaysinh, sinhvien.diachi, sinhvien.gioitinh, phieuthu.maphieuthutt, phieuthu.maphieuthu, phieuthu.msv, phieuthu.mamonhoc, phieuthu.tenkhoanthu, phieuthu.namhoc, phieuthu.hocky, phieuthu.ngaythu, phieuthu.sotien, phieuthu.hinhthuc, phieuthu.mataikhoannganhangSV, phieuthu.mataikhoannhantienHP from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv = phieuthu.msv and sinhvien.msv in (select msv from phieuthu) ";
            //string sql = "select * from sinhvien left join phieuthu on sinhvien.msv = phieuthu.msv where sinhvien.msv = phieuthu.msv and sinhvien.msv in (select msv from phieuthu)";
            SqlConnection con = ds.getConnection();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int id = int.Parse(dt.Rows[0][0].ToString());
            int id1 = int.Parse(dt.Rows[0][1].ToString());  
            int id2 = int.Parse(dt.Rows[0][2].ToString());
            int id3 = Int32.Parse(dt.Rows[0][3].ToString());
            string id4 = dt.Rows[0][4].ToString();
            string id5 = dt.Rows[0][5].ToString();
            string id6 = dt.Rows[0][6].ToString();
            string id7 = dt.Rows[0][7].ToString();
            string id8 = dt.Rows[0][8].ToString();
            int id9 = Int32.Parse(dt.Rows[0][9].ToString());
            int id10 = Int32.Parse(dt.Rows[0][10].ToString());
            int id11 = Int32.Parse(dt.Rows[0][11].ToString());
            if (dt.Rows.Count > 0)
            {
                if(Int32.Parse(dt.Rows[0][1].ToString()) == Int32.Parse(dt.Rows[0][11].ToString()))
                {
                    //sinhvien cv = new sinhvien(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), dt.Rows[0][14].ToString(), dt.Rows[0][15].ToString(), dt.Rows[0][16].ToString(), dt.Rows[0][17].ToString(), dt.Rows[0][18].ToString());
                    tbsinhvien sv = new tbsinhvien();
                    sv.masv = id1;
                    sv.thongbao = "Đã đóng học phí";
                    bllsv.EditTT(sv);
                }
                
            }
            if (dt.Rows.Count < 0)
            {

                    //int id = Int32.Parse(dt.Rows[0][0].ToString());
                    //int id1 = Int32.Parse(dt.Rows[0][1].ToString());
                    //sinhvien cv = new sinhvien(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), dt.Rows[0][14].ToString(), dt.Rows[0][15].ToString(), dt.Rows[0][16].ToString(), dt.Rows[0][17].ToString(), dt.Rows[0][18].ToString());
                    tbsinhvien sv = new tbsinhvien();
                    sv.masvtt = id;
                    sv.masv = id1;
                    sv.thongbao = "Chưa đóng học phí";
                    bllsv.EditTT(sv);
            }*/
            if (capquyen == "1")
            {
                quyen.Text = "Admin";
                quyen.ForeColor = Color.Red;
            }
            if (capquyen == "2")
            {
                quyen.Text = "Quản lý";
                quyen.ForeColor = Color.Red;
            }
            if (capquyen == "3")
            {
                quyen.Text = "Sinh viên";
                quyen.ForeColor = Color.Red;
            }
            if (capquyen != "1" && capquyen != "2")
            {
                add.Hide();
                edit.Hide();
                delete.Hide();
                msvs.Hide();
                masvs.Hide();
                mdts.Hide();
                madoituongs.Hide();
                malops.Hide();
                mlop.Hide();
                hten.Hide();
                hotens.Hide();
                ns.Hide();
                ngaysinhs.Hide();
                dc.Hide();
                diachis.Hide();
                gt.Hide();
                gioitinhs.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            ShowAllSinhVien();
        }

        // Tạo 1 phương thức kiểm tra xem người dùng đã nhập đầy đủ thông tin hay chưa, nếu chưa nhập đủ thông tin thì trả về false, nếu nhập đầy đủ thông tin rồi thì trả về true
        public bool checkData()
        {
            // Kiểm tra từng trường dữ liệu
            if (string.IsNullOrEmpty(masvs.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                masvs.Focus(); // Để con trỏ focus vào
                return false;
            }

            if (string.IsNullOrEmpty(hotens.Text))
            {
                MessageBox.Show("Bạn chưa nhập họ tên sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hotens.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(madoituongs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                madoituongs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(malops.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                malops.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(ngaysinhs.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập ngày sinh sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                ngaysinhs.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(diachis.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập địa chỉ sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                diachis.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(gioitinhs.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập giới tính sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                gioitinhs.Focus(); // Để con trỏ focus vào
                return false;
            }
            return true;
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData", nếu hàm này trả về true, nghĩa là người dùng đã nhập đầy đủ thông tin rồi thì bắt đầu lưu dữ liệu vào database
            {
                // Khởi tạo lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                sv.masv = int.Parse(masvs.Text);// Vì mã sinh viên là kiểu số nguyên nên phải khai báo là "int.Parse()"
                sv.madoituong = int.Parse(madoituongs.Text);
                if (sv.malop != null)
                {
                    sv.malop = int.Parse(malops.Text);
                }
                else
                {
                    MessageBox.Show("Mã lớp không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                sv.hoten = hotens.Text;
                sv.ngaysinh = ngaysinhs.Text;
                sv.diachi = diachis.Text;
                sv.gioitinh = gioitinhs.Text;

                // Sau khi chèn được dữ liệu ở lớp tbsinhvien rồi thì bắt đầu gọi hàm thêm sinh viên(AddSinhVien) ở lớp bllsv
                if (bllsv.AddSinhVien(sv))
                {
                    if (sv.madoituong == 1)
                    {
                        bllsv.AddSinhViendb(sv);
                        MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 10 || sv.malop <= 4 || sv.malop == 11)
                    {
                        bllsv.AddSinhVienk14(sv);
                        MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 5 || sv.malop == 6 || sv.malop == 8 || sv.malop == 12)
                    {
                        bllsv.AddSinhVienk15(sv);
                        MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if(sv.malop == 7 || sv.malop == 9 || sv.malop == 15)
                    {
                        bllsv.AddSinhVienk16(sv);
                        MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    string sql = "select * from taikhoan where tentaikhoan = " + masvs.Text + "";
                    SqlConnection con = ds.getConnection();
                    da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count <= 0)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.tentaikhoanDN = int.Parse(masvs.Text);
                        cv.matkhau = masvs.Text;
                        cv.capquyen = 3;
                        bll.AddTKSV(cv);
                    }
                    // Nếu trả về bằng true nghĩa là thêm thành công thì sẽ hiển thị ra dữ liệu vừa thêm
                    ShowAllSinhVien();
                }
                    
                
                
                else // Nếu thêm không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void masvs_TextChanged(object sender, EventArgs e)
        {

        }

        int id;
        // Phương thức lấy ra các trường dữ liệu để sửa thông tin sinh viên
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; // Khai báo 1 index, để lấy ra được cái index vừa click vào
            if(index >= 0) // Khi click vào dòng dữ liệu bất kỳ thì sẽ hiển thị dữ liệu đó lên
            {
                id = Int32.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
                masvs.Text = dataGridView1.Rows[index].Cells[1].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "masv"
                madoituongs.Text = dataGridView1.Rows[index].Cells[2].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "madoituong"
                malops.Text = dataGridView1.Rows[index].Cells[3].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "malop"
                hotens.Text = dataGridView1.Rows[index].Cells[4].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "hoten"
                ngaysinhs.Text = dataGridView1.Rows[index].Cells[5].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "ngaysinh"
                diachis.Text = dataGridView1.Rows[index].Cells[6].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "diachi"
                gioitinhs.Text = dataGridView1.Rows[index].Cells[7].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "gioitinh"
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void hten_Click(object sender, EventArgs e)
        {

        }

        private void gt_Click(object sender, EventArgs e)
        {

        }

        // Phương sửa sinh viên
        private void edit_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData", nếu hàm này trả về true, nghĩa là người dùng đã nhập đầy đủ thông tin rồi thì bắt đầu cập nhật dữ liệu vào database
            {
                // Khởi tạo lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                sv.masvtt = id;
                sv.masv = int.Parse(masvs.Text);
                sv.madoituong = int.Parse(madoituongs.Text);
                sv.malop = int.Parse(malops.Text);
                sv.hoten = hotens.Text;
                sv.ngaysinh = ngaysinhs.Text; 
                sv.diachi = diachis.Text;
                sv.gioitinh = gioitinhs.Text;

                if (bllsv.UpdateSinhVien(sv))
                {
                    if (sv.madoituong == 1)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        cv.madoituong = int.Parse(madoituongs.Text);
                        cv.malop = int.Parse(malops.Text);
                        cv.hoten = hotens.Text;
                        cv.ngaysinh = ngaysinhs.Text;
                        cv.diachi = diachis.Text;
                        cv.gioitinh = gioitinhs.Text;
                        bllsv.UpdateSinhViendb(cv);
                        MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.madoituong != 1)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhViendb(cv);
                    }

                    if (sv.madoituong == 1)
                    {
                        string sql = "select * from dacbiet where msv = " + masvs.Text + "";
                        SqlConnection con = ds.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count <= 0)
                        {
                            tbsinhvien cv = new tbsinhvien();
                            cv.masv = int.Parse(masvs.Text);
                            cv.madoituong = int.Parse(madoituongs.Text);
                            cv.malop = int.Parse(malops.Text);
                            cv.hoten = hotens.Text;
                            cv.ngaysinh = ngaysinhs.Text;
                            cv.diachi = diachis.Text;
                            cv.gioitinh = gioitinhs.Text;
                            bllsv.AddSinhViendb(cv);
                            MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        /*else
                        {
                            MessageBox.Show("Bản ghi đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }*/
                        
                    }
                    if (sv.malop == 10 || sv.malop <= 4 || sv.malop == 11)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        cv.madoituong = int.Parse(madoituongs.Text);
                        cv.malop = int.Parse(malops.Text);
                        cv.hoten = hotens.Text;
                        cv.ngaysinh = ngaysinhs.Text;
                        cv.diachi = diachis.Text;
                        cv.gioitinh = gioitinhs.Text;
                        bllsv.UpdateSinhVienk14(cv);
                        MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 5 || sv.malop == 6 || sv.malop == 8 || sv.malop == 12)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        cv.madoituong = int.Parse(madoituongs.Text);
                        cv.malop = int.Parse(malops.Text);
                        cv.hoten = hotens.Text;
                        cv.ngaysinh = ngaysinhs.Text;
                        cv.diachi = diachis.Text;
                        cv.gioitinh = gioitinhs.Text;
                        bllsv.UpdateSinhVienk15(cv);
                        MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 7 || sv.malop == 9 || sv.malop == 15)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        cv.madoituong = int.Parse(madoituongs.Text);
                        cv.malop = int.Parse(malops.Text);
                        cv.hoten = hotens.Text;
                        cv.ngaysinh = ngaysinhs.Text;
                        cv.diachi = diachis.Text;
                        cv.gioitinh = gioitinhs.Text;
                        bllsv.UpdateSinhVienk16(cv);
                        MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // Khi update lại dữ liệu mà mã lớp không khớp thì xóa luôn dữ liệu ở bảng sinh viên khóa 14(sinhvienk14)
                    if (sv.malop != 10 && sv.malop != 1 && sv.malop != 2 && sv.malop != 3 && sv.malop != 4 && sv.malop != 11)
                    {
                        
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhVienk14(cv);
                    }

                    if (sv.malop == 5 || sv.malop == 6 || sv.malop == 8 || sv.malop == 12)
                    {

                        string sql = "select * from SinhVienK15 where msv = " + masvs.Text + "";
                        SqlConnection con = ds.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable(); 
                        da.Fill(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            tbsinhvien bv = new tbsinhvien();
                            bv.masv = int.Parse(masvs.Text);
                            bv.madoituong = int.Parse(madoituongs.Text);
                            bv.malop = int.Parse(malops.Text);
                            bv.hoten = hotens.Text;
                            bv.ngaysinh = ngaysinhs.Text;
                            bv.diachi = diachis.Text;
                            bv.gioitinh = gioitinhs.Text;
                            bllsv.AddSinhVienk15(bv);
                            MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        /*else
                        {
                            MessageBox.Show("Bản ghi này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }*/

                    }
                    if (sv.malop == 7 || sv.malop == 9 || sv.malop == 15)
                    {
                        // Kiểm tra xem mã sinh viên(msv) này đã tồn tại hay chưa, nêu chưa tồn tại thì bắt đầu thêm dữ liệu vào database, nếu tồn tại rồi thì đưa ra câu thông báo cho người dùng
                        string sql = "select * from SinhVienK16 where msv = " + masvs.Text + "";
                        SqlConnection con = ds.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            tbsinhvien k16 = new tbsinhvien();
                            k16.masv = int.Parse(masvs.Text);
                            k16.madoituong = int.Parse(madoituongs.Text);
                            k16.malop = int.Parse(malops.Text);
                            k16.hoten = hotens.Text;
                            k16.ngaysinh = ngaysinhs.Text;
                            k16.diachi = diachis.Text;
                            k16.gioitinh = gioitinhs.Text;
                            bllsv.AddSinhVienk16(k16);
                            MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        /*else
                        {
                            MessageBox.Show("Bản ghi này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }*/

                    }
                    if (sv.malop == 10 || sv.malop <= 4 || sv.malop == 11)
                    {
                        string sql = "select * from SinhVienK14 where msv = " + masvs.Text + "";
                        SqlConnection con = ds.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            tbsinhvien kv = new tbsinhvien();
                            kv.masv = int.Parse(masvs.Text);
                            kv.madoituong = int.Parse(madoituongs.Text);
                            kv.malop = int.Parse(malops.Text);
                            kv.hoten = hotens.Text;
                            kv.ngaysinh = ngaysinhs.Text;
                            kv.diachi = diachis.Text;
                            kv.gioitinh = gioitinhs.Text;
                            bllsv.AddSinhVienk14(kv);
                            MessageBox.Show("Sửa bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        /*else
                        {
                            MessageBox.Show("Bản ghi này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }*/

                    }

                    /*if (sv.malop == 5 || sv.malop == 6 || sv.malop == 8 || sv.malop == 12)
                    {
                        tbsinhvien bv = new tbsinhvien();
                        bv.masv = int.Parse(masvs.Text);
                        bv.madoituong = int.Parse(madoituongs.Text);
                        bv.malop = int.Parse(malops.Text);
                        bv.hoten = hotens.Text;
                        bv.ngaysinh = ngaysinhs.Text;
                        bv.diachi = diachis.Text;
                        bv.gioitinh = gioitinhs.Text;
                        bllsv.AddSinhVienk15(bv);
                    }*/

                    if (sv.malop != 5 && sv.malop != 6 && sv.malop != 8 && sv.malop != 12)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhVienk15(cv);
                    }
                    if (sv.malop != 7 && sv.malop != 9 && sv.malop != 15)
                    {
                        /*if (sv.malop == 10 || sv.malop <= 4 || sv.malop == 11)
                        {
                            string sql = "select * from SinhVienK14";
                            SqlConnection con = ds.getConnection();
                            da = new SqlDataAdapter(sql, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if(dt.Rows.Count <= 0)
                            {
                                tbsinhvien kv = new tbsinhvien();
                                kv.masv = int.Parse(masvs.Text);
                                kv.madoituong = int.Parse(madoituongs.Text);
                                kv.malop = int.Parse(malops.Text);
                                kv.hoten = hotens.Text;
                                kv.ngaysinh = ngaysinhs.Text;
                                kv.diachi = diachis.Text;
                                kv.gioitinh = gioitinhs.Text;
                                bllsv.AddSinhVienk14(kv);
                            }
                            else
                            {
                                MessageBox.Show("Bản ghi này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }*/
                        tbsinhvien k16s = new tbsinhvien();
                        k16s.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhVienk16(k16s);
                    }
                    // gọi lại lớp sửa sinh viên(UpdateSinhVien) trong lớp "bllsv", Nếu sửa sinh viên thành công thì sẽ hiển thị dữ liệu vừa được sửa
                    ShowAllSinhVien();
                } 
                
                /*if (sv.madoituong != 1)
                {
                    tbsinhvien cv = new tbsinhvien();
                    cv.masv = int.Parse(masvs.Text);
                    cv.madoituong = int.Parse(madoituongs.Text);
                    cv.malop = int.Parse(malops.Text);
                    cv.hoten = hotens.Text;
                    cv.ngaysinh = ngaysinhs.Text;
                    cv.diachi = diachis.Text;
                    cv.gioitinh = gioitinhs.Text;
                    bllsv.AddSinhViendb(cv);
                }*/
                
                
                else
                    MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Hiển thị thông báo hỏi xem người dùng có muốn xóa hay không, nếu người dùng chọn "Yes" thì sẽ xóa, "DialogResult.Yes" nghĩa là người dùng chọn vào "Yes"
            {
                

                // Bắt đầu thực hiện lệnh xóa
                tbsinhvien sv = new tbsinhvien();
                // Lệnh xóa chỉ cần chuyền vào mã sinh viên(masv) là xóa được
                //sv.masvtt = id; // Lấy ra trường mã sinh viên(masv)
                sv.masv = int.Parse(masvs.Text);

                string sql = "select * from taikhoan where tentaikhoan = " + sv.masv + "";
                SqlConnection con = ds.getConnection();
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    tbsinhvien svs = new tbsinhvien();
                    svs.tentaikhoanDN = int.Parse(masvs.Text);
                    bll.DeleteTKSV(svs);
                }
                

                if (bllsv.DeleteSinhVien(sv))
                {
                    tbsinhvien bv = new tbsinhvien();
                    bv.masvLS = int.Parse(masvs.Text);
                    bv.madoituongLS = int.Parse(madoituongs.Text);
                    bv.malopLS = int.Parse(malops.Text);
                    bv.hotenLS = hotens.Text;
                    bv.ngaysinhLS = ngaysinhs.Text;
                    bv.diachiLS = diachis.Text;
                    bv.gioitinhLS = gioitinhs.Text;
                    bv.mota = "Thông tin sinh viên tên là: " + hotens1 + ", có mã sinh viên là: " + bv.masvLS + ", khóa học: " + khoahocs1 + "";
                    bv.id_taikhoanLS = int.Parse(tentaikhoan);
                    bllsv.AddLichSu(bv);
                    if (bv.madoituongLS == 1)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhViendb(cv);
                    }
                    if (bv.malopLS == 10 || bv.malopLS <= 4 || bv.malopLS == 11)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhVienk14(cv);
                    }
                    if (bv.malopLS == 5 || bv.malopLS == 6 || bv.malopLS == 8 || bv.malopLS == 12)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhVienk15(cv);
                    }
                    if (bv.malopLS == 7 || bv.malopLS == 9 || bv.malopLS == 15)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.masv = int.Parse(masvs.Text);
                        bllsv.DeleteSinhVienk16(cv);
                    }

                    /*string sql = "select * from taikhoan where tentaikhoan = " + sv.masv + "";
                    SqlConnection con = ds.getConnection();
                    da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        tbsinhvien svs = new tbsinhvien();
                        svs.tentaikhoanDN = int.Parse(masvs.Text);
                        bll.DeleteTKSV(svs);
                    }*/

                    
                    // Gọi hàm xóa trong lớp "bllsv", nếu xóa thành công thì hiển thị lại tất cả thông tin sinh viên trong bảng
                    ShowAllSinhVien();
                }
                else
                {
                    // Nếu không xóa được thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                } 
            }
        }

        private void find_TextChanged(object sender, EventArgs e)
        {
            string value = find.Text; // Khởi tạo "find" ở ô textBox trong form để tìm kiếm
            if (!string.IsNullOrEmpty(value)) // Câu lệnh này nghĩa là: Nếu ô tìm kiếm không bị rỗng (nghĩa là có giá trị tìm kiếm được chuyền vào) thì bắt đầu tìm kiếm
            {
                // Khai báo 1 lớp "DataTable" và gọi hàm tìm kiếm sinh viên(FindSinhVien) trong lớp "bllsv"(sinhvienBLL)
                DataTable dt = bllsv.FindSinhVien(value);
                dataGridView1.DataSource = dt;
            }
            else // Nếu ô textBox tìm kiếm mà rỗng thì phải hiển thị lại tất cả sinh viên
                ShowAllSinhVien(); 
        }
    }
}
