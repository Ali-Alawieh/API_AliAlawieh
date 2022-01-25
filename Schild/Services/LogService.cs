using Schild.Models;
using Schild.DB;
using Microsoft.EntityFrameworkCore;

namespace Schild.Services;


public class LogService
{
    private static int nextId = 5;
    LogService()
    {
       
    }


    public static void Add(Log log)
    {
        var db = new LogDB();
        log.Id = nextId++;
        db.Add(log);
        db.SaveChanges();
    }
    
    
}