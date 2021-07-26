using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.Controllers.Data;
using SimpleApi.Controllers.Models;

namespace SimpleApi.Controllers
{
    //api/cm
    [Route("api/cm")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private readonly ICommand _mockCommand;

        public CommandController(ICommand mockCommand)
        {
            _mockCommand = mockCommand;
        }

        // GET api/cm
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAll()
        {
            try
            {
                var commandItem = _mockCommand.GetAll();
                return Ok(commandItem);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        //GET api/cm/{id}
        [HttpGet("/{id}")]
        public ActionResult <Command> GetSingleById(int id)
        {
            try
            {
                var commandItem = _mockCommand.GetCommandSingleById(id);
                return Ok(commandItem);
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}