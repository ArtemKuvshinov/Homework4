﻿namespace Homework4.Services.Interfaces
{
    /// <summary>
    /// Интерфейс сервиса для создания сущности.
    /// </summary>
    /// <typeparam name="TDto">DTO.</typeparam>
    /// <typeparam name="TModel">Domain model.</typeparam>
    public interface ICreatable<TDto>
    {
        /// <summary>
        /// Создание сущности.
        /// </summary>
        /// <param name="dto">DTO.</param>
        /// <returns>Идентификатор созданной сущности.</returns>
        TDto Create(TDto dto);
    }
}