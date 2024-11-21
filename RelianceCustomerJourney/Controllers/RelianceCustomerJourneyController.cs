using RelianceCustomerJourney.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace RelianceCustomerJourney.Controllers
{
    public class RelianceCustomerJourneyController : Controller
    {
        // GET: RelianceCustomerJourney/PreSrDetails
        private readonly HttpClient _httpClient = new HttpClient();
        public async Task<ActionResult> PreSrDetails(int? SrNo)
        {

            TempData["PreSrNumber"] = SrNo;
            TempData["CustomerName"] = "JAMES V S";
            TempData["PolicyNo"] = "53730240";

            #region APi call

            //HttpResponseMessage response = await _httpClient.GetAsync("your-api-url");

            //if (response.IsSuccessStatusCode)
            //{
            //    // Read the response content as XML
            //    string xmlContent = await response.Content.ReadAsStringAsync();

            //    // Parse XML into XDocument
            //    XDocument xmlDoc = XDocument.Parse(xmlContent);







            //    List<CustomerJourneyData> customerDataList = new List<CustomerJourneyData>();

            //    foreach (var element in xmlDoc.Descendants("Table"))
            //    {
            //        CustomerJourneyData customerData = new CustomerJourneyData
            //        {
            //            ClientId = element.Element("ClientId")?.Value,
            //            CustomerName = element.Element("CustomerName")?.Value,
            //            PolicyNo = element.Element("PolicyNo")?.Value,
            //            UserSapCode = element.Element("UserSapCode")?.Value,
            //            STCode = element.Element("STCode")?.Value,
            //            STName = element.Element("STName")?.Value
            //        };

            //        customerDataList.Add(customerData);
            //    }

            //    // Now you have a list of CustomerData objects
            //    // Do whatever you need with this data
            //}
            //else
            //{
            //    // Handle error response
            //    ModelState.AddModelError(string.Empty, "Failed to fetch data from API.");
            //}





            #endregion

            return RedirectToAction("FreelookupView");
        }

            public ActionResult FreelookupView()
        {
            var CustomerJourneys = new CustomerJourney();
            CustomerJourneys.PreSrNumber = TempData["PreSrNumber"].ToString();
            CustomerJourneys.CustomerName = TempData["CustomerName"].ToString();
            CustomerJourneys.PolicyNo = TempData["PolicyNo"].ToString();
           return View(CustomerJourneys);
        }

        public string data()
        {




            return "";
        
        }
    }
}