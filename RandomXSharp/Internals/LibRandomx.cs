using AdvancedDLSupport;

namespace RandomXSharp.Internals
{
    internal static class LibRandomx
    {
        public static ILibRandomx Instance { get; }

        static LibRandomx()
        {
            SequenceLogger.Log("Initializing instance...");
            Instance = NativeLibraryBuilder.Default.ActivateInterface<ILibRandomx>("randomx");
            SequenceLogger.Log("Initialized instance.");
        }
    }
}
