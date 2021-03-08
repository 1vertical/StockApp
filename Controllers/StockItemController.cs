using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockApp.Controllers
{
    public class StockItemController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // Shows each item's details
            return View();

            
        }

        // Add items to the stock list
        public IActionResult AddItem()
        {

            return View();
        }

        // Technician changes the state of the item (In for repairs/In Use/In Stock)
        public IActionResult ModifyItemState()
        {
            return View();
            
        }

        //Shows the list of recent owners as well as other details.
        public IActionResult ShowItemDetails(int Id)
        {
            
            return View(Id);
        }
        

        
    }
}
