using System;

namespace TargetingExample
{
    public static class WhoAmI
    {
        public static string TellMe()
        {
#if NETCOREAPP1_1
            return ".NET Core";
#elif NETFULL
            return ".NET Framework";
#else
            throw new NotImplementedException();  // Safety net in case of typos in symbols
#endif
        }
    }
}
