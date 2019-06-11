using MvpProject.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MvpProject.Repository
{
    public class GameRatingRepository : IGameRatingRepository
    {
        private string BaseDirectory
        {
            get { return Path.GetDirectoryName(Application.ExecutablePath); }
        }

        private readonly string fileName = "gameRatings.json";

        public void DeleteGameRating(int id)
        {
            List<GameRating> gameRatings = GetGameRatings();
            gameRatings.Remove(gameRatings.FirstOrDefault(x => x.Id == id));

            File.WriteAllText(Path.Combine(BaseDirectory, fileName), JsonConvert.SerializeObject(gameRatings));
        }

        public GameRating GetGameRating(int id)
        {
            List<GameRating> gameRatings = GetGameRatings();
            return gameRatings.FirstOrDefault(x => x.Id == id);
        }

        public List<GameRating> GetGameRatings()
        {
            var file = Path.Combine(BaseDirectory, fileName);
            List<GameRating> gameRatings = new List<GameRating>();

            if (File.Exists(file))
            {
                string fileText = File.ReadAllText(file);
                gameRatings = JsonConvert.DeserializeObject<List<GameRating>>(fileText);
            }
            else
            {
                //TODO: create file
            }

            return gameRatings;
        }

        public void SaveGameRating(GameRating gameRating)
        {
            List<GameRating> gameRatings = GetGameRatings();
            gameRatings.Add(gameRating);

            File.WriteAllText(Path.Combine(BaseDirectory, fileName), JsonConvert.SerializeObject(gameRatings));
        }
    }
}
