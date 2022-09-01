﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DataConnection 
    {
        public SqlConnection conexion;
        public string CadenaDeConexion = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=gym_bdd;Data Source=DESKTOP-94J33F0";
        public DataConnection()
        {
            conexion = new SqlConnection(CadenaDeConexion);
        }

        #region Apertura y cierre de conexioón
        public void OpenConnection()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
                ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de conectar con la base de datos", e);
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión con la base de datos", e);
            }
        }

        #endregion
    }
}
