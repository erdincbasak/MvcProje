using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer.Concrete;


namespace MvcProjeKampi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic

        Context _context = new Context();
        public ActionResult Index()
        {
            var totalCategory = _context.Categories.Count(); //Toplam Kategori Sayisi
            ViewBag.totalNumberOfCategories = totalCategory;

            var softwareCategory = _context.Headings.Count(x => x.CategoryID == 18); // Yazilim Kategorisi (18) baslik sayisi
            ViewBag.softwareCategoryTitleNumber = softwareCategory;

            var writerNameSortByA = _context.Writers.Count(x => x.WriterName.Contains("a")); // Yazar adinda "a" harfi gecen yazar sayisi
            ViewBag.writerNameSortByA = writerNameSortByA;

            var categoryNameWithTheMostTitles = _context.Categories.Where(u => u.CategoryID == _context.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count()).Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();// En fazla basliga sahip kategori adi
            ViewBag.categoryNameWithTheMostTitles = categoryNameWithTheMostTitles;




            //var  = _context.Headings.Max(x => x.Category.CategoryName ); 
            //ViewBag.categoryNameWithTheMostTitles = mostTitles;

            var categoryStatusTrue = _context.Categories.Count(x => x.CategoryStatus == true); // Kategoriler tablosundaki aktif kategori sayisi
            ViewBag.activeCategories = categoryStatusTrue;

            return View();
        }
    }
}