namespace Utils
{
    using System;

    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        public static void Main() 
        {
            int i = 0;
            ulong ul = 0;
            string s = "Test";
            
            Console.WriteLine((Utils.IsItFormattable(i) ? "int is" : "int is not") + " formattable");
            Console.WriteLine((Utils.IsItFormattable(ul) ? "ulong is" : "ulong is not") + " formattable");
            Console.WriteLine((Utils.IsItFormattable(s) ? "string is" : "string is not") + " formattable");
        }
    }
}
