using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure;
using Azure.AI.TextAnalytics;
using Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models;

namespace azure_text_test_ai
{
    internal class Test_Azure
    {
        const string endpoint = "xxx";
        const string apiKey = "xxx";

        static void Main(string[] args)
        {
            Console.WriteLine("Azure Text Analyze Started!!!");
            Console.WriteLine();

            Console.WriteLine("Insert the text to analyze sentiment: ");
            string document = Console.ReadLine();
            analyzeSentimentScore(document);
            analyzeLanguageDocument(document);
        }

        static void analyzeSentimentScore(string document)
        {
            var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            try
            {
                Response<DocumentSentiment> resp = client.AnalyzeSentiment(document);
                DocumentSentiment docSentiment = resp.Value;

                Console.WriteLine($"Sentiment was {docSentiment.Sentiment}, with confidence scores: [+: {docSentiment.ConfidenceScores.Positive}, N:{docSentiment.ConfidenceScores.Neutral}, -: {docSentiment.ConfidenceScores.Negative} ]");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void analyzeLanguageDocument(string document)
        {
            var client = new TextAnalyticsClient(new Uri(endpoint), new AzureKeyCredential(apiKey));

            try
            {
                Response<Azure.AI.TextAnalytics.DetectedLanguage> resp = client.DetectLanguage(document);
                Azure.AI.TextAnalytics.DetectedLanguage docDetectedLanguage = resp.Value;

                Console.WriteLine($"Detected language {docDetectedLanguage.Name} with confidence score {docDetectedLanguage.ConfidenceScore}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        

        }

    }


}
