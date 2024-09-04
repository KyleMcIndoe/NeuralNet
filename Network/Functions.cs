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

    }
}