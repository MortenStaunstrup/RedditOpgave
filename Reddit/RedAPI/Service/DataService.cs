using Microsoft.EntityFrameworkCore;
using RedAPI.Models;

namespace RedAPI.Service;

public class DataService
{
    private PostContext db;

    public DataService(PostContext db)
    {
        this.db = db;
    }

    public void SeedData()
    {
        Post? post = db.Posts.FirstOrDefault();
        if (post == null)
        {
            var post1 = new Post()
            {
                PostId = 1,
                Author = "Neil Degrasse Tyson",
                Content = "The solar system is a scam fr ong, anybody saying different knows my address",
                TimeStamp = new DateTime(2022, 12, 25),
                Title = "Solar system is a scam",
                Downvotes = 1,
                Upvotes = 242145,
                Comments = new List<Comment>
                {
                    new Comment { CommentId = 1, Author = "BeastMaster64", Content = "You right ong", TimeStamp = new DateTime(2022, 12, 25), Upvotes = 20, Downvotes = 2 },
                    new Comment { CommentId = 2, Author = "ScienceChad", Content = "Dude what are you on about 😂", TimeStamp = new DateTime(2022, 12, 25, 13, 14, 10), Upvotes = 11, Downvotes = 0 },
                    new Comment { CommentId = 3, Author = "Astronomy_Nerd", Content = "Somebody tell Pluto, he got kicked out for nothing 😔", TimeStamp = new DateTime(2022, 12, 26), Upvotes = 31, Downvotes = 1 },
                    new Comment { CommentId = 4, Author = "MoonWalker", Content = "Bruh not another conspiracy...", TimeStamp = new DateTime(2022, 12, 27), Upvotes = 6, Downvotes = 4 },
                    new Comment { CommentId = 5, Author = "FlatMarsSociety", Content = "Finally, someone who gets it!!", TimeStamp = new DateTime(2022, 12, 27, 17, 3, 0), Upvotes = 29, Downvotes = 10 },
                    new Comment { CommentId = 6, Author = "Galileo420", Content = "Next up: Sun isn't real either 🤣", TimeStamp = new DateTime(2022, 12, 28, 10, 10, 0), Upvotes = 15, Downvotes = 1 },
                    new Comment { CommentId = 7, Author = "CosmicCarl", Content = "Neil. Please. Log off.", TimeStamp = new DateTime(2022, 12, 29, 20, 14, 0), Upvotes = 45, Downvotes = 0 },
                }
            };

            var post2 = new Post()
            {
                PostId = 2,
                Author = "Jane Doe",
                Content = "Gravity is just the earth hugging you and never letting go.",
                TimeStamp = new DateTime(2023, 1, 14, 11, 35, 00),
                Title = "Why gravity is cuddly",
                Downvotes = 2,
                Upvotes = 412,
                Comments = new List<Comment>
                {
                    new Comment { CommentId = 8, Author = "PunnyGuy", Content = "That's kinda wholesome tbh", TimeStamp = new DateTime(2023, 1, 14, 12, 8, 3), Upvotes = 7, Downvotes = 1 },
                    new Comment { CommentId = 9, Author = "JumpingJack", Content = "So that's why I can't get out of bed!", TimeStamp = new DateTime(2023, 1, 14, 12, 9, 13), Upvotes = 16, Downvotes = 3 },
                    new Comment { CommentId = 10, Author = "ScienceBae", Content = "Earth's hugs are a bit too tight at 9.8m/s²", TimeStamp = new DateTime(2023, 1, 14, 12, 10, 45), Upvotes = 11, Downvotes = 4 },
                    new Comment { CommentId = 11, Author = "FloatyToasty", Content = "Zero G = zero cuddles?", TimeStamp = new DateTime(2023, 1, 14, 12, 14, 20), Upvotes = 3, Downvotes = 2 },
                    new Comment { CommentId = 12, Author = "DadJokeDan", Content = "If you fall for someone, blame gravity.", TimeStamp = new DateTime(2023, 1, 14, 12, 16, 7), Upvotes = 18, Downvotes = 1 },
                    new Comment { CommentId = 13, Author = "NegativeNancy", Content = "Not the kind of hug I wanted today.", TimeStamp = new DateTime(2023, 1, 14, 13, 1, 33), Upvotes = 1, Downvotes = 8 },
                    new Comment { CommentId = 14, Author = "OrbitFan", Content = "Centripetal force says hi.", TimeStamp = new DateTime(2023, 1, 14, 14, 55, 0), Upvotes = 5, Downvotes = 0 },
                }
            };

            var post3 = new Post()
            {
                PostId = 3,
                Author = "Isaac Newton",
                Content = "An apple a day keeps relativity away. Trust me, I invented gravity.",
                TimeStamp = new DateTime(2022, 7, 4, 9, 0, 0),
                Title = "Gravity Pro Tips",
                Downvotes = 18,
                Upvotes = 1805,
                Comments = new List<Comment>
                {
                    new Comment { CommentId = 15, Author = "RelativityFan", Content = "Bro Einstein punching the air rn", TimeStamp = new DateTime(2022, 7, 4, 10, 3, 0), Upvotes = 25, Downvotes = 2 },
                    new Comment { CommentId = 16, Author = "FruitSalad", Content = "Are pears anti-matter?", TimeStamp = new DateTime(2022, 7, 4, 11, 0, 0), Upvotes = 9, Downvotes = 1 },
                    new Comment { CommentId = 17, Author = "PhysicsPunny", Content = "Gravity got me down too, bro.", TimeStamp = new DateTime(2022, 7, 4, 12, 27, 17), Upvotes = 6, Downvotes = 0 },
                    new Comment { CommentId = 18, Author = "HistoryBuff", Content = "Invented gravity? What about Galileo?", TimeStamp = new DateTime(2022, 7, 4, 14, 45, 0), Upvotes = 8, Downvotes = 4 },
                    new Comment { CommentId = 19, Author = "SirIsaac", Content = "Since when is fruit so dangerous?", TimeStamp = new DateTime(2022, 7, 4, 15, 6, 0), Upvotes = 3, Downvotes = 1 },
                    new Comment { CommentId = 20, Author = "Mathematician99", Content = "Did you patent apples?", TimeStamp = new DateTime(2022, 7, 4, 16, 15, 10), Upvotes = 13, Downvotes = 0 },
                    new Comment { CommentId = 21, Author = "StarryNight", Content = "Falling for your logic", TimeStamp = new DateTime(2022, 7, 4, 18, 56, 0), Upvotes = 2, Downvotes = 1 },
                }
            };

                    var post4 = new Post()
            {
                PostId = 4,
                Author = "Albert Einstein",
                Content = "When you sit with a nice girl for two hours, it feels like two minutes. That's relativity.",
                TimeStamp = new DateTime(2021, 10, 20, 16, 45, 25),
                Title = "Relativity explained",
                Downvotes = 5,
                Upvotes = 7120,
                Comments = new List<Comment>
                {
                    new Comment { CommentId = 22, Author = "LoveGuru", Content = "Relativity is smooth af", TimeStamp = new DateTime(2021, 10, 20, 17, 2, 0), Upvotes = 14, Downvotes = 0 },
                    new Comment { CommentId = 23, Author = "TimeTraveler", Content = "So that's why Mondays last forever", TimeStamp = new DateTime(2021, 10, 20, 17, 10, 23), Upvotes = 19, Downvotes = 1 },
                    new Comment { CommentId = 24, Author = "EinsteinFan", Content = "Bro really just explained life", TimeStamp = new DateTime(2021, 10, 20, 18, 0, 0), Upvotes = 7, Downvotes = 0 },
                    new Comment { CommentId = 25, Author = "Sheldor", Content = "Bazinga! That tracks.", TimeStamp = new DateTime(2021, 10, 20, 18, 35, 0), Upvotes = 8, Downvotes = 2 },
                    new Comment { CommentId = 26, Author = "SpeedyGonzalez", Content = "Explains why traffic jams feel eternal", TimeStamp = new DateTime(2021, 10, 21, 9, 3, 0), Upvotes = 11, Downvotes = 3 },
                    new Comment { CommentId = 27, Author = "Jokester", Content = "Can I use relativity as an excuse for being late?", TimeStamp = new DateTime(2021, 10, 21, 10, 47, 0), Upvotes = 23, Downvotes = 2 },
                    new Comment { CommentId = 28, Author = "RelativelyConfused", Content = "Wait, is this science or dating advice?", TimeStamp = new DateTime(2021, 10, 21, 12, 11, 0), Upvotes = 21, Downvotes = 0 },
                }
            };

            var post5 = new Post()
            {
                PostId = 5,
                Author = "Sally Ride",
                Content = "Space is hard, but so was my math homework. Guess which one I conquered first.",
                TimeStamp = new DateTime(2023, 3, 5, 19, 10, 0),
                Title = "My first mission (math was harder)",
                Downvotes = 0,
                Upvotes = 350,
                Comments = new List<Comment>
                {
                    new Comment { CommentId = 29, Author = "HomeworkHater", Content = "Honestly, math > Mars on difficulty", TimeStamp = new DateTime(2023, 3, 5, 20, 0, 0), Upvotes = 9, Downvotes = 0 },
                    new Comment { CommentId = 30, Author = "MissionControl", Content = "Math: the true final frontier", TimeStamp = new DateTime(2023, 3, 5, 20, 5, 23), Upvotes = 8, Downvotes = 1 },
                    new Comment { CommentId = 31, Author = "SpaceNerd", Content = "Zero G makes the numbers float", TimeStamp = new DateTime(2023, 3, 5, 20, 9, 0), Upvotes = 3, Downvotes = 2 },
                    new Comment { CommentId = 32, Author = "RocketMan", Content = "Differential equations > black holes", TimeStamp = new DateTime(2023, 3, 5, 21, 11, 43), Upvotes = 7, Downvotes = 1 },
                    new Comment { CommentId = 33, Author = "CrayonAstronaut", Content = "At least space had cooler views", TimeStamp = new DateTime(2023, 3, 5, 21, 30, 15), Upvotes = 6, Downvotes = 4 },
                    new Comment { CommentId = 34, Author = "PiGal", Content = "Proof: π > ∞ when it comes to stress.", TimeStamp = new DateTime(2023, 3, 5, 22, 0, 0), Upvotes = 5, Downvotes = 0 },
                    new Comment { CommentId = 35, Author = "FutureAstronaut", Content = "Thanks for paving the way!", TimeStamp = new DateTime(2023, 3, 5, 22, 35, 0), Upvotes = 12, Downvotes = 0 },
                }
            };

            var post6 = new Post()
            {
                PostId = 6,
                Author = "Carl Sagan",
                Content = "We are made of star stuff. Except Mondays. Mondays are made of failed supernovas.",
                TimeStamp = new DateTime(2023, 6, 12, 8, 0, 0),
                Title = "The truth about Mondays",
                Downvotes = 22,
                Upvotes = 5482,
                Comments = new List<Comment>
                {
                    new Comment { CommentId = 36, Author = "MondayBlues", Content = "So that’s why I feel like cosmic dust on Mondays", TimeStamp = new DateTime(2023, 6, 12, 8, 25, 10), Upvotes = 20, Downvotes = 6 },
                    new Comment { CommentId = 37, Author = "StarStruck", Content = "Can we reschedule Monday to another galaxy?", TimeStamp = new DateTime(2023, 6, 12, 9, 0, 0), Upvotes = 28, Downvotes = 2 },
                    new Comment { CommentId = 38, Author = "AstroNerd42", Content = "Mondays collapse faster than neutron stars", TimeStamp = new DateTime(2023, 6, 12, 9, 30, 0), Upvotes = 9, Downvotes = 3 },
                    new Comment { CommentId = 39, Author = "CoffeeBlackHole", Content = "The only solution: caffeine and Carl Sagan quotes", TimeStamp = new DateTime(2023, 6, 12, 10, 14, 0), Upvotes = 17, Downvotes = 1 },
                    new Comment { CommentId = 40, Author = "TiredHuman", Content = "And Fridays are made of neutron stars b/c they hit so hard", TimeStamp = new DateTime(2023, 6, 12, 10, 30, 0), Upvotes = 12, Downvotes = 0 },
                    new Comment { CommentId = 41, Author = "StellarJoke", Content = "Is there a wormhole out of Monday?", TimeStamp = new DateTime(2023, 6, 12, 11, 12, 0), Upvotes = 15, Downvotes = 2 },
                    new Comment { CommentId = 42, Author = "CosmicComedian", Content = "Now I blame the Big Bang for my calendar", TimeStamp = new DateTime(2023, 6, 12, 11, 50, 0), Upvotes = 13, Downvotes = 0 },
                }
            };

            db.AddRange(post1, post2, post3, post4, post5, post6);
            db.SaveChanges();
        }
    }

