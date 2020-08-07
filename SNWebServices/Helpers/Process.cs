using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SNWebServices.Helpers
{
    public class Process
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }


    }

    public class Process<T> : Process
    {
        public T Result { get; set; }
    }
}