using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Core.Events;
using Microsoft.VisualBasic.CompilerServices;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
