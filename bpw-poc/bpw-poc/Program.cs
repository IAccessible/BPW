using System;
using Google.Cloud.Vision.V1;
namespace bpw_poc
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = ImageAnnotatorClient.Create();
            var image = Image.FromUri("gs://bpw-poc-images/property-tax.jpg");
            var response = client.DetectDocumentText(image);
            foreach (var page in response.Pages)
            {
                foreach (var block in page.Blocks)
                {
                    if (block.BlockType == Block.Types.BlockType.Text)
                    {
                        foreach (var para in block.Paragraphs)
                        {
                            foreach (var word in para.Words)
                            {
                                foreach (var sym in word.Symbols)
                                {
                                    Console.Write(sym.Text);
                                }
                            }
                        }
                    }
                    else if (block.BlockType == Block.Types.BlockType.Table)
                    {
                        Console.WriteLine("found a table. don't know how to handle this yet!");
                    }
                }
            }
            Console.WriteLine(response.Text);
            Console.ReadLine();
        }
    }
}
