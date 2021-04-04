using System;
using System.IO;
using IFConverter.Base.Services;
using McMaster.Extensions.CommandLineUtils;

namespace IFConverter.Terminal
{
    class Program
    {
        static void Main(string[] args)
        => CommandLineApplication.Execute<Program>(args);

        // TODO: Params: Override Background Colour, Override Font Colour, Override Font, DPI, Print Spine, Print Cutting, Include BrandLogo, override spine text position

        [Option(Description = "The path to the ifolor photo book")]
        public string ProjectFilePath { get; } = ".";

        [Option(Description = "The path where the generated images will be saved")]
        public string ExportFolderPath { get; } = "Export";

        private void OnExecute()
        {
            //TODO DI Magic
            IIFolorService ifolorService = new IFolorService();
            IImageGeneratorService imageService = new ImageGeneratorService();

            var projectFilePath = Path.Join(ProjectFilePath, "Project.ipp");
            if (!File.Exists(projectFilePath))
            {
                Console.WriteLine($"Project.ipp file not found: {projectFilePath}");
                //TODO return error code
                return;
            }

            //TODO Log the progress
            var project = ifolorService.LoadPhotobook(projectFilePath);
            imageService.RenderAllPages(project, ProjectFilePath, ExportFolderPath);
        }
    }
}
