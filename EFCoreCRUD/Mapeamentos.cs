using AutoMapper;

namespace EFCoreCRUD
{
    public class Mapeamentos : Profile
    {
        public Mapeamentos()
        {
            CreateMap<Models.Entidades.Usuario, Models.ViewModels.Usuario>();
            CreateMap<Models.ViewModels.Usuario, Models.Entidades.Usuario>();
        }

    }
}
