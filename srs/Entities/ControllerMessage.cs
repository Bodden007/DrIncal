using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrIncal.srs.Entities
{
    internal class ControllerMessage : EventArgs
    {
        public string Message { get; set; }
        public bool IsError { get; set; }
        public ControllerMessage(string message, bool isError)
        {
            Message = message;
            IsError = isError;
        }
    }
}
