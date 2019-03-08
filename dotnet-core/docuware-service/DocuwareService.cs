using System;
using System.Collections.Generic;
using data_transport_layer;
using service_layer;

namespace docuware_service
{
    public class DocuwareService : IDocumentService
    {
        public List<DocumentDTO> GetDocuments(String attrName, String attrValue)
        {
            Console.WriteLine("DocuwareService.GetDocuments called!");
            var documents = new List<DocumentDTO>();
            documents.Add(new DocumentDTO{});
            documents.Add(new DocumentDTO{});
            documents.Add(new DocumentDTO{});

            return documents;
        }
    }
}
