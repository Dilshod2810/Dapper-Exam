using Domain.Models;

namespace Infrastructure.ClassstudentService;

public interface IClassStudentService
{
    List<ClassStudent>  GetAllClassesStudents();
    ClassStudent? getClassStudentById(int id);
    bool AddClassStudent(ClassStudent classStudent);
    bool UpdateClassStudent(ClassStudent classStudent);
    bool DeleteClassStudent(int id); 
}