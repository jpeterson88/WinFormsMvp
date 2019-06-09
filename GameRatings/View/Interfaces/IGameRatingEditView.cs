using System;

namespace MvpProject.Presenter
{
    public interface IGameRatingEditView
    {
        event EventHandler GameRatingSaved;

        string Title { get; set; }
        string Description { get; set; }
        int Rating { get; set; }

        void Close();
        void Save();
    }
}
