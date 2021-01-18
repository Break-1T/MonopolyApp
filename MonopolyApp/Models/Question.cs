using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using MonopolyApp.Fields.Special_fields.Question_actions;
using MonopolyApp.Interfaces;

namespace MonopolyApp.Models
{
    class Question : IQuestion
    {
        public Question()
        {
            //Для теста добавлю только один вопрос.
            allActions = new List<IQuestionAction>()
            {
                new QA1()
            };
        }
        public string Name { get; set; }
        public int Coordinate { get; set; }
        public Image Appearance { get; set; }
        public List<IQuestionAction> allActions { get; set; }
    }
}
