using PeterWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeterWeb.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        public ActionResult Index()
        {
            petlevdbEntities db = new petlevdbEntities();

            List<InkopslistaViewModel> ivmList = new List<InkopslistaViewModel>();

            try
            {
                List<Inkopslista> inkopslistaList = db.Inkopslista.Select(x => x).ToList<Inkopslista>();

                if (inkopslistaList.Count > 0)
                {
                    ivmList = DbInkListKonvert(inkopslistaList);
                }
            }
            catch (Exception e)
            {
                string msg = e.Message;
                throw;
            }
            return View(ivmList);
        }

        // GET: ToDo/Details/5
        public ActionResult Details(int id)
        {
            //TODO läs från databas med id som select 
            petlevdbEntities db = new petlevdbEntities();
            InkopslistaViewModel ivm;

            try
            {
                Inkopslista inkopslista = db.Inkopslista.SingleOrDefault(x => x.ID == id);

                 ivm = DbInkKonvert(inkopslista);

            }
            catch (Exception)
            {

                throw;
            }
            return View(ivm);
        }

        // GET: ToDo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToDo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ToDo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ToDo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ToDo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Returnera en lista med InkopalistaViewModel från en lista av databas Inkopslista
        /// </summary>
        /// <param name="inkopslistaList">Din databas Inkopslista</param>
        /// <returns></returns>
        private List<InkopslistaViewModel> DbInkListKonvert(List<Inkopslista> inkopslistaList)
        {
            List<InkopslistaViewModel> ivmList = new List<InkopslistaViewModel>();
            try
            {
                if (inkopslistaList.Count > 0)
                {
                    foreach (var item in inkopslistaList)
                    {
                        InkopslistaViewModel ivm = new InkopslistaViewModel();
                        ivm.Antal = item.Antal;
                        ivm.Beskrivning = item.Beskrivning;
                        ivm.Butik = item.Butik;
                        ivm.Create = item.Create;
                        ivm.ID = item.ID;
                        ivm.inkopt = item.inkopt;
                        ivm.Kategori = item.Kategori;
                        ivm.Modified = item.Modified;
                        ivm.Name = item.Name;
                        ivmList.Add(ivm);
                    }
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return ivmList;
        }

        /// <summary>
        /// Returnera en lista med InkopalistaViewModel från en lista av databas Inkopslista
        /// </summary>
        /// <param name="inkopslistaList">Din databas Inkopslista</param>
        /// <returns></returns>
        private InkopslistaViewModel DbInkKonvert(Inkopslista inkopslista)
        {
            InkopslistaViewModel ivm = new InkopslistaViewModel();
            try
            {
                if (inkopslista != null)
                {
                    ivm.Antal = inkopslista.Antal;
                    ivm.Beskrivning = inkopslista.Beskrivning;
                    ivm.Butik = inkopslista.Butik;
                    ivm.Create = inkopslista.Create;
                    ivm.ID = inkopslista.ID;
                    ivm.inkopt = inkopslista.inkopt;
                    ivm.Kategori = inkopslista.Kategori;
                    ivm.Modified = inkopslista.Modified;
                    ivm.Name = inkopslista.Name;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return ivm;
        }
    }
}
