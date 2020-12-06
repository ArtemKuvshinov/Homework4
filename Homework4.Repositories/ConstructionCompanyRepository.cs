using Homework4.DAL.Domain;
using Homework4.Models.DTO;
using Homework4.Repositories.Interfaces;
using AutoMapper;
using Homework4.DAL.Contexts;

namespace Homework4.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями Застройщик.
    /// </summary>
    public class ConstructionCompanyRepository : BaseRepository<ConstructionCompanyDTO, ConstructionCompany>, IConstructionCompanyRepository
    {
        public ConstructionCompanyRepository(Homework4Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
