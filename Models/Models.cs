using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Models;

namespace Models {
    public class BandB : HasId {
        [Required]
        public int Id {get;set;}
        public string Name {get;set;}
        public List<Visitor> Visitors {get;set;}
        public List<Message> Messages {get;set;}
    }

    public class Visitor : HasId {
        [Required]
        public int Id {get;set;}
        public int BandBId {get;set;}
    }

    public class Message : HasId {
        [Required]
        public int Id {get;set;}
        public string Text {get;set;}
        public Visitor Vis {get;set;}
    }
}

// colocate DbSet declarations with classes
public partial class DB : IdentityDbContext<IdentityUser> {
    public DbSet<Models.BandB> BBs { get; set; }
    public DbSet<Models.Visitor> Visitors { get; set; }
    public DbSet<Models.Message> Messages { get; set; }
}

// from ASP.NET Identity
// public class IdentityDbContext<T> : DbContext {
//     public DbSet<T> AspNetUsers {get;set;}
//     public DbSet<...> AspNetRoles {get;set;}
// }

public partial class Handler {
    public void RegisterRepos(IServiceCollection services){
        Repo<BandB>.Register(services, "BBs", dbset => dbset.Include(x => x.Visitors).Include(x => x.Messages));
        // Repo<Visitor>.Register(services, "Visitors");
        // Repo<Message>.Register(services, "Messages");
    }
}