using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ITEMController : Controller
    {
        // GET: Item
        string Baseurl = "http://localhost:50605/";
        public async Task<ActionResult> Index()
        {
            
            List<ITEM> ItemInfo = new List<ITEM>();
            using (var client = new HttpClient())
            {                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                
                HttpResponseMessage res = await client.GetAsync("api/ITEMS");                
                if (res.IsSuccessStatusCode)
                {                     
                    var ItemResponse = res.Content.ReadAsStringAsync().Result;                    
                    ItemInfo = JsonConvert.DeserializeObject<List<ITEM>>(ItemResponse);
                }                
                return View(ItemInfo);
            }
        }
        public async Task<ActionResult> EditItem(string Id)
        {
            ITEM ItemInfo = new ITEM();
            using (var client = new HttpClient())
            {
                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                
                HttpResponseMessage Res = await client.GetAsync("api/ITEMS/" + Id);                 
                if (Res.IsSuccessStatusCode)
                {                      
                    var ItemResponse = Res.Content.ReadAsStringAsync().Result;                    
                    ItemInfo = JsonConvert.DeserializeObject<ITEM>(ItemResponse);
                }               
                return View(ItemInfo);
            }
        }
        public ActionResult CreateItem()
        {
             
            return View();

        }
        [HttpPost]
        [ActionName("CreateItem")]
        public async Task<ActionResult> CreateItem(ITEM i)
        {
            try
            {
                ITEM Value = new ITEM();
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
                        HttpResponseMessage Res = await client.PostAsJsonAsync<ITEM>("api/ITEMS/", Value);                         
                        ITEM ItemInfo = new ITEM();
                        if (Res.IsSuccessStatusCode)
                        {                               
                            var ItemResponse = Res.Content.ReadAsStringAsync().Result;                             
                            ItemInfo = JsonConvert.DeserializeObject<ITEM>(ItemResponse);
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
        [ActionName("EditItem")]
        public async Task<ActionResult> EditItem_Post(ITEM i)
        {
            try
            {
                ITEM Value = new ITEM();
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
                        HttpResponseMessage Res = await client.PutAsJsonAsync<ITEM>("api/ITEMs/" + Value.ITCODE, Value);
                        //HttpResponseMessage Res = await client.PutAsJsonAsync<ITEM>()

                        ITEM ItemInfo = new ITEM();
                        if (Res.IsSuccessStatusCode)
                        {                             
                            var ItemResponse = Res.Content.ReadAsStringAsync().Result;                             
                            ItemInfo = JsonConvert.DeserializeObject<ITEM>(ItemResponse);
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
        public async Task<ActionResult> DetailsItem(string Id)
        {
            ITEM ItemInfo = new ITEM();
            using (var client = new HttpClient())
            {                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));               
                HttpResponseMessage Res = await client.GetAsync("api/ITEMs/" + Id);
                
                if (Res.IsSuccessStatusCode)
                {                      
                    var ItemResponse = Res.Content.ReadAsStringAsync().Result;                    
                    ItemInfo = JsonConvert.DeserializeObject<ITEM>(ItemResponse);
                }                
                return View(ItemInfo);
            }
        }

        public async Task<ActionResult> DeleteItem(string Id)
        {
            ITEM ItemInfo = new ITEM();
            using (var client = new HttpClient())
            {                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                  
                HttpResponseMessage Res = await client.DeleteAsync("api/ITEMs/" + Id);               
                return RedirectToAction("Index");
            }

        }
        public async Task<ActionResult> ViewItems()
        {
            List<ITEM> ItemInfo = new List<ITEM>();
            
            using (var client = new HttpClient())
            {                
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();                 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));               
                HttpResponseMessage Res = await client.GetAsync("api/ITEM/Get");                 
                if (Res.IsSuccessStatusCode)
                {                     
                    var ItemResponse = Res.Content.ReadAsStringAsync().Result;                    
                    ItemInfo = JsonConvert.DeserializeObject<List<ITEM>>(ItemResponse);
                }              
                return View(ItemInfo);
            }
        }
    }
}