using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace Core
{
    /// <summary>
    /// Common helper functions
    /// </summary>
    public class Helper
    {
        public static void ReadWriteStream(Stream readStream, Stream writeStream)
        {
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            
            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
            }
            readStream.Close();
            writeStream.Close();
        }

        public static void RunShell(string command)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = command;
            proc.Start();
        }

        public static void RunShell(string command, string arguments)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.EnableRaisingEvents = false;
            proc.StartInfo.FileName = command;
            proc.StartInfo.Arguments = arguments;
            proc.Start();
        }

        public static string ToRtfString(string s)
        {
            // unicode rtf conversion
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (c > 255)
                {   // rtf tag: \uNc, N-unicode character code, c character for non-unicode parsers
                    result.Append("\\u" + ((int)c).ToString() + '?');
                }
                else
                {
                    result.Append(c);
                }
            }
            return result.ToString().Replace("m³", "m\\'b3");
        }


        public static string RtfTrueTick()
        {
            return @"{\rtf1{\pict\wmetafile8\picwgoal195\pichgoal195 
                    0100090000039a00000000007500000000000400000003010800050000000b0200000000050000
                    000c020e000e00030000001e00040000000701040075000000410b2000cc000d000d0000000000
                    0d000d0000000000280000000d0000000d00000001000400000000000000000000000000000000
                    00000000000000000000000000ffffff00fefefe00000000000000000000000000000000000000
                    000000000000000000000000000000000000000000000000000000000000000000000000000000
                    000000022222222222000602222222222200020222202222220000022200022222000202200000
                    222200000220020002220002022022200022000702222222002200020222222220220000022222
                    222222000002222222222200000000000000000000040000002701ffff030000000000
                    }}";
        }

        public static string RtfFalseTick()
        {
            return @"{\rtf1{\pict\wmetafile8\picwgoal179\pichgoal195 
                    0100090000039a00000000007500000000000400000003010800050000000b0200000000050000
                    000c0208000800030000001e00040000000701040075000000410b2000cc000d000c0000000000
                    0700070000000000280000000c0000000d00000001000400000000000000000000000000000000
                    00000000000000000000000000ffffff00fefefe00000000000000000000000000000000000000
                    000000000000000000000000000000000000000000000000000000000000000000000000000000
                    000000022222222220020202222222222002000222222222200202022222222220020202000000
                    002002000200000000200202020000000020000002222222222002000222222222200000022222
                    222220000002222222222002000000000000000202040000002701ffff030000000000
                    }}";
        }
        public static string RtfNothingTick()
        {
            return @"{\rtf1{\pict\wmetafile8\picwgoal179\pichgoal195 
                    0100090000039a00000000007500000000000400000003010800050000000b0200000000050000
                    000c0208000800030000001e00040000000701040075000000410b2000cc000d000c0000000000
                    0700070000000000280000000c0000000d00000001000400000000000000000000000000000000
                    00000000000000000000000000ffffff00fefefe00000000000000000000000000000000000000
                    000000000000000000000000000000000000000000000000000000000000000000000000000000
                    000000022222222220020202222222222002000222222222200202022222222220020202000000
                    002002000200000000200202020000000020000002222222222002000222222222200000022222
                    222220000002222222222002000000000000000202040000002701ffff030000000000
                    }}";
        }

        public static string RtfTrueTableTick()
        {
            return @"{\rtf1{\pict\wmetafile8\picwgoal240\pichgoal225 
                    010009000003a200000000007d00000000000400000003010800050000000b0200000000050000
                    000c0210001100030000001e0004000000070104007d000000410b2000cc000f00100000000000
                    0f0010000000000028000000100000000f00000001000400000000000000000000000000000000
                    00000000000000000000000000ffffff00999999006666660033333300cccccc00000000000000
                    000000000000000000000000000000000000000000000000000000000000000000001115211111
                    111111111403111111111111100051111111111130004111111111150030421111111114041203
                    511111111432154021111111111111540511111111111112041111111111111130411111111111
                    111304111111111111113041111111111111120011111111111111100111111111111111110400
                    00002701ffff030000000000
                    }}";
        }
        public static string RtfFalseTableTick()
        {
            return "";
        }
    }
}
