﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsProcessing
{
    interface ILevenshteinDistance
    {
        int CalcLevenshteinDistance(string firstString, string secondString);
    }
}
