using FashionStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FashionStore.Controllers
{
    public class DanhmucController : Controller
    {
        // GET: Danhmuc
        FashionStoreEntities db = new FashionStoreEntities();
        // GET: Danhmuc
        public ActionResult danhmucpartial()
        {
            var danhmuc = db.LoaiHangs.ToList();
            return PartialView(danhmuc);

        }

    }
}