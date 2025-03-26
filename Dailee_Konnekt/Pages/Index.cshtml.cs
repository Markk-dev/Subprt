using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dailee_Konnekt.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public IActionResult OnPost()
        {
            if (Username == "Username" && Password == "123") 
            {
                return RedirectToPage("/Home");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }
        }
    }
}
