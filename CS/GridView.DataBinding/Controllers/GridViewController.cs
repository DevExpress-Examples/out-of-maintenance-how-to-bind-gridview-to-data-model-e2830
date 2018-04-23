using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GridView.DataBinding.Models;

namespace GridView.DataBinding.Controllers {
    [HandleError]
    public class GridViewController : Controller {
        public ActionResult Index() {
            return DataBinding();
        }
        public ActionResult DataBinding() {
            return View("DataBinding", NorthwindDataProvider.GetProducts());
        }
        public ActionResult DataBindingPartial() {
            return PartialView("DataBindingPartial", NorthwindDataProvider.GetProducts());
        }
    }
}
