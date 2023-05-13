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
        CentroCNC,
        Brochadora,
        Agujereadora,
        GrabadoraLaser,
        Autoelevador,
        Otro,
    }
    public enum Section
    {
        Matriceria,
        Mecanizado,
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
