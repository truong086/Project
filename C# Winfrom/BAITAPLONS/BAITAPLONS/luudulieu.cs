using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace BAITAPLONS
{
    internal class luudulieu
    {
        tbsinhvien tb;
        sinhvienBLL bll;
        public luudulieu()
        {
            tb = new tbsinhvien();
            bll = new sinhvienBLL();
        }

        public static bool kiemtra(List<tbsinhvien> dssv, DataTable dt, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                foreach (tbsinhvien tb in dssv)
                {
                    string line = tb.masvtt + "-" + tb.masv + "-" + tb.madoituong + "-" + tb.malop + "-" + tb.hoten + "-" + tb.ngaysinh + "-" + tb.diachi + "-" + tb.gioitinh;
                    sw.WriteLine(line);
                }
                sw.Close();
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

            return false;
        }
    }
}
