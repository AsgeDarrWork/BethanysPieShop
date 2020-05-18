using System;
using System.Collections.Generic;
using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels
{
    public class CommentsViewModel
    {
        
        public ICommentRepository commentRepository { get; set; }
        public Comment comment { get; set; }

        public String Name { get; set; }
        public String Email { get; set; }
        public String CComment { get; set; }

    }
}
