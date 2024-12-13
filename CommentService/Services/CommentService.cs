using Grpc.Core;
using CommentService;

namespace CommentService.Services
{
    public class CommentServiceImpl : CommentService.CommentServiceBase
    {
        public override Task<CommentResponse> AddComment(AddCommentRequest request, ServerCallContext context)
        {
            // Логика добавления комментария
            return Task.FromResult(new CommentResponse
            {
                CommentId = Guid.NewGuid().ToString(),
                Text = request.Text,
                UserId = request.UserId
            });
        }

        public override Task<CommentsResponse> GetComments(GetCommentsRequest request, ServerCallContext context)
        {
            // Логика получения комментариев
            var comments = new CommentsResponse();
            comments.Comments.Add(new CommentResponse { CommentId = "1", Text = "Comment 1", UserId = "1" });
            comments.Comments.Add(new CommentResponse { CommentId = "2", Text = "Comment 2", UserId = "2" });
            return Task.FromResult(comments);
        }
    }
}