﻿using System;
using System.Collections.Generic;
using System.Text;
using MonopolyApp.Models;

namespace MonopolyApp.Interfaces
{
    interface IQuestion:IField
    {
        List<IQuestionAction> allActions { get; set; }
    }
}
