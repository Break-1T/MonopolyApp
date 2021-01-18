using System;
using System.Collections.Generic;
using System.Text;
using MonopolyApp.Interfaces;
using MonopolyApp.Models;

namespace MonopolyApp.Fields.Special_fields.Question_actions
{
    class QA1:IQuestionAction
    {
        public QA1()
        {
            _rand = new Random();
            _sumarray = new double[]{ 250,500,1000};
            sum = _sumarray[_rand.Next(0,_sumarray.Length)];
            this.Content = $"Возврат налога в размере +{sum}$";
        }

        private Random _rand;
        private double[] _sumarray;
        
        private double sum;
        
        public string Content { get; set; }

        public void Action(Player player)
        {
            player.Money += sum;
        }
    }
}
