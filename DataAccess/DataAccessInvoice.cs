using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using DomainModel;
using Core.Models;

namespace DataAccessSqliteProvider
{
    public class DataAccessInvoice : InvoiceAccesProvider
    {
        private readonly DomainModelSqlContext _context;
        private readonly ILogger _logger;

        public DataAccessInvoice(DomainModelSqlContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("DataAccessSqlProvider");
        }

        public async Task<Facturas> AddDataInvoice(Facturas datainvoice)
        {
            try
            {

                _context.Facturas.Add(datainvoice);
                await _context.SaveChangesAsync();
                return datainvoice;
            }
            catch (Exception ex)
            {
                var d = ex;
                throw;
            }
        }



        public async Task UpdateDataInvoice(long dataInvoiceRecordId, Facturas datainvoice)
        {
            var data = _context.Facturas.Where(p => p.idFactura == dataInvoiceRecordId).FirstOrDefault();
            data.idPago = datainvoice.idPago;
            data.iva = datainvoice.iva;
            data.total = datainvoice.total;
            data.Fecha = datainvoice.Fecha;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDataInvoice(long dataInvoiceRecordId)
        {
            var entity = _context.Facturas.First(t => t.idFactura == dataInvoiceRecordId);
            _context.Facturas.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<Facturas> GetDataInvoice(long dataId)
        {
            return await _context.Facturas
                .FirstAsync(t => t.idFactura == dataId);
        }

        public async Task<List<Facturas>> GetDataInvoice()
        {
            var s = _context.Facturas.ToList();
            return await _context.Facturas
                .ToListAsync();
        }

        public async Task<bool> DataInvoiceExists(long id)
        {
            var filteredDataStudentsRecords = _context.Facturas
                .Where(item => item.idFactura == id);

            return await filteredDataStudentsRecords.AnyAsync();
        }

        Task<bool> InvoiceAccesProvider.DataInvoicetExists(long id)
        {
            var _exist = _context.Facturas.Where(p => p.idFactura == id).FirstOrDefault();
            if (_exist != null)
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
