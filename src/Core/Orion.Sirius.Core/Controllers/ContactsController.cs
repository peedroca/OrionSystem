using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orion.Sirius.Domain.Entities;
using Orion.Sirius.Domain.Interfaces;

namespace Orion.Sirius.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private IContactRepository contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            this.contactRepository = contactRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(contactRepository.GetContacts());
        }

        [HttpPost]
        public IActionResult Post([FromBody] ContactEntity contactEntity)
        {
            contactRepository.SaveContact(contactEntity);
            return Created("api/Contacts", contactEntity);
        }
    }
}
