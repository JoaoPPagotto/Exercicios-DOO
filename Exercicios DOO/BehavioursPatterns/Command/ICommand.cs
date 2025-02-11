using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_DOO.BehavioursPatterns.Command
{
    public interface ICommand 
    { 
        void Execute(); 
        void Undo(); 
    }
}
