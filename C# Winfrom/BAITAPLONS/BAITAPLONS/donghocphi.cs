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
    public partial class donghocphi : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        sinhvienBLL bll;
        DataConnection dscc;
        SqlDataAdapter da;
        public donghocphi(string matutt, string taikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            dscc = new DataConnection();

            this.matutt = matutt;
            this.tk = taikhoan;
            this.mk = matkhau;
            this.capquyen = capquyen;
        }
        public bool checkData()
        {
            /*if (string.IsNullOrEmpty(maphieuthus.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập mã phiếu thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maphieuthus.Focus();
                return false;
            }*/
            if (string.IsNullOrEmpty(msvs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msvs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(mamonhocs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mamonhocs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tenphieuthus.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập tên phiếu thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tenphieuthus.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(namhocs.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập năm học phiếu thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                namhocs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(hockys.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập học kỳ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hockys.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(ngaythus.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập ngày thu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ngaythus.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sotiens.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập số tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sotiens.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(hinhthucs.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập hình thức nộp tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hinhthucs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(mataikhoannganhangSVs.Text)) // Sử dụng hàm "IsNullOrEmpty()" để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa, nếu chưa nhập đầy đủ thông tin thì thực hiện câu lệnh bên dưới là hiển thị ra 1 thông báo lỗi
            {
                MessageBox.Show("Bạn chưa nhập mã tài khoản ngân hàng sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mataikhoannganhangSVs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(mataikhoannhantienHPs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã tài khoản nhận tiền học phí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mataikhoannhantienHPs.Focus();
                return false;
            }
            return true;
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.masvv = int.Parse(msvs.Text);
                sv.mamonhoc = int.Parse(mamonhocs.Text);
                sv.tenkhoanthu = tenphieuthus.Text;
                sv.namhoc = namhocs.Text;
                sv.hocky = hockys.Text;
                sv.ngaythu = ngaythus.Text;
                sv.sotien = float.Parse(sotiens.Text);
                sv.hinhthuc = hinhthucs.Text;
                sv.mataikhoanSV = int.Parse(mataikhoannganhangSVs.Text);
                sv.mataikhoanNT = int.Parse(mataikhoannhantienHPs.Text);
                if (bll.AddPT(sv))
                    MessageBox.Show("Đóng tiền học phí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void donghocphi_Load(object sender, EventArgs e)
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
            mataikhoannhantienHPs.Text = "1";
            string sql = "select * from taikhoannganhangSV where msv = " + tk + "";
            SqlConnection con = dscc.getConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                string masv = dt.Rows[0][0].ToString();
                string namhoc = dt.Rows[0][1].ToString();
                string tenkhoanthu = dt.Rows[0][2].ToString();
                mataikhoannganhangSVs.Text = masv;
            }
        }
    }
}
