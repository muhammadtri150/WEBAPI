using BelanjaDulu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BelanjaDulu.Controllers
{
    public class BarangController : Controller
    {
        // GET: Barang
        [Route("formBarang")]
        public ActionResult Form()
        {
            if (TempData.Peek("keranjang") == null)
            {
                List<Keranjang> keranjang = new List<Keranjang>();
                TempData.Add("keranjang", keranjang);
            }
            return View("FormBarang");
        }

        [Route("tambah")]
        public ActionResult Tambah(Keranjang brg)
        {
            if (ModelState.IsValid)
            {
            List<Keranjang> keranjang = (List<Keranjang>)TempData.Peek("keranjang");
            keranjang.Add(brg);
            return Redirect("~/KeranjangBelanja");
            }
            return View("FormBarang");
        }

        [Route("KeranjangBelanja")]
        public ActionResult KeranjangBelanja()
        {
            List<Keranjang> keranjang = (List<Keranjang>)TempData.Peek("keranjang");
            return View(keranjang);
        }

        [Route("edit/{id:int?}")]
        public ActionResult EditBarang(int? id)
        {
            List<Keranjang> keranjang = (List<Keranjang>)TempData.Peek("keranjang");
            Keranjang barang = keranjang.Find(e => e.BarangId == id);
            return View(barang);
        }

        [Route("update")]
        public ActionResult Update(Keranjang barang)
        {
            if (ModelState.IsValid)
            {
            List<Keranjang> keranjang = (List<Keranjang>)TempData.Peek("keranjang");
            int index = keranjang.FindIndex(e => e.BarangId == e.BarangId);
            keranjang[index] = barang;
            return Redirect("~/KeranjangBelanja");
            }
            return View("EditBarang");
        }

        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            List<Keranjang> keranjang = (List<Keranjang>)TempData.Peek("keranjang");
            Keranjang barang = keranjang.Find(e => e.BarangId == id);
            keranjang.Remove(barang);
            return Redirect("~/KeranjangBelanja");
        }
    }
}