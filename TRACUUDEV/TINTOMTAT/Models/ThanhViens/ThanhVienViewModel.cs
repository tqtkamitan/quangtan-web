using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TINTOMTAT.Models.ThanhViens
{
    public class ThanhVienViewModel
    {
        public long Id { get; set; }
        public string TenThanhVien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NgayTaoDisplay => NgayTao == null ? "" : NgayTao.Value.ToString("dd/MM/yyyy - HH-mm");
        public string Email { get; set; }
        public bool? IsDeleted { get; set; }
        public string IsDeletedDisplay => IsDeleted == null ? "Đang hoạt động" : (IsDeleted == true ? "Đã xóa" : "Đang hoạt động");
    }
}