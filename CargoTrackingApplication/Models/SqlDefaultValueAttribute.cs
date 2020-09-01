using System;

namespace CargoTrackingApplication.Models
{
    internal class SqlDefaultValueAttribute : Attribute
    {
        public string Defaultvalue { get; set; }
    }
}