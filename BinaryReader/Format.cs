using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryReader
{
    internal static class Format
    {
        private const int hex = 16;
        private const string sep = "    ";
        internal static IEnumerable<string> Lines(IReadOnlyCollection<byte> bytes)
        {
            //            "<8digit><4s>X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2<4s><   16 chars   >"
            yield return $"        {sep}+0 +1 +2 +3 +4 +5 +6 +7 +8 +9 +A +B +C +D +E +F{sep}0123456789ABCDEF{Environment.NewLine}";
            foreach (var line in bytes.Buffer(hex).Select((bs, i) => (idx: i, bytes:bs)))
            {
                var byteExpressions = line.bytes.Select(b => $"{b:X2}").Concat(Enumerable.Repeat("  ", hex)).Take(hex);
                var charExpressions = line.bytes.Select(b => char.IsLetter((char)b) || char.IsDigit((char)b) ? (char)b : '.' ).Concat(Enumerable.Repeat(' ', hex)).Take(hex);
                yield return $"{line.idx:X7}0{sep}{string.Join(" ",byteExpressions)}{sep}{string.Join(string.Empty, charExpressions)}{Environment.NewLine}";
            }
        }
    }
}
