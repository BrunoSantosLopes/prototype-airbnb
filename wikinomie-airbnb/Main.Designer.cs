namespace PrototypeWikinomie
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbTagsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvEntries = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.cbObservatory = new System.Windows.Forms.ComboBox();
            this.tbSecretKey = new System.Windows.Forms.TextBox();
            this.tbTag = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.epEntry = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbCoWaBooOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTagsList
            // 
            this.lbTagsList.FormattingEnabled = true;
            this.lbTagsList.Location = new System.Drawing.Point(1, 121);
            this.lbTagsList.Name = "lbTagsList";
            this.lbTagsList.Size = new System.Drawing.Size(149, 329);
            this.lbTagsList.TabIndex = 0;
            this.lbTagsList.SelectedIndexChanged += new System.EventHandler(this.LbTagsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "646-21 Wikinomie - Airbnb";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(694, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Récupération de statistique sur les logement d\'Airbnb en Suisse via l\'api de CoWa" +
    "Boo (prototype)";
            // 
            // lvEntries
            // 
            this.lvEntries.Location = new System.Drawing.Point(171, 121);
            this.lvEntries.Name = "lvEntries";
            this.lvEntries.Size = new System.Drawing.Size(257, 329);
            this.lvEntries.TabIndex = 3;
            this.lvEntries.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(551, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ajouter une entrée";
            // 
            // cbObservatory
            // 
            this.cbObservatory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObservatory.FormattingEnabled = true;
            this.cbObservatory.Location = new System.Drawing.Point(526, 193);
            this.cbObservatory.Name = "cbObservatory";
            this.cbObservatory.Size = new System.Drawing.Size(195, 21);
            this.cbObservatory.TabIndex = 5;
            // 
            // tbSecretKey
            // 
            this.tbSecretKey.Location = new System.Drawing.Point(526, 248);
            this.tbSecretKey.Name = "tbSecretKey";
            this.tbSecretKey.Size = new System.Drawing.Size(195, 20);
            this.tbSecretKey.TabIndex = 6;
            // 
            // tbTag
            // 
            this.tbTag.Location = new System.Drawing.Point(526, 296);
            this.tbTag.Name = "tbTag";
            this.tbTag.Size = new System.Drawing.Size(195, 20);
            this.tbTag.TabIndex = 7;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(526, 343);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(195, 20);
            this.tbValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Observatoire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Secret key de l\'auteur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Donnée";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(554, 392);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // epEntry
            // 
            this.epEntry.ContainerControl = this;
            // 
            // lbCoWaBooOut
            // 
            this.lbCoWaBooOut.AutoSize = true;
            this.lbCoWaBooOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoWaBooOut.ForeColor = System.Drawing.Color.Red;
            this.lbCoWaBooOut.Location = new System.Drawing.Point(219, 74);
            this.lbCoWaBooOut.Name = "lbCoWaBooOut";
            this.lbCoWaBooOut.Size = new System.Drawing.Size(0, 29);
            this.lbCoWaBooOut.TabIndex = 14;
            this.lbCoWaBooOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCoWaBooOut);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.tbTag);
            this.Controls.Add(this.tbSecretKey);
            this.Controls.Add(this.cbObservatory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvEntries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTagsList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.Text = "646-21 Wikinomie - Airbnb";
            ((System.ComponentModel.ISupportInitialize)(this.epEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTagsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvEntries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbObservatory;
        private System.Windows.Forms.TextBox tbSecretKey;
        private System.Windows.Forms.TextBox tbTag;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ErrorProvider epEntry;
        private System.Windows.Forms.Label lbCoWaBooOut;
    }
}

