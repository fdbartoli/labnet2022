﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02
{
    public static class Logic
    {
        public static void ThrowException()
        {
            throw new Exception();
        }

        public static void ThrowCustomException()
        {
            throw new Exceptions.CustomException();
        }

    }
}