    public List<Post> GetPosts()
    {
        // Henter posts uden comments, til forsiden
        return db.Posts.ToList();
    }

    public Post? GetPost(long id)
    {
        return db.Posts.Include(p => p.Comments).FirstOrDefault(p => p.PostId == id);
    }

    public Post? UpvotePost(long id)
    {
        var post = db.Posts.FirstOrDefault(p => p.PostId == id);
        if (post == null)
            return null;
        
        post.Upvotes += 1;
        db.Update(post);
        db.SaveChanges();
        return post;
    }

    public Post? DownvotePost(long id)
    {
        var post = db.Posts.FirstOrDefault(p => p.PostId == id);
        if (post == null)
            return null;
        
        post.Downvotes += 1;
        db.Update(post);
        db.SaveChanges();
        return post;
    }

    public Comment? UpvoteComment(long postId, long commentId)
    {
        var post = db.Posts.Include(p => p.Comments).FirstOrDefault(p => p.PostId == postId);
        if (post == null)
            return null;
        
        var comment = db.Comments.FirstOrDefault(c => c.CommentId ==  commentId);
        if (comment == null)
            return null;
        
        comment.Upvotes += 1;
        db.Update(comment);
        db.SaveChanges();
        return comment;
    }
    
    public Comment? DownvoteComment(long postId, long commentId)
    {
        var post = db.Posts.Include(p => p.Comments).FirstOrDefault(p => p.PostId == postId);
        if (post == null)
            return null;
        
        var comment = db.Comments.FirstOrDefault(c => c.CommentId ==  commentId);
        if (comment == null)
            return null;
        
        comment.Downvotes += 1;
        db.Update(comment);
        db.SaveChanges();
        return comment;
    }

