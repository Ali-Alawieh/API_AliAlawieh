namespace WebAPIClient2.Models;

public class Log
{   
    public Log(int id, string log)
    {
        Id = id;
        this.log = log;
    }
        
    public int Id { get; set; }
    public string log { get; set; }
}