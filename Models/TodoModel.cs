using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todo_dotnet.Models;

namespace todo_dotnet.Models
{
    public class TodoModel
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public bool IsComplete { get; set; } = false;
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
