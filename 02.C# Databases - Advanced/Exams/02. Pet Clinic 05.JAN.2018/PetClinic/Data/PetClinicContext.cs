﻿using PetClinic.Data.Configurations;
using PetClinic.Models;

namespace PetClinic.Data
{
    using Microsoft.EntityFrameworkCore;

    public class PetClinicContext : DbContext
    {
        public PetClinicContext() { }

        public PetClinicContext(DbContextOptions options)
            :base(options) { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalAid> AnimalAids { get; set; }
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ProcedureAnimalAid> ProceduresAnimalAids { get; set; }
        public DbSet<Vet> Vets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new AnimalAidConfig())
                .ApplyConfiguration(new AnimalConfig())
                .ApplyConfiguration(new PassportConfig())
                .ApplyConfiguration(new VetConfig())
                .ApplyConfiguration(new ProcedureConfig())
                .ApplyConfiguration(new ProcedureAnimalAidConfig());
        }
    }
}
