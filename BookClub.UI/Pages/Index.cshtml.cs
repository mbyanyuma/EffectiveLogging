using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookClub_UI.Pages
{
    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> _logger)
        {
            this._logger = _logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("Hiiiiiiiiiii from the home page. lol");
        }
    }
}
