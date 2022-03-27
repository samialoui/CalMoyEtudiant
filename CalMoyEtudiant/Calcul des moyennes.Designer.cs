
namespace CalMoyEtudiant
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textEx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMoy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listEtudiant = new System.Windows.Forms.ListBox();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom et Prenom";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(137, 110);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(186, 20);
            this.textNom.TabIndex = 1;
            // 
            // textEx
            // 
            this.textEx.Location = new System.Drawing.Point(137, 197);
            this.textEx.Name = "textEx";
            this.textEx.Size = new System.Drawing.Size(186, 20);
            this.textEx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Note Examen";
            // 
            // textDS
            // 
            this.textDS.Location = new System.Drawing.Point(137, 155);
            this.textDS.Name = "textDS";
            this.textDS.Size = new System.Drawing.Size(186, 20);
            this.textDS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Note DS";
            // 
            // textTp
            // 
            this.textTp.Location = new System.Drawing.Point(137, 235);
            this.textTp.Name = "textTp";
            this.textTp.Size = new System.Drawing.Size(186, 20);
            this.textTp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Note TP";
            // 
            // textMoy
            // 
            this.textMoy.Location = new System.Drawing.Point(137, 270);
            this.textMoy.Name = "textMoy";
            this.textMoy.ReadOnly = true;
            this.textMoy.Size = new System.Drawing.Size(186, 20);
            this.textMoy.TabIndex = 9;
            this.textMoy.TextChanged += new System.EventHandler(this.textMoy_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Moyenne";
            // 
            // listEtudiant
            // 
            this.listEtudiant.FormattingEnabled = true;
            this.listEtudiant.Location = new System.Drawing.Point(408, 100);
            this.listEtudiant.Name = "listEtudiant";
            this.listEtudiant.Size = new System.Drawing.Size(295, 186);
            this.listEtudiant.TabIndex = 10;
            this.listEtudiant.SelectedIndexChanged += new System.EventHandler(this.listEtudiant_SelectedIndexChanged);
            // 
            // btnCalcul
            // 
            this.btnCalcul.Location = new System.Drawing.Point(137, 341);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(126, 23);
            this.btnCalcul.TabIndex = 11;
            this.btnCalcul.Text = "Calculer";
            this.btnCalcul.UseVisualStyleBackColor = true;
            this.btnCalcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(570, 341);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(133, 23);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Location = new System.Drawing.Point(364, 341);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(122, 23);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.listEtudiant);
            this.Controls.Add(this.textMoy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textTp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textEx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calcul des moyennes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textEx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMoy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listEtudiant;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
    }
}

