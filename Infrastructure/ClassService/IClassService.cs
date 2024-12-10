using Domain.Models;

namespace Infrastructure.ClassService;

public interface IClassService
{
    List<Class>  GetAllClasses();
    Class? GetClassById(int id);
    bool AddClass(Class class);
    bool UpdateClass(Class class);
    bool DeleteClass(int id);    
}