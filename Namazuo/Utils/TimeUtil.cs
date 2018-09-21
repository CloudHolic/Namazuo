using System;
using System.Linq.Expressions;

namespace Namazuo.Utils
{
    public static class TimeUtil
    {
        private const double EorzeaConstant = 20.571428571428573;

        public static DateTime RealTimeToEorzeaTime(DateTime realTime)
        {
            UnixTime actualTime = UnixTime.FromDateTime(realTime);
            var eorzeaUnix = actualTime.Timestamp * EorzeaConstant;

            var eorzeaTime = UnixTime.ToUniversalDateTime(eorzeaUnix);

            return eorzeaTime;
        }

        public static DateTime EorzeaTimeToRealTime(DateTime eorzeaTime)
        {
            UnixTime actualTime = UnixTime.FromDateTime(eorzeaTime);
            var realUnix = actualTime.Timestamp / EorzeaConstant;

            var realTime = UnixTime.ToUniversalDateTime(realUnix);

            return realTime;
        }
    }
}
