using Microsoft.AspNetCore.Mvc.RazorPages;
using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using ContactManager.Services;
using Microsoft.AspNetCore.Authorization;

namespace ContactManager.Pages.Contacts
{

    [AllowAnonymous]
    public class IndexModel(ContactService contactService) : PageModel
    {
        private readonly ContactService _contactService = contactService;

        public List<Contact> Contacts { get; set; } = [];
        public int NumContacts { get; set; } = 0;

        public void OnGet()
        {
            Contacts = [.. _contactService.GetCurrentContacts().Where(c => !c.IsDeleted)];
            NumContacts = Contacts.Count;
        }

        public IActionResult OnPostDelete(int id)
        {
            _contactService.SoftDelete(id);
            return RedirectToPage();
        }
    }
}