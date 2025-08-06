using System;
using NaughtyAttributes;

namespace NikosAssets.Helpers.Experimental
{
    public class CommandArgsEditorMono : BaseNotesMono
    {
#if UNITY_EDITOR
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_EDITORONLY)]
        public string[] editorCommands = Array.Empty<string>();
#endif
    }
}
