using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TINTOMTAT.Data;
using TINTOMTAT.Infrastructure;
using TINTOMTAT.Models.ThanhViens;

namespace TINTOMTAT.Controllers
{
    [CustomAuthenticationFilter]
    public class ThanhVienAdminController : Controller
    {
        QuangTanDbContext _connect = new QuangTanDbContext();
        // GET: ThanhVienAdmin
        public ActionResult Index()
        {
            var result = _connect.ThanhViens.Where(x => x.IsDeleted.Value != true).Select(p => new ThanhVienViewModel
            {
                Id = p.Id,
                TenThanhVien = p.TenHienthi,
                Email = p.Email,
                IsDeleted = p.IsDeleted.Value,
                NgayTao = p.CreateDate.Value
            });

            return View(result);
        }
    }
}