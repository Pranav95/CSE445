using EnglishStemmer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TFIDFExample
{
    public  class TFIDF
    {
        /// <summary>
        /// Document vocabulary, containing each word's IDF value.
        /// </summary>
        private static Dictionary<string, double> _vocabularyIDF = new Dictionary<string, double>();

        public  double[][] Transform(string[] documents, int vocabularyThreshold = 3)
        {
            List<List<string>> stemmedDocs;
            List<string> vocabulary;

            // Get the vocabulary and stem the documents at the same time.
            vocabulary = GetVocabulary(documents, out stemmedDocs, vocabularyThreshold);

            if (_vocabularyIDF.Count == 0)
            {
                // Calculate the IDF for each vocabulary term.
                foreach (var term in vocabulary)
                {
                    double numberOfDocsContainingTerm = stemmedDocs.Where(d => d.Contains(term)).Count();
                    _vocabularyIDF[term] = Math.Log((double)stemmedDocs.Count / ((double)1 + numberOfDocsContainingTerm));
                }
            }

            // Transform each document into a vector of tfidf values.
            return TransformToTFIDFVectors(stemmedDocs, _vocabularyIDF);
        }

        private static double[][] TransformToTFIDFVectors(List<List<string>> stemmedDocs, Dictionary<string, double> vocabularyIDF)
        {
            // Transform each document into a vector of tfidf values.
            List<List<double>> vectors = new List<List<double>>();
            foreach (var doc in stemmedDocs)
            {
                List<double> vector = new List<double>();

                foreach (var vocab in vocabularyIDF)
                {
                    // Term frequency = count how many times the term appears in this document.
                    double tf = doc.Where(d => d == vocab.Key).Count();
                    double tfidf = tf * vocab.Value;

                    vector.Add(tfidf);
                }

                vectors.Add(vector);
            }

            return vectors.Select(v => v.ToArray()).ToArray();
        }

        public static double[][] Normalize(double[][] vectors)
        {
            // Normalize the vectors using L2-Norm.
            List<double[]> normalizedVectors = new List<double[]>();
            foreach (var vector in vectors)
            {
                var normalized = Normalize(vector);
                normalizedVectors.Add(normalized);
            }

            return normalizedVectors.ToArray();
        }

        public static double[] Normalize(double[] vector)
        {
            List<double> result = new List<double>();

            double sumSquared = 0;
            foreach (var value in vector)
            {
                sumSquared += value * value;
            }

            double SqrtSumSquared = Math.Sqrt(sumSquared);

            foreach (var value in vector)
            {
                // L2-norm: Xi = Xi / Sqrt(X0^2 + X1^2 + .. + Xn^2)
                result.Add(value / SqrtSumSquared);
            }

            return result.ToArray();
        }
        
        #region Private Helpers

        private static List<string> GetVocabulary(string[] docs, out List<List<string>> stemmedDocs, int vocabularyThreshold)
        {
            List<string> vocabulary = new List<string>();
            Dictionary<string, int> wordCountList = new Dictionary<string, int>();
            stemmedDocs = new List<List<string>>();

            int docIndex = 0;

            foreach (var doc in docs)
            {
                List<string> stemmedDoc = new List<string>();

                docIndex++;

                if (docIndex % 100 == 0)
                {
                    Console.WriteLine("Processing " + docIndex + "/" + docs.Length);
                }

                string[] parts2 = Tokenize(doc);

                List<string> words = new List<string>();
                foreach (string part in parts2)
                {
                    // Strip non-alphanumeric characters.
                    string stripped = Regex.Replace(part, "[^a-zA-Z0-9]", "");

                    if (!StopWords.stopWordsList.Contains(stripped.ToLower()))
                    {
                        try
                        {
                            var english = new EnglishWord(stripped);
                            string stem = english.Stem;
                            words.Add(stem);

                            if (stem.Length > 0)
                            {
                                // Build the word count list.
                                if (wordCountList.ContainsKey(stem))
                                {
                                    wordCountList[stem]++;
                                }
                                else
                                {
                                    wordCountList.Add(stem, 0);
                                }

                                stemmedDoc.Add(stem);
                            }
                        }
                        catch
                        {
                        }
                    }
                }

                stemmedDocs.Add(stemmedDoc);
            }

            // Get the top words.
            var vocabList = wordCountList.Where(w => w.Value >= vocabularyThreshold);
            foreach (var item in vocabList)
            {
                vocabulary.Add(item.Key);
            }

            return vocabulary;
        }

        private static string[] Tokenize(string text)
        {
           
            // Strip numbers.
            text = Regex.Replace(text, "[0-9]+", "number"); 

           // Tokenize and also get rid of any punctuation
            return text.Split(" @$/#.-:&*+=[]?!(){},''\">_<;%\\".ToCharArray());
        }

        #endregion
    }
}
