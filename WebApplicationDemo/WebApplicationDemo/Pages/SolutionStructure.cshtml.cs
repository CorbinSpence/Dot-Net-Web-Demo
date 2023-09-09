using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationDemo.Pages
{
    public class SolutionStructureModel : PageModel
    {
        private readonly ILogger<SolutionStructureModel> _logger;

        public SolutionStructureModel(ILogger<SolutionStructureModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
