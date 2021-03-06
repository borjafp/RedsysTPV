﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedsysTPV.Models;

namespace RedsysTPV.Tests
{
    [TestClass]
    public class PaymentRequestServiceTests
    {
        [TestMethod]
        public void GetPaymentRequestFormData_ShouldWork()
        {
            string merchantKey = "Mk9m98IfEblmPfrpsawt7BmxObt98Jev";
            PaymentRequest paymentRequest = new PaymentRequest(
                "",
                "999008881",
                "871",
                "0",
                "145",
                "978",
                "19990000000A",
                "",
                "",
                Language.Spanish
                );
            IPaymentRequestService paymentRequestService = new PaymentRequestService();
            var result = paymentRequestService.GetPaymentRequestFormData(paymentRequest, merchantKey);

            Assert.IsTrue(result.Ds_SignatureVersion == "HMAC_SHA256_V1");
            Assert.IsTrue(result.Ds_MerchantParameters == "eyJEc19NZXJjaGFudF9Db25zdW1lckxhbmd1YWdlIjoiMDAxIiwiRHNfTWVyY2hhbnRfQW1vdW50IjoiMCIsIkRzX01lcmNoYW50X09yZGVyIjoiOTc4IiwiRHNfTWVyY2hhbnRfTWVyY2hhbnRDb2RlIjoiIiwiRHNfTWVyY2hhbnRfQ3VycmVuY3kiOiIxNDUiLCJEc19NZXJjaGFudF9UcmFuc2FjdGlvblR5cGUiOiI4NzEiLCJEc19NZXJjaGFudF9UZXJtaW5hbCI6Ijk5OTAwODg4MSIsIkRzX01lcmNoYW50X01lcmNoYW50VVJMIjoiMTk5OTAwMDAwMDBBIiwiRHNfTWVyY2hhbnRfVXJsT0siOiIiLCJEc19NZXJjaGFudF9VcmxLTyI6IiIsIkRzX01lcmNoYW50X1BheU1ldGhvZCI6IkMifQ==");
            Assert.IsTrue(result.Ds_Signature == "n4wE9ctvMwysrh517aDTrhQiNlt0XSXyQPQpSpJmeN8=");
        }

    }
}
