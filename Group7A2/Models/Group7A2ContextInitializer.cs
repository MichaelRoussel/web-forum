﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Group7A2.Models
{
    public class Group7A2ContextInitializer : DropCreateDatabaseAlways<Group7A2Context>
    {
        protected override void Seed(Group7A2Context context)
        {
            Category books = new Category { Name = "Text Books", Description = "Buy and sale your text books" };

            Category carPool = new Category { Name = "Car Pool", Description = "Find a ride" };

            Category club = new Category { Name = "Clubs", Description = "Join a club" };

            Category news = new Category { Name = "News", Description = "What is happening" };

            context.Categories.Add(books);
            context.Categories.Add(carPool);
            context.Categories.Add(club);
            context.Categories.Add(news);

            Post p1 = new Post
            {
                Subject = "Sell Java book",
                Content = "The “for dummies” books are rarely worth the money if you already have some experience writing code. But for absolute beginners these books are often perfect because they’re written clearly in plain English without too many confusing terms.",
                Category = books,

            };

            Post p2 = new Post
            {
                Subject = "Orillia to Barrie",
                Content = "Every monday to friday.",
                Category = carPool,

            };


            context.Posts.Add(p1);
            context.Posts.Add(p2);

            Comment c1 = new Comment
            {
                Content = "I want your book",
                Post = p1,
            };

            Comment c2 = new Comment
            {
                Content = "How much for your book",
                Post = p1,
            };
            context.Comments.Add(c1);
            context.Comments.Add(c2);
            base.Seed(context);
        }
    }
}