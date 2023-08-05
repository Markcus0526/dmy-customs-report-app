using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;

namespace CDTFileAssoc
{
    public class FileSelectorTypeEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (context == null || context.Instance == null)
                return base.GetEditStyle(context);
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService editorService;

            if (context == null || context.Instance == null || provider == null)
                return value;

            try
            {
                // get the editor service, just like in windows forms
                editorService = (IWindowsFormsEditorService)
                   provider.GetService(typeof(IWindowsFormsEditorService));

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Exe files (*.exe)|*.exe";
                dlg.CheckFileExists = true;

                string filename = (string)value;
                if (!File.Exists(filename))
                    filename = null;
                dlg.FileName = filename;

                using (dlg)
                {
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        filename = dlg.FileName;
                    }
                }
                return filename;

            }
            finally
            {
                editorService = null;
            }
        }
    }
}
