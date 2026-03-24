namespace Task3
{
    partial class Form1
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
            this.gbFlavor = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPriceInfo = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.chkPlombir = new System.Windows.Forms.CheckBox();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.chkFruit = new System.Windows.Forms.CheckBox();
            this.chkVanilla = new System.Windows.Forms.CheckBox();
            this.gbFlavor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFlavor
            // 
            this.gbFlavor.Controls.Add(this.chkFruit);
            this.gbFlavor.Controls.Add(this.chkChocolate);
            this.gbFlavor.Controls.Add(this.chkVanilla);
            this.gbFlavor.Controls.Add(this.chkPlombir);
            this.gbFlavor.Location = new System.Drawing.Point(55, 66);
            this.gbFlavor.Name = "gbFlavor";
            this.gbFlavor.Size = new System.Drawing.Size(152, 109);
            this.gbFlavor.TabIndex = 6;
            this.gbFlavor.TabStop = false;
            this.gbFlavor.Text = "Оберіть сорт морозива";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(361, 213);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(107, 13);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "До сплати: 0.00 грн";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(55, 266);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 32);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPriceInfo
            // 
            this.lblPriceInfo.AutoSize = true;
            this.lblPriceInfo.Location = new System.Drawing.Point(344, 78);
            this.lblPriceInfo.Name = "lblPriceInfo";
            this.lblPriceInfo.Size = new System.Drawing.Size(249, 13);
            this.lblPriceInfo.TabIndex = 9;
            this.lblPriceInfo.Text = "* При замовленні більше 20 порцій — знижка 5%";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(218, 211);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(62, 20);
            this.numQuantity.TabIndex = 8;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(52, 213);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(160, 13);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Кількість порцій кожного виду";
            // 
            // chkPlombir
            // 
            this.chkPlombir.AutoSize = true;
            this.chkPlombir.Location = new System.Drawing.Point(6, 19);
            this.chkPlombir.Name = "chkPlombir";
            this.chkPlombir.Size = new System.Drawing.Size(68, 17);
            this.chkPlombir.TabIndex = 12;
            this.chkPlombir.Text = "Пломбір";
            this.chkPlombir.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Location = new System.Drawing.Point(6, 42);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(83, 17);
            this.chkChocolate.TabIndex = 13;
            this.chkChocolate.Text = "Шоколадне";
            this.chkChocolate.UseVisualStyleBackColor = true;
            // 
            // chkFruit
            // 
            this.chkFruit.AutoSize = true;
            this.chkFruit.Location = new System.Drawing.Point(5, 63);
            this.chkFruit.Name = "chkFruit";
            this.chkFruit.Size = new System.Drawing.Size(77, 17);
            this.chkFruit.TabIndex = 14;
            this.chkFruit.Text = "Фруктове";
            this.chkFruit.UseVisualStyleBackColor = true;
            // 
            // chkVanilla
            // 
            this.chkVanilla.AutoSize = true;
            this.chkVanilla.Location = new System.Drawing.Point(6, 86);
            this.chkVanilla.Name = "chkVanilla";
            this.chkVanilla.Size = new System.Drawing.Size(71, 17);
            this.chkVanilla.TabIndex = 15;
            this.chkVanilla.Text = "Ванільне";
            this.chkVanilla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFlavor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPriceInfo);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbFlavor.ResumeLayout(false);
            this.gbFlavor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFlavor;
        private System.Windows.Forms.CheckBox chkFruit;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.CheckBox chkVanilla;
        private System.Windows.Forms.CheckBox chkPlombir;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPriceInfo;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}

