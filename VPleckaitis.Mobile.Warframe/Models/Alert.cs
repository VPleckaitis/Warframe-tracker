using System;

namespace VPleckaitis.Mobile.Warframe.Models
{
    public class Alert
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
    }
}