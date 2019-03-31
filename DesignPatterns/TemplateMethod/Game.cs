namespace DesignPatterns.TemplateMethod
{
    public abstract class Game
    {
        /// <summary>
        /// Template method
        /// </summary>
        public void Play()
        {
            Initialize();
            Start();
            End();
        }

        protected abstract void Initialize();
        protected abstract void Start();
        protected abstract void End();
    }
}
