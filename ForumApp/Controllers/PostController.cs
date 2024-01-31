using ForumApp.BuisnessLogic.Contracts;
using ForumApp.BuisnessLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService postService;
        public PostController(IPostService _postService)
        {
            postService = _postService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<PostViewModel> model = await postService.GetAllPostsAsync();

            return View(model);
        }

        [HttpGet]
       public IActionResult Add ()
        {
            var model = new PostViewModel();
                return View(model);
        }

        [HttpPost]
        public async Task <IActionResult> Add(PostViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View (model);
            }

           await postService.AddAsync(model);

            return RedirectToAction(nameof(Index));
        }
    }
}
