using AutoMapper;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.API.Models
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserModel, UserView>();
            CreateMap<SmartContractModel, SmartContractView>()
                .ForMember(to => to.CompanyView, from => from.MapFrom(f => f.CompanyModel));
            CreateMap<CompanyModel, CompanyView>();
        }
    }
}
