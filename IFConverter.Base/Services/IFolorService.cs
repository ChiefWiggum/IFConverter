using IFConverter.Base.Model.IFolor;
using IFConverter.Base.Model.Xaml;
using System;
using System.IO;
using System.IO.Compression;
using System.Xml.Serialization;

namespace IFConverter.Base.Services
{
    public class IFolorService : IIFolorService
    {
        private const int GzipOffset = 23;

        public Section GetTextSection(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or whitespace.", nameof(filePath));
            }
            var textFile = new FileInfo(filePath);
            if (!textFile.Exists)
            {
                throw new ArgumentOutOfRangeException(nameof(filePath), filePath, "File not found.");
            }

                        try
            {
                using (FileStream fileStream = textFile.OpenRead())
                {
                    fileStream.Position = GzipOffset;

                    using (GZipStream decompressionStream = new GZipStream(fileStream, CompressionMode.Decompress))
                    {
                        var zipFile = new ZipArchive(decompressionStream);
                        var document = zipFile.GetEntry("Xaml/Document.xaml");
                        XmlSerializer serializer = new XmlSerializer(typeof(Section));

                        var section = serializer.Deserialize(document.Open()) as Section;
                        if (section == null)
                        {
                            throw new ArgumentOutOfRangeException(nameof(filePath), filePath, "Project file not valid.");

                        }

                        return section;
                    }
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        public Stream GetXaml(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or whitespace.", nameof(filePath));
            }
            var textFile = new FileInfo(filePath);
            if (!textFile.Exists)
            {
                throw new ArgumentOutOfRangeException(nameof(filePath), filePath, "File not found.");
            }

                        try
            {
                using (FileStream fileStream = textFile.OpenRead())
                {
                    fileStream.Position = GzipOffset;

                    using (GZipStream decompressionStream = new GZipStream(fileStream, CompressionMode.Decompress))
                    {
                        var zipFile = new ZipArchive(decompressionStream);
                        var document = zipFile.GetEntry("Xaml/Document.xaml");

                        return document.Open();
                        
                    }
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public PhotobookProject LoadPhotobook(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException($"'{nameof(filePath)}' cannot be null or whitespace.", nameof(filePath));
            }
            var projectFile = new FileInfo(filePath);
            if (!projectFile.Exists)
            {
                throw new ArgumentOutOfRangeException(nameof(filePath), filePath, "File not found.");
            }

            try
            {
                using (FileStream fileStream = projectFile.OpenRead())
                {
                    fileStream.Position = GzipOffset;

                    using (GZipStream decompressionStream = new GZipStream(fileStream, CompressionMode.Decompress))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(PhotobookProject));

                        var project = serializer.Deserialize(decompressionStream) as PhotobookProject;
                        if (project == null)
                        {
                            throw new ArgumentOutOfRangeException(nameof(filePath), filePath, "Project file not valid.");

                        }

                        return project;
                    }
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}