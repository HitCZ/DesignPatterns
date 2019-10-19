using System;

namespace DesignPatterns.Decorator
{
    class CommentsBackendProvider : IBackendProvider<CommentGroup>
    {
        public CommentGroup CreateOrUpdate(CommentGroup obj)
        {
            Console.WriteLine("Creating new CommentGroup.");
            return obj;
        }

        public bool Delete(CommentGroup obj)
        {
            Console.WriteLine("Deleting CommentGroup.");
            return true;
        }
    }
}
