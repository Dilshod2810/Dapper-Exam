using Dapper;
using Domain.Models;
using Infrastructure.DataContext;
using Infrastructure.StudentParentService;
using Infrastructure.StudentService;

public class StudentParentService : IStudentParentService
{
    
    private readonly DapperContext _context;
    public StudentParentService()
    {
        _context = new DapperContext();
    }
    public List<StudentParent> GetAllStudentParent()
    {
        var sql = $"Select * from studentParents";
        var result = _context.Connection().Query<StudentParent>(sql).ToList();
        return result;
    }

    public StudentParent GetStudentParentById(int id)
    {
        var sql = $"Select * from studentParents where student_parent_id={@id}";
        var result = _context.Connection().QueryFirstOrDefault(sql);
        return result;
    }

    public bool AddStudentParent(StudentParent studentParent)
    {
        var sql = $"insert into studentParents (student_id, parent_id, relationship)" +
                  $"values('{studentParent.Student_id}','{studentParent.Parent_id}','{studentParent.Relationship}')";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }

    public bool UpdateStudentParent(StudentParent studentParent)
    {
        var sql =
            $"update studentParents set student_id='{studentParent.Student_id}',parent_id='{studentParent.Parent_id}',relationship='{studentParent.Relationship}'"; 
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }

    public bool DeleteStudentParent(int id)
    {
        var sql = $"Delete from studentParents where student_parent_id={@id}";
        var result = _context.Connection().Execute(sql);
        return result > 0;
    }
}