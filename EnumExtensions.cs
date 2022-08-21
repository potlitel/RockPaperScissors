using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public static class EnumExtensions
    {
        //Get method implementation from "https://stackoverflow.com/questions/3132126/how-do-i-select-a-random-value-from-an-enumeration"
        public static Enum GetRandomEnumValue(this Type t)
        {
            return Enum.GetValues(t)          // get values from Type provided
                .OfType<Enum>()               // casts to Enum
                .OrderBy(e => Guid.NewGuid()) // mess with order of results
                .FirstOrDefault();            // take first item in result
        }
    }
}