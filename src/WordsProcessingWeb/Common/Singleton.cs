using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WordsProcessingWeb.Common
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new Object();

        private Singleton() 
        {
            Factory = new ConcreteFactory();
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }

        public IFactory Factory { get; set; }
    }
}