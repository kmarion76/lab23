using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab23.Repositories;
using lab23.Models;
using lab23.Data;
using Microsoft.EntityFrameworkCore;
using jdk.nashorn.@internal.objects.annotations;

namespace lab23.Controllers
{
    public class Movie : Controller
    {

        private readonly IMovieRepository _repository;
        public Movie(IMovieRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var results = await _repository.Get();
            return View(results);
        }
        public async Task<IActionResult> Details(int? id)
        {
            var results = await _repository.Get(id.Value);
            return View(results);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(MovieViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await _repository.Create(model);
            return RedirectToAction("Index");
        }
        //public IActionResult SearchResultGenre(MovieViewModel model)
        //{
        //    return View();
        //}
        //public IActionResult SearchResultTitle(MovieViewModel model)
        //{
        //    return View();
        //}
        //public async Task<IActionResult> Index(MovieViewModel model)
        //{
        //    await _repository.Get().Where(x => x.Genre == model.Genre);
        //    return View();

        //}
        //public async Task<IActionResult> Index(MovieViewModel model)
        //{
        //    await _repository.Get().Where(x => x.Title == model.Title);
        //    return View();

        //}
    }
}
