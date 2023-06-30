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

namespace BAITAPLONS
{
    public partial class sinhvienk14 : Form
    {
        DataConnection dcs;
        SqlDataAdapter da;
        string mataikhoantt = "" ,tentaikhoan = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        public sinhvienk14(string mataikhoantt, string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.mataikhoantt = mataikhoantt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
            dcs = new DataConnection();
        }

        public void getAll()
        {
            DataTable dt = bll.getAllsinhvien14();
            dataGridView1.DataSource = dt;
        }
        private void sinhvienk14_Load(object sender, EventArgs e)
        {
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
            if (capquyen == "2")
            {
                delete.Hide();
            }
            getAll();
        }
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
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(dataGridView1.Rows[index].Cells["masvtt"].Value.ToString());
                masvs.Text = dataGridView1.Rows[index].Cells["msv"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "masv"
                madoituongs.Text = dataGridView1.Rows[index].Cells["madoituong"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "madoituong"
                malops.Text = dataGridView1.Rows[index].Cells["malop"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "malop"
                hotens.Text = dataGridView1.Rows[index].Cells["hoten"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "hoten"
                ngaysinhs.Text = dataGridView1.Rows[index].Cells["ngaysinh"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "ngaysinh"
                diachis.Text = dataGridView1.Rows[index].Cells["diachi"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "diachi"
                gioitinhs.Text = dataGridView1.Rows[index].Cells["gioitinh"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "gioitinh"
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            // Nếu update dữ liệu bị lỗi thì xóa "sv.masvtt = id" rồi thử lại 
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                //sv.masvtt = id; // Nếu mà lỗi không update vào được bảng sinh viên(sinhvien) thì xóa dòng này đi
                sv.masv = int.Parse(masvs.Text); 
                sv.madoituong = int.Parse(madoituongs.Text);
                sv.malop = int.Parse(malops.Text);
                sv.hoten = hotens.Text;
                sv.ngaysinh = ngaysinhs.Text;
                sv.diachi = diachis.Text;
                sv.gioitinh = gioitinhs.Text;
                //if (bll.UpdateSinhVien(sv))
                //{
                    if (sv.madoituong == 1)
                    {
                        bll.UpdateSinhVien(sv);
                        bll.UpdateSinhViendb(sv);
                    }
                    else if (sv.madoituong != 1)
                    {
                        string sql = "select * from dacbiet where msv = " + masvs.Text + ";";
                        SqlConnection con = dcs.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        con.Open();
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Bạn đang sửa bản ghi khác với dữ liệu ở sinh viên đặc biệt, nếu tiếp tục sửa thì bản ghi này sẽ bị xóa đi", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bll.UpdateSinhVien(sv);
                                bll.UpdateSinhVienk14(sv);
                                tbsinhvien cv = new tbsinhvien();
                                sv.masv = int.Parse(masvs.Text);
                                bll.DeleteSinhViendb(cv);
                            }
                        }

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
                            bll.UpdateSinhVienk14(cv);
                            bll.UpdateSinhVien(sv);
                            getAll();
                        }
                    
                    if(sv.malop != 10 && sv.malop != 4 && sv.malop != 11 && sv.malop != 1 && sv.malop != 2 && sv.malop != 3)
                    {
                        if (MessageBox.Show("Bản ghi bạn vừa nhập không trùng với tên lớp của khóa 14, nếu tiếp tục sửa bản ghi này sẽ bị xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                        {
                            bll.UpdateSinhVien(sv); // Nếu xóa mà không muốn update lại dữ liệu vào bảng sinh viên(sinhvien) thì xóa dòng này đi
                            if (sv.malop == 5 || sv.malop == 6 || sv.malop == 8 || sv.malop == 12)
                                {
                                    string sql = "select * from SinhVienK15 where msv = " + masvs.Text + ";";
                                    SqlConnection con = dcs.getConnection();
                                    da = new SqlDataAdapter(sql, con);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    if(dt.Rows.Count <= 0)
                                    {
                                        tbsinhvien cv = new tbsinhvien();
                                        cv.masv = int.Parse(masvs.Text);// Vì mã sinh viên là kiểu số nguyên nên phải khai báo là "int.Parse()"
                                        cv.madoituong = int.Parse(madoituongs.Text);
                                        cv.malop = int.Parse(malops.Text);
                                        cv.hoten = hotens.Text;
                                        cv.ngaysinh = ngaysinhs.Text;
                                        cv.diachi = diachis.Text;
                                        cv.gioitinh = gioitinhs.Text;
                                        bll.UpdateSinhVien(sv);
                                        bll.AddSinhVienk15(cv);
                                    }
                                    else
                                    {
                                        tbsinhvien cv = new tbsinhvien();
                                        cv.masv = int.Parse(masvs.Text);// Vì mã sinh viên là kiểu số nguyên nên phải khai báo là "int.Parse()"
                                        cv.madoituong = int.Parse(madoituongs.Text);
                                        cv.malop = int.Parse(malops.Text);
                                        cv.hoten = hotens.Text;
                                        cv.ngaysinh = ngaysinhs.Text;
                                        cv.diachi = diachis.Text;
                                        cv.gioitinh = gioitinhs.Text;
                                        bll.UpdateSinhVien(sv);
                                        bll.UpdateSinhVienk15(cv);
                                    }
                                }
                                if (sv.malop == 7 || sv.malop == 9 || sv.malop == 15)
                                {
                                    string sql = "select * from SinhVienK16 where msv = " + masvs.Text + ";";
                                    SqlConnection con = dcs.getConnection();
                                    da = new SqlDataAdapter(sql, con);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    if (dt.Rows.Count <= 0)
                                    {
                                        tbsinhvien cv = new tbsinhvien();
                                        cv.masv = int.Parse(masvs.Text);// Vì mã sinh viên là kiểu số nguyên nên phải khai báo là "int.Parse()"
                                        cv.madoituong = int.Parse(madoituongs.Text);
                                        cv.malop = int.Parse(malops.Text);
                                        cv.hoten = hotens.Text;
                                        cv.ngaysinh = ngaysinhs.Text;
                                        cv.diachi = diachis.Text;
                                        cv.gioitinh = gioitinhs.Text;
                                        bll.UpdateSinhVien(sv);
                                        bll.AddSinhVienk16(cv);
                                    }
                                    else
                                    {
                                        tbsinhvien cv = new tbsinhvien();
                                        cv.masv = int.Parse(masvs.Text);// Vì mã sinh viên là kiểu số nguyên nên phải khai báo là "int.Parse()"
                                        cv.madoituong = int.Parse(madoituongs.Text);
                                        cv.malop = int.Parse(malops.Text);
                                        cv.hoten = hotens.Text;
                                        cv.ngaysinh = ngaysinhs.Text;
                                        cv.diachi = diachis.Text;
                                        cv.gioitinh = gioitinhs.Text;
                                        bll.UpdateSinhVien(sv);
                                        bll.UpdateSinhVienk16(cv);
                                    }
                                }
                        tbsinhvien bv = new tbsinhvien();
                            bv.masv = int.Parse(masvs.Text);
                            bll.DeleteSinhVienk14(bv);
                            getAll();
                        }
                    }
                
                //}
                    
                
            }
            else
                MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.masv = int.Parse(masvs.Text);
                if (bll.DeleteSinhVienk14(sv) && bll.DeleteSinhVien(sv))
                {
                    tbsinhvien cv = new tbsinhvien();
                    cv.masv = int.Parse(masvs.Text);
                    cv.madoituong = int.Parse(madoituongs.Text);
                    cv.malop = int.Parse(malops.Text);
                    cv.hoten = hotens.Text;
                    cv.ngaysinh = ngaysinhs.Text;
                    cv.diachi = diachis.Text;
                    cv.gioitinh = gioitinhs.Text;
                    cv.id_taikhoan = int.Parse(tentaikhoan);
                    bll.AddLichsu(cv);
                    getAll();
                }

                else {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
        }

        private void find_TextChanged(object sender, EventArgs e)
        {
            string value = find.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.FindSinhVienk14(value);
                dataGridView1.DataSource = dt;
            }
            else
            {
                getAll();
            }
        }
    }
}
