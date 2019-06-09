using MvpProject.Presenter;
using MvpProject.View;
using MvpProject.View.Interfaces;
using System.Windows.Forms;

namespace MvpProject
{
    public partial class GameRatingForm : Form, IGameRatingFormView
    {
        public GameRatingForm()
        {
            InitializeComponent();
            SetControl(ControlType.GameRatingSelect);
        }
        //public GameRatingForm(IGameRatingEditView gameRatingEditView,
        //    IGameRatingSelectionView gameRatingSelectionView)
        //{
        //    GameRatingEditView = gameRatingEditView;
        //    GameRatingSelectionView = gameRatingSelectionView;
        //    InitializeComponent();
        //    SwitchControl(ControlType.GameRatingSelect);
        //}

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
                groupBox.Controls.Add(new GameRatingSelectionView());
            }
        }
    }
}
