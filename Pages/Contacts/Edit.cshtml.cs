using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManager.Data;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager.Pages.Contacts
{
    public class EditModel(ContactService contactService) : PageModel
    {
        private readonly ContactService _contactService = contactService;

        [BindProperty]
        public required Contact Contact { get; set; }

        public IActionResult OnGet(int id)
        {
            Contact = _contactService.GetById(id);

            if (Contact == null)
                return NotFound();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _contactService.Update(Contact);

            return RedirectToPage("Index");
        }
    }
}