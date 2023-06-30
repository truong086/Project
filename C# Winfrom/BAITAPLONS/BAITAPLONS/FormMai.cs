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
    public partial class FormMai : Form
    {
        string matutt = "", tentaikhoan = "", matkhau = "", capquyen = "", masvtt = "", msv = "", madoituong = "", malop = "", hoten = "", ngaysinh = "", diachi = "", gioitinh = "", maloptt = "", malops= "", manganhs1 = "", tenlop = "", GVCNlop = "", khoahoc = "";
        
        public FormMai(string matutt, string tentaikhoan, string matkhau, string capquyen, string masvtt, string msv, string madoituong, string malop, string hoten, string ngaysinh, string diachi, string gioitinh, string maloptt, string malops, string manganhs1, string tenlop, string GVCNlop, string khoahoc)
        {
            InitializeComponent();
            this.matutt = matutt;
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
            this.capquyen = capquyen;
            this.masvtt = masvtt;
            this.msv = msv;
            this.madoituong = madoituong;
            this.malop = malop;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.gioitinh = gioitinh;
            this.maloptt = maloptt;
            this.malops = malops;
            this.manganhs1 = manganhs1;
            this.tenlop = tenlop;
            this.GVCNlop = GVCNlop;
            this.khoahoc = khoahoc;
        }
        private void sinhvien_Click(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                // Tạo khai báo form muốn click chuyển sang
                sinhvien sv = new sinhvien(matutt,tentaikhoan, matkhau, capquyen, masvtt, msv, madoituong, malop, hoten, ngaysinh, diachi, gioitinh, maloptt, malops, manganhs1, tenlop, GVCNlop, khoahoc); // Phải chuyền tham số vào lớp sinh viên thì mới phân quyền được, tham số được chuyền vào ở đây là: tentaikhoan, matkhau, capquyen, đều là các trường dữ liệu trong database "taikhoan"
                // Hiển thị form đó lên
                sv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void gvcn_Click(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                // Tạo khai báo form muốn click chuyển sang
                taikhoannganhangSV tk = new taikhoannganhangSV(matutt, tentaikhoan, matkhau, capquyen);
                // Hiển thị form đó lên
                tk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            dangnhap log = new dangnhap();
            log.ShowDialog();
        }

        private void mucthu_Click(object sender, EventArgs e)
        {
            if(capquyen == "1")
            {
                taikhoannhantien tk = new taikhoannhantien(matutt, tentaikhoan, matkhau, capquyen);
                tk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                taikhoanNT.BackColor = Color.Gray;
            }
            
        }

        private void namhoc_Click(object sender, EventArgs e)
        {
            if (capquyen == "1")
            {
                taikhoan tk = new taikhoan(matutt, tentaikhoan, matkhau, capquyen);
                tk.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(capquyen == "1")
            {
                lichsu lichsu = new lichsu(matutt, tentaikhoan, matkhau, capquyen);
                lichsu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                guiemail guiemail = new guiemail(matutt, tentaikhoan, matkhau, capquyen);
                guiemail.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            thacmac thacmac = new thacmac(matutt, tentaikhoan, matkhau, capquyen);
            thacmac.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                phanhoi phanhoi = new phanhoi(matutt, tentaikhoan, matkhau, capquyen);
                phanhoi.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button1_Click_5(object sender, EventArgs e)
        {
            doimatkhau doimatkhau = new doimatkhau(matutt, tentaikhoan, matkhau, capquyen);
            doimatkhau.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            donghocphi donghocphi = new donghocphi(matutt, tentaikhoan, matkhau, capquyen);
            donghocphi.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (capquyen == "1" || capquyen == "2" || malop == "5" || malop == "6" || malop == "8" || malop == "12")
            {
                sinhvienk15 k15 = new sinhvienk15(matutt, tentaikhoan, matkhau, capquyen);
                k15.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void svk16_Click(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2" || malop == "7" || malop == "9" || malop == "15")
            {
                sinhvienk16 svk16 = new sinhvienk16(matutt, tentaikhoan, matkhau, capquyen);
                svk16.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if(manganhs1 == "123" || manganhs1 == "124" || manganhs1 == "125" || manganhs1 == "126" || capquyen == "1" || capquyen == "2")
            {
                khoacntt nganhcntt = new khoacntt(matutt, tentaikhoan, matkhau, capquyen);
                nganhcntt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(manganhs1 == "128" || manganhs1 == "129" || manganhs1 == "130" || manganhs1 == "131" || capquyen == "1" || capquyen == "2")
            {
                nganhdulich dl = new nganhdulich(matutt, tentaikhoan, matkhau, capquyen);
                dl.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(manganhs1 == "132" || manganhs1 == "133" || manganhs1 == "134" || manganhs1 == "135" || manganhs1 == "138" || capquyen == "1" || capquyen == "2")
            {
                nganhluat luat = new nganhluat(matutt, tentaikhoan, matkhau, capquyen);
                luat.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(manganhs1 == "136" || manganhs1 == "137" || capquyen == "1" || capquyen == "2")
            {
                nganhquantrikinhdoanh qtkd = new nganhquantrikinhdoanh(matutt, tentaikhoan, matkhau, capquyen);
                qtkd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void lop_Click(object sender, EventArgs e)
        {
            lop lp = new lop(matutt, tentaikhoan, matkhau, capquyen);
            lp.ShowDialog();
        }

        private void khoa_Click(object sender, EventArgs e)
        {
            khoa k = new khoa(matutt, tentaikhoan, matkhau, capquyen);
            k.ShowDialog();
        }

        private void nganh_Click(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                nganh ng = new nganh(matutt, tentaikhoan, matkhau, capquyen);
                ng.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capquyen == "1" || capquyen == "2")
            {
                doituong dt = new doituong(matutt, tentaikhoan, matkhau, capquyen);
                dt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (capquyen == "1" || capquyen == "2")
            {
                sinhviendb sv = new sinhviendb(matutt, tentaikhoan, matkhau, capquyen);
                sv.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(malop == "11" || malop == "10" || malop == "1" || malop == "2" || malop == "3" || malop == "4" || capquyen == "1" || capquyen == "2")
            {
                sinhvienk14 k14 = new sinhvienk14(matutt, tentaikhoan, matkhau, capquyen);
                k14.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (capquyen == "1" || capquyen == "2")
            {
                dadonghocphi hp = new dadonghocphi(matutt, tentaikhoan, matkhau, capquyen);
                hp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                sinhvienhocCNTT cntt = new sinhvienhocCNTT(matutt, tentaikhoan, matkhau, capquyen);
                cntt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            monhoc mh = new monhoc(matutt, tentaikhoan, matkhau, capquyen);
            mh.ShowDialog();
        }

        private void FormMai_Load(object sender, EventArgs e)
        {
            if(capquyen == "1")
            {
                quyen.Text = "Admin";
                quyen.ForeColor = Color.Red;
                quyen.BackColor = Color.Yellow;
                ten.Text = "Tên Admin: " + hoten;
                ten.BackColor = Color.Yellow;
                khoahocs.Text = diachi;
                khoahocs.BackColor = Color.Yellow;
                gvcns.Hide();
            }
            if (capquyen == "2")
            {
                quyen.Text = "Quản lý";
                ten.Text = "Họ tên quản lý: " + hoten;
                khoahocs.Text = diachi;
                gvcns.Hide();
            }
            if (capquyen == "3")
            {
                quyen.Text = "Sinh viên";
                ten.Text = "Họ tên sinh viên: " + hoten;
                khoahocs.Text = khoahoc;
                gvcns.Text = "Giáo viên chủ nhiệm lớp: " + GVCNlop;
            }
            /*if (capquyen != "1" && capquyen != "2") // Nếu quyền truy cập không bằng với 1 thì sẽ không cho hiển thị lên các chức năng ở bên dưới
            {
                // Ẩn chức năng phiếu thu
                phieuthu.Hide();
                //TKNH.BackColor = Color.Red;
                TKNH.Hide();
                taikhoan.Hide();
                //taikhoanNT.Hide();
                taikhoanNT.BackColor = Color.Red;
                doituong.Hide();
                svdb.Hide();
                cdhp.Hide();
                svcntt.Hide();
                sinhvien.Hide();
                nganh.Hide();
            }*/

            if (capquyen != "1" && capquyen != "2") // Nếu quyền truy cập không bằng với 1 thì sẽ không cho hiển thị lên các chức năng ở bên dưới
            {
                // Ẩn chức năng phiếu thu
                phieuthu.BackColor = Color.Red;
                //TKNH.BackColor = Color.Red;
                TKNH.BackColor = Color.Red;
                taikhoan.BackColor = Color.Red;
                //taikhoanNT.Hide();
                taikhoanNT.BackColor = Color.Red;
                doituong.BackColor = Color.Red;
                svdb.BackColor = Color.Red;
                cdhp.BackColor = Color.Red;
                svcntt.BackColor = Color.Red;
                sinhvien.BackColor = Color.Red;
                nganh.BackColor = Color.Red;
                lichsu.BackColor = Color.Red;
                email.BackColor = Color.Red;
                phanhoi.BackColor = Color.Red;
            }

            /*if (capquyen == "2")
            {
                //phieuthu.Show();
                taikhoan.Hide();
                taikhoanNT.Hide();
            }*/
            if (capquyen == "2")
            {
                //phieuthu.Show();
                taikhoan.BackColor = Color.Red;
                taikhoanNT.BackColor = Color.Red;
            }
            if (malop == "11" || malop == "10" || malop == "1" || malop == "2" || malop == "3" || malop == "4")
            {
                svk14.Show();
            }
            else
            {
                //svk14.Hide();
                svk14.BackColor = Color.Red;
            }

            if(malop == "5" || malop == "6" || malop == "8" || malop == "12")
            {
                    svk15.Show();
            }
            else if(malop != "5" || malop != "6" || malop != "8" || malop != "12")
            {
                //svk15.Hide();
                svk15.BackColor = Color.Red;
            }
            if (malop == "7" || malop == "9" || malop == "15")
            {
                svk16.Show();
            }
            else if (malop != "7" || malop != "9" || malop != "15")
            {
                //svk16.Hide();
                svk16.BackColor = Color.Red;
            }

            if(manganhs1 == "123" || manganhs1 == "124" || manganhs1 == "125" || manganhs1 == "126")
            {
                nganhcntt.Show();
            }else if(manganhs1 != "123" && manganhs1 != "124" && manganhs1 != "125" && manganhs1 != "126")
            {
                //nganhcntt.Hide();
                nganhcntt.BackColor = Color.Red;
            }

            if (manganhs1 == "128" || manganhs1 == "129" || manganhs1 == "130" || manganhs1 == "131")
            {
                dulichs.Show();
            }
            else if (manganhs1 != "128" && manganhs1 != "129" && manganhs1 != "130" && manganhs1 != "131")
            {
                //dulichs.Hide();
                dulichs.BackColor = Color.Red;
            }
            if (manganhs1 == "132" || manganhs1 == "133" || manganhs1 == "134" || manganhs1 == "135" || manganhs1 == "138")
            {
                luats.Show();
            }
            else if (manganhs1 != "132" && manganhs1 != "133" && manganhs1 != "134" && manganhs1 != "135" && manganhs1 != "138")
            {
                //luats.Hide();
                luats.BackColor = Color.Red;
            }
            if (manganhs1 == "136" || manganhs1 == "137")
            {
                qtkds.Show();
            }
            else if (manganhs1 != "136" && manganhs1 != "137")
            {
                //qtkds.Hide();
                qtkds.BackColor = Color.Red;
            }
            if (tentaikhoan == "12345" && matkhau == "123")
            {
                //svk15.Show();
                svk15.BackColor = Color.Orange;
                //svk16.Show();
                svk16.BackColor = Color.Orange;
                //svk14.Show();
                svk14.BackColor = Color.Orange;
                //nganhcntt.Show();
                nganhcntt.BackColor = Color.Orange;
                //dulichs.Show();
                dulichs.BackColor= Color.Orange;
                //luats.Show();
                luats.BackColor= Color.Orange;
                //qtkds.Show();
                qtkds.BackColor = Color.Orange;
                sinhvien.BackColor = Color.Orange;
                taikhoan.BackColor = Color.Orange;
                TKNH.BackColor = Color.Orange;
                phieuthu.BackColor = Color.Orange;
                taikhoanNT.BackColor = Color.Orange;
                khoa.BackColor = Color.Orange;
                lop.BackColor = Color.Orange;
                nganh.BackColor = Color.Orange;
                doituong.BackColor = Color.Orange;
                monhoc.BackColor = Color.Orange;
                svdb.BackColor = Color.Orange;
                svcntt.BackColor = Color.Orange;
                cdhp.BackColor = Color.Orange;
                lichsu.BackColor = Color.Orange;
                email.BackColor = Color.Orange;
                phanhoi.BackColor = Color.Orange;
                thacmac.BackColor = Color.Orange;
            }
            if (capquyen == "1")
            {
                //phieuthu.Show();
                /*svk15.Show();
                svk16.Show();
                svk14.Show();
                nganhcntt.Show();
                dulichs.Show();
                luats.Show();
                qtkds.Show();*/
                //svk15.Show();
                svk15.BackColor = Color.Orange;
                //svk16.Show();
                svk16.BackColor = Color.Orange;
                //svk14.Show();
                svk14.BackColor = Color.Orange;
                //nganhcntt.Show();
                nganhcntt.BackColor = Color.Orange;
                //dulichs.Show();
                dulichs.BackColor = Color.Orange;
                //luats.Show();
                luats.BackColor = Color.Orange;
                //qtkds.Show();
                qtkds.BackColor = Color.Orange;
                sinhvien.BackColor = Color.Orange;
                taikhoan.BackColor = Color.Orange;
                TKNH.BackColor = Color.Orange;
                phieuthu.BackColor = Color.Orange;
                taikhoanNT.BackColor = Color.Orange;
                khoa.BackColor = Color.Orange;
                lop.BackColor = Color.Orange;
                nganh.BackColor = Color.Orange;
                doituong.BackColor = Color.Orange;
                monhoc.BackColor = Color.Orange;
                svdb.BackColor = Color.Orange;
                svcntt.BackColor = Color.Orange;
                cdhp.BackColor = Color.Orange;
                lichsu.BackColor = Color.Orange;
                email.BackColor = Color.Orange;
                phanhoi.BackColor = Color.Orange;
                thacmac.BackColor = Color.Orange;
            }

            if (capquyen == "2")
            {
                //phieuthu.Show();
                /*svk15.Show();
                svk16.Show();
                svk14.Show();
                nganhcntt.Show();
                dulichs.Show();
                luats.Show();
                qtkds.Show();*/
                //svk15.Show();
                svk15.BackColor = Color.Orange;
                //svk16.Show();
                svk16.BackColor = Color.Orange;
                //svk14.Show();
                svk14.BackColor = Color.Orange;
                //nganhcntt.Show();
                nganhcntt.BackColor = Color.Orange;
                //dulichs.Show();
                dulichs.BackColor = Color.Orange;
                //luats.Show();
                luats.BackColor = Color.Orange;
                //qtkds.Show();
                qtkds.BackColor = Color.Orange;
                sinhvien.BackColor = Color.Orange;
                taikhoan.BackColor = Color.Gray;
                TKNH.BackColor = Color.Orange;
                phieuthu.BackColor = Color.Orange;
                taikhoanNT.BackColor = Color.Gray;
                khoa.BackColor = Color.Orange;
                lop.BackColor = Color.Orange;
                nganh.BackColor = Color.Orange;
                doituong.BackColor = Color.Orange;
                monhoc.BackColor = Color.Orange;
                svdb.BackColor = Color.Orange;
                svcntt.BackColor = Color.Orange;
                cdhp.BackColor = Color.Orange;
                lichsu.BackColor = Color.Gray;
                email.BackColor = Color.Orange;
                phanhoi.BackColor = Color.Orange;
                thacmac.BackColor = Color.Orange;
            }

            donghocphi.ForeColor= Color.Orange;

        }

        private void phieuthu_Click(object sender, EventArgs e)
        {
            if(capquyen == "1" || capquyen == "2")
            {
                // Tạo khai báo from muốn click chuyển sang
                phieuthu pt = new phieuthu(matutt, tentaikhoan, matkhau, capquyen);
                // Hiển thị from đó lên
                pt.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Bạn không có quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
