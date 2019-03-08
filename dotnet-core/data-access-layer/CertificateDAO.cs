using System;
using System.Collections.Generic;
using data_transport_layer;

namespace data_access_layer
{
    public class CertificateDAO : ICertificateDAO
    {
        public CertificateDTO Restore(string imoNumber)
        {
            Console.WriteLine("Real CertificateDAO.Restore called!");
            return new CertificateDTO { IMONumber = imoNumber };
        }

        public void Store(CertificateDTO certificate)
        {
            Console.WriteLine("Real CertificateDAO.Store called!");
        }
    }
}
