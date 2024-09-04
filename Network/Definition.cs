using System;

public Random rnd = new Random();

public class network {

    class node {
        List<int> weights = new List<int>;
        double bias = 0;

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
}