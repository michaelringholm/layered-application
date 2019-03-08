using System;
using docuware_service;
using Microsoft.Extensions.DependencyInjection;
using business_layer;
using data_access_layer;
using service_layer;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Layer Usage Demo");
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<CaseWorkerBO,CaseWorkerBO>();
            serviceCollection.AddSingleton<ICertificateDAO,CertificateDAO>();
            serviceCollection.AddSingleton<IDocumentService,DocuwareService>();
            Run(serviceCollection.BuildServiceProvider());
        }

        private static void Run(IServiceProvider serviceProvider)
        {
            var caseWorkerBO = serviceProvider.GetService<CaseWorkerBO>();
            var imoNumber = "111222";
            var shipCertificate = caseWorkerBO.GetShipCertificate(imoNumber);
            var shipDocuments = caseWorkerBO.GetShipDocuments(imoNumber);
        }
    }
}
