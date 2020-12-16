using Homework4.Models.DTO;
using Homework4.Models.Requests.Building;
using Homework4.Models.Responses.Building;
using AutoMapper;

namespace Homework4.Controllers.Mapping
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Здание".
    /// </summary>
    public class BuildingProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingProfile"/>.
        /// </summary>
        public BuildingProfile()
        {
            CreateMap<CreateBuildingRequest, BuildingDTO>();
            CreateMap<UpdateBuildingRequest, BuildingDTO>();
            CreateMap<BuildingDTO, BuildingResponse>()
                .ForMember(x=>x.ConstructionCompanyName, y => y.MapFrom(prop => prop.ConstructionCompany.Name))
                .ForMember(x => x.ConstructionCompanyEmail, y => y.MapFrom(prop => prop.ConstructionCompany.Email));
        }
    }
}
