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
    public partial class doituong : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        sinhvienBLL bll;
        public doituong(string matutt,string taikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = taikhoan;
            this.mk = matkhau;
            this.capquyen = capquyen;
        }

        public void showAllDoituong()
        {
            DataTable dt = bll.getAllDoituong();
            doituongss.DataSource = dt;
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(madoituongs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                madoituongs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tendoituongs.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đối tượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tendoituongs.Focus();
                return false;
            }
            return true;
        }
        private void doituong_Load(object sender, EventArgs e)
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
                dt.Hide();
                tendt.Hide();
                madoituongs.Hide();
                tendoituongs.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllDoituong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.madoituong = int.Parse(madoituongs.Text);
                sv.tendoituong = tendoituongs.Text;

                if (bll.AddDoituong(sv))
                    showAllDoituong();
                else
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int id;
        private void doituongss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(doituongss.Rows[index].Cells["madoituongtt"].Value.ToString());
                madoituongs.Text = doituongss.Rows[index].Cells["madoituong"].Value.ToString();
                tendoituongs.Text = doituongss.Rows[index].Cells["tendoituong"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.madoituongtt = id;
                sv.madoituong = int.Parse(madoituongs.Text);
                sv.tendoituong = tendoituongs.Text;

                if (bll.EditDoituong(sv))
                    showAllDoituong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();

                sv.madoituongtt = id;

                if (bll.DeleteDoituong(sv))
                    showAllDoituong();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.TimkiemDoituong(value);
                doituongss.DataSource = dt;
            }
            else
            {
                showAllDoituong();
            }
        }
    }
}
