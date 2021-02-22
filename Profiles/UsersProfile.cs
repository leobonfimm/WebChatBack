using AutoMapper;
using WebChat.Dtos;
using WebChat.Models;

namespace WebChat.Profiles
{
  public class UsersProfile : Profile
  {
    public UsersProfile()
    {
      //Source -> Target
      CreateMap<User, UserReadDto>();
      CreateMap<UserCreateDto, User>();
    }
  }
}
