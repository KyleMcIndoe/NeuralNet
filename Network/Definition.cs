using System;
using System.Collections.Generic;

public Random rnd = new Random();

global class network {

    class node {
        
        double value = 0;

        double bias = 0;
        List<int> weights = new List<int>;
        List<node> connections = new List<node>;

        public node(double x) {
            this.bias = x;
        }
    }

    class layer {
        node[] nodes;

        public layer(int nodecount) {
            this.nodes = new node[nodecount];
            for(int i = 0; i < nodes.Length; i++) { // generate nodes in layer
                nodes[i] = new node(rnd.Next(1, 5);
            }
        }
    }

    
    layer[] layers;

    public network(int[] layersizes) {
        this.layers = new layer[layersizes.Length];
            
        for(int i = 0; i < layersizes.Length; i++) { // generate layers based on input array
            this.layers[i] = new layer(layersizes[i]);
        }

        for(int i = 0; i < layersizes.Length - 1; i++) { // string together nodes
            foreach(node n in this.layers[i].nodes) { 
                for(int j = 0; j < layersizes[i + 1]) {
                    n.connections.Add(this.layers[i + 1].nodes[j]); // I need coffee
                    n.weights.Add(rnd.Next(1, 3)); // I wanna kms
                }
            }
        } // this constructor is built on hopes and dreams
    }


    double[] calculateOutputs(double[] inputs, network n) {
        for(int i = 0; i < n.layers[0].Length; i++) { // initial input, passes array values into first layer
            n.layers[0].nodes[i].value = inputs[i];
        }

        void layerMath(layer l) {
            for(int i = 0; i < l.Length; i++) {
                node n = l[i];
                n.value += n.bias;
                n.value = functions.sigmoid(n.value);

                for(int j = 0; j < n.connections.Count; j++) {
                    n.connections[j] += n.value * n.weights[j];
                }
            }
        }

        double[] lastLayerMath(layer l) {

            double[] ans = new double[l.nodes.Length];

            for(int i = 0; i < l.nodes.Length; i++) {
                node no = l.nodes[i];
                no.value += no.bias;
                no.value = functions.sigmoid(n.value);
                ans[i] = no.value;
            }

            return ans;
        }

        for (int i = 0; i < n.layers.Length - 1; i++) {
            layerMath(n.layers[i]);
        }

        double[] output = lastLayerMath(n.layers[n.layers.Length - 1]);
        return output;
    }
}