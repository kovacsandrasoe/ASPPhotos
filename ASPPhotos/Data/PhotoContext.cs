using ASPPhotos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPPhotos.Data
{
    public class PhotoContext : DbContext
    {
        public PhotoContext(DbContextOptions<PhotoContext> opt) : base(opt)
        {

        }

        //milyen táblákat szeretnénk?
        public DbSet<PhotoModel> Photos { get; set; }
    }
}
