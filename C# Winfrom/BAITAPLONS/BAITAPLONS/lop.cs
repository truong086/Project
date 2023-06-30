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
    public partial class lop : Form
    {
        string matutt = "", tentaikhoan = "", matkhau = "", capquyen = "";
        // Gọi lại lớp "sinhvienBLL"\
        sinhvienBLL bll;
        public lop(string matutt, string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            // Khởi tạo lớp "sinhvienBLL"
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
        }

        public void showAllLop()
        {
            // Khởi tạo lớp DataTable và gọi lại phương thức hiển thị thông tin(getAllLop) ở lớp "sinhvienBLL"(bll)
            DataTable dt = bll.getAllLop();
            lopss.DataSource = dt;
        }
        private void lop_Load(object sender, EventArgs e)
        {

            add.BackColor = Color.Orange;
            edit.BackColor = Color.Orange;
            delete.BackColor = Color.Orange;
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
                mlop.Hide();
                mnganh.Hide();
                tlop.Hide();
                gvlop.Hide();
                khoah.Hide();
                malops.Hide();
                manganhs.Hide();
                tenlops.Hide();
                gvcnlops.Hide();
                khoahocs.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllLop();
        }

        // Khởi tạo 1 phương thức kiểm tra xem người dùng đã nhập đầy đủ dữ liệu chưa
        public bool checkData()
        {
            if (string.IsNullOrEmpty(malops.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                malops.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(manganhs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                manganhs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tenlops.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenlops.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gvcnlops.Text))
            {
                MessageBox.Show("Bạn chưa nhập giáo viên chủ nhiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvcnlops.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(khoahocs.Text))
            {
                MessageBox.Show("Bạn chưa nhập khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                khoahocs.Focus();
                return false;
            }
            return true;
        }

        int id;
        private void lopss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(lopss.Rows[index].Cells["maloptt"].Value.ToString());
                malops.Text = lopss.Rows[index].Cells["malop"].Value.ToString();
                manganhs.Text = lopss.Rows[index].Cells["manganh"].Value.ToString();
                tenlops.Text = lopss.Rows[index].Cells["tenlop"].Value.ToString();
                gvcnlops.Text = lopss.Rows[index].Cells["GVCNlop"].Value.ToString();
                khoahocs.Text = lopss.Rows[index].Cells["khoahoc"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData()) // gọi lại hàm "checkData()"
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();

                // Khởi tạo các trường dữ liệu
                sv.malopp = int.Parse(malops.Text);
                sv.manganh = int.Parse(manganhs.Text);
                sv.tenlop = tenlops.Text;
                sv.GVCNlop = gvcnlops.Text;
                sv.khoahoc = khoahocs.Text;

                if (bll.AddLop(sv))
                    showAllLop();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData()"
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                // Khai báo các trường dữ liệu
                sv.maloptt = id;
                sv.malopp = int.Parse(malops.Text);
                sv.manganh = int.Parse(manganhs.Text);
                sv.tenlop = tenlops.Text;
                sv.GVCNlop = gvcnlops.Text;
                sv.khoahoc = khoahocs.Text;

                if (bll.EditLop(sv))
                    showAllLop();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Hiển thị 1 thông báo hỏi người dùng xem muốn xóa không
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                sv.maloptt = id;
                if (bll.DeleteLop(sv))
                    showAllLop();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.TimkiemLop(value);
                lopss.DataSource = dt;
            }
            else
            {
                showAllLop();
            }
        }
    }
}
