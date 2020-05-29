using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure;
using System.Globalization;
using Azure.AI.TextAnalytics;


namespace BethanysPieShop.Models
{
    public class CommentRepository: ICommentRepository
    {
        private readonly AppDbContext _appDbContext;
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential("964b259ac0264466b3cdbda5dcd43473");
        private static readonly Uri endpoint = new Uri("https://bethanys-text-analysis.cognitiveservices.azure.com/");



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

        public string AddSentimentByCommentId(int id)
        {
            string text = GetCommentById(id).CComment;

            var client = new TextAnalyticsClient(endpoint, credentials);
            string sentiment = SentimentAnalysisExample(client, text);
            string language = LanguageDetectionExample(client, text);
            string entity = EntityRecognitionExample(client, text);
            string keyPhrases = KeyPhraseExtractionExample(client, text);

            string result = language + sentiment + keyPhrases + entity;
            return (result);
        }

        static string LanguageDetectionExample(TextAnalyticsClient client,string text)
        {
            
            DetectedLanguage detectedLanguage = client.DetectLanguage(text);
            string response = "Language: \n" + $"      {detectedLanguage.Name},      ISO-6391: {detectedLanguage.Iso6391Name}\n\n";
            Console.WriteLine(response);
            

            return response;
        }

        static string EntityRecognitionExample(TextAnalyticsClient client, string text)
        {
            var response = client.RecognizeEntities(text);
            Console.WriteLine("Named Entities:");
            string result = "Named Entities:\n";
            foreach (var entity in response.Value)
            {
                Console.WriteLine($"      Text: {entity.Text},      Category: {entity.Category},      Sub-Category: {entity.SubCategory}");
                Console.WriteLine($"            Length: {entity.GraphemeLength},      Score: {entity.ConfidenceScore:F2}\n");
                result = result + $"      Text: {entity.Text}\n      Category: {entity.Category}\n      Sub-Category: {entity.SubCategory}\n";
                result = result + $"    Score: {entity.ConfidenceScore:F2}\n\n";
            }
            return result;
        }

        static string KeyPhraseExtractionExample(TextAnalyticsClient client, string text)
        {
            var response = client.ExtractKeyPhrases(text);
            string result = "";
            // Printing key phrases
            Console.WriteLine("Key phrases:");
            result = "Key phrases: ";
            foreach (string keyphrase in response.Value)
            {
                Console.WriteLine($"      {keyphrase}");
                result = result + $"      {keyphrase}" +", " ;
            }
            result = result + "\n\n";
            return result;
        }

        static string SentimentAnalysisExample(TextAnalyticsClient client, string text)
        {
            string inputText = text;
            string response = "";
            DocumentSentiment documentSentiment = client.AnalyzeSentiment(inputText);
            Console.WriteLine($"Document sentiment: {documentSentiment.Sentiment}\n");
            response = response + $"Document sentiment: {documentSentiment.Sentiment}\n";


            var si = new StringInfo(inputText);
            foreach (var sentence in documentSentiment.Sentences)
            {
                
                Console.WriteLine($"      Text: \"{si.SubstringByTextElements(sentence.GraphemeOffset, sentence.GraphemeLength)}\"");
                response = response + $"      Text: \"{si.SubstringByTextElements(sentence.GraphemeOffset, sentence.GraphemeLength)}\"\n";
                Console.WriteLine($"      Sentence sentiment: {sentence.Sentiment}");
                response = response + $"      Sentence sentiment: {sentence.Sentiment}" + "\n";
                Console.WriteLine($"      Positive score: {sentence.ConfidenceScores.Positive:0.00}");
                response = response + $"      Positive score: {sentence.ConfidenceScores.Positive:0.00} ";
                Console.WriteLine($"      Negative score: {sentence.ConfidenceScores.Negative:0.00}");
                response = response + $"      Negative score: {sentence.ConfidenceScores.Negative:0.00} " ;
                Console.WriteLine($"      Neutral score: {sentence.ConfidenceScores.Neutral:0.00}\n");
                response = response + $"      Neutral score: {sentence.ConfidenceScores.Neutral:0.00}\n\n";
            }

            return response;
        }

    }
}
