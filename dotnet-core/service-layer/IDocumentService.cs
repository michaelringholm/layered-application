using System;
using System.Collections.Generic;
using data_transport_layer;

namespace service_layer
{
    public interface IDocumentService
    {
        List<DocumentDTO> GetDocuments(String attrName, String attrValue);
    }
}
