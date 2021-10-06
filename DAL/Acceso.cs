using System;
using System.Data;
using System.Collections;
using System.Data.SqlClient;

namespace DAL
    {
        public class Acceso
        {
            private SqlConnection con = new(@"Data Source=.\SQLEXPRESS;Initial Catalog=PrimerParcial;Integrated Security=True");
            private SqlTransaction transaction;
            private SqlCommand cmd;

            public void Abrir()
            {
                con = new SqlConnection();
                con.Open();
            }

            public void Cerrar()
            {
                con.Close();
                con.Dispose();
                con = null;
                GC.Collect();
            }

            public DataSet Leer(string consulta, Hashtable Hdatos)
            {
                DataSet ds = new DataSet();
                cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = consulta;
                cmd.CommandType = CommandType.StoredProcedure;


                if (Hdatos != null)
                {
                    foreach (string d in Hdatos.Keys)
                    {
                        cmd.Parameters.AddWithValue(d, Hdatos[d]);
                    }


                }
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(ds);

                return ds;

            }

            public bool Escribir(string Consulta, Hashtable Hdatos)
            {
                Abrir();

                try
                {
                    transaction = con.BeginTransaction();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = Consulta;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = transaction;

                    if (Hdatos != null)
                    {
                        foreach (string d in Hdatos.Keys)
                        {
                            cmd.Parameters.AddWithValue(d, Hdatos[d]);
                        }
                    }

                    int a = cmd.ExecuteNonQuery();
                    transaction.Commit();
                    return true;


                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    Cerrar();
                }
            }
        }
    }
