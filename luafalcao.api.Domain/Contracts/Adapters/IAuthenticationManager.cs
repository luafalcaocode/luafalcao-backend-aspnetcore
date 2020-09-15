using System.Threading.Tasks;
using luafalcao.api.Persistence.Entities;
using luafalcao.api.Shared.Utils;

namespace luafalcao.api.Domain.Contracts.Adapters
{
    public interface IAuthenticationManager
    {
        Task<Message> RegisterUser(Usuario usuario);
        Task<bool> ValidateUser(Usuario usuario);
        Task<Usuario> GetUserByUserName(string username);

        Task<string> CreateToken();
        
    }
}