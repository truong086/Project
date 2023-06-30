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
    public partial class taikhoan : Form
    {
        string matutt = "", tentaikhoan1 = "", matkhau1 = "", capquyen1 = "";
        // Gọi lại lớp sinhvienBLL
        sinhvienBLL bll;
        SqlDataAdapter da;
        DataConnection dsa;
        public taikhoan(string matutt, string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            // Khởi tạo lớp "sinhvienBLL"
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tentaikhoan1 = tentaikhoan;
            this.matkhau1 = matkhau;
            this.capquyen1 = capquyen;
            dsa = new DataConnection();
        }
        public void showAllTKSV()
        {
            // Khởi tạo lại lớp DataTable và gọi lại lớp hiển thị dữ liệu(getAllTKSV)
            DataTable dt = bll.getAllTKSV();
            taikhoanss.DataSource = dt;
        }
        

        private void taikhoan_Load(object sender, EventArgs e)
        {
            if (capquyen1 == "1")
            {
                quyen.Text = "Admin";
                quyen.ForeColor = Color.Red;
            }
            if (capquyen1 == "2")
            {
                quyen.Text = "Quản lý";
                quyen.ForeColor = Color.Red;
            }
            if (capquyen1 == "3")
            {
                quyen.Text = "Sinh viên";
                quyen.ForeColor = Color.Red;
            }
            if (capquyen1 != "1" && capquyen1 != "2")
            {
                add.Hide();
                edit.Hide();
                delete.Hide();
                use.Hide();
                password.Hide();
                cq.Hide();
                tentaikhoans.Hide();
                matkhaus.Hide();
                capquyens.Hide();
            }
            if(capquyen1 == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllTKSV();
        }

        // Tạo 1 phương thức để kiểm tra xem người dùng đã nhập đầy đủ dữ liệu chưa
        public bool checkData()
        {
            if (string.IsNullOrEmpty(tentaikhoans.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng nhập đầy đủ thông tin chưa, nếu chuwanhaapj đủ thì thực hiện các câu lệnh bên trong "if()"
            {
                // Khi người dùng chưa nhập đầy đủ thông tin thì hiển thị thông báo lỗi
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tentaikhoans.Focus(); // Để con trỏ "Focus()" vào
                return false;
            }
            if (string.IsNullOrEmpty(matkhaus.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                matkhaus.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(capquyens.Text))
            {
                MessageBox.Show("Bạn chưa phân quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                capquyens.Focus();
                return false;
            }
            return true;
        }
       

        private void add_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData()"
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                // Khai báo các trường dữ liệu để thêm dữ liệu vào database
                sv.tentaikhoanDN = int.Parse(tentaikhoans.Text); // Vì tên tài khoản(tentaikhoan) là số nguyên nên phải khai báo là: "int.Parse()" để chuyển sang số nguyên
                sv.matkhau = matkhaus.Text;
                sv.capquyen = int.Parse(capquyens.Text); // Vì cấp quyền(capquyen) là số nguyên nên phải khai báo là "int.Parse" để chuyển sang số nguyên

                // Khi khai báo xong các trường dữ liệu rồi thì bắt đầu gọi lại hàm thêm dữ liệu(AddTKSV) ở lớp "sinhvienBLL"(bll) để thêm dữ liệu
                if(bll.AddTKSV(sv))
                    showAllTKSV(); // Khi thêm dữ liệu thành công thì phải hiển thị lại toàn bộ dữ liệu
                else // Nếu thêm không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int id;
        private void taikhoanss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; // Khai báo 1 biến index để bắt sự kiện khi người dùng click vào cột dữ liệu bất kỳ thì sẽ hiển thị dữ liệu đó lên
            if (index >= 0) // Khi người dùng click vào cột dữ liệu bất kỳ thì sẽ hiển thị dữ liệu đó lên
            {
                id = Int32.Parse(taikhoanss.Rows[index].Cells[0].Value.ToString());
                tentaikhoans.Text = taikhoanss.Rows[index].Cells["tentaikhoan"].Value.ToString();
                matkhaus.Text = taikhoanss.Rows[index].Cells["matkhau"].Value.ToString();
                capquyens.Text = taikhoanss.Rows[index].Cells["capquyen"].Value.ToString();
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData()" để kiểm tra, nếu hàm này trả về "true" nghĩa là người dùng nhập đầy đủ thông tin rồi thì bắt đầu thực hiện các câu lệnh bên dưới
            {
                // Khi người dùng nhập đầy đủ thông tin rồi thì bắt đầu sửa dữ liệu
                tbsinhvien sv = new tbsinhvien(); // Gọi lại lớp "tbsinhvien"
                // Khai báo các trường dữ liệu để sửa dữ liệu
                sv.mataikhoantt = id;
                sv.tentaikhoanDN = int.Parse(tentaikhoans.Text); // Vì tên tài khoản(tentaikhoan) là số nguyên nên phải khai báo là "int.Parse()" để chuyển về số nguyên
                sv.matkhau = matkhaus.Text;
                sv.capquyen = int.Parse(capquyens.Text); // Vì cấp quyền(capquyen) là số nguyên nên phải khai báo là "int.Parse()" để chuyển về số nguyên

                // Khi khai báo xong các trường dữ liệu ở trên rồi thì bắt đầu gọi lại phương thức sửa tài khoản(EditTKSV) trong lớp "sinhvienBLL"(bll)
                if (bll.EditTKSV(sv))
                    showAllTKSV(); // Khi sửa tài khoản thành công thì phải hiển thị lại toàn bộ dữ liệu
                else // Nếu sửa không thành công thì hiển thị thông báo lối
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes) // Hiển thị thông báo hỏi người dùng xem muốn xóa không, Nếu người dùng chọn vào "Yes" thì bắt đầu xóa, "DialogResult.Yes" nghĩa là khi người dùng chọn vào "Yes"
            {
                
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();

                // Khai báo trường dữ liệu để xóa, Muốn xóa chỉ cần chuyền vào 1 trường dữ liệu là tên tài khoản(tentaikhoan)
                //sv.mataikhoantt = id;
                sv.tentaikhoanDN = int.Parse(tentaikhoans.Text);

                // Gọi lại lớp xóa tài khoản(DeleteTKSV()) ở lớp "sinhvienBLL"(bll)
                if (bll.DeleteTKSV(sv))
                {

                    /*string sql = "select * from sinhvien where msv = " + sv.tentaikhoanDN + "";
                    SqlConnection con = dsa.getConnection();
                    da = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        tbsinhvien svs = new tbsinhvien();
                        svs.masv = int.Parse(tentaikhoans.Text);
                        bll.DeleteSinhVien(svs);
                    }*/

                    tbsinhvien bv = new tbsinhvien();
                    bv.masvLS = int.Parse(tentaikhoans.Text);
                    if (capquyens.Text == "1")
                    {
                        bv.mota = "Tài khoản Admin, có mã tài khoản là: " + bv.masvLS + ", mật khẩu là: " + matkhaus.Text + "";
                    }
                    if (capquyens.Text == "2")
                    {
                        bv.mota = "Tài khoản Quản lý, có mã tài khoản là: " + bv.masvLS + ", mật khẩu là: " + matkhaus.Text + "";
                    }
                    if (capquyens.Text == "3")
                    {
                        bv.mota = "Tài khoản sinh viên, có mã tài khoản là: " + bv.masvLS + ", mật khẩu là: " + matkhaus.Text + "";
                    }

                    bv.id_taikhoanLS = int.Parse(tentaikhoan1);
                    bll.AddLichSuTK(bv);

                    showAllTKSV(); // Xóa thành công thì hiển thị lại toàn bộ dữ liệu
                }
                else {
                    // Nếu xóa không thành công thì hiển thị thông báo lối
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text; // Khởi tạo ô textBox ở from có name là "timkiems" để tìm kiếm giá trị
            if (!string.IsNullOrEmpty(value)) // Câu lệnh này nghĩa là: khi ô nhập giá trị textBox ở from có name là: "timkiems" không bị rỗng(nghĩa là có giá trị chuyền vào) thì bắt đầu tìm kiếm
            {
                // Khởi tạo lại lớp DataTable và gọi lại lớp tìm kiếm tài khoản sinh viên(TimkiemTKSV) ở lớp "sinhvienBLL"(bll) để tìm kiếm
                DataTable dt = bll.TimkiemTKSV(value);
                taikhoanss.DataSource = dt;
            }
            else // Nếu ô textBox có name là: "timkiems" mà bị rỗng thì phải hiển thị lại toàn bộ dữ liệu
            {
                showAllTKSV();
            }
        }

        private void taikhoanss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
