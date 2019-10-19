namespace DesignPatterns.Adapter
{
    public interface IAdvancedMediaPlayer
    {
        void PlayMp4(string path);
        void PlayVlc(string path);
    }
}
