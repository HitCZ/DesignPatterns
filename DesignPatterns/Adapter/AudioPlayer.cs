using System;

namespace DesignPatterns.Adapter
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter adapter;

        public void Play(AudioType type, string path)
        { 
            switch (type)
            {
                case AudioType.Mp4:
                    adapter = new MediaAdapter(AudioType.Mp4);
                    adapter.Play(AudioType.Mp4, path);
                    break;
                case AudioType.Vlc:
                    adapter = new MediaAdapter(AudioType.Vlc);
                    adapter.Play(AudioType.Vlc, path);
                    break;
                case AudioType.Mp3:
                    Console.WriteLine($"Playing {AudioType.Mp3} file: {path}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
