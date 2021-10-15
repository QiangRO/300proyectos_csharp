//  THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
//  PURPOSE.
//
//  This material may not be duplicated in whole or in part, except for 
//  personal use, without the express written consent of the author. 
//
//  Email:  ianier@hotmail.com
//
//  Copyright (C) 1999-2003 Ianier Munoz. All Rights Reserved.

using System;
using System.IO;

namespace Wave.Wave_Class
{
    public class WaveBuffer
    {
        public WaveData[] Waves;
        public int Lenght;
        public int Count;
        public int Sequence=0;
        public int ReadSequence=0;
        public bool OverFllow = false;
        public void Add(short n)
        {
            if (Waves[Sequence].Add(n))
            {
                if (++Sequence == Count)
                    Sequence = 0;
                if (Waves[Sequence].Full)
                    OverFllow = true;
                Waves[Sequence].Reset();
                Waves[Sequence].Add(n);
            }
        }
        public WaveData GetFirst()
        {
            if (Waves[ReadSequence].Full)
            {
                WaveData r = Waves[ReadSequence];
                if (++ReadSequence == Count)
                {
                    ReadSequence = 0;
                }
                return r;
            }
            return null;
        }
        public void Reset()
        {
            for (int i = 0; i < Count; i++)
            {
                Waves[i] = new WaveData(Lenght);
            }
            ReadSequence = Sequence = 0;
        }
        public WaveBuffer(int BufferCount,int BufferLen)
        {
            Lenght = BufferLen;
            Count = BufferCount;
            Waves=new WaveData[Count];
            for (int i = 0; i < Count; i++)
            {
                Waves[i] = new WaveData(BufferLen);
            }
        }
    }
    public class WaveData
    {
        public int _WaveBufferLen_ = WaveFile._WaveBufferLen_;
        public short[] Wave;
        public bool Full;
        public int Count;
        public bool Shifting;
        public bool Changed = false;
        public bool Add(short n)
        {
            Changed = true;
            if (Shifting)
            {
                for (int i = Wave.Length - 1; i > 0; i--) Wave[i] = Wave[i - 1];
                Wave[0] = n;
                Count++;
                if (Count == Wave.Length) return (Full = true);
            }
            else
            {

                if (Count == Wave.Length) return (true);
                short m;
                m = (short)((n << 7) - 32000);
                 
                Wave[Count++] = (short)(m);
                if (Count == Wave.Length) return (Full = true);
            }
            return false;
        }
        public void Reset()
        {
            Count = 0;
            Full = false;
            for (int i = 0; i < Wave.Length; i++) Wave[i] = 0;
        }
        public WaveData(bool ShiftFlag)
        {
            Wave = new short[_WaveBufferLen_];
            Shifting = ShiftFlag;
            Reset();
        }
        public WaveData()
        {
            Wave = new short[_WaveBufferLen_];
            Shifting = true;
            Reset();
        }
        public WaveData(int BufferLen)
        {
            _WaveBufferLen_ = BufferLen;
            Wave = new short[BufferLen];
            Shifting = false;
            Reset();
        }
    }
    public struct WaveHeader
    {
        public char[] ChunkID;
        public int ChunkSize;
        public char[] ChunkFmt;
        public char[] SubChunk1ID;
        public int SubChunk1Size;
        public short AudioFormat;
        public short NumChannels;
        public int SampleRate;
        public int ByteRate;
        public short BlockAlign;
        public short BitPerSample;
        public char[] subChunk2ID;
        public int SubChunk2Size;
    };
    public class WaveFile
    {
        public const int _WaveBufferLen_ = 4096;
        byte[] data = new byte[(_WaveBufferLen_ * 2)];
        public bool Opened;
        System.IO.FileStream rfp;
        public WaveHeader wh = new WaveHeader();
        System.IO.BinaryWriter bw;
        public string fn;
        int SampleCount;

        public void WaveInit()
        {
            wh.ChunkID = "RIFF".ToCharArray();
            wh.ChunkFmt = "WAVE".ToCharArray();
            wh.SubChunk1ID = "fmt ".ToCharArray();
            wh.SubChunk1Size = 16;
            wh.AudioFormat = 1;
            wh.subChunk2ID = "data".ToCharArray();
        }
        public void Set(short channels, int samplerate, short datasize)
        {
            WaveInit();
            wh.NumChannels = channels;
            wh.SampleRate = samplerate;
            wh.BlockAlign = (short)(datasize * channels / 8);
            wh.ByteRate = samplerate * wh.BlockAlign;
            wh.BitPerSample = datasize;
        }

        void Fin(short channels, int samplerate, short datasize, int totalsamples)
        {
            Set(channels, samplerate, datasize);
            wh.SubChunk2Size = totalsamples * wh.BlockAlign;
            wh.ChunkSize = wh.SubChunk2Size + 36;
        }
        public void Fine(int totalsamples)
        {
            wh.SubChunk2Size = totalsamples * wh.BlockAlign;
            wh.ChunkSize = wh.SubChunk2Size + 36;
        }
        public bool Open(string FileName, short channels, int samplerate, short datasize)
        {
            if (!Opened)
            {
                WaveInit();
                fn = FileName;
                try
                {
                    rfp = new System.IO.FileStream(fn, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write, System.IO.FileShare.None);
                    bw = new System.IO.BinaryWriter(rfp);
                    Set(channels, samplerate, datasize);
                    Opened = true;
                }
                catch
                {

                }

                SampleCount = 0;
                return true;
            }
            return false;
        }
        public bool WriteBlock(short[] Buf)
        {
            Buffer.BlockCopy(Buf, 0, data, 0, (_WaveBufferLen_ * 2));
            bw.Write(data);
            SampleCount += Buf.Length;
            return true;
        }

