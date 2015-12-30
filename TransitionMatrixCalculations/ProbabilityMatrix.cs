using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitionMatrixCalculations
{
    /*
     * This object represents the probability of
     * measuring a, b or x based on what state
     * you are in
     */
    class ProbabilityMatrix
    {
        // probability where index represents the state
        private double[] a_p = { 0.9, 0.0, 0.1 };
        private double[] b_p = { 0.1, 0.7, 0.2 };
        private double[] x_p = { 0.0, 0.3, 0.7 };

        public ProbabilityMatrix();

        // accessors to get the probabilities based 
        // the state required
        public double get_a(int stateIndex)
        {
            return a_p[stateIndex];
        }

        // accessors to get the probabilities based 
        // the state required
        public double get_b(int stateIndex)
        {
            return b_p[stateIndex];
        }

        // accessors to get the probabilities based 
        // the state required
        public double get_x(int stateIndex)
        {
            return x_p[stateIndex];
        }
    }
}
