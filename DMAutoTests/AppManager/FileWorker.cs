using System.Diagnostics;

namespace DMAutoTests
{
    public class FileWorker : HelperBase
    {
        public FileWorker(ApplicationManager manager) : base(manager) { }
        /// <summary>
        /// Get MUW executable file version
        /// </summary>
        /// <returns>MUW executable file version</returns>
        public string GetMUWExecutableVersion()
        {
            FileVersionInfo MUWExecutableVersion = FileVersionInfo.GetVersionInfo(manager.GetAppPath());
            return $"v {MUWExecutableVersion.FileMajorPart}.{MUWExecutableVersion.FileMinorPart}.{MUWExecutableVersion.FileBuildPart}.{MUWExecutableVersion.ProductPrivatePart}";
        }
    }
}