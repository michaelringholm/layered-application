using System;
using System.Collections.Generic;
using Moq;
using business_layer;
using data_access_layer;
using data_transport_layer;
using service_layer;
using Xunit;

namespace business_layer_test
{
    public class CaseWorkerBOTest
    {
        [Fact]
        [Trait("Category","UnitTest")]
        public void GetShipCertificate() {
            var certificateDAOMock = new Mock<ICertificateDAO>();
            certificateDAOMock.Setup(f => f.Restore("5555")).Returns(new CertificateDTO{IMONumber="5555"});
            var caseWorkerBO = new CaseWorkerBO(certificateDAOMock.Object, null);
            var shipCertificate = caseWorkerBO.GetShipCertificate("5555");
            Assert.Equal("5555", shipCertificate?.IMONumber);
        }

        [Fact]
        [Trait("Category","UnitTest")]
        public void GetShipDocuments() {
            var documentServiceMock = new Mock<IDocumentService>();
            var shipMockDocuments = new List<DocumentDTO>();
            shipMockDocuments.Add(new DocumentDTO{Author = "John Doe"});
            shipMockDocuments.Add(new DocumentDTO{Author = "Jane Doe"});
            documentServiceMock.Setup(f => f.GetDocuments("IMONumber", "5555")).Returns(shipMockDocuments);
            var caseWorkerBO = new CaseWorkerBO(null, documentServiceMock.Object);
            var shipDocuments = caseWorkerBO.GetShipDocuments("5555");
            Assert.Equal(2, shipDocuments.Count);
            Assert.Equal("Jane Doe", shipDocuments[1].Author);
        }        
    }
}
