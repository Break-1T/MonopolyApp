using System;
using System.Collections.Generic;
using System.Text;
using MonopolyApp.Models;

namespace MonopolyApp.Interfaces
{
    interface IQuestionAction
    {
        string Content { get; set; }
        void Action(Player player);
    }
}
