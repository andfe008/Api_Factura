using Api.View_Models.Models;
using Core.Models;
using DomainModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public class InvoiceProvider
    {
        private readonly InvoiceAccesProvider _dataAccessProvider;

        public InvoiceProvider(InvoiceAccesProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        public async Task<IEnumerable<VmFacturas>> GetDataInvoice()
        {
            var data = await _dataAccessProvider.GetDataInvoice();

            var results = data.Select(der => new VmFacturas
            {
                Fecha = der.Fecha,
                idFactura = der.idFactura,
                idPago = der.idPago,
                iva = der.iva,
                total = der.total
            });

            return results;
        }

        public async Task<bool> existsdataInvoice(long id)
        {
            return await _dataAccessProvider.DataInvoicetExists(id);
        }

        public async Task<VmFacturas> GetDataInvoice(long id)
        {
            var der = await _dataAccessProvider.GetDataInvoice(id);

            var result = new VmFacturas
            {
                Fecha = der.Fecha,
                idFactura = der.idFactura,
                idPago = der.idPago,
                iva = der.iva,
                total = der.total,
            };

            return result;
        }

        public async Task<VmFacturas> AddDataInvoice(VmFacturas value)
        {
            var dataEventRecord = new Facturas
            {
                Fecha = value.Fecha,
                idFactura = value.idFactura,
                idPago = value.idPago,
                iva = value.iva,
                total = value.total,
            };


            var der = await _dataAccessProvider.AddDataInvoice(dataEventRecord);

            var result = new VmFacturas
            {
                Fecha = der.Fecha,
                idFactura = der.idFactura,
                idPago = der.idPago,
                iva = der.iva,
                total = der.total
            };

            return result;
        }

        public async Task UpdateDataInvoice(long id, VmFacturas value)
        {
            var dataEventRecord = new Facturas
            {
                Fecha = value.Fecha,
                idFactura = value.idFactura,
                idPago = value.idPago,
                iva = value.iva,
                total = value.total
            };


            await _dataAccessProvider.UpdateDataInvoice(id, dataEventRecord);
        }

        public async Task DeleteDataInvoice(long id)
        {
            await _dataAccessProvider.DeleteDataInvoice(id);
        }
    }
}