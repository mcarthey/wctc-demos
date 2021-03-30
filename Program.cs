using System;
using System.Linq;
using EFPart1.DataModels;
using Microsoft.EntityFrameworkCore;

namespace EFPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            // INSERT to Blog database
            // using (var db = new BloggingContext())
            // {
            //     var blog = new Blog()
            //     {
            //         Rating = 1,
            //         Url = "some/other/url"
            //     };
            //     db.Blogs.Add(blog);
            //     db.SaveChanges();
            // }

            // INSERT to Post database
            // using (var db = new BloggingContext())
            // {
            //     var post = new Post() {
            //         BlogId = 3,
            //         Content = "Some content of lesser importance",
            //         Title = "Not so important"
            //     };
            //     db.Posts.Add(post);
            //     db.SaveChanges();
            // }

            // SELECT from Blog database
            using (var db = new BloggingContext())
            {
            		// Eager Loading - see https://docs.microsoft.com/en-us/ef/ef6/querying/related-data
                    var blogs = db.Blogs
                        .Include(b => b.Posts).ToList();

                foreach (var blog in blogs)
                {
                    System.Console.WriteLine("BLOGS");
                    System.Console.WriteLine($"({blog.BlogId}) {blog.Url}");

                    System.Console.WriteLine("POSTS");
                    foreach (var post in blog.Posts) {
                        System.Console.WriteLine($"({post.PostId}){post.Title}");
                    }
                    System.Console.WriteLine();
                }
            }

        }
    }
}
