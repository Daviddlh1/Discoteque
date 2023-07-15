namespace Discoteque.Data.Models;

public class BaseEntity<TID> 
where TID : struct
{
    public TID Id { get; set; }
}