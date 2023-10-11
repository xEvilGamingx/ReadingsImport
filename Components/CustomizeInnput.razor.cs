using ReadingsImport.Models;
using ExcelDataReader;

namespace ReadingsImport.Components
{
    public partial class CustomizeInnput
    {
        FileModel fileModel = new FileModel();

        protected override void OnInitialized()
        {
            using (MemoryStream ms = new MemoryStream(InputModel.Content))

            {

                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var reader = ExcelReaderFactory.CreateReader(ms))
                {
                    var result = reader.AsDataSet();

                    var table = result.Tables[0];
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        var row = table.Rows[i];
                        var fileRow = new Row();
                        for (int j = 0; j < row.ItemArray.Length-1; j++)
                        {
                            fileRow.Values.Add(new Value()
                            {
                                Content = row.ItemArray[j].ToString()
                            });
                        }
                        fileModel.Rows.Add(fileRow);
                    }
                }

            }
        }
    }
}