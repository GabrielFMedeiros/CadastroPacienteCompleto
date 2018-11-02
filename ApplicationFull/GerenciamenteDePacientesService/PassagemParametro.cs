using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace GerenciamentoDePacientesService
{
    public enum TipoParametro
    {
        String,
        Int,
        DateTime
    }
    public class PassagemParametro
    {
        public String nomeParametro { get; set; }
        public Object valorParametro { get; set; }
        public TipoParametro TipoParametro { get; set; }

        public PassagemParametro()
        {

        }
        public PassagemParametro(String nomeParametro, Object valorParametro, TipoParametro tipo)
        {
            this.nomeParametro = nomeParametro;
            this.valorParametro = valorParametro;
            this.TipoParametro = tipo;
        }

        public void ExecuteNonQuery(string comandoSQL, List<PassagemParametro> parametros)
        {
            Connection con = new Connection();
            SqlConnection conn = new SqlConnection(con.connectionString);
            conn.Open();
            SqlCommand command = new SqlCommand(comandoSQL, conn);
            command.Parameters.AddRange(RecuperarParametros(parametros));
            command.ExecuteNonQuery();
            conn.Close();
        }

        private SqlParameter[] RecuperarParametros(List<PassagemParametro> parametros)
        {
            List<SqlParameter> parametrosSQL = new List<SqlParameter>();

            foreach (var param in parametros)
            {
                SqlDbType sqlDbType = SqlDbType.VarChar;

                switch (param.TipoParametro)
                {
                    case TipoParametro.Int:
                        sqlDbType = SqlDbType.Int;
                        break;

                    case TipoParametro.DateTime:
                        sqlDbType = SqlDbType.Date;
                        break;
                }

                parametrosSQL.Add(new SqlParameter { ParameterName = param.nomeParametro, Value = param.valorParametro, SqlDbType = sqlDbType });

            }
            return parametrosSQL.ToArray();
        }
    }
}
