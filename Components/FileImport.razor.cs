using Microsoft.AspNetCore.Components.Forms;
using ReadingsImport.Models;
using ExcelDataReader;

namespace ReadingsImport.Components
{
    public partial class FileImport
    {
        async void LoadFiles(InputFileChangeEventArgs e)
        {
            var file = e.File;
            var stream = file.OpenReadStream();

            using (MemoryStream ms = new MemoryStream())
            {
                await stream.CopyToAsync(ms);
                InputModel.Content = ms.ToArray();
            }
        }

        protected override Task OnInitializedAsync()
        {
            //Leeren des Dokumentes
            InputModel.Content = null;
            return base.OnInitializedAsync();
        }
    }
}