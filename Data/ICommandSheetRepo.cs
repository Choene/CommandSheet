using System.Collections.Generic;
using CommandSheet.Models;

namespace CommandSheet.Data
{
    public interface ICommandSheetRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}