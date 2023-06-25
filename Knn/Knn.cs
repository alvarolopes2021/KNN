
using KNN.Models;

namespace KNN.Knn
{
    public class Knn
    {
        public static int Classify(DataModel unknown, List<DataModel> trainData, int numClasses, int k)
        {            
            IndexAndDistance[] info = new IndexAndDistance[trainData.Count];
            for (int i = 0; i < trainData.Count; ++i)
            {
                IndexAndDistance curr = new IndexAndDistance();
                double dist = Distance(unknown, trainData[i]);
                curr.idx = i;
                curr.dist = dist;
                info[i] = curr;
            }

            Array.Sort(info);  // sort by distance
            Console.WriteLine("Nearest / Distance / Class");
            Console.WriteLine("==========================");
            for (int i = 0; i < k; ++i)
            {
                int c = (int)trainData[info[i].idx].Class;
                string dist = info[i].dist.ToString("F3");
                Console.WriteLine("( " + trainData[info[i].idx].Id + "," + info[i].dist + " )  :  " + dist + "        " + c);
            }

            int result = Vote(info, trainData, numClasses, k);
            return result;
        }


        public static int Vote(IndexAndDistance[] info, List<DataModel> trainData, int numClasses, int k)
        {
            int[] votes = new int[numClasses];  // One cell per class
            for (int i = 0; i < k; ++i)
            {       // Just first k
                int idx = info[i].idx;            // Which train item
                int c = trainData[idx].Class;   // Class in last cell
                ++votes[c];
            }
            int mostVotes = 0;
            int classWithMostVotes = 0;
            for (int j = 0; j < numClasses; ++j)
            {
                if (votes[j] > mostVotes)
                {
                    mostVotes = votes[j];
                    classWithMostVotes = j;
                }
            }
            return classWithMostVotes;
        }


        public static double Distance(DataModel unknown, DataModel data)
        {
            double sum = Math.Pow(unknown.Age - data.Age, 2) + Math.Pow(unknown.Menopause - data.Menopause, 2) +
                Math.Pow(unknown.TumorSize - data.TumorSize, 2) + Math.Pow(unknown.InvNodes - data.InvNodes, 2) +
                Math.Pow(unknown.NodeCaps - data.NodeCaps, 2) + Math.Pow(unknown.DegMalig - data.DegMalig, 2) +
                Math.Pow(unknown.Breast - data.Breast, 2) + Math.Pow(unknown.BreastQuad - data.BreastQuad, 2) +
                Math.Pow(unknown.Irradiat - data.Irradiat, 2) + Math.Pow(unknown.Class - data.Class, 2);

            return Math.Sqrt(sum);
        }


    }
}
