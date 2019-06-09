using MvpProject.Repository;
using MvpProject.View.Interfaces;

namespace MvpProject.Presenter
{
    public class GameRatingEditPresenter
    {
        private readonly IGameRatingEditView _view;
        private readonly IGameRatingRepository _repository;

        public GameRatingEditPresenter(IGameRatingEditView view, IGameRatingRepository repository)
        {
            _view = view;
            _repository = repository;
        }
    }
}
