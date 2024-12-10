using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
namespace Infrastructure.TeacherService;

public class TeacherService : ITeacherService
{
    private readonly DapperContext _context;
    public TeacherService()
    {
        _context = new DapperContext();
    }
    public List<Teacher> GetAllTeacher()
    {
        var sql = $"Select * from teachers";
        var result = _context.Connection().Query<Teacher>(sql).ToList();
        return result;
    }

    public Teacher GetTeacherById(int id)
    {
        var sql = $"Select * from teachers where teacher_id={@id}";
        var result = _context.Connection().QueryFirstOrDefault(sql);
        return result;
    }

    public bool AddTeacher(Teacher teacher)
    {
        var sql = $"insert into teachers (teacher_code, teacher_full_name, gender, dob, email, phone, is_active, join_date, working_days, created_at, updated_at)" +
                  $"values('{teacher.Teacher_code}','{teacher.Teacher_full_name}','{teacher.Gender}','{teacher.Dob}','{teacher.Email}','{teacher.Phone}','{teacher.Is_active}','{teacher.Join_date}','{teacher.Working_days}','{teacher.Created_at}','{teacher.Updated_at}')";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }

    public bool UpdateTeacher(Teacher teacher)
    {
        var sql = $"update teachers set teacher_code='{teacher.Teacher_code}',teacher_full_name='{teacher.Teacher_full_name}',gender='{teacher.Gender}'," +
                  $"dob='{teacher.Dob}',email='{teacher.Email}',phone='{teacher.Phone}',is_active={teacher.Is_active}, join_date={teacher.Join_date}, working_days={teacher.Working_days}, created_at={teacher.Created_at}, updated_at={teacher.Updated_at} where teacher_id={teacher.Teacher_id}";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }

    public bool DeleteTeacher(int id)
    {
        var sql = $"Delete from teachers where teacher_id={@id}";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }


}
