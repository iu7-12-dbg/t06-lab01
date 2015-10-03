using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordsProcessing;
using WordsProcessing.Algorithms;

namespace Lab1
{
    public class NinjectConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILevenshteinDistance>().To<WagnerFischer>();
        }
    }
}
