using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPLONS
{
    internal class DataConnection 
    {
        string constr;
        public DataConnection()
        {
            // Tạo chuỗi kết nối đến Database
            constr = "Data Source = LAPTOP-D5OKMO3H\\SQLEXPRESS; Initial Catalog=quanlyhocphi11s; Integrated Security=true";
        }
        public SqlConnection getConnection()
        {
            // Lấy chuỗi kết nối
            return new SqlConnection(constr);
        }
    }
}
