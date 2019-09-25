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
    public class POMASTERController : Controller
    {
        // GET: PoMaster
        string Baseurl = "http://localhost:50605/";
        public async Task<ActionResult> Index()
        {

            List<POMASTER> PoMasterInfo = new List<POMASTER>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage res = await client.GetAsync("api/POMASTERs");
                if (res.IsSuccessStatusCode)
                {
                    var PoMasterResponse = res.Content.ReadAsStringAsync().Result;
                    PoMasterInfo = JsonConvert.DeserializeObject<List<POMASTER>>(PoMasterResponse);
                }
                return View(PoMasterInfo);
            }
        }
        public async Task<ActionResult> EditPoMaster(string Id)
        {
            POMASTER PoMasterInfo = new POMASTER();
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/POMASTERs/" + Id);
                if (Res.IsSuccessStatusCode)
                {
                    var PoMasterResponse = Res.Content.ReadAsStringAsync().Result;
                    PoMasterInfo = JsonConvert.DeserializeObject<POMASTER>(PoMasterResponse);
                }
                return View(PoMasterInfo);
            }
        }
        public ActionResult CreatePoMaster()
        {

            return View();

        }
        [HttpPost]
        [ActionName("CreatePoMaster")]
        public async Task<ActionResult> CreatePoMaster(POMASTER i)
        {
            try
            {
                POMASTER Value = new POMASTER();
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
                        HttpResponseMessage Res = await client.PostAsJsonAsync<POMASTER>("api/POMASTERs/", Value);
                        POMASTER PoMasterInfo = new POMASTER();
                        if (Res.IsSuccessStatusCode)
                        {
                            var PoMasterResponse = Res.Content.ReadAsStringAsync().Result;
                            PoMasterInfo = JsonConvert.DeserializeObject<POMASTER>(PoMasterResponse);
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
        [ActionName("EditPoMaster")]
        public async Task<ActionResult> EditPoMaster_Post(POMASTER i)
        {
            try
            {
                POMASTER Value = new POMASTER();
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
                        HttpResponseMessage Res = await client.PutAsJsonAsync<POMASTER>("api/POMASTERs/" + i.PONO, i);

                        POMASTER PoMasterInfo = new POMASTER();
                        if (Res.IsSuccessStatusCode)
                        {
                            var PoMasterResponse = Res.Content.ReadAsStringAsync().Result;
                            PoMasterInfo = JsonConvert.DeserializeObject<POMASTER>(PoMasterResponse);
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
        public async Task<ActionResult> DetailsPoMaster(string Id)
        {
            POMASTER PoMasterInfo = new POMASTER();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/POMASTERs/" + Id);

                if (Res.IsSuccessStatusCode)
                {
                    var PoMasterResponse = Res.Content.ReadAsStringAsync().Result;
                    PoMasterInfo = JsonConvert.DeserializeObject<POMASTER>(PoMasterResponse);
                }
                return View(PoMasterInfo);
            }
        }

        public async Task<ActionResult> DeletePoMaster(string Id)
        {
            POMASTER PoMasterInfo = new POMASTER();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.DeleteAsync("api/POMASTERs/" + Id);
                return RedirectToAction("Index");
            }

        }
        public async Task<ActionResult> ViewPoMasters()
        {
            List<POMASTER> PoMasterInfo = new List<POMASTER>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/POMASTER/Get");
                if (Res.IsSuccessStatusCode)
                {
                    var PoMasterResponse = Res.Content.ReadAsStringAsync().Result;
                    PoMasterInfo = JsonConvert.DeserializeObject<List<POMASTER>>(PoMasterResponse);
                }
                return View(PoMasterInfo);
            }
        }
    }
}