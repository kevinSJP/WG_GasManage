using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MLApp;
namespace Gas_test2.BLL
{
    class ML1
    {
        public double[,] ExeAlgorithm(double[] inputData, string algType)
        {
            MLAppClass matlab1 = new MLAppClass();
            double[,] outputData = new double[inputData.Length, 1];

            if (algType == "bp")
            {
                matlab1.PutWorkspaceData("a", "base", inputData);
                matlab1.Execute("b=funBP(a)");

                var b = matlab1.GetVariable("b", "base");

                outputData = (double[,])b;
            }
            return outputData;

        }
    }
}
