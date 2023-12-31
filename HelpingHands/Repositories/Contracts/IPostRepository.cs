﻿using HelpingHands.Entities;
using HelpingHands.Responses;

namespace HelpingHands.Repositories.Contracts
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllPosts();
        Task<Response<int>> CreatePost(Post post);
        Task DeletePost(Post post); 
        Task<Post> GetPostById(int id);
    }
}
