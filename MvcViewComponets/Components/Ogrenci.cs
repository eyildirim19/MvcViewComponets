using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcViewComponets.Components
{
    //[ViewComponent]
    public class Ogrenci : ViewComponent
    {
        // modelimiz...
        string[] array = { "Alper", "Umit", "Emre", "Ahmet", "Recep" };

        public IViewComponentResult Invoke()
        {
            return View(array);
        }
    }
}
