namespace Domain.Models;

public class Class
{
    public int Class_Id { get; set; }
    public string Class_Name { get; set; }
    public int Subject_Id { get; set; }
    public int Teacher_Id { get; set; }
    public int Classroom_Id { get; set; }
    public string Section { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}