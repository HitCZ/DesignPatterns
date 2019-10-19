namespace DesignPatterns.Adapter
{
    public interface IMediaPlayer
    {
        void Play(AudioType type, string path);
    }
}
