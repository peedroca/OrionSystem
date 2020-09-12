using AutoMapper;
using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.Sirius.Core.Models
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Costumer, CostumerEntity>().ReverseMap();
        }
    }
}
