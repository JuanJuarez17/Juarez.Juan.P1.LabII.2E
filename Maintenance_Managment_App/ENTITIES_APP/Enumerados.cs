using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES_APP
{
    // Enum para Operator
    public enum Division
    {
        Mecanica,
        Electricidad,
        Electronica,
        Limpieza,
    }

    // Enum para MaintenanceOrder
    public enum Machine
    {
        Torno,
        Fresadora,
        CentroCNC,
        Brochadora,
        Agujereadora01,
        Agujereadora02,
        GrabadoraLaser,
        Autoelevador01,
        Autoelevador02,
        Otro,
    }
    public enum Section
    {
        Matriceria,
        Mecanizado,
        Pintura,
        Ensamble,
        Almacen,
        Otro,
    }

    public enum Urgency
    {
        Programable,
        Normal,
        Urgente
    }

}
