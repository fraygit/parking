using parkSmartly.Common;
using parkSmartly.Data.Model;
using parkSmartly.Data.Repository;
using parkSmartly.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace parkSmartly.Controllers
{
    public class WithdrawController : Controller
    {
        // GET: Withdraw
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Withdraw(decimal amountToWithdraw, string accountNumber)
        {
            try
            {

                var withdrawalService = new WithdrawalService();
                var result = await withdrawalService.Withdraw(amountToWithdraw, accountNumber, User.Identity.Name);
                if (result)
                {
                    return Json(new { success = true, responseText = "Added." }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, responseText = "ewan ko ba" }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                return Json(new { success = false, responseText = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}