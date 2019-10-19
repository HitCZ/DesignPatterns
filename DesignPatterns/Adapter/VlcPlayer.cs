using System;

namespace DesignPatterns.Adapter
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayMp4(string path)
        {
        }

        public void PlayVlc(string path)
        {
            Console.WriteLine($"Playing {AudioType.Vlc} file: {path}");
        }
    }
}
