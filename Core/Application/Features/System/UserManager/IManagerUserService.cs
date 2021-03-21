using Application.DTOs.User;
using Application.DTOs.User.UserRequest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.System.UserManager
{
    public interface IManagerUserService
    {
        Task<TokenResponse> Login(UserLoginRequest rq);
        Task<TokenResponse> LoginWithFacebook(string Token);
        Task<TokenResponse> Register(UserRegisterRequest rq);
        Task<UserDTO> GetCurrentUser();
        Task<List<UserDTO>> GetByUsername(string rqUser);
        Task<UserDTO> GetById(Guid Id);
        //Task<List<UserDTO>> GetAllUser(PagingRequest pg);
        //Task<List<UserDTO>> GetUserByPhone(string Phones, PagingRequest pg);
        Task<int> Update(Guid Id, UserUpdateRequest rq);
        Task<int> Delete(Guid Id);
        Task<int> SetRole(Guid Id, string RoleName);
        Task<List<FriendDTO>> GetAllStatusFiend();
        Task<List<FirendAcceptedDTO>> GetAllFiend();
        Task<int> SendFriendRequest(Guid ReceiverId);
        Task<int> AcceptFriendRequest(Guid SenderID);
        Task<int> DenyFriendRequest(Guid SenderID);
    }
}
