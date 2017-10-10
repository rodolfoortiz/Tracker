using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DefinityFirst.PointTracker.MVC.Features.Point
{
    public class PointController : Controller
    {
        private readonly IMediator _mediator;

        public PointController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: Point
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Grid(Index.Query query)
        {
            var model = await _mediator.Send(query);
            int current = 0;
            return Json(
                new
                {
                    total = model.Count,
                    rows = model,
                    current
                });
        }

        // GET: Point/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Point/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Point/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Point/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Point/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Point/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Point/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}