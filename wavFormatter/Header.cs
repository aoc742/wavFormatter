using System;
using System.Collections.Generic;
using System.Text;

namespace wavFormatter
{
    // Source of .WAV file specification: http://soundfile.sapp.org/doc/WaveFormat/

    class Header
    {
        // 0x52494646 big-endian ASCII
        private char[] chunkID = new char[4]; // "RIFF" Chunk ID
        private char[] chunkSize = new char[4];
        private char[] format = new char[4]; // "WAVE"
        private char[] subchunkID = new char[4];


    }
}
