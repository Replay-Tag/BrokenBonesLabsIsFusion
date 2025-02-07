﻿using LabFusion.MarrowIntegration;
using LabFusion.Utilities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace LabFusion.Data {
    public class AscentDMData : DMLevelDataHandler {
        public override string LevelTitle => "13 - Ascent";

        protected override Vector3[] DeathmatchSpawnPoints => new Vector3[9] {
    new Vector3(-52.726f, 0.9224f, -109.7318f),
    new Vector3(-48.1395f, -10.7126f, -100.4935f),
    new Vector3(-45.7142f, -2.7126f, -128.9812f),
    new Vector3(-52.0538f, 5.9993f, -106.6313f),
    new Vector3(-42.6469f, 6.7974f, -121.3241f),
    new Vector3(-54.4932f, 10.2287f, -135.039f),
    new Vector3(-54.103f, 12.7674f, -124.1091f),
    new Vector3(-42.0812f, -10.7126f, -137.8919f),
    new Vector3(-55.4245f, -3.9879f, -120.9371f),
        };
    }
}
