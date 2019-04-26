namespace cliente
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.border = new System.Windows.Forms.GroupBox();
            this.bt_off = new MetroFramework.Controls.MetroButton();
            this.bt_comida = new MetroFramework.Controls.MetroButton();
            this.bt_descanso = new MetroFramework.Controls.MetroButton();
            this.bt_reunion = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.Controls.Add(this.metroTextBox1);
            this.border.Controls.Add(this.bt_reunion);
            this.border.Controls.Add(this.bt_descanso);
            this.border.Controls.Add(this.bt_comida);
            this.border.Controls.Add(this.bt_off);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(20, 60);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(335, 95);
            this.border.TabIndex = 0;
            this.border.TabStop = false;
            // 
            // bt_off
            // 
            this.bt_off.BackColor = System.Drawing.Color.Red;
            this.bt_off.Location = new System.Drawing.Point(7, 20);
            this.bt_off.Name = "bt_off";
            this.bt_off.Size = new System.Drawing.Size(55, 23);
            this.bt_off.Style = MetroFramework.MetroColorStyle.Red;
            this.bt_off.TabIndex = 0;
            this.bt_off.Text = "Off";
            this.bt_off.UseCustomBackColor = true;
            this.bt_off.UseSelectable = true;
            this.bt_off.Click += new System.EventHandler(this.TriggerStatus);
            // 
            // bt_comida
            // 
            this.bt_comida.BackColor = System.Drawing.Color.MediumOrchid;
            this.bt_comida.Location = new System.Drawing.Point(78, 20);
            this.bt_comida.Name = "bt_comida";
            this.bt_comida.Size = new System.Drawing.Size(70, 23);
            this.bt_comida.TabIndex = 1;
            this.bt_comida.Text = "Comida";
            this.bt_comida.UseCustomBackColor = true;
            this.bt_comida.UseSelectable = true;
            // 
            // bt_descanso
            // 
            this.bt_descanso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bt_descanso.Location = new System.Drawing.Point(164, 20);
            this.bt_descanso.Name = "bt_descanso";
            this.bt_descanso.Size = new System.Drawing.Size(70, 23);
            this.bt_descanso.TabIndex = 2;
            this.bt_descanso.Text = "Descanso";
            this.bt_descanso.UseCustomBackColor = true;
            this.bt_descanso.UseSelectable = true;
            // 
            // bt_reunion
            // 
            this.bt_reunion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_reunion.Location = new System.Drawing.Point(250, 20);
            this.bt_reunion.Name = "bt_reunion";
            this.bt_reunion.Size = new System.Drawing.Size(75, 23);
            this.bt_reunion.TabIndex = 3;
            this.bt_reunion.Text = "Reunion";
            this.bt_reunion.UseCustomBackColor = true;
            this.bt_reunion.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(7, 61);
            this.metroTextBox1.MaxLength = 280;
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Razon de la ausencia";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(318, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Razon de la ausencia";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 175);
            this.Controls.Add(this.border);
            this.MaximumSize = new System.Drawing.Size(375, 175);
            this.MinimumSize = new System.Drawing.Size(375, 175);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Semita";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.border.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox border;
        private MetroFramework.Controls.MetroButton bt_off;
        private MetroFramework.Controls.MetroButton bt_reunion;
        private MetroFramework.Controls.MetroButton bt_descanso;
        private MetroFramework.Controls.MetroButton bt_comida;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}

