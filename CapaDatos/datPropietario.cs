﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datPropietario
    {
        #region singleton
        private static datPropietario _instancia = new datPropietario();

        public static datPropietario Instancia
        {
            get { return datPropietario._instancia; }
        }
        #endregion singleton

        public Boolean RegistrarPropietario(entPropietario Propietario)
        {
            Boolean registrar = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistrarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", Propietario.dni);
                cmd.Parameters.AddWithValue("@nombre", Propietario.nombre);
                cmd.Parameters.AddWithValue("@apellido", Propietario.apellido);
                cmd.Parameters.AddWithValue("@edad", Propietario.edad);
                cmd.Parameters.AddWithValue("@celular", Propietario.celular);
                cmd.Parameters.AddWithValue("@direccion", Propietario.direccion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registrar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return registrar;
        }


        public Boolean ExisteDatosAgente(entPropietario Propietario)
        {
            Boolean existe = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spExisteDatosPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Propietario.dni);
                cmd.Parameters.AddWithValue("@celular", Propietario.celular);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    existe = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return existe;
        }


        public List<entPropietario> ListarPropietario()
        {
            SqlCommand cmd = null;
            List<entPropietario> lista = new List<entPropietario>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entPropietario prop = new entPropietario();
                    prop.id = Convert.ToInt32(dr["id"]);
                    prop.dni = Convert.ToInt32(dr["dni"]);
                    prop.nombre = dr["nombre"].ToString();
                    prop.apellido = dr["apellido"].ToString();
                    prop.edad = Convert.ToInt32(dr["edad"]);
                    prop.celular = Convert.ToInt32(dr["celular"]);
                    prop.direccion = dr["direccion"].ToString();
                    lista.Add(prop);
                }
            }
            catch (Exception e)
            {
                throw e;

            }
            finally { cmd.Connection.Close(); }
            return lista;
        }



        public Boolean ModificarPropietario(entPropietario Propietario)
        {
            SqlCommand cmd = null;
            Boolean modificar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spModificarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Propietario.id);
                cmd.Parameters.AddWithValue("@dni", Propietario.dni);
                cmd.Parameters.AddWithValue("@nombre", Propietario.nombre);
                cmd.Parameters.AddWithValue("@apellido", Propietario.apellido);
                cmd.Parameters.AddWithValue("@edad", Propietario.edad);
                cmd.Parameters.AddWithValue("@celular", Propietario.celular);
                cmd.Parameters.AddWithValue("@Direccion", Propietario.direccion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    modificar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return modificar;
        }



        public Boolean BuscaPropietario(entPropietario Propietario)
        {
            Boolean encontrado = false;
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", Propietario.dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    encontrado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return encontrado;
        }


        public entPropietario DatosPropietario(int dni)
        {
            entPropietario prop = new entPropietario();
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDatosPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    prop.id = Convert.ToInt32(dr["id"]);
                    prop.dni = Convert.ToInt32(dr["dni"]);
                    prop.nombre = dr["nombre"].ToString();
                    prop.apellido = dr["apellido"].ToString();
                    prop.edad = Convert.ToInt32(dr["edad"]);
                    prop.celular = Convert.ToInt32(dr["celular"]);
                    prop.direccion = dr["direccion"].ToString();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return prop;
        }
        public Boolean HabilitarPropietario(entPropietario Propietario)
        {
            SqlCommand cmd = null;
            Boolean Habilitar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spHabilitarPropietario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Propietario.id);
                cmd.Parameters.AddWithValue("@dni", Propietario.dni);
                cmd.Parameters.AddWithValue("@nombre", Propietario.nombre);
                cmd.Parameters.AddWithValue("@apellido", Propietario.apellido);
                cmd.Parameters.AddWithValue("@edad", Propietario.edad);
                cmd.Parameters.AddWithValue("@celular", Propietario.celular);
                cmd.Parameters.AddWithValue("@direccion", Propietario.direccion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Habilitar = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return Habilitar;
        }
    }
}
