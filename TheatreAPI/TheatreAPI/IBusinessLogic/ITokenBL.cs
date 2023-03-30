using TheatreAPI.Models;

namespace TheatreAPI.IBusinessLogic
{
    public interface ITokenBL
    {
        string CreateToken(User user);
    }
}
