using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuralNet
{
    public class network {
        layer[] layers;
        public network(int[] layersizes) {

        }
    }
    public class layer {
        double[,] weights;
        double[] biases;
        public layer(int nodecount)
        {

        }

        
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
}
