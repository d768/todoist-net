﻿using System;

namespace Todoist.Net.Exceptions
{
    /// <summary>
    /// Represents an errors that occur during requests to Todoist API.
    /// </summary>
    /// <seealso cref="System.Exception" />
#if NETFW
    [Serializable]
#endif
    public class TodoistException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TodoistException"/> class.
        /// </summary>
        public TodoistException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TodoistException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public TodoistException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TodoistException"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="message">The message.</param>
        public TodoistException(uint code, string message)
            : base(message)
        {
            Code = code;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TodoistException"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="message">The message.</param>
        /// <param name="rawError">The raw error.</param>
        public TodoistException(uint code, string message, dynamic rawError)
            : base(message)
        {
            Code = code;
            RawError = rawError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TodoistException"/> class.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner exception.</param>
        public TodoistException(uint code, string message, Exception inner)
            : base(message, inner)
        {
            Code = code;
        }

        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <value>The code.</value>
        public uint Code { get; }

        /// <summary>
        /// Gets the raw error.
        /// </summary>
        /// <value>The raw error.</value>
        public dynamic RawError { get; }
    }
}
