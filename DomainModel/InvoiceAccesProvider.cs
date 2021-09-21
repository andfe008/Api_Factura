using Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public interface InvoiceAccesProvider
    {
        Task<Facturas> AddDataInvoice(Facturas dataInvoice);
        Task UpdateDataInvoice(long dataInvoiceRecordId, Facturas dataInvoice);
        Task DeleteDataInvoice(long dataInvoiceRecordId);
        Task<Facturas> GetDataInvoice(long dataInvoiceRecordId);
        Task<List<Facturas>> GetDataInvoice();
        Task<bool> DataInvoicetExists(long id);
    }
}
