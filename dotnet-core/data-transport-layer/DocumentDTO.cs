using System;

namespace data_transport_layer
{
    public class DocumentDTO
    {
        public string GUID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string MIMEType { get; set; }
        public DateTime LastUpdated { get; set; }
        public byte[] Contents { get; set; }
    }
}
