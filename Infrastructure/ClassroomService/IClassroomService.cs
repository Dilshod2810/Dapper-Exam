using Domain.Models;

namespace Infrastructure.ClassroomService;

public interface IClassroomService
{
    List<Classroom>  GetAllClassroom();
    Classroom? GetClassroomById(int id);
    bool AddClassroom(Classroom classroom);
    bool UpdateClassroom(Classroom classroom);
    bool DeleteClassroom(int id); 
}