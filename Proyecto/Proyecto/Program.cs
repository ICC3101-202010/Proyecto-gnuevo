using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Proyecto
{
    class MainClass
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Stream stream = File.Open("Users.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, Spotflix.GetUserDB);
            stream.Close();

            Stream stream2 = File.Open("Songs.dat", FileMode.Create);
            BinaryFormatter bf2 = new BinaryFormatter();
            bf2.Serialize(stream2, Spotflix.GetSongDB);
            stream2.Close();

            Stream stream3 = File.Open("Videos.dat", FileMode.Create);
            BinaryFormatter bf3 = new BinaryFormatter();
            bf3.Serialize(stream3, Spotflix.GetVideoDB);
            stream3.Close();
        }
    }
}

//string a = "sss.mp4";
//_ = Process.Start(a);
//private Process a = new Process();