﻿using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajednicki
{
    [Serializable]
    public class Odgovor
    {
        public Signal Signal { get; set; }
        public Trener Trener { get; set; }
        public List<GrupaZaTrening> Grupe { get; set; }
    }

    public enum Signal
    {
        UspesnoPrijavljen,
        ClanUspesnoDodat
    }
}