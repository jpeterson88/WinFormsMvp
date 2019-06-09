using MvpProject.Model;
using MvpProject.Presenter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MvpProject.View
{
    public partial class GameRatingSelectionView : UserControl, IGameRatingSelectionView
    {
        public GameRating SelectedGameRating { get; set; }

        public GameRatingSelectionView()
        {
            InitializeComponent();
        }

        public event EventHandler GameRatingCreate;
        public event EventHandler GameRatingSelected;
        public event EventHandler GameRatingDeleted;
        public event EventHandler GameRatingEdit;

        private void createButton_Click(object sender, EventArgs e)
        {
            if (GameRatingCreate != null)
                GameRatingCreate(sender, e);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (GameRatingEdit != null)
                GameRatingEdit(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (GameRatingDeleted != null)
                GameRatingDeleted(sender, e);
        }

        private void gameRating_Click(object sender, EventArgs e)
        {
            if (GameRatingSelected != null)
                GameRatingSelected(sender, e);
        }

        public void LoadGameRatings(List<GameRating> gameRatings)
        {
            gameRatingListings.DataSource = gameRatings;
        }

        public GameRating EditGameRating()
        {
            throw new NotImplementedException();
        }
    }
}
