using Exemplo_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;
namespace Exemplo1.Controllers

{

    public class HomeController : Controller

    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)

        {
            _logger = logger;
        }

        /* public IActionResult Index()
        {
            return View();
        }*/

        public String Index()

        {
            return "olala";
        }

        /*//localhost:5220/home/index2/sara*/

        [Route("olala/{p1}")]
        public String index2(String p1)

        {
            String x = "olalax2 ";
            return x + p1;
        }


        [Route("segundafeira/{p2}")]
        public String segundafeira(String p2)
        {
            String x = "segundafeira ";
            return x + p2;
        }

        [Route("Peru/{umdolita}")]
        public String PeruRecheado(String umdolita)
        {
            return "Eu gosto de peru recheado. "
                + umdolita + " pareces um peru";
        }

        [Route("bacalhau")]
        public String BacalhauAssado()
        {
            return "Eu gosto de bacalhau assado.";
        }

        [Route("sushi")]
        public String Sashimi()
        {
            return "Eu amo Sushi.";
        }

        [Route("vezes10/{id}/{ee}/{tt}")]
        public String Vezes10(int id, int ee, int tt)
        {
            /*Outra forma de converter int p string:
             * int p = id * 10;
             * String texto = p.ToString();
             * return texto;*/

            return (id * 10).ToString();
        }

        [Route("soma/{id}")]
        public String Soma10(int id)
        {
            return (id + 10).ToString();
        }

        public String DizOla(String entremeada)
        {
            return "Ola " + entremeada;
        }

        [Route("dizola2/{id}")]
        public String DizOla2(int id)
        {
            if (id == 1)
                return "Ola 1";
            else if (id == 2)
                return "Ola 2 ";
            else if (id == 3)
                return "Ola 3 ";
            else if (id == 4)
                return "Ola 4 ";
            else
                return "Ola";

        }

        /*localhost:5220/home/Rotina1ComHTML*/

        public ContentResult Rotina1ComHTML(int id)
        {
            ContentResult c1 = new ContentResult();
            c1.ContentType = "text/html";
            c1.Content = "<h2>sim</h2>";
            return c1;
        }

        public ContentResult Rotina2ComHTML(int id)
        {
            ContentResult c1 = new ContentResult();
            c1.ContentType = "text/html";
            String tabela = "<table border=1 style='background-color:grey'>";
           
            for (int i=0;i<id;i++)
            tabela = tabela + " <tr><td>" + id + " </td></tr>";
            tabela = tabela + "</tr></table>";
            c1.Content = tabela;
            return c1;
        }
        public ContentResult Rotina3ComHTML(String id)
        {
            ContentResult c1 = new ContentResult();
            c1.ContentType = "text/html";
            String paragrafoMaisImagem = "<body style ='background-color:"+id+"'>"
                +"<h1>Imagem gira</h1>" +
                "<img src='/Forest.jpg'>"
                +"</body>";
            c1.Content = paragrafoMaisImagem;
            return c1;
        }

       /* public IActionResult Privacy()
        {
            return View();
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()

        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       */
    }

}

