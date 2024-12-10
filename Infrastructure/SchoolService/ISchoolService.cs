using Domain.Models;

namespace Infrastructure.SchoolService;

public interface ISchoolService
{
    List<School>  GetAllSchool();
    School? GetSchoolroomById(int id);
    bool AddSchool(School school);
    bool UpdateSchool(School school);
    bool DeleteSchool(int id); 
}