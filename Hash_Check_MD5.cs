/* This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Hash_Checker
{
    public delegate void OnFinishEventHandler();
    public delegate void OnProgressUpdateEventHandler();

    class Hash_Check_MD5
    {
        private Thread _Thread;
        private string _Hash;
        private int _progress;

        public string MD5_Hash
        {
            get { return _Hash; }
        }

        public int Progress
        {
            get { return _progress; }
        }


        public event OnFinishEventHandler OnFinish;
        public event OnProgressUpdateEventHandler OnProgressUpdate;

        //pokrece izracun
        public void Check_Hash(string str)
        {
            _Thread = new Thread(new ParameterizedThreadStart(Check_Hash_Thread));
            _Thread.Start(str);
        }

        private void Check_Hash_Thread(object str)
        {
            byte[] buffer;
            byte[] oldBuffer;
            int bytesRead;
            int oldBytesRead;
            long size;
            long totalBytesRead = 0;

            using (Stream stream = File.OpenRead((string)str))
            using (HashAlgorithm hashAlgorithm = MD5.Create())
            {
                size = stream.Length;

                buffer = new byte[4096];

                bytesRead = stream.Read(buffer, 0, buffer.Length);
                totalBytesRead += bytesRead;

                do
                {
                    oldBytesRead = bytesRead;
                    oldBuffer = buffer;

                    buffer = new byte[4096];
                    bytesRead = stream.Read(buffer, 0, buffer.Length);

                    totalBytesRead += bytesRead;

                    if (bytesRead == 0)
                    {
                        hashAlgorithm.TransformFinalBlock(oldBuffer, 0, oldBytesRead);
                    }
                    else
                    {
                        hashAlgorithm.TransformBlock(oldBuffer, 0, oldBytesRead, oldBuffer, 0);
                    }

                    
                    _progress = (int)((double)totalBytesRead * 100 / size);
                    OnProgressUpdate();

                } while (bytesRead != 0);

                _Hash = BitConverter.ToString(hashAlgorithm.Hash).Replace("-", "").ToLower();
                OnFinish();
            }
        }




    }
}
