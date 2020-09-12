using Orion.Sirius.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Shared.Services
{
    public static class ContactService
    {
        public static IEnumerable<Contact> GetContacts()
        {
            try
            {
                var service = new RestService<Contact>(SharedSettings.EndPoint);
                return service.List("contacts");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Contact SaveContact(Contact contact)
        {
            try
            {
                var service = new RestService<Contact>(SharedSettings.EndPoint);
                return service.Post("contacts", contact);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
