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
    public partial class sinhviendb : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        sinhvienBLL bll;
        public sinhviendb(string matutt, string tk, string mk, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tk = tk;
            this.mk = mk;
            this.capquyen = capquyen;
        }

        public void getAllDB()
        {
            DataTable dt = bll.getAllsinhviendb();
            svdb.DataSource = dt;
        }
        private void sinhviendb_Load(object sender, EventArgs e)
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
            getAllDB();
        }

        int id;
        private void svdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                id = Int32.Parse(svdb.Rows[index].Cells["masvtt"].Value.ToString());
                masvs.Text = svdb.Rows[index].Cells["msv"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "masv"
                madoituongs.Text = svdb.Rows[index].Cells["madoituong"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "madoituong"
                malops.Text = svdb.Rows[index].Cells["malop"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "malop"
                hotens.Text = svdb.Rows[index].Cells["hoten"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "hoten"
                ngaysinhs.Text = svdb.Rows[index].Cells["ngaysinh"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "ngaysinh"
                diachis.Text = svdb.Rows[index].Cells["diachi"].Value.ToString(); // Lấy ra từng trường dữ liệu, và chuyển về kiểu "ToString()", lấy ra trường dữ liệu "diachi"
                gioitinhs.Text = svdb.Rows[index].Cells["gioitinh"].Value.ToString();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tbsinhvien sv = new tbsinhvien();
                sv.masv = int.Parse(masvs.Text);

                if (bll.DeleteSinhViendb(sv))
                {
                    tbsinhvien cv = new tbsinhvien();
                    cv.masv = int.Parse(masvs.Text);
                    cv.madoituong = int.Parse(madoituongs.Text);
                    cv.malop = int.Parse(malops.Text);
                    cv.hoten = hotens.Text;
                    cv.ngaysinh = ngaysinhs.Text;
                    cv.diachi = diachis.Text;
                    cv.gioitinh = gioitinhs.Text;
                    cv.id_taikhoan = int.Parse(tk);
                    bll.AddLichsu(cv);
                    bll.DeleteSinhVien(sv);
                    getAllDB();
                }
                    
                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void find_TextChanged(object sender, EventArgs e)
        {
            string value = find.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bll.FindSinhVienkdb(value);
                svdb.DataSource = dt;
            }
            else
            {
                getAllDB();
            }
        }

        private void svdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
