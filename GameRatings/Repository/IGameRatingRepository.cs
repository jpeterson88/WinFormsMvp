using MvpProject.Model;
using System.Collections.Generic;

namespace MvpProject.Repository
{
    public interface IGameRatingRepository
    {
        List<GameRating> GetGameRatings();
        GameRating GetGameRating(int id);
        void DeleteGameRating(int id);
        void SaveGameRating(GameRating gameRating);
    }
}
