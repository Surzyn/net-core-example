using DataAccess.Data;
using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    //TodoRepository - Warstwa abstrakcji bazodanowej
    //Tutaj wykonujemy wszystkie operacje na tabelce todo z bazy
    //Tylko tutaj wiadomo jest skąd pochodza te dane
    public class TodoRepository : ITodoRepository
    {
        public List<Todo> GetTodos()
        {
            using (var dbContext = new TodoContext())
            {
                return dbContext.Todos.ToList();
            }
        }

        public void AddTodo(Todo todo)
        {
            using (var dbContext = new TodoContext())
            {
                dbContext.Todos.Add(todo);
                dbContext.SaveChanges();
            }
        }

        public void UpdateTodo(int id, string name)
        {
            using (var dbContext = new TodoContext())
            {
                var todo = dbContext.Todos.FirstOrDefault(x => x.Id == id);
                todo.Name = "Pierwszego nie przepijać";
                dbContext.SaveChanges();
            }
        }

        public void RemoveItem(int id)
        {
            using (var dbContext = new TodoContext())
            {
                var item = dbContext.Todos.FirstOrDefault(x => x.Id == id);
                dbContext.Todos.Remove(item);
                dbContext.SaveChanges();
            }
        }

        public void MarkAsDone(int id)
        {
            using (var dbContext = new TodoContext())
            {
                var todo = dbContext.Todos.FirstOrDefault(x => x.Id == id);
                todo.IsDone = true;
                dbContext.SaveChanges();
            }
        }
    }
}
