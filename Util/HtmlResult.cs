// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using rpg2.Models;

// namespace vueproj.Util
// {
//     public class HtmlResult : IActionResult
//     {
//         string htmlCode;
//         public HtmlResult(string html)
//         {
//             htmlCode = html;
//         }
//         public async Task ExecuteResultAsync(ActionContext context)
//         {   
//             var response = context.HttpContext.Response;
//             var request = context.HttpContext.Request;
           
//             if (request.Path == "/api/user")
//             {
//                 var responseText = "Некорректные данные";   // содержание сообщения по умолчанию
        
//                 if (request.HasJsonContentType())
//                 {
//                     var userdata = await request.ReadFromJsonAsync<UserData>();
//                     if (userdata != null)
//                         responseText = $"Name: {userdata.inputname}  Age: {userdata.inputemail}";
//                 }
//                 await response.WriteAsJsonAsync(new {text = responseText});
//             }

//             var person = await context.HttpContext.Request.ReadFromJsonAsync<UserData>();

//             await context.HttpContext.Response.WriteAsync("1");
            


            
//         }
//     }

// }