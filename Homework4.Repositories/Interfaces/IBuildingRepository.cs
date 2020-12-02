using Homework4.DAL.Domain;
using Homework4.Models.DTO;
using Homework4.Repositories.Interfaces.CRUD;

namespace Homework4.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с объектами Здание.
    /// </summary>
    public interface IBuildingRepository : ICrudRepository<BuildingDTO, Building>
    {
    }
}
