using Domain.Models;

namespace Infrastructure.TeacherService;

public interface ITeacherService
{
    List<Teacher>  GetAllTeacher();
    Teacher? GetTeacherById(int id);
    bool AddTeacher(Teacher teacher);
    bool UpdateTeacher(Teacher teacher);
    bool DeleteTeacher(int id);
}