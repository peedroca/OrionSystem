using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface de Contato
    /// </summary>
    public interface IContactRepository
    {
        void SaveContact(ContactEntity contact);

        IEnumerable<ContactEntity> GetContacts();

        IEnumerable<ContactEntity> GetContacts(string number);

        ContactEntity GetContact(long pk);
    }
}
