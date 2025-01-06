using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_FRAMEWORK_4._7.Models;



namespace CRUD_FRAMEWORK_4._7.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            using (Models.DbModel context = new Models.DbModel())
            {


                return View(context.Productos.ToList());
            }

            
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            using (Models.DbModel context = new Models.DbModel())
            {


                return View(context.Productos.Where(x=>x.IdProducto == id).FirstOrDefault());
            }

        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Productos productos)
        {
            try
            {
                using (Models.DbModel context = new Models.DbModel())
                {
                    
                    context.Productos.Add(productos);
                    context.SaveChanges();

                   
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            using (Models.DbModel context = new Models.DbModel())
            {


                return View(context.Productos.Where(x => x.IdProducto == id).FirstOrDefault());
            }

        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Productos productos)
        {
            try
            {
                using (Models.DbModel context = new Models.DbModel())
                {


                   context.Entry(productos).State= EntityState.Modified;
                   context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            using (Models.DbModel context = new Models.DbModel())
            {


                return View(context.Productos.Where(x => x.IdProducto == id).FirstOrDefault());
            }
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (Models.DbModel context = new Models.DbModel())
                {

                    Productos productos = context.Productos.Where(x=>x.IdProducto==id).FirstOrDefault();
                    context.Productos.Remove(productos);
                    context.SaveChanges();
                   
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
