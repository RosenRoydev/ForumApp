using ForumApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace ForumApp.Infrastructure.Data.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        private List<Post> initialPosts = new List<Post>()
        {
            new Post(){Id = 1, Title = "FirstPost" , Content = "I like to write posts"},
            new Post(){Id = 2, Title = "SecondPost" , Content = "My second post"},
            new Post(){Id = 3, Title = "ThirdPost" , Content = "My third successful post "}
        };

        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(initialPosts);
        }
    }
}