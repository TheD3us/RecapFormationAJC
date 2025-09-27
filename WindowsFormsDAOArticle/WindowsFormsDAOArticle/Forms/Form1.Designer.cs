namespace WindowsFormsDAOArticle
{
    partial class Accueil
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BSelectAll = new System.Windows.Forms.Button();
            this.BSelectByRef = new System.Windows.Forms.Button();
            this.BInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BSelectAll
            // 
            this.BSelectAll.Location = new System.Drawing.Point(86, 95);
            this.BSelectAll.Name = "BSelectAll";
            this.BSelectAll.Size = new System.Drawing.Size(75, 23);
            this.BSelectAll.TabIndex = 0;
            this.BSelectAll.Text = "SelectAll";
            this.BSelectAll.UseVisualStyleBackColor = true;
            this.BSelectAll.Click += new System.EventHandler(this.BSelectAll_Click);
            // 
            // BSelectByRef
            // 
            this.BSelectByRef.Location = new System.Drawing.Point(86, 178);
            this.BSelectByRef.Name = "BSelectByRef";
            this.BSelectByRef.Size = new System.Drawing.Size(75, 23);
            this.BSelectByRef.TabIndex = 1;
            this.BSelectByRef.Text = "SelectByRef";
            this.BSelectByRef.UseVisualStyleBackColor = true;
            // 
            // BInsert
            // 
            this.BInsert.Location = new System.Drawing.Point(86, 259);
            this.BInsert.Name = "BInsert";
            this.BInsert.Size = new System.Drawing.Size(75, 23);
            this.BInsert.TabIndex = 2;
            this.BInsert.Text = "Insert";
            this.BInsert.UseVisualStyleBackColor = true;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BInsert);
            this.Controls.Add(this.BSelectByRef);
            this.Controls.Add(this.BSelectAll);
            this.Name = "Accueil";
            this.Text = "Accueil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BSelectAll;
        private System.Windows.Forms.Button BSelectByRef;
        private System.Windows.Forms.Button BInsert;
    }
}

