using UnityEngine;

namespace NikosAssets.Helpers
{
    public class QuitApplicationMono : BaseNotesMono
    {
        public void Quit()
        {
            Application.Quit();
        }
        
        public void Quit(int exitCode)
        {
            Application.Quit(exitCode);
        }
    }
}
