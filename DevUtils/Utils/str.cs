using System;

namespace DevUtilsAPI
{
    internal static class str
    {
        public static string MultiToSingleLine(string raw)
        { return raw.Replace(Environment.NewLine, " "); }
    }
}
