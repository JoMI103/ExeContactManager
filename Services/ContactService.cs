using ContactManager.Data;
using ContactManager.Models;

namespace ContactManager.Services
{
    public class ContactService(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public List<Contact> GetCurrentContacts()
        {
            return [.. _context.Contacts];
        }

        public void Create(Contact contact)
        {
            contact.IsDeleted = false;

            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }
        public void SoftDelete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return;

            contact.IsDeleted = true;

            _context.SaveChanges();
        }

        public Contact? GetById(int id)
        {
            return _context.Contacts.Find(id);
        }

        public void Update(Contact updatedContact)
        {
            var contact = _context.Contacts.Find(updatedContact.ID);

            if (contact == null)
                return;

            contact.Name = updatedContact.Name;
            contact.Email = updatedContact.Email;
            contact.ContactNumber = updatedContact.ContactNumber;

            _context.SaveChanges();
        }
    }
}