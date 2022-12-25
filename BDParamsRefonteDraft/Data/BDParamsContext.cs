using BDParamsRefonteDraft.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BDParamsRefonteDraft.Data;

public class BDParamsContext : DbContext
{
    public string DBPath {get;}
    public BDParamsContext(DbContextOptions options) : base(options)
    {        
    }
    public DbSet<Parametre> Parametres {get; set;} 
    public DbSet<Modele> Modeles {get; set;} 
    public DbSet<Capteur> Capteurs {get; set;}
     
}
