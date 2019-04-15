using DataAccess.Interfaces;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    //Złamanie zasady Interface segregation z SOLID - nie róbta tak :)
    //MockRepository jest tylko w ramach przykładu
    public class MockRepository : ITodoRepository
    {
        public void AddTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetTodos()
        {
            var todos = new List<Todo>()
            {
                new Todo()
                {
                    Id= 1,
                    Name = "Nauczyć się .Net",
                    AddDate = DateTime.Now.AddMonths(-2),
                    ExecuteBeforeDate = DateTime.Now.AddDays(14),
                    IsDone = false,
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 2,
                    Name = "Nauczyć się C#",
                    IsDone = true,
                    AddDate = DateTime.Now.AddMonths(-2),
                    ExecuteBeforeDate = DateTime.Now.AddDays(14),
                    DoneDate = DateTime.Now,
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 3,
                    Name = "Nauczyć się T-SQL",
                    IsDone = true,
                    AddDate = DateTime.Now.AddMonths(1),
                    DoneDate = DateTime.Now.AddDays(-7),
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 4,
                    Name = "Nauczyć się HTML",
                    IsDone = true,
                    AddDate = DateTime.Now.AddMonths(-5),
                    DoneDate = new DateTime(2018,12,10),
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 5,
                    Name = "Nauczyć się JS",
                    IsDone = false,
                    AddDate = DateTime.Now.AddMonths(-5),
                    ExecuteBeforeDate = DateTime.Now.AddYears(5),
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 6,
                    Name = "Nauczyć się CSS",
                    IsDone = true,
                    AddDate = new DateTime(2018,11,05),
                    ExecuteBeforeDate = new DateTime(2018,11,30),
                    DoneDate = new DateTime(2018,11,27),
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 7,
                    Name = "Nauczyć się React",
                    IsDone = true,
                    AddDate = new DateTime(2018,12,01),
                    DoneDate = new DateTime(2019,01,01),
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 8,
                    Name = "Nauczyć się Redux",
                    IsDone = false,
                    AddDate = new DateTime(2018,12,01),
                    ExecuteBeforeDate = new DateTime(2019,12,01),
                    Type= TodoType.Learn
                },
                new Todo()
                {
                    Id= 9,
                    Name = "Pozmywać naczynia",
                    IsDone = false,
                    AddDate = DateTime.Now,
                    ExecuteBeforeDate = DateTime.Now.AddHours(2),
                    Type= TodoType.HouseWork
                },
                new Todo()
                {
                    Id= 10,
                    Name = "Zrobić pranie",
                    IsDone = false,
                    AddDate = DateTime.Now.AddDays(2),
                    Type= TodoType.HouseWork
                },
                new Todo()
                {
                    Id= 11,
                    Name = "Zrobić zakupy",
                    IsDone = true,
                    AddDate = DateTime.UtcNow.AddDays(-2),
                    DoneDate = DateTime.UtcNow,
                    Type= TodoType.HouseWork
                },
                new Todo()
                {
                    Id= 12,
                    Name = "Zjeść burgera w m22",
                    IsDone = false,
                    AddDate = DateTime.UtcNow,
                    ExecuteBeforeDate = DateTime.UtcNow.AddDays(1),
                    Type= TodoType.General
                },
                new Todo()
                {
                    Id= 12,
                    Name = "Nauczyć się jodłowania",
                    IsDone = true,
                    AddDate = DateTime.Now.AddDays(-23),
                    ExecuteBeforeDate = DateTime.UtcNow.AddDays(-20),
                    DoneDate= DateTime.UtcNow.AddDays(-13),
                    Type= TodoType.General
                }
            };

            return todos;
        }

        public void MarkAsDone(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveItem(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTodo(int id, string name)
        {
            throw new NotImplementedException();
        }
    }
}
