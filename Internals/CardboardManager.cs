using UnityEngine;

namespace Cardboard.Internals
{
    public class CardboardManager : MonoBehaviour
    {
        public static CardboardManager instance { get; private set; }

        void Start()
        {
            instance = this;
        }
    }
}
