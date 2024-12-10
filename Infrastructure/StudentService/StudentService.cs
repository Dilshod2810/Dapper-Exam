using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.StudentService;

public class StudentService
{
    
    private readonly DapperContext _context;
    public StudentService()
    {
        _context = new DapperContext();
    }
    public List<Student> GetAllStudent()
    {
        var sql = $"Select * from students";
        var result = _context.Connection().Query<Student>(sql).ToList();
        return result;
    }

    public Student GetStudentById(int id)
    {
        var sql = $"Select * from students where student_id={@id}";
        var result = _context.Connection().QueryFirstOrDefault(sql);
        return result;
    }

    public bool AddStudent(Student student)
    {
        var sql = $"insert into students (student_code, student_full_name, gender, dob, email, phone, school_id, stage, section, is_active, join_date, created_at, updated_at)" +
                  $"values('{student.Student_Code}','{student.Stdudent_Full_Name}','{student.Gender}','{student.Dob}','{student.Email}','{student.Phone}','{student.School_Id}','{student.Stage}','{student.Created_At}','{student.Updated_At}')";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }

    public bool UpdateStudent(Student student)
    {
        var sql = $"update students set student_code='{student.Student_Code}',student_full_name='{student.Stdudent_Full_Name}',gender='{student.Gender}'," +
                  $"dob='{student.Dob}',email='{student.Email}',phone='{student.Phone}',is_active={student.Is_Active}, join_date={student.School_Id}, created_at={student.Created_At}, updated_at={student.Updated_At} where student_id={student.Student_Id}";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }

    public bool DeleteStudent(int id)
    {
        var sql = $"Delete from students where student_id={@id}";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }


}