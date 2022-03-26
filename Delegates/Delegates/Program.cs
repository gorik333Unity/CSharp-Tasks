using System;

namespace Delegates
{
    public class PhotoFilter
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filter = new PhotoFilter();

            Action<Photo> filterHandler = filter.ApplyBrightness;
            filterHandler += filter.ApplyContrast;
            filterHandler += filter.Resize;

            photoProcessor.Process("Test", filterHandler);

            Console.ReadLine();
        }
    }
}
