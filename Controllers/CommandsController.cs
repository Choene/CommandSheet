using System.Collections.Generic;
using CommandSheet.Data;
using CommandSheet.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandSheet.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommandSheetRepo _repository = new MockCommandSheetRepo();
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var CommandItems = _repository.GetAppCommands();

            return Ok(CommandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetComandById(int id)
        {
            var CommandItem = _repository.GetCommandById(id);

            return Ok(CommandItem);
        }
    }
}