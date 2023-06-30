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
    public partial class khoacntt : Form
    {
        DataConnection daa;
        SqlDataAdapter da;
        string mataikhoantt = "", tentaikhoan = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        public khoacntt(string mataikhoantt, string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.mataikhoantt = mataikhoantt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
            daa = new DataConnection();
        }

        public void getAllKHoa()
        {
            DataTable dt = bll.getAllKhoacntt();
            nganhcnttss.DataSource = dt;
        }
        private void khoacntt_Load(object sender, EventArgs e)
        {
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
                edit.Hide();
                delete.Hide();
                mnganh.Hide();
                mkhoa.Hide();
                tnganh.Hide();
                manganhs.Hide();
                makhoas.Hide();
                tennganhs.Hide();
            }
            if (capquyen == "2")
            {
                delete.Hide();
            }
            getAllKHoa();
        }
        public bool checkData()
        {
            if (string.IsNullOrEmpty(manganhs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                manganhs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(makhoas.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                makhoas.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tennganhs.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tennganhs.Focus();
                return false;
            }
            return true;
        }

        int id;
        private void nganhcnttss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(nganhcnttss.Rows[index].Cells["manganhtt"].Value.ToString());
                manganhs.Text = nganhcnttss.Rows[index].Cells["manganh"].Value.ToString();
                makhoas.Text = nganhcnttss.Rows[index].Cells["makhoa"].Value.ToString();
                tennganhs.Text = nganhcnttss.Rows[index].Cells["tennganh"].Value.ToString();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                //sv.manganhtt = id;
                sv.manganhh = int.Parse(manganhs.Text);
                sv.makhoaa = int.Parse(makhoas.Text);
                sv.tennganh = tennganhs.Text;
                if(sv.makhoaa == 113)
                {
                    bll.EditNganhcntt(sv);
                    bll.EditNganh(sv);
                    getAllKHoa();
                }
                else
                {
                    if(MessageBox.Show("Bạn đang sửa lại bản ghi không tương xứng với ngành công nghệ thông tin, nếu bạn tiếp tục sửa thì bản ghi ở đây sẽ bị xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        bll.EditNganh(sv);
                        if(sv.makhoaa == 114)
                        {
                            string sql = "select * from nganhdulich where manganh = " + manganhs.Text + ";";
                            SqlConnection con = daa.getConnection();
                            da = new SqlDataAdapter(sql, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if(dt.Rows.Count <= 0)
                            {
                                tbsinhvien cvc = new tbsinhvien();
                                cvc.manganhh = int.Parse(manganhs.Text);
                                cvc.makhoaa = int.Parse(makhoas.Text);
                                cvc.tennganh = tennganhs.Text;
                                bll.EditNganh(sv);
                                bll.AddNganhdulich(cvc);
                            }
                            else
                            {
                                tbsinhvien cvc = new tbsinhvien();
                                cvc.manganhh = int.Parse(manganhs.Text);
                                cvc.makhoaa = int.Parse(makhoas.Text);
                                cvc.tennganh = tennganhs.Text;
                                bll.EditNganh(sv);
                                bll.EditNganhdulich(cvc);
                            }
                        }
                        if (sv.makhoaa == 115)
                        {
                            string sql = "select * from nganhluat where manganh = " + manganhs.Text + ";";
                            SqlConnection con = daa.getConnection();
                            da = new SqlDataAdapter(sql, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count <= 0)
                            {
                                tbsinhvien cvc = new tbsinhvien();
                                cvc.manganhh = int.Parse(manganhs.Text);
                                cvc.makhoaa = int.Parse(makhoas.Text);
                                cvc.tennganh = tennganhs.Text;
                                bll.EditNganh(sv);
                                bll.AddNganhluat(cvc);
                            }
                            else
                            {
                                tbsinhvien cvc = new tbsinhvien();
                                cvc.manganhh = int.Parse(manganhs.Text);
                                cvc.makhoaa = int.Parse(makhoas.Text);
                                cvc.tennganh = tennganhs.Text;
                                bll.EditNganh(sv);
                                bll.AddNganhluat(cvc);
                            }
                        }
                        if (sv.makhoaa == 116)
                        {
                            string sql = "select * from nganhQTKD where manganh = " + manganhs.Text + ";";
                            SqlConnection con = daa.getConnection();
                            da = new SqlDataAdapter(sql, con);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            if (dt.Rows.Count <= 0)
                            {
                                tbsinhvien cvc = new tbsinhvien();
                                cvc.manganhh = int.Parse(manganhs.Text);
                                cvc.makhoaa = int.Parse(makhoas.Text);
                                cvc.tennganh = tennganhs.Text;
                                bll.EditNganh(sv);
                                bll.AddNganhqtkd(cvc);
                            }
                            else
                            {
                                tbsinhvien cvc = new tbsinhvien();
                                cvc.manganhh = int.Parse(manganhs.Text);
                                cvc.makhoaa = int.Parse(makhoas.Text);
                                cvc.tennganh = tennganhs.Text;
                                bll.EditNganh(sv);
                                bll.AddNganhqtkd(cvc);
                            }
                        }
                        tbsinhvien cv = new tbsinhvien();
                        cv.manganhh = int.Parse(manganhs.Text);
                        bll.DeleteNganhcntt(cv);
                        getAllKHoa();
                    }
                }
            }
        }

        private void tnganh_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.manganhh = int.Parse(manganhs.Text);
                if (bll.DeleteNganhcntt(sv) && bll.DeleteNganh(sv))
                    getAllKHoa();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.TimkiemNganhcntt(value);
                nganhcnttss.DataSource = dt;
            }
            else
            {
                getAllKHoa();
            }
        }
    }
}
