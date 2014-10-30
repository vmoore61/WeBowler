using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeBowler.Tests
{
    class Greeting
    {
        private IEmailService es;

        public Greeting(IEmailService es)
        {
            // TODO: Complete member initialization
            this.es = es;
        }

        internal void Build()
        {
            es.Send("message for email");
        }
    }
}
