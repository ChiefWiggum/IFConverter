using IFConverter.Base.Model.IFolor;
using System;
using System.IO;
using System.IO.Compression;
using System.Xml.Serialization;

namespace IFConverter.Base.Services
{
    public class IFolorService : IIFolorService
    {
        private const int GzipOffset = 23;
        public PhotobookProject LoadPhotobook(string file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                throw new ArgumentException($"'{nameof(file)}' cannot be null or whitespace.", nameof(file));
            }
            var projectFile = new FileInfo(file);
            if (!projectFile.Exists)
            {
                throw new ArgumentOutOfRangeException(nameof(file), file, "File not found.");
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
                            throw new ArgumentOutOfRangeException(nameof(file), file, "Project file not valid.");

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