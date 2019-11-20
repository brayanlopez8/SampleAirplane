using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using VuelosApp.DAL.UnitOfWork;

namespace VuelosApp.Aviones
{
    public class AvionesController : Controller
    {
        //private IConfiguration configuration { get; }
        //private UnitOfWork UnitOfWork { get; }
        //public AvionesController(IConfiguration configuration)
        //{
        //    UnitOfWork = new UnitOfWork(configuration);
        //}
        public IActionResult Index()
        {
            return View();
        }

    }
}