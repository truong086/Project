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
    public partial class doimatkhau : Form
    {
        string matutt = "", tk = "", mk = "", capquyens = "";
        sinhvienBLL bll;
        SqlDataAdapter da;
        DataConnection daas;
        public doimatkhau(string matutt, string taikhoan, string matkhau, string capquyens)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            daas = new DataConnection();
            this.matutt = matutt;
            this.tk = taikhoan;
            this.mk = matkhau;
            this.capquyens = capquyens;
        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {
            thaydois.BackColor = Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from taikhoan where tentaikhoan = N'" + tentaikhoans.Text + "' and matkhau = N'" + matkhaus.Text + "'";
            SqlConnection con = daas.getConnection(); // Gọi lại chuỗi kết nối
            da = new SqlDataAdapter(sql, con); // Xử lý câu lệnh "sql, con"
            DataTable dt = new DataTable(); // Khởi tạo DataTable
            da.Fill(dt); // Đổ dữ vào DataTable bằng hàm "Fill()"
            if(dt.Rows.Count > 0) // Nếu tài khoản tồn tại thì bắt đầu chỉnh sửa tài khoản
            {
                tbsinhvien sv = new tbsinhvien();
                sv.tentaikhoanDN = int.Parse(tentaikhoans.Text);
                sv.matkhau = matkhaumoi.Text;
                sv.capquyen = int.Parse(capquyens);
                bll.EditTKSV(sv);

                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông tin tài khoản không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
