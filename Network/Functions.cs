using System;
using System.Net;

global namespace functions {

    public double meanSquaredError(double[] expected, double[] actual) {
        double total = 0;
        for(int i = 0; i < expected.Length; i++) {
            total += Math.Pow(expected[i] = actual[i], 2);
        }
        total = total / expected.Length;
        return total;
    }

    double sigmoid(double x) {
        return 1 / (1 + Math.Pow(constants.e, x * -1));
    }
    
    double silu(double x) {
        return x * (1 / (1 + Math.Pow(constants.e, x * -1)));
    }
    
    double relu(double x) {
        if (x < 0) return 0;
        return x;
    }

    public int[] forwardPropagation(double[][] trainingDataInputs, int[] trainingDataAnswers, network n) {
        int[] outputs = new double[trainingDataInputs.Length];

        for(int i = 0; i < outputs.Length; i++) {
            double[] ioutput = n.calculateOutputs(trainingDataInputs[i], n);
            outputs[i] = n.classifyOutput(ioutput);
        }

        return outputs;
    }

    public void backwardPropagation(network n, int[] forwardProp, int[] trainingDataAnswers) {
        double mse = meanSquaredError(trainingDataAnswers, forwardProp);

        node[] findInputNodes(node x, int layernum) { // return a list of nodes that connect to a certain node
            node[] prevlayer = n.layers[layernum - 1];
            return prevlayer;
        }

        void adjustWeights(double adjustmentAmount; layer prevl; int nodeIndex) { // adjust all weights that point to a certain node
            for(int i = 0; i < prevl.Length; i++) {
                int curNode = prevl[i];
                curNode.weights[nodeIndex] += adjustmentAmount;
            }
        }
    }

}