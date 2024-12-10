using Domain.Models;

namespace Infrastructure.SubjectService;

public interface ISubjectService
{
    List<Subject>  GetAllSubject();
    Subject? GetSubjectById(int id);
    bool AddSubject(Subject subject);
    bool UpdateSubject(Subject subject);
    bool DeleteSubject(int id);
}