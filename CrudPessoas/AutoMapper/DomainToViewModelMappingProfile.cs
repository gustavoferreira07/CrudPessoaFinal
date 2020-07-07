using AutoMapper;
using CrudPessoas.Models;
using CrudPessoas.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudPessoas.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected  override void Configure()
        {
            Mapper.CreateMap<PessoaViewModel, PessoaModel>();
            Mapper.CreateMap<GastoViewModel, GastoModel>();
        }
    }
}