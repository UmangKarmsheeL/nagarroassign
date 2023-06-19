using BookReadingEvent1.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace BookReadingEvent1.Repository
{
    public interface IAccountRepository
    {
        Task <IdentityResult>CreateUserAsync(SignUpModel userModel);
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);
        Task SignOutAsync();
    }
}