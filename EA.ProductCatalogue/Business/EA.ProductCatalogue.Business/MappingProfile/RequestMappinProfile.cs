using AutoMapper;
using EA.ProductCatalogue.Business.DTO.Requests;
using EA.ProductCatalogue.Business.DTO.Responses;
using EA.ProductCatalogue.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.Business.MappingProfile
{
   public class RequestMappinProfile: Profile
    {
        public RequestMappinProfile()
        {
            CreateMap<AddProductRequest, Product>();
            CreateMap<Product, ProductListResponse>().ReverseMap();

        }
    }
}
