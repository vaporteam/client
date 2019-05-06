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
            this.TextBox_Razon = new MetroFramework.Controls.MetroTextBox();
            this.Button_Reunion = new MetroFramework.Controls.MetroButton();
            this.Button_Descanso = new MetroFramework.Controls.MetroButton();
            this.Button_Comida = new MetroFramework.Controls.MetroButton();
            this.Button_Off = new MetroFramework.Controls.MetroButton();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // border
            // 
            this.border.Controls.Add(this.TextBox_Razon);
            this.border.Controls.Add(this.Button_Reunion);
            this.border.Controls.Add(this.Button_Descanso);
            this.border.Controls.Add(this.Button_Comida);
            this.border.Controls.Add(this.Button_Off);
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(20, 60);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(335, 95);
            this.border.TabIndex = 0;
            this.border.TabStop = false;
            // 
            // TextBox_Razon
            // 
            this.TextBox_Razon.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TextBox_Razon.CustomButton.Image = null;
            this.TextBox_Razon.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.TextBox_Razon.CustomButton.Name = "";
            this.TextBox_Razon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_Razon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Razon.CustomButton.TabIndex = 1;
            this.TextBox_Razon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Razon.CustomButton.UseSelectable = true;
            this.TextBox_Razon.CustomButton.Visible = false;
            this.TextBox_Razon.Lines = new string[0];
            this.TextBox_Razon.Location = new System.Drawing.Point(7, 61);
            this.TextBox_Razon.MaxLength = 280;
            this.TextBox_Razon.Multiline = true;
            this.TextBox_Razon.Name = "TextBox_Razon";
            this.TextBox_Razon.PasswordChar = '\0';
            this.TextBox_Razon.PromptText = "Razon de la ausencia";
            this.TextBox_Razon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Razon.SelectedText = "";
            this.TextBox_Razon.SelectionLength = 0;
            this.TextBox_Razon.SelectionStart = 0;
            this.TextBox_Razon.ShortcutsEnabled = true;
            this.TextBox_Razon.Size = new System.Drawing.Size(318, 23);
            this.TextBox_Razon.TabIndex = 5;
            this.TextBox_Razon.UseSelectable = true;
            this.TextBox_Razon.WaterMark = "Razon de la ausencia";
            this.TextBox_Razon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Razon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Button_Reunion
            // 
            this.Button_Reunion.BackColor = System.Drawing.Color.MediumOrchid;
            this.Button_Reunion.Location = new System.Drawing.Point(250, 20);
            this.Button_Reunion.Name = "Button_Reunion";
            this.Button_Reunion.Size = new System.Drawing.Size(75, 23);
            this.Button_Reunion.TabIndex = 4;
            this.Button_Reunion.Text = "Reunion";
            this.Button_Reunion.UseCustomBackColor = true;
            this.Button_Reunion.UseSelectable = true;
            this.Button_Reunion.Click += new System.EventHandler(this.TriggerStatus);
            // 
            // Button_Descanso
            // 
            this.Button_Descanso.BackColor = System.Drawing.Color.MediumOrchid;
            this.Button_Descanso.Location = new System.Drawing.Point(164, 20);
            this.Button_Descanso.Name = "Button_Descanso";
            this.Button_Descanso.Size = new System.Drawing.Size(70, 23);
            this.Button_Descanso.TabIndex = 3;
            this.Button_Descanso.Text = "Descanso";
            this.Button_Descanso.UseCustomBackColor = true;
            this.Button_Descanso.UseSelectable = true;
            this.Button_Descanso.Click += new System.EventHandler(this.TriggerStatus);
            // 
            // Button_Comida
            // 
            this.Button_Comida.BackColor = System.Drawing.Color.MediumOrchid;
            this.Button_Comida.Location = new System.Drawing.Point(78, 20);
            this.Button_Comida.Name = "Button_Comida";
            this.Button_Comida.Size = new System.Drawing.Size(70, 23);
            this.Button_Comida.TabIndex = 2;
            this.Button_Comida.Text = "Comida";
            this.Button_Comida.UseCustomBackColor = true;
            this.Button_Comida.UseSelectable = true;
            this.Button_Comida.Click += new System.EventHandler(this.TriggerStatus);
            // 
            // Button_Off
            // 
            this.Button_Off.BackColor = System.Drawing.Color.Red;
            this.Button_Off.Location = new System.Drawing.Point(7, 20);
            this.Button_Off.Name = "Button_Off";
            this.Button_Off.Size = new System.Drawing.Size(55, 23);
            this.Button_Off.Style = MetroFramework.MetroColorStyle.Red;
            this.Button_Off.TabIndex = 1;
            this.Button_Off.Text = "Off";
            this.Button_Off.UseCustomBackColor = true;
            this.Button_Off.UseSelectable = true;
            this.Button_Off.Click += new System.EventHandler(this.TriggerStatus);
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
        private MetroFramework.Controls.MetroButton Button_Off;
        private MetroFramework.Controls.MetroButton Button_Reunion;
        private MetroFramework.Controls.MetroButton Button_Descanso;
        private MetroFramework.Controls.MetroButton Button_Comida;
        private MetroFramework.Controls.MetroTextBox TextBox_Razon;
    }
}

