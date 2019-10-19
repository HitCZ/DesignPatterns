using System;

namespace DesignPatterns.Decorator
{
    class CommentsBackendProviderEventPublishingDecorator : IBackendProvider<CommentGroup>
    {
        private readonly CommentsBackendProvider decorated;
        
        public CommentsBackendProviderEventPublishingDecorator(CommentsBackendProvider decorated)
        {
            this.decorated = decorated;
        }

        public CommentGroup CreateOrUpdate(CommentGroup obj)
        {
            var result = decorated.CreateOrUpdate(obj);
            Console.WriteLine("Comment Created Event triggered.");

            return result;
        }

        public bool Delete(CommentGroup obj)
        {
            var result = decorated.Delete(obj);
            Console.WriteLine("Comment Deleted Event triggered.");

            return result;
        }
    }
}
