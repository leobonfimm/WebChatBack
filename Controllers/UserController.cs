using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebChat.Data;
using WebChat.Dtos;
using WebChat.Models;

namespace WebChat.Controllers
{
  [Route("api/users")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly IUserRepository _repository;
    private readonly IMapper _mapper;

    public UserController(IUserRepository repository, IMapper mapper)
    {
      _repository = repository;
      _mapper = mapper;
    }

    [HttpGet]
    public ActionResult<IEnumerable<User>> GetAllUsers()
    {
      var listUsers = _repository.GetAllUsers();

      return Ok(_mapper.Map<IEnumerable<UserReadDto>>(listUsers));
    }

    [HttpGet("{id}", Name = "GetUserById")]
    public ActionResult<UserReadDto> GetUserById(int id)
    {
      var userItem = _repository.GetUserById(id);

      if(userItem == null)
      {
        return NotFound();
      }

      return Ok(_mapper.Map<UserReadDto>(userItem));
    }

    [Route("login")]
    [HttpGet]
    public ActionResult<UserReadDto> GetUserByEmail([FromQuery]string email)
    {
      var userItem = _repository.GetUserByEmail(email);

      if (userItem == null)
      {
        return NotFound();
      }

      return Ok(_mapper.Map<UserReadDto>(userItem));
    }

    [HttpPost]
    public ActionResult<UserCreateDto> CreateUser(UserCreateDto userCreateDto)
    {
      var userModel = _mapper.Map<User>(userCreateDto);

      var userItem = _repository.GetUserByEmail(userModel.Email);

      if (userItem != null)
      {
        return Ok(_mapper.Map<UserReadDto>(userItem));
      }

      _repository.CreateUser(userModel);
      _repository.SaveChanges();

      var userReadDto = _mapper.Map<UserReadDto>(userModel);

      return CreatedAtRoute(nameof(GetUserById), new { Id = userModel.Id}, userReadDto);
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteUser(int id)
    {
      var userModel = _repository.GetUserById(id);

      if (userModel == null)
      {
        return NotFound();
      }

      _repository.DeleteUser(userModel);
      _repository.SaveChanges();

      return NoContent();
    }
  }
}
