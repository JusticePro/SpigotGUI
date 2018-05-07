using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpigotGUI
{
    static class Program
    {

        [DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        public static Edition edition;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists("licence.spigotgui"))
            {

                if (File.ReadAllText("licence.spigotgui").Equals(getProfessionalEdition(getSerialNumber() ) + ""))
                {
                    edition = Edition.Professional;
                }else
                {
                    MessageBox.Show("Your activation code expired. If this is not right contact me with this message.");
                    edition = Edition.Standard;
                }

            }else
            {
                edition = Edition.Standard;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static bool isAssociated()
        {
            return(Registry.CurrentUser.OpenSubKey("Software\\Classes\\.spigotgui", false) == null);
        }

        public static void associate()
        {
            string dir = AppDomain.CurrentDomain.BaseDirectory;
            RegistryKey filereg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\.spigotgui");
            RegistryKey appreg = Registry.CurrentUser.CreateSubKey("Software\\Classes\\Applications\\SpigotGUI.exe");
            RegistryKey assoc = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FileExts\\.spigotgui");

            filereg.CreateSubKey("DefaultIcon").SetValue("", dir + "\\icon.ico");
            filereg.CreateSubKey("PerceivedType").SetValue("", "Server");

            appreg.CreateSubKey("shell\\open\\command").SetValue("", "\"" + Application.ExecutablePath + "\"");
            appreg.CreateSubKey("DefaultIcon").SetValue("", dir + "\\icon.ico");

            assoc.CreateSubKey("UserChoice").SetValue("Progid", "Applications\\SpigotGUI.exe");
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }


        public static int getProfessionalEdition(int serial)
        {
            int num = serial;

            num *= num;
            num += 5433;
            num /= 4;
            num *= 77;

            return num;
        }

        public static int getSerialNumber()
        {
            PhysicalAddress mac = GetMacAddress();

            int number = 0;

            foreach (char c in mac.ToString().ToCharArray())
            {
                if (c != '-')
                {

                    if (Char.IsDigit(c))
                    {
                        number += int.Parse(c + "");
                        number = number * 10;
                    }

                    if (c == 'A')
                    {
                        number += 10;
                        //number = number * 10;
                    }


                    if (c == 'B')
                    {
                        number += 11;
                        //number = number * 10;
                    }

                    if (c == 'C')
                    {
                        number += 12;
                        //number = number * 10;
                    }

                    if (c == 'D')
                    {
                        number += 13;
                        //number = number * 10;
                    }

                    if (c == 'E')
                    {
                        number += 14;
                        //number = number * 10;
                    }
                    
                    if (c == 'F')
                    {
                        number += 15;
                        //number = number * 10;
                    }

                }
            }
            
            return number;
        }

        /// <summary>
        /// Gets the MAC address of the current PC.
        /// </summary>
        /// <returns></returns>
        public static PhysicalAddress GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet &&
                    nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress();
                }
            }
            return null;
        }

    }

}
