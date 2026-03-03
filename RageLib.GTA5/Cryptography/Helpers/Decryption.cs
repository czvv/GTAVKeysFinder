// Copyright © Neodymium, carmineos and contributors. See LICENSE.md in the repository root for more information.

using RageLib.Data;
using System.IO;

namespace RageLib.GTA5.Cryptography.Helpers
{
    public class Decryption
    {
        
        // round 1,2,16
        public static byte[] DecryptNGRoundA(byte[] data, uint[] key, uint[][] table)
        {
            var x1 =
                table[0][data[0]] ^
                table[1][data[1]] ^
                table[2][data[2]] ^
                table[3][data[3]] ^
                key[0];
            var x2 =
                table[4][data[4]] ^
                table[5][data[5]] ^
                table[6][data[6]] ^
                table[7][data[7]] ^
                key[1];
            var x3 =
                table[8][data[8]] ^
                table[9][data[9]] ^
                table[10][data[10]] ^
                table[11][data[11]] ^
                key[2];
            var x4 =
                table[12][data[12]] ^
                table[13][data[13]] ^
                table[14][data[14]] ^
                table[15][data[15]] ^
                key[3];

            var result = new byte[16];
            Array.Copy(BitConverter.GetBytes(x1), 0, result, 0, 4);
            Array.Copy(BitConverter.GetBytes(x2), 0, result, 4, 4);
            Array.Copy(BitConverter.GetBytes(x3), 0, result, 8, 4);
            Array.Copy(BitConverter.GetBytes(x4), 0, result, 12, 4);
            return result;
        }


    }
}