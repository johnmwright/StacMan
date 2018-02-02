using System;
using Xunit;

namespace StackExchange.StacMan.Tests.Utilities
{
    public static class Assert2
    {
        public static void Throws<T>(Action func) where T : Exception
        {
            Assert.Throws<T>(func);
        }

        public static void ThrowsArgumentException(Action func, string paramName)
        {
            Assert.Equal(paramName, Assert.Throws<ArgumentException>(func).ParamName);
        }

        public static void ThrowsArgumentNullException(Action func, string paramName)
        {
            Assert.Equal(paramName, Assert.Throws<ArgumentNullException>(func).ParamName);
        }
    }
}
