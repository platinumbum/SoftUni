using P01.Stream_Progress.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01.Stream_Progress
{
    public abstract class StreamProgressor
    {
        private IStreamable file;
        

        public StreamProgressor(IStreamable file)
        {
            this.file = file;
        }


        public virtual int CalculateCurrentPercent()
        {
            return (this.file.BytesSent * 100) / this.file.Length;
        }
    }
}
