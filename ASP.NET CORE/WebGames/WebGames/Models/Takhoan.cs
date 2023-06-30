using System;
using System.Collections.Generic;

namespace WebGames.Models
{
    public partial class Takhoan
    {
        public Takhoan()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Tentaikhoan { get; set; }
        public string? Matkhau { get; set; }
        public string? Fullname { get; set; }
        public string? Email { get; set; }
        public int? Phanquyen { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
