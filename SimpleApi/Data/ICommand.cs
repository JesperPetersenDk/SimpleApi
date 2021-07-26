using System.Collections;
using System.Collections.Generic;
using SimpleApi.Controllers.Models;

namespace SimpleApi.Controllers.Data
{
    public interface ICommand
    {
        List<Command> GetAll();
        Command GetCommandSingleById(int id);
    }
}