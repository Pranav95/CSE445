using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using TFIDFExample;

namespace Assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService2
    {
        public void DoWork()
        {
        }
        public string TFIDF_score(string[] webcontent)
        {
            TFIDF idf = new TFIDF();
            double[][] inputs = idf.Transform(webcontent, 0);
            inputs = TFIDF.Normalize(inputs);

            string final = "";
            for (int index = 0; index < inputs.Length; index++)
            {
                final = final + webcontent[index] + "\n";

                foreach (double value in inputs[index])
                {
                    final = value + ",";
                }

                final = final + "\n\n";

            }
            return final;
        }
    }
}
