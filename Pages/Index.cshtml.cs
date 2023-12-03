using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab12.Pages;

public class Index : PageModel
{
    public IActionResult OnGet()
    {
        return RedirectToPage("./Records/Index");
    }
}