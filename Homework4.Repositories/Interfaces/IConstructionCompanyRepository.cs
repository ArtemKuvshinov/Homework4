using Homework4.DAL.Domain;
using Homework4.Models.DTO;
using Homework4.Repositories.Interfaces.CRUD;

namespace Homework4.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для с объектами Застройщик.
    /// </summary>
   public interface IConstructionCompanyRepository : ICrudRepository<ConstructionCompanyDTO, ConstructionCompany>
    {
    }
}
