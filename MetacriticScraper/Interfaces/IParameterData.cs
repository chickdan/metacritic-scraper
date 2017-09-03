﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetacriticScraper.Interfaces
{
    public interface IParameterData
    {
        string ParameterString { get; set; }
        string GetParameterValue(string parameter);
    }
}
