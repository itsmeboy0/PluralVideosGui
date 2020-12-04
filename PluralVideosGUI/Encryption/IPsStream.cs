﻿using System.IO;

namespace PluralVideosGui.Encryption
{
    public interface IPsStream
    {
        void Dispose();
        int Read(byte[] pv, int i, int count);
        void Seek(int offset, SeekOrigin begin);

        long Length { get; }

        int BlockSize { get; }
    }
}
