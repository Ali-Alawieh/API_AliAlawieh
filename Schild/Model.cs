using Schild.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;

namespace Schild.DB;

public class LogDB : DbContext
{
    public DbSet<Log> Logs { get; set; }

    public string DbPath { get; }

    public LogDB()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "logs.db");
        Console.WriteLine(DbPath);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

}