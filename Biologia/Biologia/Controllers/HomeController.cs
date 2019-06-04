using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biologia.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace Biologia.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }
        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Insectos insecto)
        {
            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DefaultConnection"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   string sql = $"Insert Into Registro (Taxa,Morfo,Abun,Frasco,Vegetacion,Metodo,Sustrato,Localida,Longitud,Altitud) Values ('{insecto.Taxa}','{insecto.Morfoespecie}','{insecto.Abundancia}','{insecto.NumFrasco}','{insecto.TipoVegetacion}','{insecto.MetodoColecta}','{insecto.Sustrato}','{insecto.Localidad}','{insecto.Longitud}','{insecto.Altitud}')";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                    }
                    return RedirectToAction("Index");
                }
            }
            else
                return View();
        }
       
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
