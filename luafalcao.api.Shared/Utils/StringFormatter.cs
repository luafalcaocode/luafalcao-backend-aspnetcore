using System;
using System.Collections.Generic;

namespace luafalcao.api.Shared.Utils
{
    public static class StringFormatter
    {
       
        public static string GetFromList(IList<string> messages)
        {                       
           return string.Join(", ", messages);            
        }
    }
}
