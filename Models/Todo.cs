using System;
using System.ComponentModel.DataAnnotations;

namespace todoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DoneDate { get; set; }
        public bool Done { get; set; }

        public string Description { get; set; }
        public string UserMail { get; set; }
    }
}