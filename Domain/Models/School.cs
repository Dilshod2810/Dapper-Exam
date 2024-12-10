namespace Domain.Models;

public class School
{
    public int School_id { get; set; }
    public string School_title { get; set; }
    public int Level_count { get; set; }
    public int Is_active { get; set; }
    public DateTime Created_at { get; set; }
    public DateTime Updated_at { get; set; }
}