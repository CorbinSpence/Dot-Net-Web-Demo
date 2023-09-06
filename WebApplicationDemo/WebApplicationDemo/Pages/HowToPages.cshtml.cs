using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationDemo.Pages
{
    public class HowToPagesModel : PageModel
    {
        private readonly ILogger<HowToPagesModel> _logger;

        public HowToPagesModel(ILogger<HowToPagesModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
