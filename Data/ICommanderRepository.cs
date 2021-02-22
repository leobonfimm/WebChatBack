using System.Collections.Generic;
using WebChat.Models;

namespace WebChat.Data
{
    public interface ICommanderRepository
    {
      bool SaveChanges();

      IEnumerable<Command> GetAllCommands();
      Command GetCommandById(int id);
      void CreateCommand(Command cmd);
      void UpdateCommand(Command cmd);
      void DeleteCommand(Command cmd);
    }
}
