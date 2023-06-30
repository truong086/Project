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
    public partial class khoa : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        sinhvienBLL bll;
        public khoa(string matutt, string tk, string mk, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = tk;
            this.mk = mk;
            this.capquyen = capquyen;
        }

        public void showAllKhoa()
        {
            DataTable dt = bll.getAllKhoa();
            khoass.DataSource = dt;
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(makhoas.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makhoas.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tenkhoas.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenkhoas.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(gvchkhoa.Text))
            {
                MessageBox.Show("Bạn chưa nhập giáo viên chủ nhiệm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvchkhoa.Focus();
                return false;
            }
            {

            }
            return true;
        }
        private void khoa_Load(object sender, EventArgs e)
        {
            add.BackColor = Color.Orange;
            edit.ForeColor= Color.Orange;
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
                mkhoa.Hide();
                tenkh.Hide();
                giaovcnk.Hide();
                makhoas.Hide();
                tenkhoas.Hide();
                gvchkhoa.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllKhoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.makhoa = int.Parse(makhoas.Text);
                sv.tenkhoa = tenkhoas.Text;
                sv.GVCNkhoa = gvchkhoa.Text;

                if (bll.AddKhoa(sv))
                    showAllKhoa();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int id;
        private void khoass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(khoass.Rows[index].Cells["makhoatt"].Value.ToString());
                makhoas.Text = khoass.Rows[index].Cells["makhoa"].Value.ToString();
                tenkhoas.Text = khoass.Rows[index].Cells["tenkhoa"].Value.ToString();
                gvchkhoa.Text = khoass.Rows[index].Cells["GVCNkhoa"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();

                sv.makhoatt = id;
                sv.makhoa = int.Parse(makhoas.Text);
                sv.tenkhoa = tenkhoas.Text;
                sv.GVCNkhoa = gvchkhoa.Text;

                if (bll.EditKhoa(sv))
                    showAllKhoa();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.makhoatt = id;

                if (bll.DeleteKhoa(sv))
                    showAllKhoa();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.TimkiemKhoa(value);
                khoass.DataSource = dt;
            }
            else
            {
                showAllKhoa();
            }
        }
    }
}
