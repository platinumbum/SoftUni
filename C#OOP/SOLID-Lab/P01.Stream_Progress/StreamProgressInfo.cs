﻿using P01.Stream_Progress.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public class StreamProgressInfo : StreamProgressor
    {
        public StreamProgressInfo(IStreamable file) : base(file)
        {
        }
    }
}
