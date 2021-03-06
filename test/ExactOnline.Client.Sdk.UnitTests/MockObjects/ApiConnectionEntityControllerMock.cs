﻿using System;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{
	public sealed class ApiConnectionEntityControllerMock : IApiConnection
	{
		public int Count()
		{
			return 0;
		}

		public string Data { get; set; }

		#region IApiConnection Members

		string IApiConnection.Get(string parameters)
		{
			throw new NotImplementedException();
		}

		string IApiConnection.GetEntity(string keyname, string guid, string parameters)
		{
			throw new NotImplementedException();
		}

		string IApiConnection.Post(string data)
		{
			Data = data;

			return @"{
				""d"": {
					""__metadata"": {
						""uri"": ""https://start.exactonline.nl/api/v1/{CurrentDivision}/salesinvoice/SalesInvoices(guid'0f8f1d9d-8a1e-49a2-b3ad-6664f58b4982')"",
						""type"": ""Exact.Web.Api.Models.SalesInvoice""
					},
					""AmountFC"": 0,
					""AmountDC"": 0,
					""Created"": ""/Date(1392818456147)/"",
					""Creator"": ""10091f1b-4661-4854-9fd0-cf5f5f668cbd"",
					""CreatorFullName"": ""Aschwin Brandt"",
					""Currency"": ""EUR"",
					""Description"": ""New invoice for Entity With Collection"",
					""Division"": 499156,
					""Document"": null,
					""DocumentNumber"": null,
					""DocumentSubject"": null,
					""DueDate"": ""/Date(1353888000000)/"",
					""InvoiceDate"": ""/Date(1351209600000)/"",
					""InvoiceID"": ""0f8f1d9d-8a1e-49a2-b3ad-6664f58b4982"",
					""InvoiceTo"": ""3734121e-1544-4b77-9ae2-7203e9bd6046"",
					""InvoiceToContactPerson"": ""e893e6e6-6eeb-4420-a5b2-378618ba9f27"",
					""InvoiceToContactPersonFullName"": ""Karin Jansen"",
					""InvoiceToName"": ""Test ABC Producten & Diensten B.V."",
					""InvoiceNumber"": null,
					""Journal"": ""50"",
					""JournalDescription"": ""Verkoopboek"",
					""Modified"": ""/Date(1392818456160)/"",
					""Modifier"": ""10091f1b-4661-4854-9fd0-cf5f5f668cbd"",
					""ModifierFullName"": ""Aschwin Brandt"",
					""OrderDate"": ""/Date(1351209600000)/"",
					""OrderedBy"": ""3734121e-1544-4b77-9ae2-7203e9bd6046"",
					""OrderedByContactPerson"": null,
					""OrderedByContactPersonFullName"": null,
					""OrderedByName"": ""Test ABC Producten & Diensten B.V."",
					""OrderNumber"": 17,
					""PaymentCondition"": ""1"",
					""PaymentConditionDescription"": ""Binnen 4 weken"",
					""Remarks"": null,
					""Salesperson"": ""10091f1b-4661-4854-9fd0-cf5f5f668cbd"",
					""SalespersonFullName"": ""Aschwin Brandt"",
					""Status"": 20,
					""StatusDescription"": ""Open"",
					""Type"": 8020,
					""TypeDescription"": ""Normal"",
					""VATAmountFC"": null,
					""VATAmountDC"": null,
					""YourRef"": null,
					""SalesInvoiceLines"": {
						""__deferred"": {
							""uri"": ""https://start.exactonline.nl/api/v1/{CurrentDivision}/salesinvoice/SalesInvoices(guid'0f8f1d9d-8a1e-49a2-b3ad-6664f58b4982')/SalesInvoiceLines""
						}
					}
				}
			}";
		}

		bool IApiConnection.Put(string keyName, string guid, string data)
		{
			Data = data;
			return true;
		}

		bool IApiConnection.Delete(string keyName, string guid)
		{
			return (keyName.Equals("ID") && guid.Equals("c931ef6c-ecdf-40db-87de-0d2c629ef322"));
		}

		#endregion

		#region IApiConnection Members


		public string GetEntity(string keyname, string guid, string parameters)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
