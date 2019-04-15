using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Interfaces
{
    //Interface - mówi nam jakie operacje są dostepne przy pomocy repozytoriów które implementują ten interface
    public interface ITodoRepository
    {
        List<Todo> GetTodos();
        void AddTodo(Todo todo);
        void UpdateTodo(int id, string name);
        void RemoveItem(int id);
        void MarkAsDone(int id);
    }
}
