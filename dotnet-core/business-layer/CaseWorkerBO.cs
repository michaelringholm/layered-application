using System;
using System.Collections.Generic;
using data_access_layer;
using data_transport_layer;
using service_layer;

namespace business_layer
{
    public class CaseWorkerBO
    {
        private ICertificateDAO certificateDAO;
        private IDocumentService documentService;
        public CaseWorkerBO(ICertificateDAO certificateDAO, IDocumentService documentService) {
            this.certificateDAO = certificateDAO;
            this.documentService = documentService;
        }

        public CertificateDTO GetShipCertificate(String imoNumber) {
            var certificates = certificateDAO.Restore(imoNumber);
            return certificates;
        }

       public List<DocumentDTO> GetShipDocuments(String imoNumber) {
            var documents = documentService.GetDocuments("IMONumber", imoNumber);
            return documents;
        }        
    }
}
