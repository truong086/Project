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
    public partial class phieuthu : Form
    {
        string matutt = "", tentaikhoan = "", matkhau = "", capquyen = "";
        sinhvienBLL bll;
        public phieuthu(string matutt , string tentaikhoan, string matkhau, string capquyen)
        {
            InitializeComponent();
            bll = new sinhvienBLL();
            this.matutt = matutt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
        }
        public void showAllPT()
        {
            DataTable dt = bll.getAllPT();
            phieuthuss.DataSource = dt;
        }
        private void phieuthu_Load(object sender, EventArgs e)
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
            if (capquyen != "1" && capquyen != "2")
            {
                add.Hide();
                edit.Hide();
                delete.Hide();
                //mphieuthu.Hide();
                msphieuthu.Hide();
                mhphieuthu.Hide();
                tkphieuthu.Hide();
                nhphieuthu.Hide();
                hkphieuthu.Hide();
                nphieuthu.Hide();
                sphieuthu.Hide();
                htphieuthu.Hide();
                tknhphieuthu.Hide();
                tkntphieuthu.Hide();
                //maphieuthus.Hide();
                msvs.Hide();
                tenphieuthus.Hide();
                mamonhocs.Hide();
                namhocs.Hide();
                hockys.Hide();
                ngaythus.Hide();
                sotiens.Hide();
                hinhthucs.Hide();
                mataikhoannganhangSVs.Hide();
                mataikhoannhantienHPs.Hide();
            }
            if(capquyen == "2")
            {
                edit.Hide();
                delete.Hide();
            }
            showAllPT();
        }

        // Khai báo 1 hàm để kiểm tra xem người dùng đã nhập đầy đủ thông tin chưa
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
        // Phương thức thêm phiếu thu
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại phương thức "checkData", nếu "checkData" trả về true nghĩa là nguwoif dùng đã nhập đầy đủ thông tin rồi thì bắt đầu thêm dữ liệu vào database
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                //sv.maphieuthu = int.Parse(maphieuthus.Text);
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

                // Gọi lại lớp thêm phiếu thu(AddPT) ở lớp bll(sinhvienBLL)
                if (bll.AddPT(sv))
                    showAllPT();


                // Cách 2: Để xóa thông tin sinh viên đã đóng học phí ở bảng sinh viên chưa đóng học phí, from(dadonghocphi)
                /*if (bll.AddPT(sv))
                {
                    tbsinhvien cv = new tbsinhvien();
                    cv.masinhvien = int.Parse(msvs.Text);
                    bll.DeleteSinhVienchdp(cv);
                    showAllPT();
                }*/ 

                else
                    MessageBox.Show("Đã có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        


        int id;
        private void phieuthuss_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex; // Khai báo 1 biến index để lấy ra được dữ liệu vừa click vào
            if(index >= 0)
            {
                id = Int32.Parse(phieuthuss.Rows[index].Cells["maphieuthu"].Value.ToString());
                //maphieuthus.Text = phieuthuss.Rows[index].Cells["maphieuthu"].Value.ToString();
                msvs.Text = phieuthuss.Rows[index].Cells["msv"].Value.ToString();
                mamonhocs.Text = phieuthuss.Rows[index].Cells["mamonhoc"].Value.ToString();
                tenphieuthus.Text = phieuthuss.Rows[index].Cells["tenkhoanthu"].Value.ToString();
                namhocs.Text = phieuthuss.Rows[index].Cells["namhoc"].Value.ToString();
                hockys.Text = phieuthuss.Rows[index].Cells["hocky"].Value.ToString();
                ngaythus.Text = phieuthuss.Rows[index].Cells["ngaythu"].Value.ToString();
                sotiens.Text = phieuthuss.Rows[index].Cells["sotien"].Value.ToString();
                hinhthucs.Text = phieuthuss.Rows[index].Cells["hinhthuc"].Value.ToString();
                mataikhoannganhangSVs.Text = phieuthuss.Rows[index].Cells["mataikhoannganhangSV"].Value.ToString();
                mataikhoannhantienHPs.Text = phieuthuss.Rows[index].Cells["mataikhoannhantienHP"].Value.ToString();

            }
        }

        private void phieuthuss_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkData()) // Gọi lại hàm "checkData" nếu hàm này trả về true nghĩa là đã có đầy đủ thông tin rồi thì bắt đầu thực hienj update dữ liệu vào database
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                // Khởi tạo các trường dữ liệu để update lại dữ liệu vào database
                //sv.mapttt = id;
                sv.maphieuthu = id;
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

                if (bll.EditPT(sv))
                    showAllPT();
                else
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // Hiển thị 1 thông báo hỏi xem người dùng có chắc chắn muốn xóa bản ghi này không, nếu người dùng chọn vào "Yes" thì bắt đầu mới xóa, "DialogResult.Yes" câu này nghĩa là: khi người dùng chọn vào "Yes"
            {
                // Gọi lại lớp "tbsinhvien"
                tbsinhvien sv = new tbsinhvien();
                // Khai báo trường dữ liệu để xóa, nếu muốn xóa dữ liệu thì chỉ cần chuyền 1 tham số vào đó là mã phiếu thu(maphieuthu)
                sv.maphieuthu = id;

                // Khi đã chèn dữ liệu vào trường dữ liệu ở trên rồi thì bắt đầu gọi lại lớp xóa phiếu thu(DeletePT()) ở lớp sinhvienBLL(bll)
                if (bll.DeletePT(sv)) // Nếu xóa thành công thì load lại dữ liệu
                    showAllPT();
                else // Nếu xóa không thành công thì hiển thị thông báo lỗi
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timkiems_TextChanged(object sender, EventArgs e)
        {
            string value = timkiems.Text; // Khởi tạo giá trị cho ô textBox "timkiems" để bắt đầu tìm kiếm
            if (!string.IsNullOrEmpty(value)) // Câu lệnh này nghĩa là: Nếu ô textBox không bị rỗng(nghĩa là có giá trị chuyền vào) thì bắt đầu tìm kiếm
            {
                // Gọi lại lớp DataTable và gọi lại lớp tìm kiếm phiếu thu(TimkiemPT) ở lớp sinhvienBLL(bll)
                DataTable dt = bll.TimkiemPT(value);
                phieuthuss.DataSource = dt;
            }
            else // Khi ô textBox bị rỗng thì phải hiển thị lại tất cả danh sách phiếu thu
            {
                showAllPT();
            }
        }
    }
}
