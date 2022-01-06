using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;
using RotativeDemo.Models;

namespace RotativeDemo.Controllers
{
    public class ExportController : Controller
    {
        public IActionResult Index()
        {
            return new ViewAsPdf(Invoice.GetOne());
        }
    }
}
