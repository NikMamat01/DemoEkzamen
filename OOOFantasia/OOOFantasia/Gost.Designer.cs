
namespace OOOFantasia
{
    partial class Gost
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gost));
            this.tableLayoutTop = new System.Windows.Forms.TableLayoutPanel();
            this.risunok = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.tableLayoutBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.risunok)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutTop
            // 
            this.tableLayoutTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutTop.BackColor = System.Drawing.Color.White;
            this.tableLayoutTop.ColumnCount = 3;
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.45161F));
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutTop.Controls.Add(this.risunok, 0, 0);
            this.tableLayoutTop.Controls.Add(this.label1, 1, 0);
            this.tableLayoutTop.Controls.Add(this.exit, 2, 0);
            this.tableLayoutTop.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutTop.Name = "tableLayoutTop";
            this.tableLayoutTop.RowCount = 1;
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutTop.Size = new System.Drawing.Size(628, 54);
            this.tableLayoutTop.TabIndex = 0;
            // 
            // risunok
            // 
            this.risunok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.risunok.Image = ((System.Drawing.Image)(resources.GetObject("risunok.Image")));
            this.risunok.Location = new System.Drawing.Point(3, 3);
            this.risunok.Name = "risunok";
            this.risunok.Size = new System.Drawing.Size(66, 48);
            this.risunok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.risunok.TabIndex = 0;
            this.risunok.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.Location = new System.Drawing.Point(421, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(204, 48);
            this.exit.TabIndex = 2;
            this.exit.Text = "Вернуться";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // tableLayoutBottom
            // 
            this.tableLayoutBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutBottom.BackColor = System.Drawing.Color.White;
            this.tableLayoutBottom.ColumnCount = 1;
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutBottom.Location = new System.Drawing.Point(2, 301);
            this.tableLayoutBottom.Name = "tableLayoutBottom";
            this.tableLayoutBottom.RowCount = 1;
            this.tableLayoutBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutBottom.Size = new System.Drawing.Size(646, 51);
            this.tableLayoutBottom.TabIndex = 1;
            // 
            // Gost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 353);
            this.Controls.Add(this.tableLayoutBottom);
            this.Controls.Add(this.tableLayoutTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Gost";
            this.Text = "OOOFantasia";
            this.tableLayoutTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.risunok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutTop;
        private System.Windows.Forms.PictureBox risunok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBottom;
    }
}

