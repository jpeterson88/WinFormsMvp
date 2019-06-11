using MvpProject.Model;
using MvpProject.Repository;
using System;
using System.Collections.Generic;

namespace MvpProject.Presenter
{
    public class GameRatingSelectionPresenter
    {
        private readonly IGameRatingSelectionView _selectionView;
        private readonly IGameRatingRepository _gameRatingRepository;
        public GameRatingSelectionPresenter(IGameRatingSelectionView selectionView, IGameRatingRepository gameRatingRepository)
        {
            _selectionView = selectionView;
            _gameRatingRepository = gameRatingRepository;

            _selectionView.GameRatingCreate += gameRatingCreated;
            _selectionView.GameRatingSelected += gameRatingSelected;
            _selectionView.GameRatingDeleted += gameRatingDeleted;
            _selectionView.GameRatingEdit += gameRatingEdit;

            loadNotes();
        }

        private void loadNotes()
        {
            List<GameRating> gameRatings = _gameRatingRepository.GetGameRatings();
            _selectionView.LoadGameRatings(gameRatings);
        }

        private void gameRatingCreated(object sender, EventArgs e)
        {

        }

        private void gameRatingDeleted(object sender, EventArgs e)
        {

        }

        private void gameRatingSelected(object sender, EventArgs e)
        {

        }

        private void gameRatingEdit(object sender, EventArgs e)
        {
            //Trigger view swap
        }
    }
}
