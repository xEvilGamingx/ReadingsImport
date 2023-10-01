using Microsoft.AspNetCore.Components;

namespace ReadingsImport.Models
{
    public class Step
    {
        public string Name { get; set; }
        public RenderFragment Component { get; set; }
        public bool Selected { get; set; }

        public Step Previous { get; set; }
        public Step Next { get; set; }
    }
}
