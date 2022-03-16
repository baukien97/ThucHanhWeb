using _1911066543_duykien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace _1911066543_duykien.Controllers
{
    public class RubikController : Controller
    {
        private List<Rubik> listRubik;
        public RubikController()
        {
            listRubik = new List<Rubik>(); 
            listRubik.Add(new Rubik()
            {
                id = 1,
                ten = "Rubik1",
                maloai = "3x3",
                mota=" Best Saller",
                hang = "Rubik VN",
                gia = 90000,
                hinh= "Content/images/rubik1.jpg",
                soluongton = 20
            });
            listRubik.Add(new Rubik()
            {
                id = 2,
                ten = "Rubik2",
                maloai = "3x3",
                mota = " Best Saller",
                hang = "Rubik UK",
                gia= 1000000,
                hinh = "Content/images/rubik2.jpg",
                soluongton = 10
            });
             listRubik.Add(new Rubik()
            {
                id = 3,
                ten = "Rubik3",
                maloai = "3x3",
                mota = " Best Saller",
                hang = "Rubik JP",
                gia = 99999,
                hinh = "Content/images/rubik3.jpg",
                 soluongton = 15
            });

        }
        public ActionResult Index()
        {
            ViewBag.TitlePageName = " Rubik view Page";
            return View(listRubik);
        }
        //detail
        public ActionResult Detail (int ? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Rubik rubik = listRubik.Find(s => s.id == id);
            if (rubik == null)
            {
                return HttpNotFound();

            }
            return View(rubik);
        }

        // edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Rubik book = listRubik.FirstOrDefault(p => p.id == id);
            if (book == null)
                return HttpNotFound();
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rubik rubik)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var editrubik = listRubik.Find(p => p.id == rubik.id);
                    editrubik.ten = rubik.ten;
                    editrubik.maloai = rubik.maloai;
                    editrubik.mota = rubik.mota;
                    editrubik.hang = rubik.hang;
                    editrubik.gia = rubik.gia;
                    editrubik.hinh = rubik.hinh;
                    editrubik.soluongton = rubik.soluongton;
                    return View("Index", listRubik);
                }
                catch (Exception ex)
                {
                    return HttpNotFound();
                }
            }
            else
            {
                ModelState.AddModelError("", "Dữ Liệu Không Hợp Lệ");
                return View(rubik);
            }
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Rubik rubik)
        {
            rubik.id = listRubik.Max(b => b.id) + 1;
            listRubik.Add(rubik);
            return View("Index", listRubik);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Rubik rubik = listRubik.Find(s => s.id == id);
            if (rubik == null)
            {
                return HttpNotFound();
            }
            return View(rubik);
        }
        [HttpPost]
        public ActionResult Delete(Rubik rubik)
        {
            var editRubik = listRubik.Find(b => b.id == rubik.id);
            listRubik.Remove(editRubik);
            return View("Index", listRubik);
        }


    }
}