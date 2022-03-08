using System.Collections.Generic;
using CommandSheet.Models;

namespace CommandSheet.Data
{
    public class MockCommandSheetRepo : ICommandSheetRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Change a theme", Line="Go to themes", Platform="Mac OS"},
                new Command{Id=1, HowTo="Play music", Line="Open media player", Platform="Windows"},
                new Command{Id=2, HowTo="Take a picture", Line="Open camera app", Platform="Android"},
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Change a theme", Line="Go to themes", Platform="Mac OS"};
        }
    }
}