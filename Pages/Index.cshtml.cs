using Microsoft.AspNetCore.Mvc.RazorPages;
using lab1.Namespace.Model;

namespace lab1.Namespace
{
    public class IndexModel : PageModel
    {
        public int Year { get; set; }

        public void OnGet()
        {
            ViewData["Zodiac"] = "";
        }

        public void OnPost(Utils model)
        {
            ViewData["Zodiac"] = model.GetZodiac();
        }
    }
}
