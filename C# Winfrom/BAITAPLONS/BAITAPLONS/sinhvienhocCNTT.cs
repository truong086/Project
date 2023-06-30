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
    public partial class sinhvienhocCNTT : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        sinhvienBLL bll;
        public sinhvienhocCNTT(string matutt, string tk, string mk, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = tk;
            this.mk = mk;
            this.capquyen = capquyen;
        }

        public void getAll()
        {
            DataTable dt = bll.getAllsinhvienCNTT();
            dataGridView1.DataSource = dt;
        }

        private void sinhvienhocCNTT_Load(object sender, EventArgs e)
        {
            if(capquyen == "1")
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
            getAll();
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.FindSinhVienCNTT(value);
                dataGridView1.DataSource= dt;
            }
            else
            {
                getAll();
            }
        }
    }
}
