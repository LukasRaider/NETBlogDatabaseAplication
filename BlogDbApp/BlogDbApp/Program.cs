using BlogDbApp;
using Microsoft.EntityFrameworkCore;

var dbContext = new MyDbContext();


var cSharpTag = new Tag { Name = "cSharp" };
var jsTag = new Tag { Name = "jsTag" };
var htmlTag = new Tag { Name = "htmlTag" };
var cssTag = new Tag { Name = "cssTag" };
var programmingTag = new Tag { Name = "programmingTag" };


var programingblogpost = new BlogPost
{
    Title = "Programming BlogPost",
    Pictures = new List<Picture>
    {
        new Picture
        {
             Name = "First Picture",
             Description = "First picture desc"
        }
    }

};

var cSharpBlogpost = new BlogPost
{
    Title = "cSharp BlogPost",
    Pictures = new List<Picture>
    {
        new Picture
        {
             Name = "First Picture",
             Description = "First picture desc"
        }
    }

};

var htmlBlogpost = new BlogPost
{
    Title = "html BlogPost",
    Pictures = new List<Picture>
    {
        new Picture
        {
             Name = "First Picture",
             Description = "First picture desc"
        }
    }

};


programingblogpost.Tags = new List<Tag>() { cSharpTag, jsTag, htmlTag, cssTag, programmingTag };
cSharpBlogpost.Tags = new List<Tag>() { cSharpTag, programmingTag };
htmlBlogpost.Tags = new List<Tag>() { htmlTag, programmingTag };


dbContext.BlogPosts.AddRange(programingblogpost, cSharpBlogpost, htmlBlogpost);

dbContext.SaveChanges();
//dbContext.SaveChanges();

var posts = dbContext.BlogPosts.Include(x=>x.Pictures).Include(x=>x.Tags).ToList();
var tags = dbContext.Tags.Include(x=>x.BlogPosts).ToList();
Console.WriteLine("Done");




