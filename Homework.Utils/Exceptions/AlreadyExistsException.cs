﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Utils.Exceptions
{
    public class AlreadyExistsException:Exception
    {
        public AlreadyExistsException()
        {

        }
        public AlreadyExistsException(string message) : base(message)
        {
        }
        public AlreadyExistsException(string message, Exception exception) :base(message, exception)
        {

        }
    }
}
