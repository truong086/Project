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
    public partial class monhoc : Form
    {
        string matutt = "", taikhoan = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        public monhoc(string matutt , string taikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
        }

        public void showAllMonhoc()
        {
            DataTable dt = bll.getAllMonhoc();
            monhocss.DataSource = dt;
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(mamonhocs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mamonhocs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tenmonhocs.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tenmonhocs.Focus();
                return false;
            }
            return true;
        }
        private void monhoc_Load(object sender, EventArgs e)
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
                mmonhoc.Hide();
                tmonhoc.Hide();
                mamonhocs.Hide();
                tenmonhocs.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllMonhoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.mamonhocc = int.Parse(mamonhocs.Text);
                sv.tenmonhoc = tenmonhocs.Text;

                if (bll.AddMonhoc(sv))
                    showAllMonhoc();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int id;
        private void monhocss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(monhocss.Rows[index].Cells["mamonhoctt"].Value.ToString()); // "Cells[]" có thể chuyền vào 2 giá trị: 1 là tên của cột dữ liệu đó, 2 là có thể chuyền vào số tự tự của cột dữ liệu đó
                mamonhocs.Text = monhocss.Rows[index].Cells["mamonhoc"].Value.ToString();
                tenmonhocs.Text = monhocss.Rows[index].Cells["tenmonhoc"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.mamonhoctt = id;
                sv.mamonhocc = int.Parse(mamonhocs.Text);
                sv.tenmonhoc = tenmonhocs.Text;

                if (bll.EditMonhoc(sv))
                    showAllMonhoc();
                else
                    MessageBox.Show("Đã có xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.mamonhoctt = id;

                if (bll.DeleteMonhoc(sv))
                    showAllMonhoc();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.TimkiemMonhoc(value);
                monhocss.DataSource = dt;
            }
            else
            {
                showAllMonhoc();
            }
        }
    }
}
