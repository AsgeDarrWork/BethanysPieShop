using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> AllComments { get; }

        int GetNextId { get; }

        Comment GetCommentById(int commentId);
        int GetNumberOfComments();
        void Add(Comment comment);
        string AddSentimentByCommentId(int id);


    }
}
