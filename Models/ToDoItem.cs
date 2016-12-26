using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApi.Models
{
    public class ToDoItem
    {
        [Required]
        public string ID {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Notes {get;set;}
        public bool Done {get;set;}
    }
}