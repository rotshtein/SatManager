using log4net;
using System;
using System.Reflection;
using System.Windows.Forms;
using WebSocketS.Properties;

namespace WebSocketS
{
    class SaveControl
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType.Name);
        Form rootForm = null;
        
        public SaveControl(Form rootForm)
        {
            Properties.Settings.Default.Upgrade();
            this.rootForm = rootForm;
        }

        private Control FinedByName(Control root, string name)
        {
            if ((string)root.Tag == name) return root;
            foreach (Control c in root.Controls)
            {
                Control t = FinedByName(c, name);
                if (t != null)
                    return t;
            }
            return null;
        }

        public void InitGuiData()
        {
            foreach (System.Configuration.SettingsProperty v in Settings.Default.Properties)
            {
                Object c = FinedByName(rootForm, v.Name);
                if ((c != null) && (Settings.Default[v.Name] != null))
                {
                    try
                    {
                        switch (c.GetType().Name)
                        {
                            case "ComboBox":
                                ((ComboBox)c).Text = (string)Settings.Default[v.Name];
                                break;

                            case "TextBox":
                                ((TextBox)c).Text = (string)Settings.Default[v.Name];
                                break;

                            case "NumericUpDown":
                                ((NumericUpDown)c).Value = (decimal)(Settings.Default[v.Name]);
                                break;

                            case "CheckBox":
                                ((CheckBox)c).Checked = bool.Parse(Settings.Default[v.Name].ToString());
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Error("Variable could not loaded", ex);
                    }
                }
            }
        }


        public void SaveGuiData( )
        {
            foreach (System.Configuration.SettingsProperty v in Properties.Settings.Default.Properties)
            {
                Object c = FinedByName(rootForm, v.Name);
                if (c != null)
                {
                    
                    switch (c.GetType().Name)
                    {
                        case "ComboBox":
                            Settings.Default[v.Name] = ((ComboBox)c).Text;
                            break;

                        case "TextBox":
                            Settings.Default[v.Name] = ((TextBox)c).Text;
                            break;

                        case "NumericUpDown":
                            Settings.Default[v.Name] = ((NumericUpDown)c).Value;
                            break;

                        case "CheckBox":
                            Settings.Default[v.Name] = ((CheckBox)c).Checked;
                            break;
                    }
                }
            }
            Settings.Default.Save();
            Settings.Default.Upgrade();
            Settings.Default.Save();
            Settings.Default.Reload();
        }

    }
}
