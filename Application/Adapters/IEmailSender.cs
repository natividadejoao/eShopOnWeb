using System.Threading.Tasks;

namespace Application.Adapters
{

    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
