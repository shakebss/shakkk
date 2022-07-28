
namespace MissionPlanner.Controls
{
    partial class QuickViewOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CMB_Source = new System.Windows.Forms.ComboBox();
            this.NUM_precision = new System.Windows.Forms.NumericUpDown();
            this.LBL_precision = new System.Windows.Forms.Label();
            this.CHK_customcolor = new System.Windows.Forms.CheckBox();
            this.TXT_color = new System.Windows.Forms.TextBox();
            this.BUT_colorpicker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_precision)).BeginInit();
            this.SuspendLayout();
            // 
            // CMB_Source
            // 
            this.CMB_Source.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_Source.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_Source.FormattingEnabled = true;
            this.CMB_Source.Location = new System.Drawing.Point(12, 12);
            this.CMB_Source.Name = "CMB_Source";
            this.CMB_Source.Size = new System.Drawing.Size(121, 21);
            this.CMB_Source.TabIndex = 1;
            this.CMB_Source.SelectedIndexChanged += new System.EventHandler(this.CMB_Source_SelectedIndexChanged);
            // 
            // NUM_precision
            // 
            this.NUM_precision.Location = new System.Drawing.Point(197, 12);
            this.NUM_precision.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NUM_precision.Name = "NUM_precision";
            this.NUM_precision.Size = new System.Drawing.Size(40, 20);
            this.NUM_precision.TabIndex = 3;
            this.NUM_precision.ValueChanged += new System.EventHandler(this.NUM_precision_ValueChanged);
            // 
            // LBL_precision
            // 
            this.LBL_precision.AutoSize = true;
            this.LBL_precision.Location = new System.Drawing.Point(139, 15);
            this.LBL_precision.Name = "LBL_precision";
            this.LBL_precision.Size = new System.Drawing.Size(53, 13);
            this.LBL_precision.TabIndex = 4;
            this.LBL_precision.Text = "Precision:";
            // 
            // CHK_customcolor
            // 
            this.CHK_customcolor.AutoSize = true;
            this.CHK_customcolor.Location = new System.Drawing.Point(246, 14);
            this.CHK_customcolor.Name = "CHK_customcolor";
            this.CHK_customcolor.Size = new System.Drawing.Size(88, 17);
            this.CHK_customcolor.TabIndex = 5;
            this.CHK_customcolor.Text = "Custom Color";
            this.CHK_customcolor.UseVisualStyleBackColor = true;
            this.CHK_customcolor.CheckedChanged += new System.EventHandler(this.CHK_customcolor_CheckedChanged);
            // 
            // TXT_color
            // 
            this.TXT_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_color.Location = new System.Drawing.Point(335, 15);
            this.TXT_color.Name = "TXT_color";
            this.TXT_color.Size = new System.Drawing.Size(54, 13);
            this.TXT_color.TabIndex = 6;
            this.TXT_color.Text = "FFFFFF";
            this.TXT_color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_color.TextChanged += new System.EventHandler(this.TXT_color_TextChanged);
            // 
            // BUT_colorpicker
            // 
            this.BUT_colorpicker.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BUT_colorpicker.Location = new System.Drawing.Point(400, 12);
            this.BUT_colorpicker.Name = "BUT_colorpicker";
            this.BUT_colorpicker.Size = new System.Drawing.Size(20, 20);
            this.BUT_colorpicker.TabIndex = 7;
            this.BUT_colorpicker.UseVisualStyleBackColor = false;
            this.BUT_colorpicker.Click += new System.EventHandler(this.BUT_colorpicker_Click);
            // 
            // QuickViewOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 45);
            this.Controls.Add(this.BUT_colorpicker);
            this.Controls.Add(this.TXT_color);
            this.Controls.Add(this.CHK_customcolor);
            this.Controls.Add(this.LBL_precision);
            this.Controls.Add(this.NUM_precision);
            this.Controls.Add(this.CMB_Source);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuickViewOptions";
            this.Text = "QuickViewOptions";
            this.Shown += new System.EventHandler(this.QuickViewOptions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.NUM_precision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_Source;
        private System.Windows.Forms.NumericUpDown NUM_precision;
        private System.Windows.Forms.Label LBL_precision;
        private System.Windows.Forms.CheckBox CHK_customcolor;
        private System.Windows.Forms.TextBox TXT_color;
        private System.Windows.Forms.Button BUT_colorpicker;
    }
}