using Microsoft.AspNetCore.Mvc;
using BookStoreProject.Models;
using BookStoreProject.Models.ViewModels;

namespace BookStoreProject.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int pageNum) //DONT name this page 
        {
            int pageSize = 10;
            var blah = new ProjectsListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(blah);
        }

    }
}
