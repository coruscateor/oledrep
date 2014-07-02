using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dbrep;
using OleDbConnector;

namespace oledrep
{

    class Program
    {

        static void Main(string[] args)
        {

            new CMDMain<OleDbDiscreteExecutor>().Run(args);

        }

    }

}
