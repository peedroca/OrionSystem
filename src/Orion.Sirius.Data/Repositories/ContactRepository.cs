using Orion.Sirius.Data.Contexts;
using Orion.Sirius.Domain.Entities;
using Orion.Sirius.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orion.Sirius.Data.Repositories
{
    /// <summary>
    /// Repositório de Contato
    /// </summary>
    public class ContactRepository : IContactRepository
    {
        private SiriusDbContext context;

        public ContactRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        public ContactEntity GetContact(long pk)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactEntity> GetContacts()
        {
            var result = context.Contacts.ToList();
            return result;
        }

        public IEnumerable<ContactEntity> GetContacts(string number)
        {
            return context.Contacts.ToList();
        }

        public void SaveContact(ContactEntity contact)
        {
            if (contact.Code != 0)
                context.Update(contact);
            else
                context.Add(contact);

            context.SaveChanges();
        }
    }
}
