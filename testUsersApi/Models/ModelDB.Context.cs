﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testUsersApi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UsersModel : DbContext
    {
        public UsersModel()
            : base("name=UsersModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Coordinates> Coordinates { get; set; }
        public virtual DbSet<Dobs> Dobs { get; set; }
        public virtual DbSet<Ids> Ids { get; set; }
        public virtual DbSet<Infoes> Infoes { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Logins> Logins { get; set; }
        public virtual DbSet<Names> Names { get; set; }
        public virtual DbSet<Pictures> Pictures { get; set; }
        public virtual DbSet<Registereds> Registereds { get; set; }
        public virtual DbSet<Results> Results { get; set; }
        public virtual DbSet<Streets> Streets { get; set; }
        public virtual DbSet<Timezones> Timezones { get; set; }
        public virtual DbSet<UsersInfoes> UsersInfoes { get; set; }
    }
}
