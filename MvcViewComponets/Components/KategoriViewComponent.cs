using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcViewComponets.Components
{
    // Component sınıfılarımız Components klasörü içerisinde tanımlanmalıdır..

    // Component dönecek sınıf ViewComponent sınıfından türemelidir...

    // Kategori componentimizin adıdır. KategoriViewComponent olarak yazılır.ViewComponent ekini NameController gibi düşünün..
    public class KategoriViewComponent : ViewComponent
    {
        // component dönecek metodumuzu yazmamlıyız. NOT : metot ismi Invoke olmalıdır...

        // IViewComponentResult => ViewCOmponentResult tipinde interface
        public IViewComponentResult Invoke()
        {
            // c# kodlarımızı yazdık....
            // işimizi bitirdik 
            // componenti dönüyoruz..

            return View();// Bu metot Shared içerisinde Component folderderi içerisinde Sınıf ismi ile eşleşen folder içerisinde Default.cshtml isimli dosya arar...
        }
    }
}
