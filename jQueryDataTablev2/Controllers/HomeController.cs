using jQueryDataTablev2.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace jQueryDataTablev2.Controllers
{


    public class HomeController : Controller
    {

        DatabaseDataTableEntities2 context = new DatabaseDataTableEntities2();
        // GET: Home

        public ActionResult Index()
        {

            List<Customers1> customer = context.Customers1.ToList();

            return View(customer);
        }




        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Customers1 customer)
        {
            try
            {
                using (DatabaseDataTableEntities2 dbModel = new DatabaseDataTableEntities2())
                {
                    dbModel.Customers1.Add(customer);
                    dbModel.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }

        }



        // GET: Edit
        public ActionResult Edit(int id)
        {
            using (DatabaseDataTableEntities2 dbModel = new DatabaseDataTableEntities2())
            {
                return View(dbModel.Customers1.Where(x => x.CustomerID == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Customers1 customer)
        {
            try
            {
                using (DatabaseDataTableEntities2 dbModel = new DatabaseDataTableEntities2())
                {
                    dbModel.Entry(customer).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }


        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DatabaseDataTableEntities2 dbModels = new DatabaseDataTableEntities2())
            {
                return View(dbModels.Customers1.Where(x => x.CustomerID == id).FirstOrDefault());
            }
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DatabaseDataTableEntities2 dbModel = new DatabaseDataTableEntities2())
                {
                    Customers1 customers = dbModel.Customers1.Where(x => x.CustomerID == id).FirstOrDefault();
                    dbModel.Customers1.Remove(customers);
                    dbModel.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        public ActionResult Details(int id)
        {
            using (DatabaseDataTableEntities2 dbModel = new DatabaseDataTableEntities2())
            {
                return View(dbModel.Customers1.Where(x => x.CustomerID == id).FirstOrDefault());
            }

        }

    }
}