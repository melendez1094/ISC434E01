using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Modelo
{
    class Capa
    {
        #region Propiedades

        public Coordenada Coordenada { get; set; }
        public Tamano Tamano { get; set; }
        public List<ObjetoVisual> ObjetosVisuales { get; set; }
        public List<Capa> Capas { get; set; }

        #endregion

        #region Metodos
        public void AgregarObjeto(ObjetoVisual Objeto)
        { }
        public void EliminarObjeto(ObjetoVisual Objeto)
        { }
        public void MoverObjeto(ObjetoVisual Objeto)
        { }

        #endregion
    }
}
