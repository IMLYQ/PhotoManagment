using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoManagment.Models
{
    public class PhotoDBcontext: DbContext
    {
        public PhotoDBcontext(DbContextOptions<PhotoDBcontext> options) : base(options)
        {

        }  

        public DbSet<photo> photos { get; set; }

        public DbSet<Place> places { get; set; }
    }
}
