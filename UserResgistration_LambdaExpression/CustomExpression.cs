using System;
using System.Collections.Generic;
using System.Text;

namespace UserResgistration_LambdaExpression
{
    class InvalidName : Exception
    {
        public InvalidName(string message) : base(message)
        { }
    }
    class InvalidEmail : Exception
    {
        public InvalidEmail(string message) : base(message)
        { }
    }
    class InvalidMobileNum : Exception
    {
        public InvalidMobileNum(string message) : base(message)
        { }
    }
    class InvalidPassword : Exception
    {
        public InvalidPassword(string message) : base(message)
        { }
    }
}