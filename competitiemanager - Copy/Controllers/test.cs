//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using competitiemanager.ViewModels;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;

//namespace competitiemanager.Controllers
//{
//    public class test : Controller
//    {
//        public ActionResult testindex()
//        {
//            var model = new HomeModel
//            {
//                AvailableFruits = GetFruits()
//            };
//            return View(model);
//        }

//        [HttpPost]
//        public ActionResult testindex(HomeModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                var fruits = string.Join(",", model.SelectedFruits);

//                // Save data to database, and redirect to Success page.

//                return RedirectToAction("Success");
//            }
//            model.AvailableFruits = GetFruits();
//            return View(model);
//        }

//        public ActionResult Success()
//        {
//            return View();
//        }

//        private IList<SelectListItem> GetFruits()
//        {
//            return new List<SelectListItem>
//        {
//            new SelectListItem {Text = "Apple", Value = "Apple"},
//            new SelectListItem {Text = "Pear", Value = "Pear"},
//            new SelectListItem {Text = "Banana", Value = "Banana"},
//            new SelectListItem {Text = "Orange", Value = "Orange"},
//        };
//        }
//    }
//}






