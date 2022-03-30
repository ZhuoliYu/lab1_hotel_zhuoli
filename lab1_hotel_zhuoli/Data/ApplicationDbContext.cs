#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lab1_hotel_zhuoli;

namespace lab1_hotel_zhuoli.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext(DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public DbSet<lab1_hotel_zhuoli.Models.Client> Client { get; set; }
        public DbSet<lab1_hotel_zhuoli.Models.Room> Room { get; set; }
    }
}