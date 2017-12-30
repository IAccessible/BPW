using System;
using Google.Cloud.Vision.V1;
namespace bpw_poc
{
   public  class Program
    {
        static void Main(string[] args)
        {
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromUri("gs://bpw-poc-images/property-tax.jpg");
            var     response = client.DetectDocumentText(image);
            Console.WriteLine(response.Text);
            Console.ReadLine();
        }
    }
}
