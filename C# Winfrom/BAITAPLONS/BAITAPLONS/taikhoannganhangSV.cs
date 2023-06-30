using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPLONS
{
    public partial class taikhoannganhangSV : Form
    {
        string matutt = "", tk = "", matkhau = "", capquyen = "";
        sinhvienBLL bllSV;
        public taikhoannganhangSV(string matutt, string tk, string matkhau, string capquyen)
        {
            InitializeComponent();
            bllSV = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = tk;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
        }

        public void showAllTK()
        {
            DataTable dt = bllSV.taikhoansv();
            dataGridView2.DataSource = dt;
        }
        private void taikhoannganhangSV_Load(object sender, EventArgs e)
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
                add.Hide();
                edit.Hide();
                delete.Hide();
                mtk.Hide();
                tnh.Hide();
                cn.Hide();
                ttk.Hide();
                stk.Hide();
                nt.Hide();
                msvs.Hide();
                tennganhangs.Hide();
                chinhanhs.Hide();
                sotaikhoans.Hide();
                tentaikhoans.Hide();
                ngaytaos.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllTK();
        }

        // Tạo 1 phương thức xem người dùng nhập đầy đủ thông tin chưa
        public bool checkData()
        {
            if (string.IsNullOrEmpty(msvs.Text)) // Sử dụng hàm "isNullOrEmpty" để kiểm tra dữ liệu xem người dùng đã nhập đủ chưa, Nếu người dùng chưa nhập đủ thông tin thì thực hiện câu lệnh bên dưới
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                msvs.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(tennganhangs.Text)) // Sử dụng hàm "isNullOrEmpty" để kiểm tra dữ liệu xem người dùng đã nhập đủ chưa, Nếu người dùng chưa nhập đủ thông tin thì thực hiện câu lệnh bên dưới
            {
                MessageBox.Show("Bạn chưa nhập tên ngân hàng sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                tennganhangs.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(chinhanhs.Text)) // Sử dụng hàm "isNullOrEmpty" để kiểm tra dữ liệu xem người dùng đã nhập đủ chưa, Nếu người dùng chưa nhập đủ thông tin thì thực hiện câu lệnh bên dưới
            {
                MessageBox.Show("Bạn chưa nhập chi nhánh sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                chinhanhs.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(sotaikhoans.Text)) // Sử dụng hàm "isNullOrEmpty" để kiểm tra dữ liệu xem người dùng đã nhập đủ chưa, Nếu người dùng chưa nhập đủ thông tin thì thực hiện câu lệnh bên dưới
            {
                MessageBox.Show("Bạn chưa nhập số tài khoản sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                sotaikhoans.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(tennganhangs.Text)) // Sử dụng hàm "isNullOrEmpty" để kiểm tra dữ liệu xem người dùng đã nhập đủ chưa, Nếu người dùng chưa nhập đủ thông tin thì thực hiện câu lệnh bên dưới
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                tennganhangs.Focus(); // Để con trỏ focus vào
                return false;
            }
            if (string.IsNullOrEmpty(ngaytaos.Text)) // Sử dụng hàm "isNullOrEmpty" để kiểm tra dữ liệu xem người dùng đã nhập đủ chưa, Nếu người dùng chưa nhập đủ thông tin thì thực hiện câu lệnh bên dưới
            {
                MessageBox.Show("Bạn chưa nhập ngày tạo sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); // "MessageBox.Show" có 4 tham số chuyền vào, tham số đầu tiên là thông báo lỗi, tham số thứ 2 là tên của thông báo, tham số thứ 3 là hiển thị 1 nút button lên cho người dùng bấm, ví dụ như hiển thị lên button "OK", tham số thứ 4 là hiển thị icon, ví dụ như: "Information"
                ngaytaos.Focus(); // Để con trỏ focus vào
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData" nếu hàm này trả về true thì thực hiện câu lệnh bên dưới là thêm dữ liệu vào database
            {
                // Khởi tạo lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                sv.masvvv = int.Parse(msvs.Text); // Vì mã sinh viên(msvs) là số nguyên nên phải khai báo là "int.Parse()" để chuyển về số nguyên
                sv.tennganhang = tennganhangs.Text;
                sv.tenchinhanh = chinhanhs.Text;
                sv.sotaikhoan = sotaikhoans.Text;
                sv.tentaikhoan = tentaikhoans.Text;
                sv.ngayvao = ngaytaos.Text;

                // Sau khi chèn được các trường dữ liệu ở trên rồi thì gọi lại lớp thêm tài khoản sinh viên(AddTaiKHoanSV) ở lớp sinhvienBLL
                if (bllSV.AddTaiKHoanSV(sv)) // Nếu trả về true nghĩa là thêm dữ liệu thành công thì sẽ hiển thị hiển thị lại tất cả dữ liệu bằng dòng lệnh "showAllTK()"
                    showAllTK();
                else // Thêm thêm dữ liệu không thành công thì sẽ hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        int id;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; // Khai báo 1 biến index, để lấy được cái index vừa click vào
            if(index >= 0) // Khi clcik vào dòng dữ liệu bất kỳ thì sẽ hiển thị nó lên
            {
                id = Int32.Parse(dataGridView2.Rows[index].Cells["manganhang"].Value.ToString());
                msvs.Text = dataGridView2.Rows[index].Cells["msv"].Value.ToString();
                tennganhangs.Text = dataGridView2.Rows[index].Cells["tennganhang"].Value.ToString();
                chinhanhs.Text = dataGridView2.Rows[index].Cells["chinhanh"].Value.ToString();
                sotaikhoans.Text = dataGridView2.Rows[index].Cells["sotaikhoan"].Value.ToString();
                tentaikhoans.Text = dataGridView2.Rows[index].Cells["tentaikhoan"].Value.ToString();
                ngaytaos.Text = dataGridView2.Rows[index].Cells["ngaytao"].Value.ToString();
            }
            else if(index == 0)
            {
                MessageBox.Show("Chưa có bản ghi", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                showAllTK();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData()" nếu hàm này trả về true nghĩa là đúng thì bắt đầu thực hiện câu lệnh bên dưới là update lại dữ liệu
            {
                tbsinhvien sv = new tbsinhvien();
                sv.mataikhoann = id;
                sv.masvvv = int.Parse(msvs.Text); // Vì mã sinh viên(msvs) là số nguyên nên phải khia báo là "int.Parse()" để chuyển sang số nguyên
                sv.tennganhang = tennganhangs.Text;
                sv.tenchinhanh = chinhanhs.Text;
                sv.sotaikhoan = sotaikhoans.Text;
                sv.tentaikhoan = tentaikhoans.Text;
                sv.ngayvao = ngaytaos.Text;

                // Khi đã chèn các dữ liệu ở trên thành công thì bắt đầu gọi lại hàm sửa tài khoản(EditTK) ở lớp BLL
                if (bllSV.EditTK(sv)) // Nếu sửa tài khoản thành công thì bắt đầu gọi lại hàm "showAllTK()" để hiện thị lại hết tất cả dữ liệu
                    showAllTK();
                else // Nếu sửa dữ liệu không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)// Hiển thị 1 cảnh báo cho người dùng là "Có chắc chắn muốn xóa bản ghi này không", nếu người dùng chọn vào "Yes" thì sẽ xóa bản ghi đó đi, "DialogResult.Yes" nghĩa là người dùng chọn vào "Yes"
            {
                // Khởi tạo lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                // Nếu muốn xóa thì chỉ cần khai 1 trường dữ liệu là mã ngân hàng(manganhang)
                sv.mataikhoann = id;

                if (bllSV.DeleteTK(sv)) // Nêu xóa thành công thì sẽ hiển thị lại tất cả danh sách tài khoản ngân hàng sinh viên 
                    showAllTK();
                else // Nếu xóa bị lỗi thì sẽ hiển thị thông báp lỗi
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void value_TextChanged(object sender, EventArgs e)
        {
            string TK = value.Text; // Khởi tạo "value" ở ô textBox trong from để tìm kiếm
            if (!string.IsNullOrEmpty(TK)) // Câu lệnh này nghĩa là: Nếu ô nhập giá trị không bị rỗng (Nghĩa là có giá trị chuyền vào) thì bắt đầu tìm kiếm
            {
                // Khởi tạo 1 hàm "DataTable" và gọi lại hàm Tìm kiếm tài khoản(TimkiemTkNH) ở lớp BLL(sinhvienBLL)
                DataTable dt = bllSV.TimKiemTkNH(TK);
                dataGridView2.DataSource = dt;
            }
            else // Nếu ô textBox mà bị rỗng thì hiển thị lại tất cả tài khoản sinh viên
            {
                showAllTK();
            }
        }
    }
}
