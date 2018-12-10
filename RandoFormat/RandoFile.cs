using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandoFormat
{
    public class RandoFile
    {
        public List<Group> groups = new List<Group>();

        public RandoFile(string s)
        {
            open(File.Open(s, FileMode.Open));
        }

        public RandoFile(Stream s)
        {
            open(s);
        }

        public RandoFile(List<Group> g)
        {
            groups = g;
        }

        private void open(Stream s)
        {
            int dl = 0x00;
            string readString()
            {
                StringBuilder sb = new StringBuilder();
                while (true)
                {
                    int t = s.ReadByte();
                    if (t == 0x00 || t == 0x01)
                    {
                        dl = t;
                        return sb.ToString();
                    };
                    sb.Append((char)t);
                }
            }

            while (s.Position < s.Length)
            {
                string n;
                List<string> e = new List<string>();
                n = readString();
                while (true)
                {
                    e.Add(readString());
                    if (e.Last() == "")
                    {
                        e.RemoveAt(e.Count - 1);
                        break;
                    }
                    if (dl == 0x01)
                    {
                        break;
                    }
                }
                if (e.Count == 0) groups.Add(new Group(n));
                else groups.Add(new Group(n, e));
            }
            s.Close();
        }

        public void write(Stream s)
        {
            void sToBytes(string n, int d)
            {
                s.Write(Encoding.Default.GetBytes(n), 0, n.Length);
                if (d != -1) s.WriteByte((byte)d);
            }
            foreach (Group g in groups)
            {
                int i = 0;
                sToBytes(g.name, 0);
                foreach (string x in g.entries)
                {
                    Console.WriteLine(i + " " + g.entries.Count);
                    i++;
                    if (i == g.entries.Count) sToBytes(x, 0x01);
                    else sToBytes(x, 0);
                }
                if (g.entries.Count == 0) s.WriteByte(0x01);
            }
            s.Close();
        }

        public void write(string s)
        {
            if (File.Exists(s)) write(File.Open(s, FileMode.Truncate));
            else write(File.Open(s, FileMode.Create));
        }
    }
}