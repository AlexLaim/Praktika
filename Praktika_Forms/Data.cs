using System.Collections.Generic;
using System.IO;

namespace Praktika_Forms
{
    class Data
    {
        public static string filename = Directory.GetCurrentDirectory() + "\\data.txt";
        public static List<string[]> list = new List<string[]>();
        public static List<string[]> grants = new List<string[]>();
        public static bool Edit = false;
        public static int RemoveItem;
        public static int male;
        public static int female;
        public static string Item;
    }
}
