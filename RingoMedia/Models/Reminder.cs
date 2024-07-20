﻿using System;

namespace RingoMedia.Models
{
    public class Reminder
    {


       

        public int ReminderId { get; set; }
        public string Title { get; set; }
        public DateTime ReminderTime { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public bool IsSent { get; set; } // To track whether the reminder email has been sent
    }


}
