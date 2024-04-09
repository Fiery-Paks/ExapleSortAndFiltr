namespace WindowsFormsApp7.UserControls
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label titleLabel;
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.minCostForAgentLabel1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(188, 32);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(42, 45);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minCostForAgentLabel.Location = new System.Drawing.Point(185, 103);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(168, 45);
            minCostForAgentLabel.TabIndex = 4;
            minCostForAgentLabel.Text = "Min Cost For Agent:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(188, 65);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(57, 45);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Title:";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDLabel1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDLabel1.Location = new System.Drawing.Point(402, 32);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(169, 45);
            this.iDLabel1.TabIndex = 1;
            this.iDLabel1.Text = "label1";
            // 
            // minCostForAgentLabel1
            // 
            this.minCostForAgentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentLabel1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCostForAgentLabel1.Location = new System.Drawing.Point(399, 103);
            this.minCostForAgentLabel1.Name = "minCostForAgentLabel1";
            this.minCostForAgentLabel1.Size = new System.Drawing.Size(169, 45);
            this.minCostForAgentLabel1.TabIndex = 5;
            this.minCostForAgentLabel1.Text = "label1";
            // 
            // titleLabel1
            // 
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleLabel1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel1.Location = new System.Drawing.Point(399, 65);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(172, 53);
            this.titleLabel1.TabIndex = 7;
            this.titleLabel1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp7.Properties.Resources.Лопушок;
            this.pictureBox1.Location = new System.Drawing.Point(18, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(WindowsFormsApp7.DataModel.Product);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentLabel1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleLabel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(516, 170);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.Label minCostForAgentLabel1;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
