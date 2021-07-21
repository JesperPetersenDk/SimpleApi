using System.Collections.Generic;
using SimpleApi.Controllers.Models;

namespace SimpleApi.Controllers.Data
{
    public class MockCommand : ICommand
    {
        public IEnumerable<Command> GetAll()
        {
            var commands = new List<Command>()
            {
                new Command {Id = 0, AccessUser = false, Name = "Jesper Petersen", RankNumber = 1},
                new Command {Id = 1, AccessUser = false, Name = "Freja Hansen", RankNumber = 3},
                new Command {Id = 2, AccessUser = true, Name = "Mette Willumsen", RankNumber = 2},
                new Command {Id = 3, AccessUser = false, Name = "Lotte Olsen", RankNumber = 1},
                new Command {Id = 4, AccessUser = true, Name = "Kasper Olsen", RankNumber = 4}
            };
            return commands;
        }

        public Command GetCommandSingleById(int id)
        {
            return new Command {Id = 0, AccessUser = false, Name = "Jesper Petersen", RankNumber = 1};
        }
    }
}