﻿using System.IO;
using Composite.Core.IO.Plugins.IOProvider;


namespace Composite.Plugins.IO.IOProviders.LocalIOProvider
{
    internal class LocalC1FileStream : IC1FileStream
    {
        private FileStream _fileStream;



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public LocalC1FileStream(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options)
        {
            _fileStream = new System.IO.FileStream(path, mode, access, share, bufferSize, options);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public string Name
        {
            get
            {
                return _fileStream.Name;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public long Length
        {
            get
            {
                return _fileStream.Length;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void SetLength(long value)
        {
            _fileStream.SetLength(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public long Position
        {
            get
            {
                return _fileStream.Position;
            }
            set
            {
                _fileStream.Position = value;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public int Read(byte[] array, int offset, int count)
        {
            return _fileStream.Read(array, offset, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public int ReadByte()
        {
            return _fileStream.ReadByte();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Write(byte[] array, int offset, int count)
        {
            _fileStream.Write(array, offset, count);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void WriteByte(byte value)
        {
            _fileStream.WriteByte(value);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public long Seek(long offset, SeekOrigin origin)
        {
            return _fileStream.Seek(offset, origin);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public bool CanRead
        {
            get
            {
                return _fileStream.CanRead;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public bool CanSeek
        {
            get
            {
                return _fileStream.CanSeek;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public bool CanWrite
        {
            get
            {
                return _fileStream.CanWrite;
            }
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Flush()
        {
            _fileStream.Flush();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Flush(bool flushToDisk)
        {
            _fileStream.Flush(flushToDisk);
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Close()
        {
            _fileStream.Close();
        }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Composite.IO", "Composite.DoNotUseFileStreamClass:DoNotUseFileStreamClass")]
        public void Dispose()
        {
            this.Close();

            _fileStream.Dispose();
            _fileStream = null;
        }
    }
}
