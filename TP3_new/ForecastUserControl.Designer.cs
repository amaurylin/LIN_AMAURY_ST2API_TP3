
namespace TP3_new
{
    partial class ForecastUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDT = new System.Windows.Forms.Label();
            this.labelWeatherCondition = new System.Windows.Forms.Label();
            this.labelWeatherDescription = new System.Windows.Forms.Label();
            this.pictureWeatherIcon = new System.Windows.Forms.PictureBox();
            this.labelForecastTempMax = new System.Windows.Forms.Label();
            this.labelForecastTempMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDT
            // 
            this.labelDT.AutoSize = true;
            this.labelDT.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDT.ForeColor = System.Drawing.Color.White;
            this.labelDT.Location = new System.Drawing.Point(82, 15);
            this.labelDT.Name = "labelDT";
            this.labelDT.Size = new System.Drawing.Size(53, 18);
            this.labelDT.TabIndex = 2;
            this.labelDT.Text = "Sunday";
            // 
            // labelWeatherCondition
            // 
            this.labelWeatherCondition.AutoSize = true;
            this.labelWeatherCondition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeatherCondition.ForeColor = System.Drawing.Color.White;
            this.labelWeatherCondition.Location = new System.Drawing.Point(82, 33);
            this.labelWeatherCondition.Name = "labelWeatherCondition";
            this.labelWeatherCondition.Size = new System.Drawing.Size(40, 18);
            this.labelWeatherCondition.TabIndex = 3;
            this.labelWeatherCondition.Text = "Clear";
            // 
            // labelWeatherDescription
            // 
            this.labelWeatherDescription.AutoSize = true;
            this.labelWeatherDescription.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeatherDescription.ForeColor = System.Drawing.Color.White;
            this.labelWeatherDescription.Location = new System.Drawing.Point(82, 51);
            this.labelWeatherDescription.Name = "labelWeatherDescription";
            this.labelWeatherDescription.Size = new System.Drawing.Size(78, 18);
            this.labelWeatherDescription.TabIndex = 4;
            this.labelWeatherDescription.Text = "Description";
            // 
            // pictureWeatherIcon
            // 
            this.pictureWeatherIcon.Location = new System.Drawing.Point(16, 15);
            this.pictureWeatherIcon.Name = "pictureWeatherIcon";
            this.pictureWeatherIcon.Size = new System.Drawing.Size(47, 53);
            this.pictureWeatherIcon.TabIndex = 1;
            this.pictureWeatherIcon.TabStop = false;
            // 
            // labelForecastTempMax
            // 
            this.labelForecastTempMax.AutoSize = true;
            this.labelForecastTempMax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForecastTempMax.ForeColor = System.Drawing.Color.White;
            this.labelForecastTempMax.Location = new System.Drawing.Point(176, 15);
            this.labelForecastTempMax.Name = "labelForecastTempMax";
            this.labelForecastTempMax.Size = new System.Drawing.Size(68, 18);
            this.labelForecastTempMax.TabIndex = 5;
            this.labelForecastTempMax.Text = "maxTemp";
            // 
            // labelForecastTempMin
            // 
            this.labelForecastTempMin.AutoSize = true;
            this.labelForecastTempMin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForecastTempMin.ForeColor = System.Drawing.Color.White;
            this.labelForecastTempMin.Location = new System.Drawing.Point(176, 33);
            this.labelForecastTempMin.Name = "labelForecastTempMin";
            this.labelForecastTempMin.Size = new System.Drawing.Size(66, 18);
            this.labelForecastTempMin.TabIndex = 6;
            this.labelForecastTempMin.Text = "minTemp";
            // 
            // ForecastUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labelForecastTempMin);
            this.Controls.Add(this.labelForecastTempMax);
            this.Controls.Add(this.labelWeatherDescription);
            this.Controls.Add(this.labelWeatherCondition);
            this.Controls.Add(this.labelDT);
            this.Controls.Add(this.pictureWeatherIcon);
            this.Name = "ForecastUserControl";
            this.Size = new System.Drawing.Size(240, 95);
            ((System.ComponentModel.ISupportInitialize)(this.pictureWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureWeatherIcon;
        public System.Windows.Forms.Label labelDT;
        public System.Windows.Forms.Label labelWeatherCondition;
        public System.Windows.Forms.Label labelWeatherDescription;
        public System.Windows.Forms.Label labelForecastTempMax;
        public System.Windows.Forms.Label labelForecastTempMin;
    }
}
