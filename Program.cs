using KNN;
using KNN.Daos;
using KNN.Knn;
using KNN.Models;

Console.WriteLine("Begin k-NN classification demo ");

MySqlDb db = new MySqlDb();

List<DataModel> list = db.SelectAll();

double[][] trainData = LoadData();

int numClasses = 3;
double[] unknown = new double[] { 5.25, 1.75 };

Console.WriteLine("Predictor values: 5.25 1.75 ");

int k = 1;

Console.WriteLine("With k = 1");

int predicted = Knn.Classify(unknown, trainData, numClasses, k);
Console.WriteLine("Predicted class = " + predicted);

k = 4;
Console.WriteLine("With k = 4");
predicted = Knn.Classify(unknown, trainData, numClasses, k);
Console.WriteLine("Predicted class = " + predicted);
Console.WriteLine("End k-NN demo ");
Console.ReadLine();


static double[][] LoadData()
{
    double[][] data = new double[33][];
    data[0] = new double[] { 2.0, 4.0, 0 };
    data[1] = new double[] { 2.0, 5.0, 0 };
    data[2] = new double[] { 2.0, 6.0, 0 };

    data[3] = new double[] { 3.0, 3.0, 0 };
    data[4] = new double[] { 4.0, 3.0, 0 };
    data[5] = new double[] { 5.0, 3.0, 0 };

    data[6] = new double[] { 6.0, 4.0, 0 };
    data[7] = new double[] { 6.0, 5.0, 0 };
    data[8] = new double[] { 6.0, 6.0, 0 };

    data[9] = new double[] { 7.0, 3.0, 0 };
    data[10] = new double[] { 7.0, 4.0, 0 };
    data[11] = new double[] { 7.0, 5.0, 0 };

    data[12] = new double[] { 3.0, 6.0, 1 };
    data[13] = new double[] { 4.0, 6.0, 1 };
    data[14] = new double[] { 5.0, 6.0, 1 };
    data[15] = new double[] { 3.0, 5.0, 1 };
    data[16] = new double[] { 4.0, 5.0, 1 };
    data[17] = new double[] { 5.0, 5.0, 1 };
    data[18] = new double[] { 3.0, 4.0, 1 };
    data[19] = new double[] { 4.0, 4.0, 1 };
    data[20] = new double[] { 5.0, 4.0, 1 };

    data[21] = new double[] { 8.0, 3.0, 1 };
    data[22] = new double[] { 8.0, 2.0, 1 };
    data[23] = new double[] { 8.0, 1.0, 1 };
    data[24] = new double[] { 7.0, 2.0, 1   };
    data[25] = new double[] { 7.0, 1.0, 1 };
    data[26] = new double[] { 6.0, 1.0, 1 };

    data[27] = new double[] { 2.0, 2.0, 2 };
    data[28] = new double[] { 3.0, 2.0, 2 };
    data[29] = new double[] { 4.0, 2.0, 2 };
    data[30] = new double[] { 2.0, 1.0, 2 };
    data[31] = new double[] { 3.0, 1.0, 2 };
    data[32] = new double[] { 4.0, 1.0, 2 };

    return data;
}