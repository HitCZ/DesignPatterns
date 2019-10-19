using System;

namespace DesignPatterns.Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(AudioType type)
        {
            switch (type)
            {
                case AudioType.Mp4:
                    advancedMediaPlayer = new Mp4Player();
                    break;
                case AudioType.Vlc:
                    advancedMediaPlayer = new VlcPlayer();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        public void Play(AudioType type, string path)
        {
            switch (type)
            {
                case AudioType.Mp4:
                    advancedMediaPlayer.PlayMp4(path);
                    break;
                case AudioType.Vlc:
                    advancedMediaPlayer.PlayVlc(path);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
