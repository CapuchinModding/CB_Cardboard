using HarmonyLib;
using System.Reflection;
using System.Collections.Generic;

namespace Cardboard.Utils
{
    /// <summary>
    /// A class providing simple Harmony patching.
    /// </summary>
    public class CardboardHarmony
    {
        private static Dictionary<Assembly, Harmony> patchedInstances = new Dictionary<Assembly, Harmony>();

        /// <summary>
        /// Patches the assembly based on the GUID provided and returns the Harmony class used to patch the plugin.
        /// </summary>
        /// <param name="_instance">The mod GUID.</param>
        /// <returns>The Harmony instance that was used to patch it.</returns>
        public static Harmony PatchInstance(string GUID)
        {
            Harmony thisHarmony = new Harmony(GUID);
            thisHarmony.PatchAll(Assembly.GetCallingAssembly());

            return thisHarmony;
        }


        /// <summary>
        /// Unpatches the calling assembly.
        /// </summary>
        public static void UnpatchInstance()
        {
            Assembly searchingAssembly = Assembly.GetCallingAssembly();
            Harmony patchedInstance = null;

            patchedInstances.TryGetValue(searchingAssembly, out patchedInstance);

            if (patchedInstance != null)
                patchedInstance.UnpatchSelf();
        }

        /// <summary>
        /// Unpatches the assembly of _instance.
        /// </summary>
        /// <param name="_instance">The patched Harmony instance.</param>
        public static void UnpatchInstance(Harmony _instance) => _instance.UnpatchSelf();
    }
}