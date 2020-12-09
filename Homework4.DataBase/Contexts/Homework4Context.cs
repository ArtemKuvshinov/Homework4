using Microsoft.EntityFrameworkCore;
using Homework4.DAL.Domain;
using Homework4.DAL.Fluent;

namespace Homework4.DAL.Contexts
{
    /// <summary>
    /// Контекс для работы с БД "Здания".
    /// </summary>
    public class Homework4Context : DbContext
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="Homework4Context"/>.
        /// </summary>
        /// <param name="options">Опции для конфигурации контекста.</param>
        public Homework4Context(DbContextOptions options) : base(options)
        {
           //Database.EnsureDeleted();
           //Database.EnsureCreated();
        }

        /// <summary>
        /// Правила создания сущностей.
        /// </summary>
        /// <param name="builder">Билдер моделей.</param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
             builder.ApplyConfiguration(new BuildingСompositionConfig());
        }

        /// <summary>
        /// Здания.
        /// </summary>
        public DbSet<Building> Buildings { get; set; }

        /// <summary>
        /// Строительные компании.
        /// </summary>
        public DbSet<ConstructionCompany> ConstructionCompanies { get; set; }

        /// <summary>
        /// Материалы.
        /// </summary>
        public DbSet<Material> Materials { get; set; }

        /// <summary>
        /// Маериалы используемые в конкетном здании.
        /// </summary>
        public DbSet<BuildingСomposition> BuildingСompositions { get; set; }

    }
}
