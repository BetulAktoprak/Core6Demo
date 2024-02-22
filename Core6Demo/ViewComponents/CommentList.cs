using Microsoft.AspNetCore.Mvc;

namespace Core6Demo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
