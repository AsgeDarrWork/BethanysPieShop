using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class CommentSectionController : Controller
    {
        private readonly ICommentRepository _commentRepository;
        

        public CommentSectionController(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
            
        }
       

        // GET: /<controller>/
        public IActionResult Index()
        {

            var commentViewModel = new CommentsViewModel
            {
                
                commentRepository = _commentRepository

            };

            return View(commentViewModel);
        }

        


        [HttpPost]
        public ActionResult CreateComment(String Name, String Email, String CComment)
        {

            Comment comment = new Comment {  CComment =  CComment, Name = Name, Email = Email };
           
            if (ModelState.IsValid)
            {
                _commentRepository.Add(comment);
                //await _commentRepository.SaveChangesAsync();

                //return View("Details", new Comment { PostId = comment.PostId });
            }


            return RedirectToAction("Index", "CommentSection");
            //return View("~/Views/CommentSection/Index.cshtml");
            
        }







    }
}
