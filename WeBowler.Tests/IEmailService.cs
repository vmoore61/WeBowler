using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeBowler.Tests
{
    public interface IEmailService
    {
        void Send(string str);

        //internal void Received()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
