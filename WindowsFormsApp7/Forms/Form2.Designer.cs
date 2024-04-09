namespace WindowsFormsApp7.Forms
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label titleLabel;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.productTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(36, 330);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(124, 50);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(27, 74);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(48, 50);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "ID:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minCostForAgentLabel.Location = new System.Drawing.Point(27, 133);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(192, 50);
            minCostForAgentLabel.TabIndex = 7;
            minCostForAgentLabel.Text = "Min Cost For Agent:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionPersonCountLabel.Location = new System.Drawing.Point(449, 74);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(239, 50);
            productionPersonCountLabel.TabIndex = 9;
            productionPersonCountLabel.Text = "Production Person Count:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(449, 136);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(285, 50);
            productionWorkshopNumberLabel.TabIndex = 11;
            productionWorkshopNumberLabel.Text = "Production Workshop Number:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productTypeIDLabel.Location = new System.Drawing.Point(36, 212);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(161, 50);
            productTypeIDLabel.TabIndex = 13;
            productTypeIDLabel.Text = "Product Type ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(36, 271);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(63, 50);
            titleLabel.TabIndex = 15;
            titleLabel.Text = "Title:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApp7.DataModel.Product);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(195, 327);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(335, 53);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(225, 133);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(204, 53);
            this.minCostForAgentTextBox.TabIndex = 8;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(773, 51);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(157, 53);
            this.productionPersonCountTextBox.TabIndex = 10;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(773, 136);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(157, 53);
            this.productionWorkshopNumberTextBox.TabIndex = 12;
            // 
            // productTypeIDTextBox
            // 
            this.productTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductTypeID", true));
            this.productTypeIDTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeIDTextBox.Location = new System.Drawing.Point(195, 209);
            this.productTypeIDTextBox.Name = "productTypeIDTextBox";
            this.productTypeIDTextBox.Size = new System.Drawing.Size(335, 53);
            this.productTypeIDTextBox.TabIndex = 14;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(195, 268);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(335, 53);
            this.titleTextBox.TabIndex = 16;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.Location = new System.Drawing.Point(225, 71);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(204, 53);
            this.iDTextBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(this.productTypeIDTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.TextBox productTypeIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
    }
}