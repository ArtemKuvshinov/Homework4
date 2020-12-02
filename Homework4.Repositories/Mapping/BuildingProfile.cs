using AutoMapper;
using Homework4.DAL.Domain;
using Homework4.Models.DTO;

namespace Homework4.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (здание).
    /// </summary>
    public class BuildingProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingProfile"/>
        /// </summary>
        public BuildingProfile()
        {
            CreateMap<Building, BuildingDTO>().ReverseMap();
        }
    }
}
