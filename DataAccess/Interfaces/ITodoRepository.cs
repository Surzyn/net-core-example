using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    public interface ITodoRepository
    {
        List<Todo> GetTodos();
    }
}
