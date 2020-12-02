using AutoMapper;
using Homework4.DAL.Domain;
using Homework4.Models.DTO;

namespace Homework4.Repositories.Mapping
{
    /// <summary>
    /// Профиль маппинга (Застройщик).
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<ConstructionCompany, ConstructionCompanyDTO>().ReverseMap();
        }
    }
}
