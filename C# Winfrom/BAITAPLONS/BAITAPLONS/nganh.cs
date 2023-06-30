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
    public partial class nganh : Form
    {
        // Chuỗi kết nối
        DataConnection dc;
        // Sử lý câu lệnh "sql", "con"
        SqlDataAdapter da;

        string matutt = "", tentaikhoan = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        public nganh(string matutt, string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
            dc = new DataConnection();
        }

        public void showAllNganh()
        {
            DataTable dt = bll.getAllNganh();
            nganhss.DataSource = dt;
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
        private void nganh_Load(object sender, EventArgs e)
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
                mnganh.Hide();
                mkhoa.Hide();
                tnganh.Hide();
                manganhs.Hide();
                makhoas.Hide();
                tennganhs.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllNganh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.manganhh = int.Parse(manganhs.Text);
                sv.makhoaa = int.Parse(makhoas.Text);
                sv.tennganh = tennganhs.Text;

                if (bll.AddNganh(sv))
                {
                    
                    if (sv.makhoaa == 113)
                    {
                        string sql = "Select * from nganhcntt1 where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        int manganht = int.Parse(manganhs.Text);
                        if(dt.Rows.Count <= 0)
                        {
                            bll.AddNganhcntt(sv);
                        }
                    }
                    if(sv.makhoaa == 114)
                    {
                        string sql = "Select * from nganhdulich where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        int manganht = int.Parse(manganhs.Text);
                        if( dt.Rows.Count <= 0)
                        {
                            bll.AddNganhdulich(sv);
                        }
                        else
                        {
                            MessageBox.Show("Bản ghi đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if(sv.makhoaa == 115)
                    {
                        string sql = "select * from nganhluat where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count <= 0)
                        {
                            bll.AddNganhluat(sv);
                        }
                    }
                    if (sv.makhoaa == 116)
                    {
                        string sql = "select * from nganhQTKD where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count <= 0)
                        {
                            bll.AddNganhqtkd(sv);
                        }
                    }
                    showAllNganh();
                }
                    
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int id;
        private void nganhss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                id = Int32.Parse(nganhss.Rows[index].Cells["manganhtt"].Value.ToString());
                manganhs.Text = nganhss.Rows[index].Cells["manganh"].Value.ToString();
                makhoas.Text = nganhss.Rows[index].Cells["makhoa"].Value.ToString();
                tennganhs.Text = nganhss.Rows[index].Cells["tennganh"].Value.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.manganhtt = id;
                sv.manganhh = int.Parse(manganhs.Text);
                sv.makhoaa = int.Parse(makhoas.Text);
                sv.tennganh = tennganhs.Text;


                if (bll.EditNganh(sv))
                {
                    if(sv.makhoaa == 113)
                    {
                        string sql = "Select * from nganhcntt1 where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            tbsinhvien bv = new tbsinhvien();
                            bv.manganhh = int.Parse(manganhs.Text);
                            bv.makhoaa = int.Parse(makhoas.Text);
                            bv.tennganh = tennganhs.Text;
                            bll.EditNganhcntt(bv);
                        }
                        /*else if (dt.Rows.Count <= 0)
                        {
                            tbsinhvien bv = new tbsinhvien();
                            bv.manganhh = int.Parse(manganhs.Text);
                            bv.makhoaa = int.Parse(makhoas.Text);
                            bv.tennganh = tennganhs.Text;
                            bll.AddNganhcntt(bv);
                        }*/
                    }

                    if(sv.makhoaa == 114)
                    {
                        string sql = "Select * from nganhdulich where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            tbsinhvien cv = new tbsinhvien();
                            cv.manganhh = int.Parse(manganhs.Text);
                            cv.makhoaa = int.Parse(makhoas.Text);
                            cv.tennganh= tennganhs.Text;
                            bll.EditNganhdulich(cv);
                        }
                    }

                    if (sv.makhoaa == 115)
                    {
                        string sql = "Select * from nganhluat where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            tbsinhvien cv = new tbsinhvien();
                            cv.manganhh = int.Parse(manganhs.Text);
                            cv.makhoaa = int.Parse(makhoas.Text);
                            cv.tennganh = tennganhs.Text;
                            bll.EditNganhluat(cv);
                        }
                    }

                    if (sv.makhoaa == 116)
                    {
                        string sql = "Select * from nganhQTKD where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            tbsinhvien cv = new tbsinhvien();
                            cv.manganhh = int.Parse(manganhs.Text);
                            cv.makhoaa = int.Parse(makhoas.Text);
                            cv.tennganh = tennganhs.Text;
                            bll.EditNganhqtkd(cv);
                        }
                    }

                    if (sv.makhoaa != 113)
                    {
                        string sql = "Select * from nganhcntt1 where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Bạn đang sửa lại bản ghi khác ngành công nghệ thông tin, nếu bản ghi này không phai công nghệ thông tin thì sẽ bị xóa ở bảng ngành CNTT", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                            {
                                bll.EditNganh(sv);
                                tbsinhvien bv = new tbsinhvien();
                                bv.manganhh = int.Parse(manganhs.Text);
                                bll.DeleteNganhcntt(bv);
                            }
                        }
                    }

                    if(sv.makhoaa != 114)
                    {
                        string sql = "select * from nganhdulich where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count > 0)
                        {
                            if(MessageBox.Show("Bạn đang sửa lại bản ghi khác ngành du lịch, nếu tiếp tục sửa bản ghi này sẽ bị xóa khởi bảng ngành du lịch", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bll.EditNganh(sv);
                                tbsinhvien cv = new tbsinhvien();
                                cv.manganhh = int.Parse(manganhs.Text);
                                bll.DeleteNganhdulich(cv);
                            }
                        }
                    }

                    if (sv.makhoaa != 115)
                    {
                        string sql = "select * from nganhluat where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Bạn đang sửa lại bản ghi khác ngành luật, nếu tiếp tục sửa bản ghi này sẽ bị xóa khởi bảng ngành du lịch", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bll.EditNganh(sv);
                                tbsinhvien cv = new tbsinhvien();
                                cv.manganhh = int.Parse(manganhs.Text);
                                bll.DeleteNganhluat(cv);
                            }
                        }
                    }

                    if (sv.makhoaa != 116)
                    {
                        string sql = "select * from nganhQTKD where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            if (MessageBox.Show("Bạn đang sửa lại bản ghi khác ngành quản trị kinh doanh, nếu tiếp tục sửa bản ghi này sẽ bị xóa khởi bảng ngành du lịch", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                bll.EditNganh(sv);
                                tbsinhvien cv = new tbsinhvien();
                                cv.manganhh = int.Parse(manganhs.Text);
                                bll.DeleteNganhqtkd(cv);
                            }
                        }
                    }

                    if (sv.makhoaa == 114)
                    {
                        string sql = "select * from nganhdulich where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if(dt.Rows.Count <= 0)
                        {
                            tbsinhvien cv = new tbsinhvien();
                            cv.manganhh = int.Parse(manganhs.Text);
                            cv.makhoaa = int.Parse(makhoas.Text);
                            cv.tennganh = tennganhs.Text;
                            bll.AddNganhdulich(cv);
                        }
                    }
                    
                    
                    
                    if (sv.makhoaa == 113)
                    {
                        string sql = "Select * from nganhcntt1 where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //int mangangt = int.Parse(manganhs.Text);
                        //if (dt.Rows.Count <= 0)
                        //{
                        if(dt.Rows.Count <= 0)
                        {
                            tbsinhvien bv = new tbsinhvien();
                            bv.manganhh = int.Parse(manganhs.Text);
                            bv.makhoaa = int.Parse(makhoas.Text);
                            bv.tennganh = tennganhs.Text;
                            bll.AddNganhcntt(bv);
                            MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                            
                        //}
                        /*else if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Bản ghi này đã có ở bảng ngành CNTT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }

                    if (sv.makhoaa == 115)
                    {
                        string sql = "Select * from nganhluat where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //int mangangt = int.Parse(manganhs.Text);
                        //if (dt.Rows.Count <= 0)
                        //{
                        if (dt.Rows.Count <= 0)
                        {
                            tbsinhvien bv = new tbsinhvien();
                            bv.manganhh = int.Parse(manganhs.Text);
                            bv.makhoaa = int.Parse(makhoas.Text);
                            bv.tennganh = tennganhs.Text;
                            bll.AddNganhluat(bv);
                            MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        //}
                        /*else if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Bản ghi này đã có ở bảng ngành luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }

                    if (sv.makhoaa == 116)
                    {
                        string sql = "Select * from nganhQTKD where manganh = " + manganhs.Text + ";";
                        SqlConnection con = dc.getConnection();
                        da = new SqlDataAdapter(sql, con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        //int mangangt = int.Parse(manganhs.Text);
                        //if (dt.Rows.Count <= 0)
                        //{
                        if (dt.Rows.Count <= 0)
                        {
                            tbsinhvien bv = new tbsinhvien();
                            bv.manganhh = int.Parse(manganhs.Text);
                            bv.makhoaa = int.Parse(makhoas.Text);
                            bv.tennganh = tennganhs.Text;
                            bll.AddNganhqtkd(bv);
                            MessageBox.Show("Thêm bản ghi mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        //}
                        /*else if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Bản ghi này đã có ở bảng ngành quản trị kinh doanh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }
                    showAllNganh();
                }
                    
                else
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.manganhtt = id;
                sv.makhoaa = int.Parse(makhoas.Text);
                //sv.manganhh = int.Parse(manganhs.Text);

                if (bll.DeleteNganh(sv))
                {
                    if(sv.makhoaa == 113)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.manganhh = int.Parse(manganhs.Text);
                        bll.DeleteNganhcntt(cv);
                    }
                    if(sv.makhoaa == 114)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.manganhh = int.Parse(manganhs.Text);
                        bll.DeleteNganhdulich(cv);
                    }
                    if (sv.makhoaa == 115)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.manganhh = int.Parse(manganhs.Text);
                        bll.DeleteNganhluat(cv);
                    }
                    if (sv.makhoaa == 116)
                    {
                        tbsinhvien cv = new tbsinhvien();
                        cv.manganhh = int.Parse(manganhs.Text);
                        bll.DeleteNganhqtkd(cv);
                    }
                    showAllNganh();
                }
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.TimkiemNganh(value);
                nganhss.DataSource = dt;
            }
            else
            {
                showAllNganh();
            }
        }
    }
}
