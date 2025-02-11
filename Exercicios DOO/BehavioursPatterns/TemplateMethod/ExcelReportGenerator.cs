﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.TemplateMethod
{
    public class ExcelReportGenerator : ReportGenerator 
    { 
        protected override void Export() 
        { 
            Console.WriteLine("Exporting to Excel..."); 
        } 
    }
}
