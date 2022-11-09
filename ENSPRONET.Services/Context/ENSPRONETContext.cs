using Microsoft.EntityFrameworkCore;
using ENSPRONET.Domains.Domains;
using ENSPRONET.Services.Services.Common.Interfaces;
using ENSPRONET.Services.Services.Country;

namespace ENSPRONET.Services.Context;

public class ENSPRONETContext : DbContext
{
    private readonly ISeederService<Country> seederCountry;
    public string DbPath { get; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<WeatherForecast> WeatherForecast { get; set; }

    public ENSPRONETContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "ENSPRONET.db");

        seederCountry = new CountryService();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite($"Data Source={DbPath}");


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Entity<Country>()
            .HasData(seederCountry.GenerateSeedData(100));
    }
}
