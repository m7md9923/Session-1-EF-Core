namespace Demo.Data.Models;

public class Department  // Model, Entity, Domain Model, POCO Class
{
    public int DeptId { get; set; }
    public string Name { get; set; }
    public DateTime DateOfCreation { get; set; }
    public int Serial { get; set; }
}