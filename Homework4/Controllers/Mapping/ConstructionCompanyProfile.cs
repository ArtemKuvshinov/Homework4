using AutoMapper;
using Homework4.Models.DTO;
using Homework4.Models.Requests.ConstructionCompany;
using Homework4.Models.Responses.ConstructionCompany;

namespace Homework4.Controllers.Mapping
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Застройщик".
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>.
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<CreateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<UpdateConstructionCompanyRequest, ConstructionCompanyDTO>();

            CreateMap<ConstructionCompanyDTO, ConstructionCompanyResponse>();
        }
    }
}
