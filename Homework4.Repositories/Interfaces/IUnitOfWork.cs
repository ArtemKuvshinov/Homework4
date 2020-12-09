using Homework4.DAL.Contexts;
using Homework4.DAL.Domain;
using Homework4.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Homework4.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для работы с паттерном IUnitOfWork
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        public IBuildingRepository Building { get; }
        public IConstructionCompanyRepository ConstructionCompany { get; }
       
        /// <summary>
        /// Сохранение изменений в БД.
        /// </summary>
        public void Save();

        /// <summary>
        /// Создание транзакции.
        /// </summary>
        public void BeginTrasaction();

        /// <summary>
        /// Коммит внесенных изменений.
        /// </summary>
        public void CommitTrasaction();

        /// <summary>
        /// Откат внесенных изменений.
        /// </summary>
        public void RollBackTrasaction();
    }
}
