using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace GerenciamentoDePacientesService
{
    public class Connection
    {
        public String connectionString { get; set; }

        public Connection()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionDB"].ToString();
        }

        public Connection(String connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
