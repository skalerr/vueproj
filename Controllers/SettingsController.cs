using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rpg2.Data;
using rpg2.Models;
using Newtonsoft.Json;
//using rpg2.Models.UserData;

namespace rpg2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private static List<Settings> settings = new List<Settings>
            {
                new Settings
                {
                   Summ = 1,
                   Day = 1,
                   PercentDay = 1,
                   PercentMonth = 1,
                   PercentYear = 1,
                   Title = "title"
                }
            };

        private readonly DataContext1 _contextt;

        public SettingsController(DataContext1 contextt)
        {
            _contextt = contextt;
        }
        // [HttpGet("Getter")]
        [HttpGet]

        public async Task<ActionResult<List<Settings>>> Get()
        {

            return Ok(await _contextt.Settings.ToListAsync());
        }
        // [HttpPost]
        // public async Task<ActionResult<List<Settings>>> Add(Settings set)
        // {
        //     _contextt.Settings.Add(set);
        //     await _contextt.SaveChangesAsync();
        //     return Ok(await _contextt.Settings.ToListAsync());

        // }
        [HttpPut(Name = "Editor")]
        public async Task<ActionResult<List<Settings>>> UpdateSettings(Settings settings_request)
        {
            var dbsettings = await _contextt.Settings.FindAsync(settings_request.Id);
            if (dbsettings == null)
                return BadRequest("Его не существует");

            dbsettings.Summ = settings_request.Summ;
            dbsettings.Day = settings_request.Day;
            dbsettings.PercentDay = settings_request.PercentDay;
            dbsettings.PercentMonth = settings_request.PercentMonth;
            dbsettings.PercentYear = settings_request.PercentYear;
            dbsettings.Title = settings_request.Title;
            await _contextt.SaveChangesAsync();
            return Ok(await _contextt.Settings.ToListAsync());
        }


        // UserData userdata;
        // string errorString;
        // [HttpPost]
        // [Route("Data")]

        // public async Task ExecuteResultAsync(ActionContext context)
        // {   
        //     var response = context.HttpContext.Response;
        //     var request = context.HttpContext.Request;

        //     if (request.Path == "api/[controller]/Data")
        //     {
        //         var responseText = "Некорректные данные";   // содержание сообщения по умолчанию

        //         if (request.HasJsonContentType())
        //         {
        //             var userdata = await request.ReadFromJsonAsync<UserData>();
        //             if (userdata != null)
        //                 responseText = $"Name: {userdata.inputname}  Age: {userdata.inputemail}";
        //         }
        //         await response.WriteAsJsonAsync(new {text = responseText});
        //     }
        //     // var person = await context.HttpContext.Request.ReadFromJsonAsync<UserData>();
        //     // await context.HttpContext.Response.WriteAsync("1");
        // }
        // IHttpClientFactory _clientFactory;
        // protected override async Task OnInitializedAsync()
        // {
        //     var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5004/api");
        //     var client = _clientFactory.CreateClient();
        //     HttpResponseMessage response = await client.SendAsync(request);


        // }
       
        // public async Task<UserData> CreateAsync(UserData user)
        // {

        //     // var response = context.HttpContext.Response;
        //     // var request = context.HttpContext.Request;
        //     using (var client = new HttpClient())
        //     {

        //         // HttpRequestMessage request = new HttpRequestMessage
        //         // var userdata = await request.Content.ReadFromJsonAsync<UserData>();
        //         client.BaseAddress = new Uri("http://localhost:5004/api");
        //         client.DefaultRequestHeaders.Accept.Clear();
        //         client.DefaultRequestHeaders.Accept.Add(
        //             new MediaTypeWithQualityHeaderValue("application/json"));

        //         HttpResponseMessage response = client.PostAsJsonAsync("http://localhost:5004/api/UserData", user).Result;
        //         // var response = client.GetAsync("/api/user/").Result;
        //         if (response.IsSuccessStatusCode)
        //         {
        //             // return response.Content.ReadFromJsonAsync<UserData>().Result;
        //             return null;
        //         }
        //         else
        //         {
        //             // return new HttpResponseMessage(response,BadRequest);
        //             return null;
        //         }
        //     }
        // }
        // public async Task<UserData> CreateAsync(UserData user)
        // {


        // public async Task<UserData> Getter(UserData user, [FromServices] IHttpClientFactory factory)
        // {
        //     try
        //     {
        //         var client = factory.CreateClient();
        //         client.BaseAddress = new Uri(" http://localhost:5004");
        //         client.DefaultRequestHeaders.Accept.Clear();
        //         client.DefaultRequestHeaders.Accept.Add(
        //             new MediaTypeWithQualityHeaderValue("application/json"));
        //         // var client = new HttpClient {  };
        //         var response = client.PostAsJsonAsync("http://localhost:5004/api/UserData", user).Result;
                
        //     }
        //     catch (Exception ex)
        //     {
        //         string message = ex.Message;
        //     }
            
        // }
        string errorString = "Error send data to backbackend";
        [HttpPost]
        [Route("Data")]
        public async Task<ActionResult> Poster(UserData user, [FromServices] IHttpClientFactory factory)
        {
            try
            {
                var client = factory.CreateClient();
                client.BaseAddress = new Uri("http://localhost:5004");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.PostAsJsonAsync("http://localhost:5004/api/UserData", user).Result;
                response.EnsureSuccessStatusCode();
                //JsonSerializer serializer = new JsonSerializer();
                //serializer.Deserialize(response);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                errorString = ex.Message;   
                return BadRequest(errorString);
            }
            
            ////if (response.IsSuccessStatusCode)
            //    {
            //    // return response.Content.ReadFromJsonAsync<UserData>().Result;

            //    return Ok("Ok");
            //    }
            //    else  
            //    {
                
            //    // return new HttpResponseMessage(response,BadRequest);
            //    return BadRequest("Bad");
            //    }
            
           
        }

            // public async Task LoadData()
            // {
            //     Datas = await context.HttpContext.Request.ReadFromJsonAsync<>;
            // }
            // public string Hello()
            // {
            //     if (request.Path == "/api/user")
            //     {
            //         var responseText = "Некорректные данные";   // содержание сообщения по умолчанию

            //         if (request.HasJsonContentType())
            //         {
            //             var person = await request.ReadFromJsonAsync<Settings>();
            //             if (person != null)
            //                 responseText = $"Name: {person.Name}  Age: {person.Age}";
            //         }
            //         await response.WriteAsJsonAsync(new { text = responseText });
            //     }
            //     return "Hello ASP.NET";
            // }


        [HttpGet]
        [Route("List")]
        public async Task<ActionResult<List<UserData>>> Getter([FromServices] IHttpClientFactory factory)
        {

            try {
                
                var client = factory.CreateClient();
                client.BaseAddress = new Uri("http://localhost:5004");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                // var response = client.PostAsJsonAsync("http://localhost:5004/api/UserData", user).Result;
                // var response = client.GetFromJsonAsync<List<UserData>>("http://localhost:5004/api/UserData").Result;
                var response = client.GetFromJsonAsync<List<UserData>>("http://localhost:5004/api/UserData").Result;

                // response.EnsureSuccessStatusCode();

                return Ok(response);
            }
            catch(Exception ex){
                errorString = ex.Message;
                return BadRequest(errorString);

            }


        }

        }
    // }
}