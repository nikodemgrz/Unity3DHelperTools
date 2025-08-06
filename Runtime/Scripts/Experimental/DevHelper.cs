using System.Linq;
using UnityEngine;

namespace NikosAssets.Helpers.Experimental
{
    /// <summary>
    /// Experimental helper class to find out if your windows build is in dev or admin mode when you enter the "dev" arg (no "-" prefix!) when launching the .exe.
    /// This is independent of a release or development build
    /// </summary>
    public static class DevHelper
    {
#if UNITY_EDITOR
        private static CommandArgsEditorMono _commandArgsEditor;

        public static CommandArgsEditorMono CommandArgsEditor
        {
            get
            {
                if (_commandArgsEditor == null)
                    _commandArgsEditor = Component.FindAnyObjectByType<CommandArgsEditorMono>(FindObjectsInactive.Include);

                return _commandArgsEditor;
            }
        }
#endif
        
        public const string DEV_MODE_ARG = "dev";
        public static bool IsDevMode =>
#if UNITY_EDITOR
            true;
#elif UNITY_STANDALONE_WIN
            System.Environment.GetCommandLineArgs().Contains(DEV_MODE_ARG);
#else
            false;
#endif

        public static string[] GetCommandLineArgs =>
#if UNITY_EDITOR
            CommandArgsEditor != null ? CommandArgsEditor.editorCommands : new string[0];
#elif UNITY_STANDALONE_WIN
            IsDevMode ? System.Environment.GetCommandLineArgs() : new string[0];
#else
            new string[0];
#endif

        public static bool ContainsArg(string commandArg)
        {
            return GetCommandLineArgs.Any(arg => 
                //contains and not equals check, because there could also be assignment and value chars (like '=' or ':' coupled with any number or string)
                arg.Contains(commandArg));
        }

        public static double ParseNumber(string commandArg, string argAndNumberSeparator = "=")
        {
            string[] args = GetCommandLineArgs;
            return double.Parse(args.First(arg => arg.Contains(commandArg)).TrimStart((commandArg + argAndNumberSeparator).ToCharArray()));
        }

    }
}
