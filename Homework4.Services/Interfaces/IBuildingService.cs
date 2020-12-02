using System.Collections.Generic;
using Homework4.Models.DTO;
using Homework4.DAL.Domain;

namespace Homework4.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание".
    /// </summary>
    public interface IBuildingService : ICrudService<BuildingDTO>
    {
    }
}
