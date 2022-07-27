using System;
using System.Collections.Generic;
using System.Text;

namespace TenderSystem.Core.Utilities.RandomNumberGenerator
{
    public class RandomNumberGenerator : IRandomNumberGenerator
    {
        public int EightDigits()
        {
            Random random = new Random();
            return random.Next(10000000, 99999999);
        }
    }
}
