using Domain.Models;

namespace Infrastructure.StudentService;

public interface IStudentService
{
    List<Student>  GetAllStudent();
    Student? GetStudentById(int id);
    bool AddStudent(Student student);
    bool UpdateStudent(Student student);
    bool DeleteStudent(int id); 
}