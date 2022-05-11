using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace SearchInsertPosition
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 1, 3, 5, 6 };
            var objSearch = new SearchInsertPosition();
            int val = objSearch.SearchInsert(nums, 2);
            Console.WriteLine(val);
            Console.Read();
        }
    }
}
