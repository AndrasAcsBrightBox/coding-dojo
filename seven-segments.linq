<Query Kind="Program" />

void Main()
{
	var solution = "";
            for (var i = 4; i < 8; i++)
                solution += GetSevenSegmentString(i) + Environment.NewLine;
	solution.Dump();
}

        private const string doubleSpace = "  ";
        private const string singleSpace = " ";
        private const string hLine = "|";
        private const string firstLineVLine = " __ ";
        private const string vLine = "__";

        public static string GetSevenSegments(int num)
        {
            if (num < 0 || num > 9) throw new ArgumentException();
            switch (num)
            {
                case 0:
                    return GetStringRepresentation(a: true, b: true, c: true, d: true, e: true, f: true);
                case 1:
                    return GetStringRepresentation(b: true, c: true);
                case 2:
                    return GetStringRepresentation(a: true, b: true, g: true, e: true, d: true);
                case 3:
                    return GetStringRepresentation(a: true, b: true, g: true, c: true, d: true);
                case 4:
                    return GetStringRepresentation(f: true, g: true, b: true, c: true);
                case 5:
                    return GetStringRepresentation(a: true, f: true, g: true, c: true, d: true);
                case 6:
                    return GetStringRepresentation(a: true, f: true, g: true, e: true, c: true, d: true);
                case 7:
                    return GetStringRepresentation(a: true, b: true, c: true);
                case 8:
                    return GetStringRepresentation(a: true, b: true, c: true, d: true, e: true, f: true, g: true);
                case 9:
                    return GetStringRepresentation(a: true, b: true, c: true, d: true, f: true, g: true);
                default: throw new ArgumentException();
            }
        }

        static string GetStringRepresentation
            (bool a = false, bool b = false, bool c = false, bool d = false, bool e = false, bool f = false, bool g = false)
        {
            string s = "";
            s += a
                ? firstLineVLine
                : singleSpace;
            s += Environment.NewLine;
            s += f
                ? hLine
                : singleSpace;
            s += doubleSpace;
            s += b
                ? hLine
                : singleSpace;
            s += Environment.NewLine;
            s += f
                ? hLine
                : singleSpace;
            s += g
                ? vLine
                : doubleSpace;
            s += b
                ? hLine
                : singleSpace;
            s += Environment.NewLine;
            s += e
                ? hLine
                : singleSpace;
            s += doubleSpace;
            s += c
                ? hLine
                : singleSpace;
            s += Environment.NewLine;
            s += e
               ? hLine
               : singleSpace;
            s += d
                ? vLine
                : doubleSpace;
            s += c
                ? hLine
                : singleSpace;
            return s;
        }

// Define other methods and classes here