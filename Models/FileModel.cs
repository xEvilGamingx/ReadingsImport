namespace ReadingsImport.Models
{
    public class FileModel
    {
        public List<Row> Rows { get; set; } = new List<Row>();
    }

    public class Row
    {
        public List<Value> Values { get; set; } = new List<Value>();
    }

    public class Value
    {
        public string Content { get; set; } = string.Empty;
    }
}
