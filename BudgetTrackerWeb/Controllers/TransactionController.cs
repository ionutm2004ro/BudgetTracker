using BudgetTrackerWeb.Data;
using BudgetTrackerWeb.Models;
using Microsoft.AspNetCore.Mvc;

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
            return View(objTransactionList);
        }

        //GET
        public IActionResult Create()
        {

            return View();
        }

        //Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Transaction obj)
        {
            if(ModelState.IsValid)
            {
                _db.Transactions.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
