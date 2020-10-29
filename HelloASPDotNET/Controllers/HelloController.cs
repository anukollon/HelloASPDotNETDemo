using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    public class HelloController : Controller
    {
        //[HttpGet]
        //[Route("/helloworld")]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/hello/welcome'>" +
                "<h1 align='center'> Welcome to ASP.Net App! </h1>" +
         "<input type='text' name='name' />" +
         "<select name='language' id='language-select'> " +
         "<option value ='english' selected> English </option>" +
         "<option value = 'french'> French </option>" +
         "<option value = 'german'>German</option>" +
         " <option value ='hindi'>Hindi</option> " +
         "<option value='spanish'>Spanish</option>" +
         "</ select > " +
         "<input type='submit' value='Greet Me!' />" +
         "</form>";

            return Content(html, "text/html");
        }

        // [HttpPost]
        //[Route("/helloworld/welcome")]
        public IActionResult Welcome(string name = "World", string language="English")
        {
            return Content(CreateMessage(name, language), "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string msg = "<h1 align='center' color='blue'>";
            if(language == "english")
            {
                msg += "Welcome " + name;
            } else if(language == "french")
            {
                msg += "Bonjour " + name;
            }
            else if (language == "german")
            {
                msg += "Hallo " + name;
            }
            else if (language == "spanish")
            {
                msg += "Hola " + name;
            }
            else if (language == "hindi")
            {
                msg += "Namaste " + name;
            }
            msg += "</h1>";
            return msg;
        }
    }
}
