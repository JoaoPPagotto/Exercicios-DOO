﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.Observer
{
    public interface IObserver 
    {
        void Update(string status); 
    }
}
