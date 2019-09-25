using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAPI.Models;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    public class SUPPLIERController : Controller
    {
        // GET: Supplier
        string Baseurl = "http://localhost:50605/";
        public async Task<ActionResult> Index()
        {

            List<SUPPLIER> SupplierInfo = new List<SUPPLIER>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("api/SUPPLIERS");
                if (res.IsSuccessStatusCode)
                {
                    var SupplierResponse = res.Content.ReadAsStringAsync().Result;
                    SupplierInfo = JsonConvert.DeserializeObject<List<SUPPLIER>>(SupplierResponse);
                }
                return View(SupplierInfo);
            }
        }
        public async Task<ActionResult> EditSupplier(string Id)
        {
            SUPPLIER SupplierInfo = new SUPPLIER();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/SUPPLIERS/" + Id);
                if (Res.IsSuccessStatusCode)
                {
                    var SupplierResponse = Res.Content.ReadAsStringAsync().Result;
                    SupplierInfo = JsonConvert.DeserializeObject<SUPPLIER>(SupplierResponse);
                }
                return View(SupplierInfo);
            }
        }
        public ActionResult CreateSupplier()
        {

            return View();

        }
        [HttpPost]
        [ActionName("CreateSupplier")]
        public async Task<ActionResult> CreateSupplier(SUPPLIER i)
        {
            try
            {
                SUPPLIER Value = new SUPPLIER();
                if (ModelState.IsValid)
                {
                    TryUpdateModel(Value);
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(Baseurl);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var myContent = JsonConvert.SerializeObject(Value);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                        ByteArrayContent byteContent = new ByteArrayContent(buffer);
                        HttpResponseMessage Res = await client.PostAsJsonAsync<SUPPLIER>("api/SUPPLIERS/", Value);
                        SUPPLIER SupplierInfo = new SUPPLIER();
                        if (Res.IsSuccessStatusCode)
                        {
                            var SupplierResponse = Res.Content.ReadAsStringAsync().Result;
                            SupplierInfo = JsonConvert.DeserializeObject<SUPPLIER>(SupplierResponse);
                            return RedirectToAction("Index");
                        }
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return View();
        }
        [HttpPost]
        [ActionName("EditSupplier")]
        public async Task<ActionResult> EditSupplier_Post(SUPPLIER i)
        {
            try
            {
                SUPPLIER Value = new SUPPLIER();
                if (ModelState.IsValid)
                {
                    TryUpdateModel(Value);
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(Baseurl);
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var myContent = JsonConvert.SerializeObject(Value);
                        var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                        ByteArrayContent byteContent = new ByteArrayContent(buffer);
                        HttpResponseMessage Res = await client.PutAsJsonAsync<SUPPLIER>("api/SUPPLIERs/" + Value.SUPLNO, Value);                        

                        SUPPLIER SupplierInfo = new SUPPLIER();
                        if (Res.IsSuccessStatusCode)
                        {
                            var SupplierResponse = Res.Content.ReadAsStringAsync().Result;
                            SupplierInfo = JsonConvert.DeserializeObject<SUPPLIER>(SupplierResponse);
                            return RedirectToAction("Index");
                        }
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

            return View();
        }
        public async Task<ActionResult> DetailsSupplier(string Id)
        {
            SUPPLIER SupplierInfo = new SUPPLIER();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/SUPPLIERs/" + Id);

                if (Res.IsSuccessStatusCode)
                {
                    var SupplierResponse = Res.Content.ReadAsStringAsync().Result;
                    SupplierInfo = JsonConvert.DeserializeObject<SUPPLIER>(SupplierResponse);
                }
                return View(SupplierInfo);
            }
        }

        public async Task<ActionResult> DeleteSupplier(string Id)
        {
            SUPPLIER SupplierInfo = new SUPPLIER();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.DeleteAsync("api/SUPPLIERs/" + Id);
                return RedirectToAction("Index");
            }

        }
        public async Task<ActionResult> ViewSuppliers()
        {
            List<SUPPLIER> SupplierInfo = new List<SUPPLIER>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/SUPPLIER/Get");
                if (Res.IsSuccessStatusCode)
                {
                    var SupplierResponse = Res.Content.ReadAsStringAsync().Result;
                    SupplierInfo = JsonConvert.DeserializeObject<List<SUPPLIER>>(SupplierResponse);
                }
                return View(SupplierInfo);
            }
        }
    }
}