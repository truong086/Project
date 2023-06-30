using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAITAPLONS
{
    public partial class guiemail : Form
    {
        string matutt = "", tk = "", mk = "", capquyen = "";
        Attachment attach = null;
        public guiemail(string matutt, string tk, string mk, string capquyen)
        {
            InitializeComponent();
            this.matutt = matutt;
            this.tk = tk;
            this.mk = mk;
            this.capquyen = capquyen;
        }

        private void guiemail_Load(object sender, EventArgs e)
        {
            file.BackColor = Color.Orange;
            gui.BackColor = Color.Orange;
            danhsachemail.BackColor = Color.Orange;
        }

        /// <summary>
        /// Gửi email theo các thông tin chuyền vào
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        /// <param name="file"></param>
        void guiEmail(string from, string to, string tieude, string message, Attachment file = null) // "Attachment file" là gửi file đính kèm, nếu có file đính kèm theo thì hệ thống sẽ gửi thêm, còn nếu không có file đính kèm thì hệ thống sẽ không gửi
        {
            MailMessage mess = new MailMessage(from, to, tieude, message); // Đây là hàm gửi thông điệp email, chuyền vào các tham số là: Người gửi(from), người nhận(to), tiêu đề email(tieude), Nội dung email(message)
            if(attach != null) // Nếu mà đường dẫn file tồn tại thì thêm đường dẫn file này vào thông báo được gửi đi
            {
                mess.Attachments.Add(attach); // Thêm đường dẫn file vào thông báo để gửi đi
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Đây là 1 thông tin, hàm này sẽ giúp chúng ta gửi email
            // hàm này sẽ chuyền vào 2 tham số là: đầu tiên là địa chỉ server name của gmail là "smtp.gmail.com", và port của gmail là: "587", muốn gửi ở định dạng khác thì phải thay: smtp của định dạng đó vào, và thay port của định dạng đó

            // Sét thêm các thuộc tính
            client.EnableSsl = true;

            // Khai báo tài khoản người gửi email để gửi email đi
            client.Credentials = new NetworkCredential(tentaikhoan.Text, matkhau.Text); // Hàm này lấy ra tên tài khoản và mật khẩu của tài khoản gửi email
            // Gửi email đi
            client.Send(mess);
        }

        // Hàm kiểm tra email có hợp lệ không
        public bool kiemtraEmaivaSDT(string email)
        {
            var r = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            return !string.IsNullOrEmpty(email) && r.IsMatch(email);
        }

        public bool checkData()
        {
            if (!kiemtraEmaivaSDT(tentaikhoan.Text))
            {
                MessageBox.Show("Bạn nhập sai emai vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tentaikhoan.Focus();
                return false;
            }
            return true;
        }

        private void gui_Click(object sender, EventArgs e)
        {
            // Đưa câu lệnh gửi email vào hàm "Thread" để xử lý, để khi người dùng ấn gửi email thì sẽ không bị đứng chương trình
            Thread th = new Thread(() =>
            {
                attach = null;
                try
                {
                    // Mở địa chỉ file lên theo đường dẫn(dùng hàm "FileInfo()") và hiển thị lên ô textbox
                    // Nếu mở được file này thì bắt đầu gán file vào ô textBox "files.Text"
                    FileInfo file = new FileInfo(files.Text);
                    attach = new Attachment(files.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (checkData())
                {
                    // Mở file "danhsachemail" lên để đọc
                    StreamReader sr = new StreamReader(to.Text); // Khởi tạo hàm mở file, đọc file, chuyền vào đó 1 tham số là ô textBox chứa địa chỉ file là: "to.Text"
                    string email;

                    // Duyệt qua từng email trong file "danhsachemail" và gán vào biến email
                    while ((email = sr.ReadLine()) != null)
                    {
                        // Vòng lặp này sẽ đọc từng dòng(từng tài khoản email) trong file emai "danhsachemail" mỗi lần đọc xong 1 email sẽ gửi luôn thông báo cho email đó, và lặp cho đến khi nào hết email trong file "danhsachemail"
                        guiEmail(tentaikhoan.Text, email, tieude.Text, listbox.Text, attach); // Đổi "to.Text" thành "email" để gửi đc email hàng loạt
                        MessageBox.Show("Gửi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // Khi đã đọc xong file thì phải đóng file lại
                    sr.Close();

                    // Cú pháp để gửi email 1 lần không phải là gửi hàng loạt
                    //guiEmail(tentaikhoan.Text, email, tieude.Text, listbox.Text, attach);
                }

            }
            );
            th.Start();

        }

        private void file_Click(object sender, EventArgs e)
        {
            // Khởi tạo hàm mở gile
            OpenFileDialog dialog = new OpenFileDialog();

            // Khi người dùng ấn mở file và chọn vào nút "OK" thì bắt đầu hiển thị file đó lên ô textbox
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files.Text = dialog.FileName;
            }
        }

        private void danhsachemail_Click(object sender, EventArgs e)
        {
            // Khi người dùng bấm vào nút "danh sách file" thì sẽ hiển thị file lên
            OpenFileDialog dialog = new OpenFileDialog(); // Khởi tạo hàm mở file

            // Khi người dùng chọn file xong và ấn vào nút "OK" thì sẽ hiển thị file đó lên ô textBox(to.Text)
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                to.Text = dialog.FileName;
            }
        }
    }
}
