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
            SqlCommand cmd = new SqlCommand("GetCustomers", _cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Name";
            param.SqlDbType = SqlDbType.VarChar;
            param.Value = name;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            List<Customers> result = new List<Customers>();
            while (reader.Read())
            {
                var customer = GetCustomerByReader(reader);
                result.Add(customer);
            }
            return result;
        }

        private static Customers GetCustomerByReader(SqlDataReader reader)
        {
            Customers customer = new Customers();
            customer.Id = reader.GetInt32(0);
            customer.Name = reader.GetString(1);
            customer.FirstName = reader.GetString(2);
            customer.LastName = reader.GetString(3);
            customer.Email = reader.GetString(4);
            customer.DateBirth = reader.GetDateTime(5);
            return customer;
        }

        public Customers GetCustomerById(int id)
        {
            SqlCommand cmd = new SqlCommand("GetCustomers", _cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Id";
            param.SqlDbType = SqlDbType.Int;
            param.Value = id;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            Customers customer = null;
            while (reader.Read())
            {
                 customer = GetCustomerByReader(reader);
               
            }
            return customer;
        }

        public bool SaveCustomer(Customers customer)
        {
            SqlCommand cmd = new SqlCommand("InsertCustomer", _cn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (customer.Id != 0)
            {
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = customer.Id;
            }
            cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value 
                = customer.Name;
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value
                = customer.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value
                = customer.LastName;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value
                = customer.Email;
            cmd.Parameters.Add("@DateBirth", SqlDbType.DateTime).Value
                = customer.DateBirth;

            int id = Convert.ToInt32( cmd.ExecuteScalar());
            customer.Id = id;
            return id > 0;
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
