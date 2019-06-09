namespace MvpProject.Presenter
{
    public class GameRatingEditPresenter
    {
        private readonly IGameRatingEditView _view;
        public GameRatingEditPresenter(IGameRatingEditView view)
        {
            _view = view;
        }
    }
}
