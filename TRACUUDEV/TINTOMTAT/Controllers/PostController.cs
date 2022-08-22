using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TINTOMTAT.Data;
using TINTOMTAT.Data.Entites;
using TINTOMTAT.Models.BaiVietPortalViewModel;
using TINTOMTAT.Models.BaiViets;

namespace TINTOMTAT.Controllers
{
    public class PostController : Controller
    {
        QuangTanDbContext _connect = new QuangTanDbContext();

        public ActionResult Index(string alias = "")
        {
            var baiViet = _connect.BaiViets.FirstOrDefault(x => x.Alias.Contains(alias));
            var baiVietViewModel = new BaiVietDetailViewModel
            {
                Id = baiViet.Id,
                TenBaiViet = baiViet.TenBaiViet,
                Alias = baiViet.Alias,
                NoiDung = baiViet.NoiDung,
                HinhAnh = baiViet.HinhAnh,
                LuotXem = baiViet.LuotXem ?? 0 + baiViet.LuotXemAo ?? 0,
                NgayTao = baiViet.NgayTao

            };

            var postHot = _connect.BaiViets.Where(x => x.DaXoa != true).Take(4).Select(p => new BaiVietViewModel
            {
                Id = p.Id,
                TenBaiViet = p.TenBaiViet,
                Alias = p.Alias,
                LuotXem = p.LuotXem ?? 0 + p.LuotXemAo ?? 0,
                HinhAnh = p.HinhAnh
            }).ToList();

            ViewBag.PostHot = postHot;
            //update lượt xem

            baiViet.LuotXem = baiViet.LuotXem != null ? baiViet.LuotXem += 1 : 0;
            _connect.Entry(baiViet).State = EntityState.Modified;
            _connect.SaveChanges();

            return View(baiVietViewModel);
        }

        [ChildActionOnly]
        public ActionResult GetCommentForPost(long postId = 0)
        {
            var lisCommnets = _connect.BinhLuans.Where(x => x.BaiVietId == postId && x.IsDeleted.Value != true).ToList().OrderByDescending(x => x.CreatedDate);
            ViewBag.BaiVietId = postId;

            if (TempData["ScrollTop"] == null)
            {
                TempData["ScrollTop"] = 0;
            }


            return PartialView(lisCommnets);
        }

        public ActionResult BinhLuan(BinhLuanViewModel model)
        {
            var binhluan = new Comment();
            binhluan.BaiVietId = model.postId;
            binhluan.ThanhVienId = model.thanhVienId;
            binhluan.Comment = model.Comment;
            binhluan.CreatedDate = DateTime.Now;

            _connect.BinhLuans.Add(binhluan);
            _connect.SaveChanges();

            //ViewBag.ScrollTop = model.ScrollTop;
            TempData["ScrollTop"] = model.ScrollTop;
            return Redirect(model.RedirecUrlComt);
        }
    }
}