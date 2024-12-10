namespace Domain.Models;

public class Student
{
    public int Student_Id { get; set; }
    public string  Student_Code { get; set; }
    public string  Stdudent_Full_Name { get; set; }
    public int  Gender { get; set; }
    public DateTime Dob { get; set; }
    public string  Email { get; set; }
    public string  Phone { get; set; }
    public int School_Id { get; set; }
    public int Stage { get; set; }
    public string Section { get; set; }
    public string Is_Active { get; set; }
    public DateTime Join_Date { get; set; }
    public DateTime Created_At { get; set; }
    public DateTime Updated_At { get; set; }
}