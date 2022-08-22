using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TINTOMTAT.Models.BaiViets
{
    public class BinhLuanViewModel
    {
        public long postId { get; set; }
        public long thanhVienId { get; set; }
        public string Comment { get; set; }
        public string RedirecUrlComt { get; set; }
        public int ScrollTop { get; set; }
    }
}