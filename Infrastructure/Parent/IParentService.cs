namespace Infrastructure.Parent;

public interface IParentService
{
    List<Domain.Models.Parent>  GetAllParent();
    Domain.Models.Parent? GetParentById(int id);
    bool AddParent(Domain.Models.Parent parent);
    bool UpdateParent(Domain.Models.Parent parent);
    bool DeleteParent(int id);
}