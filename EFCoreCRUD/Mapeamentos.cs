using AutoMapper;
using EFCoreCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD
{
    public class Mapeamentos : Profile
    {
        public Mapeamentos()
        {
            CreateMap<Models.Usuario, Models.ViewModels.Usuario>();
            CreateMap<Models.ViewModels.Usuario, Models.Usuario>();
        }

    }
}
