
using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
            cookie.Expiry = new DateTime(2020, 12, 29);
            Console.WriteLine(cookie.Expiry);
            cookie["user2"] = "Ran";
            Console.WriteLine(cookie["user2"]);
        }
    }
}
