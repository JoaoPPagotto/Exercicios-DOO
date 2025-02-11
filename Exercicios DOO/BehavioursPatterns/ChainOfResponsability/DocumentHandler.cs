﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.ChainOfResponsability
{
    public abstract class DocumentHandler
    {
        protected DocumentHandler _next;
        public DocumentHandler SetNext(DocumentHandler next) { _next = next; return next; }
        public abstract void Handle(string documentType);
    }
}
