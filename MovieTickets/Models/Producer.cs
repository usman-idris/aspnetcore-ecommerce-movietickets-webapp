﻿using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FulName { get; set; }
        public string Bio { get; set; }
    }
}
