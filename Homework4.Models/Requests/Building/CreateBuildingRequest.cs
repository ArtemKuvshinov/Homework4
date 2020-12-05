﻿using Homework4.DAL.Domain;
using System.ComponentModel.DataAnnotations;

namespace Homework4.Models.Requests.Building
{
    /// <summary>
    /// Запрос на создание новой записи Здание
    /// </summary>
    public class CreateBuildingRequest
    {
        /// <summary>
        /// Адрес.
        /// </summary>
        [StringLength(200)]
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Количетсво этажей.
        /// </summary>
        [Required]
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Кадастровый номер.
        /// </summary>
        [StringLength(16)]
        [Required]
        public string CadastralNumber { get; set; }

        /// <summary>
        /// Назначение здания
        /// </summary>
        [StringLength(200)]
        public string Purpose { get; set; }
    }
}