using MvpProject.Presenter;
using MvpProject.Repository;
using MvpProject.View;
using MvpProject.View.Interfaces;
using System.Windows.Forms;

namespace MvpProject
{
    public partial class GameRatingForm : Form, IGameRatingFormView
    {
        private IGameRatingRepository _gameRatingRepository;
        public GameRatingForm()
        {
            InitializeComponent();
            _gameRatingRepository = new GameRatingRepository();
            SetControl(ControlType.GameRatingSelect);
        }

        public IGameRatingEditView GameRatingEditView { get; set; }
        public IGameRatingSelectionView GameRatingSelectionView { get; set; }

        public void SetControl(ControlType controlType)
        {
            groupBox.Controls.Clear();
            if (controlType == ControlType.GameRatingEdit)
            {
                groupBox.Controls.Add(new GameRatingEditView());
            }
            else
            {
                var gameRatingSelectionView = new GameRatingSelectionView();
                var gameRatingSelectionPresenter = new GameRatingSelectionPresenter(gameRatingSelectionView, _gameRatingRepository);

                groupBox.Controls.Add(gameRatingSelectionView);
            }
        }
    }
}
