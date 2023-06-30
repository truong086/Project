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
    public partial class dangnhap : Form
    {
        sinhvienBLL bll;
        // Gọi lại chuỗi kết nối từ class "DataConnection"
        DataConnection dc =new DataConnection();

        SqlDataAdapter da;
        SqlCommand cmd; // Sử dụng đối tượng này để thêm sinh viên, bằng câu lệnh "insert into"
        public dangnhap()
        {
            InitializeComponent();
            bll = new sinhvienBLL();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Khởi tạo 1 phương để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
        public bool checkData()
        {
            if (string.IsNullOrEmpty(taikhoans.Text))
            {
                MessageBox.Show("Bạn chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                taikhoans.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(matkhaus.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                matkhaus.Focus();
                return false;
            }
            return true;
        }

        public bool checkDatas()
        {
            string s = taikhoans.Text;
            if (taikhoans.Text.Length > 10)
            {
                MessageBox.Show("Yêu cầu viết đúng tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void login_Click(object sender, EventArgs e)
        {
            if (checkDatas())
            {
                string sql = "select taikhoan.mataikhoantt, taikhoan.tentaikhoan, taikhoan.matkhau, taikhoan.capquyen, sinhvien.masvtt, sinhvien.msv, sinhvien.madoituong, sinhvien.malop, sinhvien.hoten, sinhvien.ngaysinh, sinhvien.diachi, sinhvien.gioitinh, lop.maloptt, lop.malop, lop.manganh, lop.tenlop, lop.GVCNlop, lop.khoahoc from ((taikhoan left join sinhvien on taikhoan.tentaikhoan = sinhvien.msv) left join lop on lop.malop = sinhvien.malop) where tentaikhoan = N'" + taikhoans.Text + "' and matkhau = N'" + matkhaus.Text + "'";
                // Gọi lại chuỗi kết nối đến CSDL
                SqlConnection con = dc.getConnection();
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) // Kiểm tra xem tài khoản này đã tòn tại chưa, nếu tồn tại rồi thì cho đăng nhập vào hệ thống dùng hàm "Rows" và "Count" để kiểm tra, nếu tài khoản chưa tồn tại thì thông báo lỗi
                {
                    MessageBox.Show("Đăng nhập thành công", "Chúc mừng!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    FormMai f = new FormMai(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), dt.Rows[0][14].ToString(), dt.Rows[0][15].ToString(), dt.Rows[0][16].ToString(), dt.Rows[0][17].ToString()); // "dt.Row[0][0]" và "dt.Row[0][1]" và "dt.Row[0][2]" nghĩa là tương ứng với trường dữ liệu trong cơ sở dữ liêu ở bảng tài khoản(taikhoan) trong database là: tentaikhoan, matkhau, capquyen lần lượt theo thứ tự bắt đầu từ số 0
                    f.ShowDialog();
                    sinhvien sv = new sinhvien(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString(), dt.Rows[0][9].ToString(), dt.Rows[0][10].ToString(), dt.Rows[0][11].ToString(), dt.Rows[0][12].ToString(), dt.Rows[0][13].ToString(), dt.Rows[0][14].ToString(), dt.Rows[0][15].ToString(), dt.Rows[0][16].ToString(), dt.Rows[0][17].ToString());
                    taikhoannganhangSV tksv = new taikhoannganhangSV(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    phieuthu ptt = new phieuthu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    lop lp = new lop(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    khoa kh = new khoa(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    nganh ng = new nganh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    doituong dts = new doituong(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    monhoc mh = new monhoc(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    taikhoan tks = new taikhoan(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    taikhoannhantien tknt = new taikhoannhantien(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    sinhvienk14 k14 = new sinhvienk14(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    sinhvienk15 k15 = new sinhvienk15(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    sinhvienk16 k16 = new sinhvienk16(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    khoacntt cntt = new khoacntt(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    nganhluat luat = new nganhluat(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    nganhdulich dulich = new nganhdulich(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    nganhquantrikinhdoanh qtkd = new nganhquantrikinhdoanh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    dadonghocphi chuadonghocphi = new dadonghocphi(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    sinhvienhocCNTT sinhvienCNTT = new sinhvienhocCNTT(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    sinhviendb sinhviendb = new sinhviendb(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    lichsu lichsu = new lichsu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    guiemail guiemail = new guiemail(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    phanhoi phanhoi = new phanhoi(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    thacmac thacmac = new thacmac(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    doimatkhau doimatkhau = new doimatkhau(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    donghocphi donghocphi = new donghocphi(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
