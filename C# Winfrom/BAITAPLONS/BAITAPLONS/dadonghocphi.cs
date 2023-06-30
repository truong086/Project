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
    public partial class dadonghocphi : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        sinhvienBLL bll;
        public dadonghocphi(string matutt, string tk, string mk, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = tk;
            this.mk = mk;
            this.capquyen = capquyen;
        }

        public void getAll()
        {
            DataTable dt = bll.chuadonghocphi();
            cdhp.DataSource = dt;
        }
        private void dadonghocphi_Load(object sender, EventArgs e)
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
            getAll();
        }
    }
}
