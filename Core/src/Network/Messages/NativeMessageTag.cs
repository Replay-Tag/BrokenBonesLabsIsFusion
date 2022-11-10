﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFusion.Network
{
    public static class NativeMessageTag
    {
        public static byte
            Unknown = 0,

            ConnectionRequest = 1,
            ConnectionResponse = 2,
            Disconnect = 3,

            PlayerRepTransform = 4,
            PlayerRepAvatar = 5,
            PlayerRepVitals = 6,

            PlayerRepGrab = 7,
            PlayerRepForceGrab = 18,
            PlayerRepRelease = 8,
            PlayerRepAnchors = 9,

            SceneLoad = 10,

            SyncableIDRequest = 11,
            SyncableIDResponse = 12,
            SyncableOwnershipRequest = 19,
            SyncableOwnershipResponse = 20,

            PropSyncableUpdate = 13,

            WorldGravity = 14,

            SpawnRequest = 15,
            SpawnResponse = 16,
            DespawnPoolee = 17,

            ModuleMessage = 80;
    }

}
