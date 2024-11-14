using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public enum Status
    {
        NotStarted,    // Not started
        InProgress,    // In progress
        Waiting,       // Waiting (e.g., waiting for raw materials)
        Deferred,      // Deferred
        Abandoned,     // Abandoned
        Completed      // Completed
    }
}