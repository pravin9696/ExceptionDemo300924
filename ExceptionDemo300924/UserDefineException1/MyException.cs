﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo300924.UserDefineException1
{
    internal class MyException:Exception
    {
        public MyException(string msg):base(msg)
        {
            
        }
    }
}
