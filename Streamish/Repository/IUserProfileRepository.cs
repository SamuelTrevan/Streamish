using Streamish.Models;
using System.Collections.Generic;

namespace Streamish.Repository
{
    public interface IUserProfileRepository
    {
        void Add(UserProfile user);
        void Delete(int id);
        List<UserProfile> GetAll();
        UserProfile GetById(int id);
        void Update(UserProfile user);
        public UserProfile GetUserByIdWithVideos(int id);
    }
}