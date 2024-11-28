namespace UiPath.Plugin.Configuration
{
    public class ConfigData
    {
        public int MaxRetryNumber { get; set; }
        public FolderData Folder { get; set; }
        public FileData File { get; set; }
        public AllabolagData Allabolag { get; set; }
    }

    public class AllabolagData
    {
        public string Url { get; set; }
    }
    public class FolderData
    {
        public string Screenshot { get; set; }
        public string ExcelResult { get; set; }
    }
    public class FileData
    {
        public string BefattningshavareResult { get; set; }
        public string AgeBefattningshavareResult { get; set; }
        public string FilterAgeBefattningshavareResult { get; set; }
        public string ReverseBefattningshavareResult { get; set; }
        public string SourceExel { get; set; }
    }
}