using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitionMatrixCalculations
{
    /*
     * PURPOSE:
     * 
     * The purpose of this program is to create a way to categorize data
     * using a known sample. This can be later used to categorize 
     * mistakes done in jobboss due to manual entry
     */

    /*
        TEST RUN:
        Assume that the probability of measuring an a, b or x is given in the
        following table.
      nothing
     
             A    B    X   
        s0  0.9  0.0  0.1
        s1  0.1  0.7  0.2
        s2  0.0  0.3  0.7
      
        Assume that there is a 0.3 probability that the system starts in state s0, a
        0.3 probability that the system starts in state s1, and a 0.4 probability that it
        starts in state s2.
        Finally, the detector measures the following sequence of outputs:
        "XAXABAXAAXBAXB"
     */

    class Program
    {
        private static readonly string sequence = "XAXABAXAAXBAXB";

        static void Main(string[] args)
        {
        }
    }
}
