using RestAPICourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPICourse.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Clean your balcony", Line = "Just fucking do it", Platform = "Vacummer" },
                new Command { Id = 1, HowTo = "Clean your room", Line = "Claen up bags with cloths", Platform = "Hands" },
                new Command { Id = 2, HowTo = "Clean your kitchen", Line = "Ask your roommate for help", Platform = "Roommate" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Clean your balcony", Line = "Just fucking do it", Platform = "Vacummer" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
