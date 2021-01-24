using System;

namespace DelegateDemo
{
    class Program
    {
        public class PhotoFilters
        {
            public static void ApplyBrightness(Photo photo)
            {
                Console.WriteLine("Apply brightness");
            }

            public static void ApplyContrast(Photo photo)
            {
                Console.WriteLine("Apply contrast");
            }

            public static void Resize(Photo photo)
            {
                Console.WriteLine("Resize photo");
            }
        }

        public class Photo
        {
            public static Photo Load(string path)
            {
                return new Photo();
            }

            public void Save()
            {

            }
        }

        public class PhotoProcessor
        {
            /*public delegate void PhotoFilterHandler(Photo photo); // custom delegate*/
            public void Process(string path, /*PhotoFilterHandler filterHandler*/ Action<Photo> filterHandler)
            {
                var photo = Photo.Load(path);

                filterHandler(photo); // this code doesn't know what filter to apply, delegate this task to the client of this code
/*                var filter = new PhotoFilters();

                filter.ApplyBrightness(photo);
                filter.ApplyContrast(photo);
                filter.Resize(photo);*/

                photo.Save();
            }
        }

        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

           /* PhotoProcessor.PhotoFilterHandler filterHandler = PhotoFilters.ApplyBrightness;*/ //delegate is a static method of class PhotoProcessor & is a pointer pointing to ApplyBrightness method
            Action<Photo> filterHandler = PhotoFilters.ApplyBrightness; 
            filterHandler += PhotoFilters.Resize;
            filterHandler += RemoveRedEyeFilter;

             
            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo) // can also add new method that is not defined in PhotoFilters 
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
