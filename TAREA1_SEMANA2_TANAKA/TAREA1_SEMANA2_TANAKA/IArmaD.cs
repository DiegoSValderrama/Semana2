﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAREA1_SEMANA2_TANAKA
{
    interface IArmaDistancia : IArmas
    {
        string Proyectil { get; set; }
        double VelocidadProyectil { get; set; }
    }
}
