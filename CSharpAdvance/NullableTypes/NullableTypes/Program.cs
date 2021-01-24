
using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable<DateTime> date = null;
            // DateTime? date = null;

            // date.GetValueOrDefault();
            // date.HasValue;
            // date.Value;

            // DateTime date2 = date ?? DateTime.Today; //?? means if date is null set date2 to DateTime.Today; if it is not null, set it to date

            // DateTime date3 = (date != null) ? date.Value : DateTime.Today;



            // Console.WriteLine(date3);

            int? number = null;
            Console.WriteLine(number.GetValueOrDefault());


        }
    }
}
