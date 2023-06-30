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
    public partial class thacmac : Form
    {
        string mataikhoantt = "", tentaikhoans1 = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        public thacmac(string mataikhoantt, string tentaikhoans1, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.mataikhoantt = mataikhoantt;
            this.tentaikhoans1 = tentaikhoans1;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
        }

        public void getAllThacMac()
        {
            tbsinhvien sv = new tbsinhvien();
            sv.msv_idPH = int.Parse(tentaikhoans1);
            DataTable dt = bll.getAllPhanHoi(sv);
            dataGridView1.DataSource = dt;
        }

        private void thacmac_Load(object sender, EventArgs e)
        {
            masvs.Text = tentaikhoans1;
            getAllThacMac();
        }

        int ID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                //if (ID >= index)
                //{
                    ID = Int32.Parse(dataGridView1.Rows[index].Cells["maphanhoiduynhat"].Value.ToString());
                    tentaikhoans.Text = dataGridView1.Rows[index].Cells["tentaikhoan"].Value.ToString();
                    emails.Text = dataGridView1.Rows[index].Cells["email"].Value.ToString();
                    sodienthoais.Text = dataGridView1.Rows[index].Cells["sodienthoai"].Value.ToString();
                    chucvus.Text = dataGridView1.Rows[index].Cells["chucvu"].Value.ToString();
                    noidungs.Text = dataGridView1.Rows[index].Cells["noidung"].Value.ToString();

                //}
                //else
                //{
                    //MessageBox.Show("Không có bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                // ID = Int32.Parse(dataGridView1.Rows[index].Cells["id"].Value.ToString());
                
                
            }
            
        }

        public bool checkData()
        {
            /*if (string.IsNullOrEmpty(masvs.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                masvs.Focus();
                return false;
            }*/
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
            
            // Kiểm tra email xem nhập đúng định dạng không
            if (!checkEmai(emailss.Text))
            {
                MessageBox.Show("Email chưa nhập đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                emailss.Focus();
                return false;
            }
            return true;
        }

        // Hàm kiểm tra định dạng email xem người dùng nhập đúng không
        public bool checkEmai(string email)
        {
            var checkEmail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return !string.IsNullOrEmpty(email) && checkEmail.IsMatch(email) ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                tbsinhvien sv = new tbsinhvien();
                sv.msv_id = int.Parse(tentaikhoans1);
                sv.lop_id = int.Parse(lops.Text);
                sv.khoahocTM = khoahocs.Text;
                sv.emailTM = emailss.Text;
                sv.sodienthoai = stds.Text;
                sv.diachiTM = diachis.Text;
                sv.noidung = nds.Text;
                sv.trangthaiTM = "Chưa duyệt";
                if (bll.AddThacMac(sv))
                    MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            }
        }
    }
}
