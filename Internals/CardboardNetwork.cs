using Cardboard.Classes;
using HarmonyLib;
using Photon.Pun;

namespace Cardboard.Internals
{
    public class CardboardNetwork : MonoBehaviourPunCallbacks
    {
        [HarmonyPatch(typeof(FusionHub), "JoinedRoom")]
        public class FusionNetworkJoin
        {
            // why does it made me do it like this?
            static void Postfix()
            {
                if (FusionHub.currentQueue.ToLower().Contains("modded")) { CardboardModded.CallModdedEvent(ModdedEventType.ModdedJoin); }
            }
        }

        [HarmonyPatch(typeof(FusionHub), "Leave")]
        public class FusionNetworkLeave
        {
            static void Postfix() => CardboardModded.CallModdedEvent(ModdedEventType.ModdedLeave);
        }
    }
}
