using System;

namespace DesignPatterns.Adapter
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string path)
        {
            Console.WriteLine($"Playing {AudioType.Mp4} file: {path}");
        }

        public void PlayVlc(string path)
        {
        }
    }
}
