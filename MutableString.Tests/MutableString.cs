using System.Runtime.InteropServices;

namespace MutableString.Tests
{
    [StructLayout(LayoutKind.Explicit)]
    public struct MutableString
    {
        private const int Offset = 0;
        
        [FieldOffset(0)]
        private readonly string _asString;
        
        [FieldOffset(0)]
        private readonly char[] _asMutable;

        public char this[int index]
        {
            get => _asMutable[index + Offset];

            set => _asMutable[index + Offset] = value;
        }

        public MutableString(string original)
        {
            _asMutable = null;
            _asString = original;
        }
    }
}