using UnityEngine;

namespace NikosAssets.Helpers
{
    public class PauseUnityPlayModeMono : BaseNotesMono
    {
        public void Pause()
        {
            Debug.Break();
        }
    }
}
