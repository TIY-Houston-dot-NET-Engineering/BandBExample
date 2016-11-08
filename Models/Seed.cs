using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public static class Seed
{
    public static void Initialize(DB db, bool canCreate, bool mustMigrate)
    {
        if(canCreate) {
            // db.Database.EnsureDeleted();
            // db.Database.EnsureCreated(); // creating tables womp womp
        }
        if(mustMigrate) db.Database.Migrate();
        
        db.SaveChanges(); 
        Console.WriteLine("----------DB SEEDED-------------");
    }
}