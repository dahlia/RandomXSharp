using RandomXSharp.Internals;

namespace RandomXSharp
{
    public static class RecommendedFlags
    {
        public static Flags Flags
        {
            get
            {
                SequenceLogger.Log("Calling randomx_get_flags()...");
                var f = LibRandomx.Instance.randomx_get_flags();
                SequenceLogger.Log("Called randomx_get_flags().");
                return f;
            }
        }
    }
}
