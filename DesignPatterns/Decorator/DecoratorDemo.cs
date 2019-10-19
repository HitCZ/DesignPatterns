namespace DesignPatterns.Decorator
{
    public class DecoratorDemo
    {
        public DecoratorDemo()
        {
            var provider = new CommentsBackendProvider();
            var decorator = new CommentsBackendProviderEventPublishingDecorator(provider);

            decorator.CreateOrUpdate(new CommentGroup());
            decorator.Delete(new CommentGroup());
        }
    }
}
