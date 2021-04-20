using System;

namespace TodoWebAPI.Models.Todo
{

    public class TodoItem
    {

        public uint TodoItemId { get; set; }

        public string Name { get; set; }

        public DateTime Due { get; set; }

        public bool IsComplete { get; set; }

        public DateTime DateTime { get; set; }

        public Person Responsible { get; set; }
        //public virtual Person Responsible { get; set; }

       // public uint PersonId  { get; set; }

    }

}