using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingsManager.Backend.Model.Activities;
using TrainingsManager.Backend.Model;

namespace TrainingsManager.Backend.EntityFramework.Data
{
    public interface ITrainingsManagerDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }///zeby entity framework wiedzial jakie tabele mam i recordy
        public DbSet<Cycling> Cyclings { get; set; }
        public DbSet<Running> Runnings { get; set; }
        public DbSet<Squatting> Squattings { get; set; }
        public int SaveChanges();

    }
}

