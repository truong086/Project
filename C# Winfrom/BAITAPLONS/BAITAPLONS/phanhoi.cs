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
    public partial class phanhoi : Form
    {
        string mataikhoantt = "", tentaikhoans1 = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        DataConnection ds;
        SqlDataAdapter da;
        public phanhoi(string mataikhoantt, string tentaikhoans1, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.mataikhoantt = mataikhoantt;
            this.tentaikhoans1 = tentaikhoans1;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
            ds = new DataConnection();
        }

        public bool checkData()
        {
            if (string.IsNullOrEmpty(tentaikhoans.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tentaikhoans.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(emails.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emails.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(sodienthoais.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sodienthoais.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(chucvus.Text))
            {
                MessageBox.Show("Bạn chưa nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chucvus.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(noidungs.Text))
            {
                MessageBox.Show("Bạn chưa nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                noidungs.Focus();
                return false;
            }

            // Kiểm tra xem người dùng nhập đúng định dạng email chưa 
            if (!CheckEmail(emails.Text))
            {
                MessageBox.Show("Bạn chưa nhập đúng định dạng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emails.Focus();
                return false;
            }
            return true;
        }

        public bool checkDataTM()
        {
            if (string.IsNullOrEmpty(masvs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                masvs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(lops.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lops.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(emailss.Text))
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailss.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(khoahocs.Text))
            {
                MessageBox.Show("Bạn chưa nhập khóa học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                khoahocs.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(stds.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stds.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nds.Text))
            {
                MessageBox.Show("Bạn chưa nhập nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nds.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(diachis.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                diachis.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(trangthaiss.Text))
            {
                MessageBox.Show("Bạn chưa nhập trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                trangthaiss.Focus();
                return false;
            }

            // Kiểm tra email xem nhập đúng định dạng không
            if (!CheckEmail(emailss.Text))
            {
                MessageBox.Show("Email chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailss.Focus();
                return false;
            }
            return true;
        }

        public bool CheckEmail(string email)
        {
            var checkEmai = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return !string.IsNullOrEmpty(email) && checkEmai.IsMatch(email);
        }

        public void getAllThacMac()
        {
            DataTable dt = bll.getAllThacMac();
            dataGridView1.DataSource = dt;
            
        }

        private void phanhoi_Load(object sender, EventArgs e)
        {
            string sql = "select maduynhat ,msv_id, lop_id, khoahoc, email, sodienthoai, diachi, noidung, trangthai from thacmac where trangthai = N'Da duyet' or trangthai = N'Đã duyệt' or trangthai = N'đã duyệt' or trangthai = N'da duyet' or trangthai = N'Đã' or trangthai = N'Da' or trangthai = N'duyet' or trangthai = N'Duyet' or trangthai = N'duyệt' or trangthai = N'Duyệt'";
            SqlConnection con = ds.getConnection();
            da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                tbsinhvien bv = new tbsinhvien();
                bv.idTM = int.Parse(dt.Rows[0][0].ToString());
                bv.msv_id = int.Parse(dt.Rows[0][1].ToString());
                bv.lop_id = int.Parse(dt.Rows[0][2].ToString());
                bv.khoahocTM = dt.Rows[0][3].ToString();
                bv.emailTM = dt.Rows[0][4].ToString();
                bv.sodienthoai = dt.Rows[0][5].ToString();
                bv.diachiTM = dt.Rows[0][6].ToString();
                bv.noidung = dt.Rows[0][7].ToString();
                bv.trangthaiTM = dt.Rows[0][8].ToString();
                if(bv.trangthaiTM == "Da duyet" || bv.trangthaiTM == "đã duyệt" || bv.trangthaiTM == "Đã duyệt" || bv.trangthaiTM == "da duyet" || bv.trangthaiTM == "da" || bv.trangthaiTM == "đã" || bv.trangthaiTM == "Da" || bv.trangthaiTM == "Đã" || bv.trangthaiTM == "duyet" || bv.trangthaiTM == "Duyet" || bv.trangthaiTM == "duyệt" || bv.trangthaiTM == "Duyệt")
                {
                    tbsinhvien cv = new tbsinhvien();
                    cv.idTM = int.Parse(dt.Rows[0][0].ToString());
                    bll.DeleteThacMac(bv);
                }
            }
            getAllThacMac();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkDataTM())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.idTM = ID;
                sv.msv_id = int.Parse(masvs.Text);
                sv.lop_id = int.Parse(lops.Text);
                sv.khoahocTM = khoahocs.Text;
                sv.emailTM = emailss.Text;
                sv.sodienthoai = stds.Text;
                sv.diachiTM = diachis.Text;
                sv.noidung = nds.Text;
                sv.trangthaiTM = trangthaiss.Text;
                if (bll.EditThacMac(sv))
                    getAllThacMac();
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int ID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                //string id = ID.ToString(); // Chuyển số sang chuỗi
                //if (ID >= index) // Nếu người dùng click vào dòng nào có dữ liệu thì mới hiển thị dữ liệu lên (nghĩa là "ID" phải lớn hơn hoặc bằng indx(index là lượt click vào bản ghi))
                //{  
                    ID = Int32.Parse(dataGridView1.Rows[index].Cells["maduynhat"].Value.ToString());
                    masvs.Text = dataGridView1.Rows[index].Cells["msv_id"].Value.ToString();
                    lops.Text = dataGridView1.Rows[index].Cells["lop_id"].Value.ToString();
                    khoahocs.Text = dataGridView1.Rows[index].Cells["khoahoc"].Value.ToString();
                    emailss.Text = dataGridView1.Rows[index].Cells["email"].Value.ToString();
                    stds.Text = dataGridView1.Rows[index].Cells["sodienthoai"].Value.ToString();
                    diachis.Text = dataGridView1.Rows[index].Cells["diachi"].Value.ToString();
                    nds.Text = dataGridView1.Rows[index].Cells["noidung"].Value.ToString();
                    trangthaiss.Text = dataGridView1.Rows[index].Cells["trangthai"].Value.ToString();
                //}
                //else // Nếu người dùng click vào dòng không có dữ liệu thì sẽ hiển thị thông báo lỗi
                //{
                    //MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}


            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.tentaikhoanPH = tentaikhoans.Text;
                sv.emailPH = emails.Text;
                sv.sodienthoaiPH = sodienthoais.Text;
                sv.chucvu = chucvus.Text;
                sv.noidungPH = noidungs.Text;
                sv.trangthai = trangthais.Text;
                sv.msv_idPH = int.Parse(manguoinhans.Text);
                if (bll.AddPhanHoi(sv))
                {
                    tbsinhvien bv = new tbsinhvien();
                    bv.idTM = ID;
                    bv.msv_id = int.Parse(masvs.Text);
                    bv.lop_id = int.Parse(lops.Text);
                    bv.khoahocTM = khoahocs.Text;
                    bv.emailTM = emailss.Text;
                    bv.sodienthoai = stds.Text;
                    bv.diachiTM = diachis.Text;
                    bv.noidung = nds.Text;
                    bv.trangthaiTM = trangthais.Text;
                    if (bll.EditThacMac(bv))
                    {
                        getAllThacMac();
                    }
                    MessageBox.Show("Gửi phản hồi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
