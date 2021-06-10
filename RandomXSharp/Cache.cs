using System;
using RandomXSharp.Internals;

namespace RandomXSharp
{
    public class Cache : IDisposable
    {
        internal readonly IntPtr _handle;

        public Cache(Flags flags, byte[] key)
        {
            SequenceLogger.Log("Calling randomx_alloc_cache()...");
            _handle = LibRandomx.Instance.randomx_alloc_cache(flags);
            SequenceLogger.Log("Calling randomx_init_cache()...");
            LibRandomx.Instance.randomx_init_cache(_handle, key, (UIntPtr)key.Length);
            SequenceLogger.Log("Called randomx_init_cache().");
        }

        public void Dispose()
        {
            SequenceLogger.Log("Calling randomx_release_cache()...");
            LibRandomx.Instance.randomx_release_cache(_handle);
            SequenceLogger.Log("Called randomx_release_cache().");
        }
    }
}
