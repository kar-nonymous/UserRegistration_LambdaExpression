using System;
using System.Collections.Generic;
using System.Text;

namespace UserResgistration_LambdaExpression
{
    /// <summary>
    /// Class to throw custom exception for invalid name
    /// </summary>
    /// <seealso cref="System.Exception" />
    class InvalidName : Exception
    {
        public InvalidName(string message) : base(message)
        { }
    }
    /// <summary>
    /// Class to throw custom exception for invalid email id.
    /// </summary>
    /// <seealso cref="System.Exception" />
    class InvalidEmail : Exception
    {
        public InvalidEmail(string message) : base(message)
        { }
    }
    /// <summary>
    /// Class to throw custom exception for invalid mobile number.
    /// </summary>
    /// <seealso cref="System.Exception" />
    class InvalidMobileNum : Exception
    {
        public InvalidMobileNum(string message) : base(message)
        { }
    }
    /// <summary>
    /// Class to throw custom exception for invalid password
    /// </summary>
    /// <seealso cref="System.Exception" />
    class InvalidPassword : Exception
    {
        public InvalidPassword(string message) : base(message)
        { }
    }
}