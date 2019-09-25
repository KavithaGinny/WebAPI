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
    public class PODETAILController : Controller
    {
        // GET: PODETAIL        
        string Baseurl = "http://localhost:50605/";
        public async Task<ActionResult> Index()
        {

            List<PODETAIL> PoDetail = new List<PODETAIL>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("api/PODETAILS");
                if (res.IsSuccessStatusCode)
                {
                    var PoDetailResponse = res.Content.ReadAsStringAsync().Result;
                    PoDetail = JsonConvert.DeserializeObject<List<PODETAIL>>(PoDetailResponse);
                }
                return View(PoDetail);
            }
        }
        public async Task<ActionResult> EditPoDetail(string Id, string itcode)
        {
            PODETAIL PoDetail = new PODETAIL();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/PODETAILS/" + Id +"/"+itcode);
                if (Res.IsSuccessStatusCode)
                {
                    var PoDetailResponse = Res.Content.ReadAsStringAsync().Result;
                    PoDetail = JsonConvert.DeserializeObject<PODETAIL>(PoDetailResponse);
                }
                return View(PoDetail);
            }
        }
        public ActionResult CreatePoDetail()
        {

            return View();

        }
        [HttpPost]
        [ActionName("CreatePoDetail")]
        public async Task<ActionResult> CreatePoDetail(PODETAIL i)
        {
            try
            {
                PODETAIL Value = new PODETAIL();
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
                        HttpResponseMessage Res = await client.PostAsJsonAsync<PODETAIL>("api/PODETAILS/", Value);
                        PODETAIL PoDetail = new PODETAIL();
                        if (Res.IsSuccessStatusCode)
                        {
                            var PoDetailResponse = Res.Content.ReadAsStringAsync().Result;
                            PoDetail = JsonConvert.DeserializeObject<PODETAIL>(PoDetailResponse);
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
        [ActionName("EditPoDetail")]
        public async Task<ActionResult> EditPoDetail_Post(PODETAIL i)
        {
            try
            {
                PODETAIL Value = new PODETAIL();
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
                        HttpResponseMessage Res = await client.PutAsJsonAsync<PODETAIL>("api/PODETAILs/" + i.PONO, i);

                        PODETAIL PoDetail = new PODETAIL();
                        if (Res.IsSuccessStatusCode)
                        {
                            var PoDetailResponse = Res.Content.ReadAsStringAsync().Result;
                            PoDetail = JsonConvert.DeserializeObject<PODETAIL>(PoDetailResponse);
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
        public async Task<ActionResult> DetailsPoDetail(string Id)
        {
            PODETAIL PoDetail = new PODETAIL();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/PODETAILs/" + Id);

                if (Res.IsSuccessStatusCode)
                {
                    var PoDetailResponse = Res.Content.ReadAsStringAsync().Result;
                    PoDetail = JsonConvert.DeserializeObject<PODETAIL>(PoDetailResponse);
                }
                return View(PoDetail);
            }
        }

        public async Task<ActionResult> DeletePoDetail(string Id,string itcode)
        {
            PODETAIL PoDetail = new PODETAIL();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.DeleteAsync("api/PODETAILs/" + Id +"/"+itcode);
                return RedirectToAction("Index");
            }

        }
        public async Task<ActionResult> ViewPoDetails()
        {
            List<PODETAIL> PoDetail = new List<PODETAIL>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/PODETAIL/Get");
                if (Res.IsSuccessStatusCode)
                {
                    var PoDetailResponse = Res.Content.ReadAsStringAsync().Result;
                    PoDetail = JsonConvert.DeserializeObject<List<PODETAIL>>(PoDetailResponse);
                }
                return View(PoDetail);
            }
        }
    }
}