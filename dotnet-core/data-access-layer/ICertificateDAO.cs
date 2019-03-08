using System.Collections.Generic;
using data_transport_layer;

namespace data_access_layer
{
    public interface ICertificateDAO
    {
        void Store(CertificateDTO certificate);
        CertificateDTO Restore(string imoNumber);
    }
}