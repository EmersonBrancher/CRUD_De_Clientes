using System;
using System.ComponentModel.DataAnnotations;

namespace ClientCRUD.Models
{
    public class Client
    {
        [Key]
        [Display(Name = "Nome")]
        [Required]
        public string name { get; set; }

        [Display(Name = "Idade")]
        [Required]
        public int age { get; set; }
    }
}