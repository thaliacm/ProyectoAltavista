﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logSitioInteres
    {
        #region singleton
        private static readonly logSitioInteres _instancia = new logSitioInteres();
        public static logSitioInteres Instancia
        {
            get { return logSitioInteres._instancia; }
        }
        #endregion singleton

        public List<entSitioInteres> ListarSitioInteres()
        {
            return datSitioInteres.Instancia.ListarSitioInteres();
        }
        public void RegistrarSI(entSitioInteres Sitio)
        {
            datSitioInteres.Instancia.IngresoSitioInteres(Sitio);
        }
        public void EditarSI(entSitioInteres Sitio)
        {
            datSitioInteres.Instancia.EditarSitioInteres(Sitio);
        }
        public Boolean BuscarSitioInteres(entSitioInteres Sitio)
        {
            return datSitioInteres.Instancia.BuscarSitioInteres(Sitio);
        }
        public entSitioInteres DatosSitioInteres(int codSitioInteres)
        {
            return datSitioInteres.Instancia.DatosSitioInteres(codSitioInteres);
        }
        public void DeshabilitarSitioInteres(entSitioInteres Sitio)
        {
          datSitioInteres.Instancia.DeshabilitarSitioInteres(Sitio);
        }
    }
}
