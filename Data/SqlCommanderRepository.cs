// using System;
// using System.Collections.Generic;
// using System.Linq;
// using WebChat.Models;

// namespace WebChat.Data
// {
//   public class SqlCommanderRepository: ICommanderRepository
//   {
//     private readonly CommanderContext _context;

//     public SqlCommanderRepository(CommanderContext context)
//     {
//       _context = context;
//     }

//     public void CreateCommand(Command cmd)
//     {
//       if(cmd == null)
//       {
//         throw new ArgumentNullException(nameof(cmd));
//       }

//       _context.Commands.Add(cmd);
//     }

//     public void DeleteCommand(Command cmd)
//     {
//       if (cmd == null)
//       {
//         throw new ArgumentNullException(nameof(cmd));
//       }

//       _context.Commands.Remove(cmd);
//     }

//     public IEnumerable<Command> GetAllCommands()
//     {
//       return _context.Commands.ToList();
//     }

//     public Command GetCommandById(int id)
//     {
//       return _context.Commands.FirstOrDefault(p => p.Id == id);
//     }

//     public bool SaveChanges()
//     {
//       return (_context.SaveChanges() >= 0);
//     }

//     public void UpdateCommand(Command cmd)
//     {
//       _context.Commands.Update(cmd);
//     }
//   }
// }
