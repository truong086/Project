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
    public partial class lichsu : Form
    {
        string tentaikhoantt = "", tentaikhoan = "", matkhau = "", capquyens = "";
        sinhvienBLL bll;
        DataConnection dss;
        SqlDataAdapter da;
        public lichsu(string tentaikhoantt, string tentaikhoan, string matkhau, string capquyens)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.tentaikhoantt = tentaikhoantt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyens = capquyens;
            dss = new DataConnection();
        }


        public void getAllLichsu()
        {
            DataTable dt = bll.getAllLichsu();
            dataGridView1.DataSource = dt;
        }

        private void lichsu_Load(object sender, EventArgs e)
        {
            ngaysinhs.Hide();
            ns.Hide();
            diachis.Hide();
            dc.Hide();
            gioitinhs.Hide();
            gt.Hide();
            add.BackColor = Color.Orange;
            delete.BackColor = Color.Orange;
            getAllLichsu();
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
                taikhoans.Text = dataGridView1.Rows[index].Cells["id_taikhoan"].Value.ToString();
                motas.Text = dataGridView1.Rows[index].Cells["mota"].Value.ToString();
            }
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
            if (string.IsNullOrEmpty(dc.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập địa chỉ sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                dc.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(gioitinhs.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập giới tính sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                gioitinhs.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(taikhoans.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
            {
                // Nếu người dùng chưa nhập đầy đủ thông tin thì sẽ hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập mã tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                taikhoans.Focus(); // Để con trỏ focus vào
                return false;
            }
            return true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                
                // Khởi tạo lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                sv.masv = int.Parse(masvs.Text);// Vì mã sinh viên là kiểu số nguyên nên phải khai báo là "int.Parse()"
                sv.madoituong = int.Parse(madoituongs.Text);
                sv.malop = int.Parse(malops.Text);
                sv.hoten = hotens.Text;
                sv.ngaysinh = ngaysinhs.Text;
                sv.diachi = dc.Text;
                sv.gioitinh = gioitinhs.Text;
                if (bll.AddSinhVien(sv))
                {
                    if (sv.madoituong == 1)
                    {
                        bll.AddSinhViendb(sv);
                        //MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 10 || sv.malop <= 4 || sv.malop == 11)
                    {
                        bll.AddSinhVienk14(sv);
                        //MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 5 || sv.malop == 6 || sv.malop == 8 || sv.malop == 12)
                    {
                        bll.AddSinhVienk15(sv);
                        //MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (sv.malop == 7 || sv.malop == 9 || sv.malop == 15)
                    {
                        bll.AddSinhVienk16(sv);
                        //MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    MessageBox.Show("Khôi phục ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    string sql = "select * from taikhoan where tentaikhoan = " + sv.masv + "";
                    SqlConnection con = dss.getConnection();
                    da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count <= 0)
                    {
                        tbsinhvien svs = new tbsinhvien();
                        svs.tentaikhoanDN = int.Parse(masvs.Text);
                        svs.matkhau = masvs.Text;
                        svs.capquyen = 3;
                        bll.AddTKSV(svs);
                    }
                        

                    tbsinhvien cv = new tbsinhvien();
                    cv.masv = int.Parse(masvs.Text);
                    bll.DeleteLichsu(cv);


                    getAllLichsu();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string sqls = "select * from taikhoan where tentaikhoan = " + masvs.Text + "";
            SqlConnection cons = dss.getConnection();
            da = new SqlDataAdapter(sqls, cons);
            cons.Open();
            DataTable dts = new DataTable();
            da.Fill(dts);
            if(dts.Rows.Count <= 0)
            {
                tbsinhvien bv = new tbsinhvien();
                bv.tentaikhoanDN = int.Parse(masvs.Text);
                bv.matkhau = "123";
                bv.capquyen = 3;
                bll.AddTKSV(bv);
            }
            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.masv = int.Parse(masvs.Text);
                if (bll.DeleteLichsu(sv))
                {
                    getAllLichsu();
                    masvs.Text = "";
                    madoituongs.Text = "";
                    malops.Text = "";
                    hotens.Text = "";
                    ngaysinhs.Text = "";
                    dc.Text = "";
                    gioitinhs.Text = "";
                    taikhoans.Text = "";
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
