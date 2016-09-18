using MyInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyInformation.Controllers
{
    public class InformationController : Controller
    {
        //
        // GET: /Information/

        private IMyInfo _myInfo;

        public InformationController()
            : this(new MyInfo())
        { }

        public InformationController(IMyInfo myInfo)
        {
            _myInfo = myInfo;
        }

        public ActionResult Index()
        {
            var model = new MyInfo();
            model.Name = "Chanchal";
            model.Place = "Pune";
            model.ContactNumber = "123456789";
            model.SumOfTwoNumber = _myInfo.GetSum(2, 3);
            return View(model);
        }

    }
}
