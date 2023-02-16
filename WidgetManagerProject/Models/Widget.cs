using System;

namespace WidgetManagerProject.Models
{
    public class Widget
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string Type { get; set; }

        public string subType { get; set; }

    }
}