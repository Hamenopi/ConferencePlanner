using System.Threading.Tasks;

public interface IAdminService
{
    Task<bool> AllowAdminUserCreationAsync();
}