using Domain.Models;

namespace Infrastructure.StudentParentService;

public interface IStudentParentService
{
    List<StudentParent>  GetAllStudentParent();
    StudentParent? GetStudentParentById(int id);
    bool AddStudentParent(StudentParent studentParent);
    bool UpdateStudentParent(StudentParent studentParent);
    bool DeleteStudentParent(int id); 
}