using System;
using System.Collections.Generic;
using System.Text;

namespace P01ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        { 
            get => this.length;
            private set
            {
                this.ThrowIfInvalid(value, nameof(Length));

                this.length = value;
            } 
        }

        public double Width
        {
            get => this.width;
            private set
            {
                this.ThrowIfInvalid(value, nameof(Width));

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                this.ThrowIfInvalid(value, nameof(Height));

                this.height = value;
            }
        }

        public double CalculateVolume()
        {
            return this.Length * this.Width * this.Height;
        }

        public double CalculateLateralSurfaceArea()
        {
            return 2 * this.Length * this.Height + 2 * this.Width * this.Height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * this.Length * this.Width + 2 * this.Length * this.Height + 2 * this.Width * this.Height; 
        }

        private void ThrowIfInvalid(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }
    }
}
