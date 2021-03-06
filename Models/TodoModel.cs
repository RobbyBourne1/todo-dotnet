using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todoDotnet.Models;

namespace todoDotnet.Models
{
    public class TodoModel
    { 
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; } = false;
        public DateTime Time { get; set; } = DateTime.Now;

        public void Complete()
        {
            IsComplete = true;
            Time = DateTime.Now;
        } 
    }
}
