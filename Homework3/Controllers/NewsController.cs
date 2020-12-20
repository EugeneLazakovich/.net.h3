using Homework3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework3.Controllers
{
    public class NewsController : Controller
    {
        private INewsRepository _newsRepository { get; }
        public NewsController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }
        public IActionResult Index()
        {
            ViewBag.News = _newsRepository.GetNews();
            //ViewBag.News = _newsRepository.GetNews().Count;
            return View();
        }
    }
}
