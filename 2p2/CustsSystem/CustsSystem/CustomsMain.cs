using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace CustsSystem
{
    class CustomsMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DialogResult bRet;

                Thread.CurrentThread.CurrentCulture = new CultureInfo("zh-CN", true);

                ComMisc.ReadEnvironment();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (DBProvider.GetAutoLogon() == true)
                {
                    if (DBProvider.ConnectServer(DBProvider.GetServerAddress()) == false)
                    {
                        FrmEnvSet frmEnvSet = new FrmEnvSet();
                        bRet = frmEnvSet.ShowDialog();
                        if (bRet == DialogResult.Cancel)
                        {
                            Application.Exit();
                            return;
                        }
                    }
                }
                else
                {
                    FrmEnvSet frmEnvSet = new FrmEnvSet();
                    bRet = frmEnvSet.ShowDialog();
                    if (bRet == DialogResult.Cancel)
                    {
                        Application.Exit();
                        return;
                    }
                }
                

                FrmLogon frmLogon = new FrmLogon();
                bRet = frmLogon.ShowDialog();
                if (bRet == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }

                FrmSplash frmSplash = new FrmSplash();
                bRet = frmSplash.ShowDialog();
                if (bRet == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }

                ComMisc.frmMDIMain = new FrmMDIMain();
                //DBProvider.SetLogonState(true);
                Application.Run(ComMisc.frmMDIMain);
                DBProvider.SetLogonState(false);
                ComMisc.WriteEnvironment();
            }
            catch (Exception ex)
            {
                ComMisc.LogErrors(ex.ToString());
            }
        }
    }
}