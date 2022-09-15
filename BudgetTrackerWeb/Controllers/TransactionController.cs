using BudgetTrackerWeb.Data;
using BudgetTrackerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BudgetTrackerWeb.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TransactionController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Transaction> objTransactionList = _db.Transactions;
            ViewBag.Currencies = _db.Currency;
            return View(objTransactionList);
        }

        //GET
        public IActionResult Create()
        {
            ViewBag.Currencies = _db.Currency;
            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Transaction obj)
        {
            if (obj.Date > DateTime.Now)
            {
                ModelState.AddModelError("Date", "The Date selected is in the future");
            }
            if (ModelState.IsValid)
            {
                _db.Transactions.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Transaction created successfully!";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var transactionFromDb = _db.Transactions.Find(id);
            if (transactionFromDb == null)
            {
                return NotFound();
            }

            ViewBag.Currencies = _db.Currency;
            return View(transactionFromDb);
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Transaction obj)
        {
            if (obj.Date > DateTime.Now)
            {
                ModelState.AddModelError("Date", "The Date selected is in the future");
            }
            if (ModelState.IsValid)
            {
                _db.Transactions.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Transaction updated successfully!";
                return RedirectToAction("Index");
            }
            ViewBag.Currencies = _db.Currency;
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var transactionFromDb = _db.Transactions.Find(id);
            if (transactionFromDb == null)
            {
                return NotFound();
            }

            return View(transactionFromDb);
        }

        //Post
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Transactions.Find(id);
            if (obj == null) {
                return NotFound();
            }

            _db.Transactions.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Transaction removed successfully!";
            return RedirectToAction("Index");
        }
    }
}
