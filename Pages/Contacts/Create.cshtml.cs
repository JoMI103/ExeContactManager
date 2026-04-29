using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManager.Data;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager.Pages.Contacts
{
    public class CreateModel(ContactService contactService) : PageModel
    {
        private readonly ContactService _contactService = contactService;

        [BindProperty]
        public required Contact Contact { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();


            _contactService.Create(Contact);

            return RedirectToPage("Index");
        }
    }
}