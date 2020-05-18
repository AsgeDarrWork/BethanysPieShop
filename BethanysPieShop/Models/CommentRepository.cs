using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class CommentRepository: ICommentRepository
    {
        private readonly AppDbContext _appDbContext;

        public CommentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            
        }

        public IEnumerable<Comment> AllComments
        {
            get
            {

                var comments = _appDbContext.Comments.Include(c => c.CommentId);

                var name = _appDbContext.Comments.FirstOrDefault(c => c.CommentId == 1);



                return comments;
            }
        }

       

        public int GetNextId
        {

            get
            {
                IEnumerable<Comment> allComments = _appDbContext.Comments;

                if (!allComments.Any())
                {
                    return (0);
                }
                else
                {

                    int currentID = 0;
                    foreach (Comment comment in allComments)
                    {
                        if (comment.CommentId > currentID)
                        {
                            currentID = comment.CommentId;
                        }
                    }

                    return (currentID + 1);
                }
            }

        }
        

        public IEnumerable<Comment> GetAllComment()
        {
            IEnumerable<Comment> allComments = _appDbContext.Comments;
            return allComments;
        }

        public int GetNextCommentId()
        {

            IEnumerable<Comment> allComments = _appDbContext.Comments;

            if(!allComments.Any())
            {
                return (1);
            }
            else { 

                int currentID = 0;
                foreach (Comment comment in allComments)
                {
                    if (comment.CommentId > currentID)
                    {
                        currentID = comment.CommentId;
                    }
                }

                return (currentID + 1);
            }
        }

        public int GetNumberOfComments()
        {

            IEnumerable<Comment> allComments = _appDbContext.Comments;

            if (!allComments.Any())
            {
                return (0);
            }
            else
            {

                int currentID = 0;
                foreach (Comment comment in allComments)
                {
                    if (comment.CommentId > currentID)
                    {
                        currentID = comment.CommentId;
                    }
                }

                return (currentID);
            }
        }



        public Comment GetCommentById(int commentId)
        {

            return _appDbContext.Comments.FirstOrDefault(p => p.CommentId == commentId);
        }




        public void Add(Comment comment)
        {
            //comment.CommentId = GetNextCommentId();

            IEnumerable<Comment> allComments = GetAllComment();
            int id = GetNextCommentId();

            comment.CommentId = id;


            using (var transaction = _appDbContext.Database.BeginTransaction())
            {
                _appDbContext.Comments.Add(comment);
                //_appDbContext.SaveChanges();

                _appDbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Comments ON;");
                _appDbContext.SaveChanges();
                _appDbContext.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Comments OFF");
                transaction.Commit();
            }

        }

    }
}
