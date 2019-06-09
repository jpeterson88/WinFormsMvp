﻿using MvpProject.Model;
using System;
using System.Collections.Generic;

namespace MvpProject.Presenter
{
    public interface IGameRatingSelectionView
    {
        event EventHandler GameRatingCreate;
        event EventHandler GameRatingSelected;
        event EventHandler GameRatingDeleted;

        GameRating SelectedGameRating { get; set; }

        List<GameRating> LoadGameRatings();
        GameRating EditGameRating();
    }
}