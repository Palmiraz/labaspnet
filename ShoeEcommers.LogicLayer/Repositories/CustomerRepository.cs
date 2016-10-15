using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ShoeEcommers.LogicLayer.DataObjects;
using ShoeEcommers.LogicLayer.Modelos;

namespace ShoeEcommers.LogicLayer.Repositories
{
    public class CustomerRepository : IDisposable
    {
        private readonly SqlConnection _cn;
        public CustomerRepository()
        {
            _cn = ConnectionProvider.GetConnection();
        }
        public List<Customers> GetCustomers(string name = "")
        {
            //TODO: Consumir el store para obtener la lista de usuario
            return null;
        }

        public Customers GetCustomerById(int id)
        {
            //TODO: Obtener un cliente por id
            return null;
        }

        public bool SaveCustomer(Customers customer)
        {
            //TODO:Guardar un cliente
            return false;
        }

        public bool DeleteCustomer(int id)
        {
            //TODO: Borrar un cliente por id
            return false;
        }



        private bool _disposed;
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                if (_cn.State == ConnectionState.Open)
                {
                    _cn.Close();
                }
                _cn.Dispose();
                _disposed = true;
            }
        }
    }
}
