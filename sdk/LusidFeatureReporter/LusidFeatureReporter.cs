using System;
using Fclp;
using LusidFeatures.Reporter;

namespace LusidFeatureReporter
{
    class ApplicationArguments
    {
        public string Assembly { get; set; }
        public string Namespace { get; set; }
        public string OutputFile { get; set; }
    }
    
    class LusidFeatureReporter
    {
        static int Main(string[] args)
        {
            var parser = new FluentCommandLineParser<ApplicationArguments>();

            parser.Setup(arg => arg.Assembly)
                .As('a', "assembly")
                .Required();

            parser.Setup(arg => arg.Namespace)
                .As('n', "namespace")
                .Required();
            
            parser.Setup(arg => arg.OutputFile)
                .As('o', "output")
                .Required();

            var result = parser.Parse(args);

            if (result.HasErrors)
            {
                Console.WriteLine(result.ErrorText);
                Console.WriteLine();
                Console.WriteLine("use --help for more information.");

                return 1;
            }

            var appArgs = parser.Object;
            var features = new FeatureReporter().GetAllFeatures(appArgs.Assembly, appArgs.Namespace);
            new FeatureFileWriter(appArgs.OutputFile).CreateAndWriteFile(string.Join("\n", features));
            
            return 0;
        }
    }
}