﻿namespace EdiFabric.Sdk.Edifact.Export.Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlSamples.SerializeToXml();
            XmlSamples.DeserializeFromXml();
        }
    }
}