        public bool Close()
        {

            if (Opened)
            {
                Opened = false;
                bw.Close();
                rfp.Close();
                rfp = new System.IO.FileStream(fn, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
                bw = new System.IO.BinaryWriter(rfp);
                try
                {
                    Fine(SampleCount);
                    bw.Write(new char[4] { 'R', 'I', 'F', 'F' });

                    bw.Write(wh.ChunkSize);

                    bw.Write(new char[8] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });

                    bw.Write(wh.SubChunk1Size);

                    bw.Write(wh.AudioFormat);
                    bw.Write(wh.NumChannels);

                    bw.Write(wh.SampleRate);

                    bw.Write(wh.ByteRate);//(samplerate * ((BitsPerSample * channels) / 8)));

                    bw.Write(wh.BlockAlign);//((BitsPerSample * channels) / 8));

                    bw.Write(wh.BitPerSample);//BitsPerSample);

                    bw.Write(new char[4] { 'd', 'a', 't', 'a' });
                    bw.Write(wh.SubChunk2Size);//DataLength);
                    bw.Close();
                    rfp.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;

        }



        public WaveFile()
        {
            wh.ChunkID = new char[4];
            wh.ChunkFmt = new char[4];
            wh.SubChunk1ID = new char[4];
            wh.subChunk2ID = new char[4];
            Opened = false;
            WaveInit();
        }
    }
    public class WaveStream : Stream, IDisposable
	{
		private Stream m_Stream;
		private long m_DataPos;
		private long m_Length;

		private WaveFormat m_Format;

		public WaveFormat Format
		{
			get { return m_Format; }
		}

		private string ReadChunk(BinaryReader reader)
		{
			byte[] ch = new byte[4];
			reader.Read(ch, 0, ch.Length);
			return System.Text.Encoding.ASCII.GetString(ch);
		}

		private void ReadHeader()
		{
			BinaryReader Reader = new BinaryReader(m_Stream);
			if (ReadChunk(Reader) != "RIFF")
				throw new Exception("Invalid file format");

			Reader.ReadInt32(); // File length minus first 8 bytes of RIFF description, we don't use it

			if (ReadChunk(Reader) != "WAVE")
				throw new Exception("Invalid file format");

			if (ReadChunk(Reader) != "fmt ")
				throw new Exception("Invalid file format");

			int len = Reader.ReadInt32();
			if (len < 16) // bad format chunk length
				throw new Exception("Invalid file format");

			m_Format = new WaveFormat(22050, 16, 2); // initialize to any format
			m_Format.wFormatTag = Reader.ReadInt16();
			m_Format.nChannels = Reader.ReadInt16();
			m_Format.nSamplesPerSec = Reader.ReadInt32();
			m_Format.nAvgBytesPerSec = Reader.ReadInt32();
			m_Format.nBlockAlign = Reader.ReadInt16();
			m_Format.wBitsPerSample = Reader.ReadInt16(); 

			// advance in the stream to skip the wave format block 
			len -= 16; // minimum format size
			while (len > 0)
			{
				Reader.ReadByte();
				len--;
			}

			// assume the data chunk is aligned
			while(m_Stream.Position < m_Stream.Length && ReadChunk(Reader) != "data")
				;

			if (m_Stream.Position >= m_Stream.Length)
				throw new Exception("Invalid file format");

			m_Length = Reader.ReadInt32();
			m_DataPos = m_Stream.Position;

			Position = 0;
		}

		public WaveStream(string fileName) : this(new FileStream(fileName, FileMode.Open))
		{
		}
		public WaveStream(Stream S)
		{
			m_Stream = S;
			ReadHeader();
		}
		~WaveStream()
		{
			Dispose();
		}
		public void Dispose()
		{
			if (m_Stream != null)
				m_Stream.Close();
			GC.SuppressFinalize(this);
		}

		public override bool CanRead
		{
			get { return true; }
		}
		public override bool CanSeek
		{
			get { return true; }
		}
		public override bool CanWrite
		{
			get { return false; }
		}
		public override long Length
		{
			get { return m_Length; }
		}
		public override long Position
		{
			get { return m_Stream.Position - m_DataPos; }
			set { Seek(value, SeekOrigin.Begin); }
		}
		public override void Close()
		{
			Dispose();
		}
		public override void Flush()
		{
		}
		public override void SetLength(long len)
		{
			throw new InvalidOperationException();
		}
		public override long Seek(long pos, SeekOrigin o)
		{
			switch(o)
			{
				case SeekOrigin.Begin:
					m_Stream.Position = pos + m_DataPos;
					break;
				case SeekOrigin.Current:
					m_Stream.Seek(pos, SeekOrigin.Current);
					break;
				case SeekOrigin.End:
					m_Stream.Position = m_DataPos + m_Length - pos;
					break;
			}
			return this.Position;
		}
		public override int Read(byte[] buf, int ofs, int count)
		{
			int toread = (int)Math.Min(count, m_Length - Position);
			return m_Stream.Read(buf, ofs, toread);
		}
		public override void Write(byte[] buf, int ofs, int count)
		{
			throw new InvalidOperationException();
		}
	}
}
