using InsuranceCRM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace InsuranceCRM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string searchQuery = Request.Params["Search_Data"];

            Policy resultObj = new Policy();

            if (searchQuery != null && searchQuery != "")
            {
                try
                {
                    resultObj = GetPolicies(int.Parse(searchQuery));
                }
                catch (System.Exception)
                {

                }
                
            }
            return View(resultObj);
        }

        private static Policy GetPolicies(int searchPN)
        {
            List<Policy> customerPolicies = new List<Policy>
            {
                new Policy(91114, "Peter Martin", "1970-08-10", "+44 3069 990585", "Third Party", "2020-01-21", 485,"91114.pdf"),
                new Policy(58761, "Isobel Hartley", "1974-01-29", "+44 3069 990781", "Third Party, Fire and Theft", "2020-06-10", 460,"58761.pdf"),
                new Policy(26581, "Hollie Nicholls", "1981-01-20", "+44 3069 990497", "Comprehensive", "2020-08-05", 440,"26581.pdf"),
                new Policy(22778, "Joseph Arnold", "1984-06-20", "+44 3069 990657", "Comprehensive", "2020-09-15", 500, "22778.pdf"),
                new Policy(83115, "Rosie Hall", "1988-07-18", "+44 3069 990151", "Third Party", "2025-08-05", 475, "83115.pdf")
            };
            return customerPolicies.SingleOrDefault(item => item.PolicyNumber == searchPN);
        }
    }
}