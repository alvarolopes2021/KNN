using KNN.Daos;
using KNN.Knn;
using KNN.Models;

Console.WriteLine("Begin k-NN classification demo ");

MySqlDb db = new MySqlDb();

List<DataModel> trainData = db.SelectAll();

int numClasses = 3;
DataModel unknown = new DataModel();
unknown.Age = 5;
unknown.Menopause = 3;
unknown.TumorSize = 10;
unknown.InvNodes = 12;
unknown.NodeCaps = 2;
unknown.DegMalig = 3;
unknown.Breast = 1;
unknown.BreastQuad = 4;
unknown.Irradiat = 2;
unknown.Class = 1;

Console.WriteLine(unknown);

int k = 7;

Console.WriteLine("With k = 1");

int predicted = Knn.Classify(unknown, trainData, numClasses, k);
Console.WriteLine("Predicted class = " + predicted);

k = 6;
Console.WriteLine("With k = 4");
predicted = Knn.Classify(unknown, trainData, numClasses, k);
Console.WriteLine("Predicted class = " + predicted);
Console.WriteLine("End k-NN demo ");
Console.ReadLine();