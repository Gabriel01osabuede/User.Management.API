namespace User.Management.API.Interface
{
    public interface IUserMGT
    {
        Task<long?> AddUserAsync();
    }
}
