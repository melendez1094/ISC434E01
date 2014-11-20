using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Practica1.Modelo
{
    class ObjetoVisual
    {
        #region Propiedades

        public Picture Picture { get; set; }
        public Coordenada Coordenada { get; set; }
        public Tamano Tamano { get; set; }

        public List<ObjetoVisual> ObjetosVisuales { get; set; }
        #endregion
    }
}
