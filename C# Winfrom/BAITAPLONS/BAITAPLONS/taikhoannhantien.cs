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
    public partial class taikhoannhantien : Form
    {
        string matutt = "", tk = "", password = "", capquyen = "";
        // Gọi lại lớp sinhvienBLL
        sinhvienBLL bll;
        public taikhoannhantien(string matutt, string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            // Khởi tạo lớp sinhvienBLL
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = tentaikhoan;
            this.password = matkhau;
            this.capquyen = capquyen;
        }

        public void ShowAllTKNT()
        {
            // Gọi lại hàm DataTable và gọi lớp "getAllNT()" ở lớp bll(sinhvienBLL) để hiển thị toàn bộ dữ liệu
            DataTable dt = bll.getAllNT();
            taikhoannhantiens.DataSource = dt;
        }

        private void taikhoannhantien_Load(object sender, EventArgs e)
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
                tnh.Hide();
                tennganhangs.Hide();
                cn.Hide();
                tenchinhanhs.Hide();
                ttk.Hide();
                tentaikhoans.Hide();
                stk.Hide();
                sotaikhoans.Hide();
                nt.Hide();
                ngaytaos.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            ShowAllTKNT();
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(tennganhangs.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem dữ liệu người dùng đã nhập đầy đủ chưa, nếu chưa nhập đầy đủ thì thực hiện các câu lệnh bên dưới
            {
                // Người dùng chưa nhập đủ dữ liệu thì hiển thị ra thông báo lỗi
                MessageBox.Show("Bạn chưa nhập tên ngân hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tennganhangs.Focus(); // Để con trỏ "Focus()" vào
                return false;
            }
            if (string.IsNullOrEmpty(tenchinhanhs.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem dữ liệu người dùng đã nhập đầy đủ chưa, nếu chưa nhập đầy đủ thì thực hiện các câu lệnh bên dưới
            {
                // Người dùng chưa nhập đủ dữ liệu thì hiển thị ra thông báo lỗi
                MessageBox.Show("Bạn chưa nhập tên chi nhánh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenchinhanhs.Focus(); // Để con trỏ "Focus()" vào
                return false;
            }
            if (string.IsNullOrEmpty(sotaikhoans.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem dữ liệu người dùng đã nhập đầy đủ chưa, nếu chưa nhập đầy đủ thì thực hiện các câu lệnh bên dưới
            {
                // Người dùng chưa nhập đủ dữ liệu thì hiển thị ra thông báo lỗi
                MessageBox.Show("Bạn chưa nhập số tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sotaikhoans.Focus(); // Để con trỏ "Focus()" vào
                return false;
            }
            if (string.IsNullOrEmpty(tentaikhoans.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem dữ liệu người dùng đã nhập đầy đủ chưa, nếu chưa nhập đầy đủ thì thực hiện các câu lệnh bên dưới
            {
                // Người dùng chưa nhập đủ dữ liệu thì hiển thị ra thông báo lỗi
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tentaikhoans.Focus(); // Để con trỏ "Focus()" vào
                return false;
            }
            if (string.IsNullOrEmpty(ngaytaos.Text)) // Dùng hàm "IsNullOrEmpty" để kiểm tra xem dữ liệu người dùng đã nhập đầy đủ chưa, nếu chưa nhập đầy đủ thì thực hiện các câu lệnh bên dưới
            {
                // Người dùng chưa nhập đủ dữ liệu thì hiển thị ra thông báo lỗi
                MessageBox.Show("Bạn chưa nhập ngày tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ngaytaos.Focus(); // Để con trỏ "Focus()" vào
                return false;
            }
            return true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData" để kiểm tra dữ liệu, nếu hàm này trả về true nghĩa là người dùng đã nhập đầy đủ thông tin và bắt đầu truyền dữ liệu vào database
            {
                // Người dùng nhập đầy đủ thông tin rồi thì bắt đầu khai báo các trường dữ liệu rồi truyền dữ liệu vào database
                tbsinhvien sv = new tbsinhvien(); // Gọi lại lớp "tbsinhvien"
                // Khai báo các trường dữ liệu để truyền dữ liệu vào database
                sv.tennganhangHT = tennganhangs.Text;
                sv.tenchinhanhHT = tenchinhanhs.Text;
                sv.sotaikhoanHT = sotaikhoans.Text;
                sv.tentaikhoanHT = tentaikhoans.Text;
                sv.ngayvaoHT = ngaytaos.Text;

                // Khi đã khai báo xong các trường dữ liệu ở trên xong thì bắt đầu thêm dữ liệu vào database, gọi lại lớp "AddNT()"(thêm dữ liệu vào database) ở lớp bll(sinhvienBLL)
                if (bll.AddNT(sv)) // Nếu thêm dữ liệu thành công thì hiển thị lại toàn bộ dữ liệu
                    ShowAllTKNT();
                else // Nếu thêm không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }


        int id;

        private void taikhoannhantiens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; // Khai báo 1 index để hiển thị dữ liệu khi người dùng click vào cột dữ liệu
            if(index >= 0) // Khi người dùng click vào cột dữ liệu bất kì thì sẽ hiển thị dữ liệu mà người dùng vừa click lên
            {
                id = Int32.Parse(taikhoannhantiens.Rows[index].Cells["mataikhoannhantien"].Value.ToString());
                tennganhangs.Text = taikhoannhantiens.Rows[index].Cells["tennganhhang"].Value.ToString();
                tenchinhanhs.Text = taikhoannhantiens.Rows[index].Cells["tenchinhanh"].Value.ToString();
                sotaikhoans.Text = taikhoannhantiens.Rows[index].Cells["sotaikhoanNT"].Value.ToString();
                tentaikhoans.Text = taikhoannhantiens.Rows[index].Cells["tentaikhoanNT"].Value.ToString();
                ngaytaos.Text = taikhoannhantiens.Rows[index].Cells["ngaytao"].Value.ToString();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();

                // Khai báo các trường dữ liệu đẻ update dữ liệu vào database
                sv.mataikhoanHT = id;
                sv.tennganhangHT = tennganhangs.Text;
                sv.tenchinhanhHT = tenchinhanhs.Text;
                sv.sotaikhoanHT = sotaikhoans.Text;
                sv.tentaikhoanHT = tentaikhoans.Text;
                sv.ngayvaoHT = ngaytaos.Text;

                // Khi khai báo các trường dữ liệu xong thì gọi lại lớp EditNT(sửa dữ liệu) ở lớp "sinhvienBLL"(bll)
                if(bll.EditNT(sv)) 
                    ShowAllTKNT(); // Khi sửa dữ liệu thành công thì hiển thị lại tất cả dữ liệu
                else // Nếu sửa không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Khi người dùng muốn xóa dữ liệu thì hiển thị 1 thông báo hỏi người dùng là "Có chắc chắn muốn xóa không" nếu người dùng chọn vào "Yes" nghĩa là muốn xóa thì bắt đầu xóa, "DialogResult.Yes" nghĩa là khi người dùng chọn vào "Yes" thì bắt đầu thực hiện các dòng lệnh ở dưới
            {
                //Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();

                // Khai báo trường dữ liệu để xóa dữ liệu, nếu muốn xóa thì chỉ cần truyền vào 1 trường dữ liệu duy nhất là: mã tài khoản nhận tiền(mataikhoannhantien)
                sv.mataikhoanHT = id;

                // Khi khai báo xong trường dữ liệu ở trên rồi thì bắt đầu gọi đến hàm xóa tài khoản(DeleteNT) ở lớp "sinhvienBLL"(bll)
                if (bll.DeleteNT(sv))
                    ShowAllTKNT(); // Khi xóa thành công thì phải hiển thị lại toàn bộ dữ liệu
                else // Nếu xóa không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text; // Khai báo ô textBox có name là "timkiems" trong from để khi người dùng vừa nhập dữ liệu vào thì bắt đầu tìm kiếm
            if (!string.IsNullOrEmpty(value)) // Câu lệnh này nghĩa là: Khi ô nhập giá trị textBox có name là: "timkiems" trong from không rỗng(nghĩa là có giá trị truyền vào) thì bắt đầu tìm kiếm
            {
                // Gọi lại lớp DataTable và gọi lại hàm tìm kiếm(TimkiemNT) ở lớp "sinhvienBLL"(bll)
                DataTable dt = bll.TimkiemNT(value);
                taikhoannhantiens.DataSource = dt;
            }
            else // Khi ô textBox có name là: "timkiems" bị rỗng (nghĩa là không có giá trị chuyền vào) thì phải hiển thị toán bộ danh sách dữ liệu trong bảng
            {
                ShowAllTKNT();
            }
        }
    }
}
