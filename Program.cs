using KNN.Daos;
using KNN.Knn;
using KNN.Models;
using KNN.Utils;
using System.Text.Json;

Console.WriteLine("Begin k-NN classification demo ");

MySqlDb db = new MySqlDb();

List<DataModel> trainData = db.SelectAll();

int numClasses = 3;
DataModel unknown = new DataModel();

// data input
Console.WriteLine("Digite a idade do paciente: ");
unknown.Age = int.Parse(Console.ReadLine());

if (unknown.Age < 10)
{
    Console.WriteLine("Idade inválida");
    Console.WriteLine("End k-NN demo ");
    Console.ReadLine();
    return;
}

unknown.Age = Utils.ClassifyAge(unknown.Age);


Console.WriteLine('\n');

Console.WriteLine("1 - antes dos 40: ");
Console.WriteLine("2 - depois dos 40: ");
Console.WriteLine("3 - pré menopausa: ");
unknown.Menopause = int.Parse(Console.ReadLine());

Console.WriteLine('\n');
Console.WriteLine("Tamanho do tumor (mm): ");
unknown.TumorSize = int.Parse(Console.ReadLine());
unknown.TumorSize = Utils.ClassifySize(unknown.TumorSize);


Console.WriteLine('\n');
Console.WriteLine("Inv nodes (linfonodos auxiliares): ");
unknown.InvNodes = int.Parse(Console.ReadLine());
unknown.InvNodes = Utils.ClassifyInvNodes(unknown.InvNodes);

Console.WriteLine('\n');
Console.WriteLine("Penetração do tumor: ");
Console.WriteLine("1 - Não");
Console.WriteLine("2 - Sim");
unknown.NodeCaps = int.Parse(Console.ReadLine());

Console.WriteLine('\n');
Console.WriteLine("Grau de malignidade: ");
Console.WriteLine("1 - Menor");
Console.WriteLine("2 - Médio");
Console.WriteLine("3 - Maior");
unknown.DegMalig = int.Parse(Console.ReadLine());

Console.WriteLine('\n');
Console.WriteLine("Mama: ");
Console.WriteLine("1 - Esquerda");
Console.WriteLine("2 - Direita");
unknown.Breast = int.Parse(Console.ReadLine());

Console.WriteLine('\n');
Console.WriteLine("Quadrante da mama: ");
Console.WriteLine("1 - equerda-cima");
Console.WriteLine("2 - esquerda-baixo");
Console.WriteLine("3 - direita-cima");
Console.WriteLine("4 - direita-baixo");
Console.WriteLine("5 - centro");
unknown.BreastQuad = int.Parse(Console.ReadLine());

Console.WriteLine('\n');
Console.WriteLine("Histórico de radioterapia: ");
Console.WriteLine("1 - Não");
Console.WriteLine("2 - Sim");
unknown.Irradiat= int.Parse(Console.ReadLine());

int k = 7;

Console.WriteLine("With k = " + k);

int predicted = Knn.Classify(unknown, trainData, numClasses, k);
Console.WriteLine("Predicted class = " + predicted);

Console.WriteLine('\n');

Console.WriteLine("End k-NN demo ");
Console.ReadLine();

