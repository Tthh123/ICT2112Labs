using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ICT2106WebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
    public string ProjectTeamName = "BOAT";
    public List<string> memberNames = new List<string> {"Desmond", "Felipe",
"Emillia", "Alan"};
}