    public Post? PostPost(RecordPost post)
    {
        try
        {
            var maxPostId =  db.Posts.Max(p => p.PostId);
            var newPost = new Post()
            {
                PostId = maxPostId + 1,
                Author = post.Author, 
                Content = post.Content, 
                Comments = new List<Comment>(), 
                Upvotes = 0, Downvotes = 0, 
                Title = post.Title,
                TimeStamp = DateTime.UtcNow
            };
            db.Posts.Add(newPost);
            db.SaveChanges();
        
            return newPost;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public Comment PostComment(long postId, RecordComment comment)
    {
        try
        {
            var post = db.Posts.FirstOrDefault(p => p.PostId == postId);
            if (post == null)
                return new Comment(){CommentId = -1, Author = "Fail", Content = "Fail",  TimeStamp = DateTime.UtcNow, Upvotes = 0, Downvotes = 0};

            var maxCommentId = db.Comments.Any() ? db.Comments.Max(c => c.CommentId) + 1 : 0;
            var newComment = new Comment()
            {
                CommentId = maxCommentId + 1,
                Author = comment.Author,
                Content = comment.Content,
                Upvotes = 0, Downvotes = 0,
                TimeStamp = DateTime.UtcNow
            };
            post.Comments.Add(newComment);
            db.Comments.Add(newComment);
            db.SaveChanges();
            return newComment;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new Comment(){CommentId = -2, Upvotes = 0, Downvotes = 0,  TimeStamp = DateTime.UtcNow, Content = "Crash", Author = "Crash"};
        }
    }
    
}