using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public TodoType Type { get; set; }
        public DateTime DoneDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ExecuteBeforeDate { get; set; }
    }
}
