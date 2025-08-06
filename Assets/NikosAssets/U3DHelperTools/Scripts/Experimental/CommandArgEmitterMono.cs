using System.Linq;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

namespace NikosAssets.Helpers.Experimental
{
    public class CommandArgEmitterMono : BaseNotesMono
    {
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_EVENTS)]
        public UnityEvent OnContainsArg;
        
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        private string _containsArg = "";

        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        private bool _invertContainsArg = false;

        private void Awake()
        {
            bool emit = DevHelper.GetCommandLineArgs.Contains(_containsArg);
            emit = _invertContainsArg ? !emit : emit;

            if(emit)
                OnContainsArg.Invoke();
        }
    }
}
