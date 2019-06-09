using MvpProject.Presenter;

namespace MvpProject.View.Interfaces
{
    public interface IGameRatingFormView
    {
        IGameRatingEditView GameRatingEditView { get; set; }
        IGameRatingSelectionView GameRatingSelectionView { get; set; }
        void SetControl(ControlType control);
    }

    public enum ControlType
    {
        GameRatingSelect,
        GameRatingEdit
    }
}
