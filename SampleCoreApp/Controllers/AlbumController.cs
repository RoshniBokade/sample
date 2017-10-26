using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleCoreApp.Models;

namespace SampleCoreApp.Controllers
{
    public class AlbumController : Controller
    {
        public IActionResult Index()
        {
            MusicStoreContext context = HttpContext.RequestServices.GetService(typeof(SampleCoreApp.Models.MusicStoreContext)) as MusicStoreContext;

            return View(context.GetAllAlbums());
        }
    }
}