using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Controls
{
    public partial class QuickViewOptions : Form
    {
        private QuickView _qv;
        public QuickViewOptions(QuickView qv)
        {
            InitializeComponent();
            _qv = qv;
        }

        private void QuickViewOptions_Shown(object sender, EventArgs e)
        {
            // Populate combobox with variables
            object thisBoxed = MainV2.comPort.MAV.cs;
            Type test = thisBoxed.GetType();

            List<Tuple<string, string>> fields = new List<Tuple<string, string>>();

            foreach (var field in test.GetProperties())
            {
                // field.Name has the field's name.
                object fieldValue = field.GetValue(thisBoxed, null); // Get value
                if (fieldValue == null)
                    continue;

                if (!fieldValue.IsNumber() && !(fieldValue is bool))
                {
                    continue;
                }

                if (field.Name.Contains("customfield"))
                {
                    if (CurrentState.custom_field_names.ContainsKey(field.Name))
                    {
                        string name = CurrentState.custom_field_names[field.Name];
                        fields.Add(new Tuple<string, string>(field.Name, name));
                    }
                }
                else
                {
                    fields.Add(new Tuple<string, string>(field.Name, field.Name));
                }
            }

            CMB_Source.ValueMember = "Item1";
            CMB_Source.DisplayMember = "Item2";
            CMB_Source.DataSource = fields;

            // Initialize combobox selection
            CMB_Source.Text = (string)_qv.Tag;

            // Initialize precision field, , assuming numberformat follows 0 to 0.0000000 format
            if (_qv.numberformat == "0")
            {
                NUM_precision.Value = 0;
            }
            else if (_qv.numberformat.StartsWith("0."))
            {
                NUM_precision.Value = _qv.numberformat.Substring(2).Count();
            }
            else
            {
                NUM_precision.Value = 2;
            }

            // Initialize custom color checkbox
            CHK_customcolor.Checked = (Utilities.Settings.Instance[_qv.Name + "_color"] != null && Utilities.Settings.Instance[_qv.Name + "_color"] != "default");

            // Initialize custom color textbox and color picker button
            TXT_color.Enabled = CHK_customcolor.Checked;
            BUT_colorpicker.Enabled = CHK_customcolor.Checked;
            TXT_color.Text = _qv.numberColorBackup.Name;
            BUT_colorpicker.BackColor = _qv.numberColorBackup;
        }

        private void CMB_Source_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utilities.Settings.Instance[_qv.Name] = (string) CMB_Source.SelectedValue;
        }

        private void NUM_precision_ValueChanged(object sender, EventArgs e)
        {
            if(NUM_precision.Value == 0)
            {
                Utilities.Settings.Instance[_qv.Name + "_format"] = "0";
            }
            else if (NUM_precision.Value >= 1)
            {
                Utilities.Settings.Instance[_qv.Name + "_format"] = "0." + new string('0', (int) NUM_precision.Value);
            }
            else // Edge case, should not happen; default to 0.00
            {
                Utilities.Settings.Instance[_qv.Name + "_format"] = "0.00";
            }
        }

        private void CHK_customcolor_CheckedChanged(object sender, EventArgs e)
        {
            TXT_color.Enabled = CHK_customcolor.Checked;
            BUT_colorpicker.Enabled = CHK_customcolor.Checked;
            if (CHK_customcolor.Checked == false)
            {
                Utilities.Settings.Instance[_qv.Name + "_color"] = "default";
            }
            else
            {
                Utilities.Settings.Instance[_qv.Name + "_color"] = TXT_color.Text;
            }
        }

        private void TXT_color_TextChanged(object sender, EventArgs e)
        {
            if (!CHK_customcolor.Checked)
            {
                return;
            }
            
            if (Regex.Match(TXT_color.Text, "^(?:[0-9a-fA-F]{2}){3,4}$").Success)
            {
                BUT_colorpicker.BackColor = System.Drawing.ColorTranslator.FromHtml("#"+TXT_color.Text);
                Utilities.Settings.Instance[_qv.Name + "_color"] = "#"+TXT_color.Text;
            }
            if (System.Drawing.Color.FromName(TXT_color.Text).IsKnownColor)
            {
                BUT_colorpicker.BackColor = System.Drawing.ColorTranslator.FromHtml(TXT_color.Text);
                Utilities.Settings.Instance[_qv.Name + "_color"] = TXT_color.Text;
            }
        }

        private void BUT_colorpicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.Color = BUT_colorpicker.BackColor;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BUT_colorpicker.BackColor = colorDlg.Color;
                TXT_color.Text = colorDlg.Color.Name;
            }
        }
    }
}
