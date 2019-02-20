using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryReader
{
    internal static class Format
    {
        internal static IEnumerable<string> Lines(IReadOnlyCollection<byte> bytes)
        {
            //            "<8digit><4s>X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2 X2<4s><   16 chars   >"
            yield return $"            +0 +1 +2 +3 +4 +5 +6 +7 +8 +9 +A +B +C +D +E +F    0123456789ABCDEF{Environment.NewLine}";
            foreach (var line in bytes.Buffer(16).Select((bs, i) => (idx: i, bytes:bs)))
            {
                var byteExpressions = line.bytes.Select(b => $"{b:X2}").Concat(Enumerable.Repeat("  ", 16)).Take(16);
                var charExpressions = line.bytes.Select(b => char.IsLetter((char)b) || char.IsDigit((char)b) ? (char)b : '.' ).Concat(Enumerable.Repeat(' ', 16)).Take(16);
                yield return $"{line.idx:X7}0    {string.Join(" ",byteExpressions)}    {string.Join(string.Empty, charExpressions)}{Environment.NewLine}";
            }
        }
    }
}
