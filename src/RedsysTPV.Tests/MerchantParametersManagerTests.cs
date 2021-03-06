﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedsysTPV.Models;

namespace RedsysTPV.Tests
{
    [TestClass]
    public class MerchantParametersManagerTests
    {
        [TestMethod]
        public void GetMerchantParameters_ShouldWork()
        {
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
            IMerchantParametersManager merchantParamentersManager = new MerchantParametersManager();
            var result = merchantParamentersManager.GetMerchantParameters(paymentRequest);

            Assert.IsTrue(result == "eyJEc19NZXJjaGFudF9Db25zdW1lckxhbmd1YWdlIjoiMDAxIiwiRHNfTWVyY2hhbnRfQW1vdW50IjoiMCIsIkRzX01lcmNoYW50X09yZGVyIjoiOTc4IiwiRHNfTWVyY2hhbnRfTWVyY2hhbnRDb2RlIjoiIiwiRHNfTWVyY2hhbnRfQ3VycmVuY3kiOiIxNDUiLCJEc19NZXJjaGFudF9UcmFuc2FjdGlvblR5cGUiOiI4NzEiLCJEc19NZXJjaGFudF9UZXJtaW5hbCI6Ijk5OTAwODg4MSIsIkRzX01lcmNoYW50X01lcmNoYW50VVJMIjoiMTk5OTAwMDAwMDBBIiwiRHNfTWVyY2hhbnRfVXJsT0siOiIiLCJEc19NZXJjaGFudF9VcmxLTyI6IiIsIkRzX01lcmNoYW50X1BheU1ldGhvZCI6IkMifQ==");
        }

        [TestMethod]
        public void GetMerchantParameters_ShouldWork_2()
        {
            PaymentRequest paymentRequest = new PaymentRequest(
                "",
                "999008881",
                "871",
                "0",
                "145",
                "978",
                "999911111111",
                "",
                "",
                Language.Spanish
                );
            IMerchantParametersManager merchantParamentersManager = new MerchantParametersManager();
            var result = merchantParamentersManager.GetMerchantParameters(paymentRequest);

            Assert.IsTrue(result == "eyJEc19NZXJjaGFudF9Db25zdW1lckxhbmd1YWdlIjoiMDAxIiwiRHNfTWVyY2hhbnRfQW1vdW50IjoiMCIsIkRzX01lcmNoYW50X09yZGVyIjoiOTc4IiwiRHNfTWVyY2hhbnRfTWVyY2hhbnRDb2RlIjoiIiwiRHNfTWVyY2hhbnRfQ3VycmVuY3kiOiIxNDUiLCJEc19NZXJjaGFudF9UcmFuc2FjdGlvblR5cGUiOiI4NzEiLCJEc19NZXJjaGFudF9UZXJtaW5hbCI6Ijk5OTAwODg4MSIsIkRzX01lcmNoYW50X01lcmNoYW50VVJMIjoiOTk5OTExMTExMTExIiwiRHNfTWVyY2hhbnRfVXJsT0siOiIiLCJEc19NZXJjaGFudF9VcmxLTyI6IiIsIkRzX01lcmNoYW50X1BheU1ldGhvZCI6IkMifQ==");
        }

        [TestMethod]
        public void GetPaymentResponse_ShouldWork()
        {
            var merchantParamenters = "eyJEc19EYXRlIjoiMTkvMDgvMjAxNSIsIkRzX0hvdXIiOiIxMjo0OSIsIkRzX0Ftb3VudCI6IjEyMzQ1IiwiRHNfQ3VycmVuY3kiOiI5NzgiLCJEc19PcmRlciI6Ijk5OTkxMTExMjIyMiIsIkRzX01lcmNoYW50Q29kZSI6IjAxMjM0NTYiLCJEc19UZXJtaW5hbCI6IjIiLCJEc19SZXNwb25zZSI6IjAiLCJEc19NZXJjaGFudERhdGEiOiIiLCJEc19TZWN1cmVQYXltZW50IjoiMSIsIkRzX1RyYW5zYWN0aW9uVHlwZSI6IjAiLCJEc19DYXJkX0NvdW50cnkiOiIiLCJEc19BdXRob3Jpc2F0aW9uQ29kZSI6IjAiLCJEc19Db25zdW1lckxhbmd1YWdlIjoiMCIsIkRzX0NhcmRfVHlwZSI6IkQifQ==";
            IMerchantParametersManager merchantParamentersManager = new MerchantParametersManager();
            var paymentResponse = merchantParamentersManager.GetPaymentResponse(merchantParamenters);

            Assert.IsNotNull(paymentResponse);
            Assert.IsTrue(paymentResponse.Ds_Amount == "12345");
            Assert.IsTrue(paymentResponse.Ds_AuthorisationCode == "0");
            Assert.IsTrue(paymentResponse.Ds_Card_Country == "");
            Assert.IsTrue(paymentResponse.Ds_Card_Type == "D");
            Assert.IsTrue(paymentResponse.Ds_ConsumerLanguage == "0");
            Assert.IsTrue(paymentResponse.Ds_Currency == "978");
            Assert.IsTrue(paymentResponse.Ds_Date == "19/08/2015");
            Assert.IsTrue(paymentResponse.Ds_Hour == "12:49");
            Assert.IsTrue(paymentResponse.Ds_MerchantCode == "0123456");
            Assert.IsTrue(paymentResponse.Ds_MerchantData == "");
            Assert.IsTrue(paymentResponse.Ds_Order == "999911112222");
            Assert.IsTrue(paymentResponse.Ds_Response == "0");
            Assert.IsTrue(paymentResponse.Ds_SecurePayment == "1");
            Assert.IsTrue(paymentResponse.Ds_Terminal == "2");
            Assert.IsTrue(paymentResponse.Ds_TransactionType == "0");
        }
    }
}
