using System;
using System.Net;

global namespace functions {

    public double meanSquaredError(double[] expected, double[] actual) { // Needs revisiting
        double total = 0;
        for(int i = 0; i < expected.Length; i++) {
            total += Math.Pow(expected[i] = actual[i], 2);
        }
        total = total / expected.Length;
        return total;
    }

    double sigmoid(double x) { // Activation function in use
        return 1 / (1 + Math.Pow(constants.e, x * -1));
    }

    double inverseSigmoid(double x) { // return the value before applying the activation function
        return Math.Log(x / 1 - x);
    }
    
    double silu(double x) {
        return x * (1 / (1 + Math.Pow(constants.e, x * -1)));
    }
    
    double relu(double x) {
        if (x < 0) return 0;
        return x;
    }

    public int[] forwardPropagation(double[][] trainingDataInputs, int[] trainingDataAnswers, network n) { // take a bunch of inputs and predict outputs
        int[] outputs = new double[trainingDataInputs.Length];

        for(int i = 0; i < outputs.Length; i++) {
            double[] ioutput = n.calculateOutputs(trainingDataInputs[i], n);
            outputs[i] = n.classifyOutput(ioutput);
        }

        return outputs;
    }

    public void backwardPropagation(network n, int[] forwardProp, int[] trainingDataAnswers, double learnrate) {
        double mse = meanSquaredError(trainingDataAnswers, forwardProp);

        node[] findInputNodes(node x, int layernum) { // return a list of nodes that connect to a certain node
            node[] prevlayer = n.layers[layernum - 1];
            return prevlayer;
        }

        void adjustWeights(node x,int nodeindex, int layernum, double amount) { // recursive function to adjust weights
            if (layernum == 0) return;

            node[] prevlayer = findInputNodes(x, layernum);
            
            for(int i = 0; i < prevlayer.Length; i++) {
                prevlayer[i].weights[nodeindex] -= amount * learnrate; // still need to figure out amount
                adjustWeights(prevlayer[i], i, layernum - 1, amount); // decrease amount by some chain rule property
            }
        }
    }
}