using AutoMapper;
using depooo.Shared.DTO;
using depooo.Shared.Model;

namespace depooo.Server.Mapper
{
    public class Profiles: Profile
    {
        public Profiles()
        {
            //Source --> Destination

            CreateMap<ProductCreateDTO, Product>();
        }
    }
}
