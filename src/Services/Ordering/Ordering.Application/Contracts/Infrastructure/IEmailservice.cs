using Ordering.Application.Models;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Infrastructure
{
    public interface IEmailservice
    {
        Task<bool> SendEmail(Email email);
    }
}
