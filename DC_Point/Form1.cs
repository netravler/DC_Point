using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DC_Point
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // check to see if swap_host_file folder exists
            if(!System.IO.Directory.Exists(@"c:\swap_host_file"))
            {
                System.IO.Directory.CreateDirectory(@"c:\swap_host_file");
                first_Time(); // create branson and lenexa host file entry 
            }
        }

        private void first_Time()
        {
            // ok this will detect a first time run and do the following:
            // 
            // create the folder C:\swap_host_file
            // create the files branson, lenexa, and emptyhost
            // 

            String[] lenexaPoolA =  {"# Copyright (c) 1993-1999 Microsoft Corp.",
                                "#",
                                "# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.",
                                "#",
                                "# This file contains the mappings of IP addresses to host names. Each",
                                "# entry should be kept on an individual line. The IP address should",
                                "# be placed in the first column followed by the corresponding host name.",
                                "# The IP address and the host name should be separated by at least one",
                                "# space.",
                                "#",
                                "# Additionally, comments (such as these) may be inserted on individual",
                                "# lines or following the machine name denoted by a '#' symbol.",
                                "#",
                                "# For example:",
                                "#",
                                "#      102.54.94.97     rhino.acme.com          # source server",
                                "#       38.25.63.10     x.acme.com              # x client host",
                                "127.0.0.1       localhost",
                                "# You will hit Lenexa servers (safra is only live in Lenexa)",
                                "216.116.81.111	  backoffice.netteller.com",
                                "216.116.81.112	  backoffice2.netteller.com",
                                "216.116.81.80     www.netteller.com",
                                "216.116.81.86     cm.netteller.com",
                                "216.116.81.81     www2.netteller.com",
                                "216.116.81.87     www.airteller.com",
                                "216.116.81.64     configuration.netteller.com",
                                "216.116.81.85     configuration2.netteller.com",
                                "216.116.81.63     bankmanagement.netteller.com",
                                "216.116.81.84     bankmanagement2.netteller.com",
                                "216.116.81.83     ww10.bankofinternet.com",
                                "216.116.81.89     ibanking.safra.com",
                                "216.116.81.113    mobileapi.netteller.com",
                                "216.116.81.111    backoffice.netteller.com",
                                "216.116.81.114    ofx.netteller.com",
                                "216.116.81.90     es.netteller.com",
                                "10.12.1.21        iss.netteller.local",
                                "10.12.1.21        bizservices.netteller.local"};

            String[] lenexaPoolB =  {"# Copyright (c) 1993-1999 Microsoft Corp.",
                                "#",
                                "# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.",
                                "#",
                                "# This file contains the mappings of IP addresses to host names. Each",
                                "# entry should be kept on an individual line. The IP address should",
                                "# be placed in the first column followed by the corresponding host name.",
                                "# The IP address and the host name should be separated by at least one",
                                "# space.",
                                "#",
                                "# Additionally, comments (such as these) may be inserted on individual",
                                "# lines or following the machine name denoted by a '#' symbol.",
                                "#",
                                "# For example:",
                                "#",
                                "#      102.54.94.97     rhino.acme.com          # source server",
                                "#       38.25.63.10     x.acme.com              # x client host",
                                "127.0.0.1       localhost",
                                "# You will hit Lenexa servers (safra is only live in Lenexa)",
                                "216.116.81.111	  backoffice.netteller.com",
                                "216.116.81.112	  backoffice2.netteller.com",
                                "216.116.81.80     www.netteller.com",
                                "216.116.81.86     cm.netteller.com",
                                "216.116.81.81     www2.netteller.com",
                                "216.116.81.87     www.airteller.com",
                                "216.116.81.64     configuration.netteller.com",
                                "216.116.81.85     configuration2.netteller.com",
                                "216.116.81.63     bankmanagement.netteller.com",
                                "216.116.81.84     bankmanagement2.netteller.com",
                                "216.116.81.89     ibanking.safra.com",
                                "216.116.81.83    mobileapi.netteller.com",
                                "216.116.81.111    backoffice.netteller.com",
                                "216.116.81.114    ofx.netteller.com",
                                "74.200.63.129     es.netteller.com",
                                "10.12.1.21        iss.netteller.local",
                                "10.12.1.21        bizservices.netteller.local"};

            // array to file
            try
            {
                System.IO.File.WriteAllLines(@"C:\swap_host_file\lenexaPoolA", lenexaPoolA);
                System.IO.File.WriteAllLines(@"C:\swap_host_file\lenexaPoolB", lenexaPoolB); 
            }
            catch
            {

            }

            String[] bransonPoolA = {"# Copyright (c) 1993-1999 Microsoft Corp.",
                               "#",
                               "# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.",
                               "#",
                               "# This file contains the mappings of IP addresses to host names. Each",
                               "# entry should be kept on an individual line. The IP address should",
                               "# be placed in the first column followed by the corresponding host name.",
                               "# The IP address and the host name should be separated by at least one",
                               "# space.",
                               "#",
                               "# Additionally, comments (such as these) may be inserted on individual",
                               "# lines or following the machine name denoted by a '#' symbol.",
                               "#",
                               "# For example:",
                               "#",
                               "#      102.54.94.97     rhino.acme.com          # source server",
                               "#       38.25.63.10     x.acme.com              # x client host",
                               "127.0.0.1       localhost",
                               "74.200.63.177	  backoffice.netteller.com",
                               "74.200.63.178	  backoffice2.netteller.com",
                               "74.200.63.166     www.netteller.com",
                               "74.200.63.170     cm.netteller.com",
                               "74.200.63.167     www2.netteller.com",
                               "74.200.63.171     www.airteller.com",
                               "74.200.63.162     configuration.netteller.com",
                               "74.200.63.182     configuration2.netteller.com",
                               "74.200.63.161     bankmanagement.netteller.com",
                               "74.200.63.169     bankmanagement2.netteller.com",
                               "74.200.63.168     ww10.bankofinternet.com",
                               "74.200.63.179     mobileapi.netteller.com",
                               "74.200.63.177     backoffice.netteller.com",
                               "74.200.63.188     ofx.netteller.com",
                               "74.200.63.129     es.netteller.com",
                               "10.204.90.226     iss.netteller.local",
                               "10.204.90.226     bizservices.netteller.local"};

            String[] bransonPoolB = {"# Copyright (c) 1993-1999 Microsoft Corp.",
                               "#",
                               "# This is a sample HOSTS file used by Microsoft TCP/IP for Windows.",
                               "#",
                               "# This file contains the mappings of IP addresses to host names. Each",
                               "# entry should be kept on an individual line. The IP address should",
                               "# be placed in the first column followed by the corresponding host name.",
                               "# The IP address and the host name should be separated by at least one",
                               "# space.",
                               "#",
                               "# Additionally, comments (such as these) may be inserted on individual",
                               "# lines or following the machine name denoted by a '#' symbol.",
                               "#",
                               "# For example:",
                               "#",
                               "#      102.54.94.97     rhino.acme.com          # source server",
                               "#       38.25.63.10     x.acme.com              # x client host",
                               "127.0.0.1       localhost",
                               "74.200.63.177	  backoffice.netteller.com",
                               "74.200.63.178	  backoffice2.netteller.com",
                               "74.200.63.166     www.netteller.com",
                               "74.200.63.170     cm.netteller.com",
                               "74.200.63.167     www2.netteller.com",
                               "74.200.63.171     www.airteller.com",
                               "74.200.63.162     configuration.netteller.com",
                               "74.200.63.182     configuration2.netteller.com",
                               "74.200.63.161     bankmanagement.netteller.com",
                               "74.200.63.169     bankmanagement2.netteller.com",
                               "74.200.63.168     mobileapi.netteller.com",
                               "74.200.63.177     backoffice.netteller.com",
                               "74.200.63.188     ofx.netteller.com",
                               "10.204.90.226     iss.netteller.local",
                               "10.204.90.226     bizservices.netteller.local"};

            // array to file
            try
            {
                System.IO.File.WriteAllLines(@"C:\swap_host_file\bransonPoolA", bransonPoolA);
                System.IO.File.WriteAllLines(@"C:\swap_host_file\bransonPoolB", bransonPoolB);
            }
            catch
            {

            }

            // copy 

            try
            {
                // capture and move the current hosts file
                File.Copy(@"C:\Windows\System32\Drivers\etc\hosts", @"C:\swap_host_file\emptyhost", true);

                // as additional safety create a second failsafe copy that is if it doesn't already exsist!
                if (!System.IO.File.Exists(@"C:\swap_host_file\hostsfailsafe"))
                {
                    File.Copy(@"C:\Windows\System32\Drivers\etc\hosts", @"C:\swap_host_file\hostsfailsafe", true);
                }
            }
            catch
            {

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // open host file and replace contents with C:\swap_host_file\lenexa

            try
            {
                string content = File.ReadAllText(@"C:\swap_host_file\lenexaPoolA");

                ReplaceFile(content, @"C:\Windows\System32\Drivers\etc\hosts");

                MessageBox.Show("You are now pointing at Lenexa.\n\nRemember you will NEED to close the Browser(s) you wish to use\nfor this change to take effect.");
            }
            catch (IOException c)
            {
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open host file and replace contents with C:\swap_host_file\branson
            try
            {
                string content = File.ReadAllText(@"C:\swap_host_file\bransonPoolA");

                ReplaceFile(content, @"C:\Windows\System32\Drivers\etc\hosts");

                MessageBox.Show("You are now pointing at Branson.\n\nRemember you will NEED to close the Browser(s) you wish to use\nfor this change to take effect.");
            }
            catch (IOException c)
            {
                
            }

        }

            // Move a file into another file, delete the original, and create a backup of the replaced file. 
        public static void ReplaceFile(string NewContent, string ToBeReplaced)
        {
            File.WriteAllText(@ToBeReplaced, NewContent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open host file and replace contents with C:\swap_host_file\branson
            try
            {
                string content = File.ReadAllText(@"C:\swap_host_file\emptyhost");

                ReplaceFile(content, @"C:\Windows\System32\Drivers\etc\hosts");

                MessageBox.Show("You are now reset.\n\nRemember you will NEED to close the Browser(s) you wish to use\nfor this change to take effect.");
 
            }
            catch (IOException c)
            {

            }
        }
    }
}
