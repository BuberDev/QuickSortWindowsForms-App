
namespace QuickSortWindowsForms_App
{
    partial class Quicksort
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnsortedList = new System.Windows.Forms.ListBox();
            this.SortedList = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.doQuicksortBtn = new System.Windows.Forms.Button();
            this.numberToAdd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberToAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // UnsortedList
            // 
            this.UnsortedList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnsortedList.FormattingEnabled = true;
            this.UnsortedList.ItemHeight = 23;
            this.UnsortedList.Location = new System.Drawing.Point(16, 200);
            this.UnsortedList.Name = "UnsortedList";
            this.UnsortedList.Size = new System.Drawing.Size(160, 510);
            this.UnsortedList.TabIndex = 0;
            // 
            // SortedList
            // 
            this.SortedList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortedList.FormattingEnabled = true;
            this.SortedList.ItemHeight = 27;
            this.SortedList.Location = new System.Drawing.Point(392, 193);
            this.SortedList.Name = "SortedList";
            this.SortedList.Size = new System.Drawing.Size(171, 517);
            this.SortedList.TabIndex = 1;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(55, 117);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(80, 54);
            this.addBtn.TabIndex = 2;
            this.addBtn.Text = "ADD";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // doQuicksortBtn
            // 
            this.doQuicksortBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.doQuicksortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doQuicksortBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doQuicksortBtn.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.doQuicksortBtn.Location = new System.Drawing.Point(198, 316);
            this.doQuicksortBtn.Name = "doQuicksortBtn";
            this.doQuicksortBtn.Size = new System.Drawing.Size(171, 95);
            this.doQuicksortBtn.TabIndex = 3;
            this.doQuicksortBtn.Text = "DO QUICKSORT";
            this.doQuicksortBtn.UseVisualStyleBackColor = false;
            this.doQuicksortBtn.Click += new System.EventHandler(this.doQuicksortBtn_Click);
            // 
            // numberToAdd
            // 
            this.numberToAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numberToAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberToAdd.Location = new System.Drawing.Point(36, 46);
            this.numberToAdd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numberToAdd.Name = "numberToAdd";
            this.numberToAdd.Size = new System.Drawing.Size(136, 54);
            this.numberToAdd.TabIndex = 4;
            this.numberToAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberToAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUICKSORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter your numbers";
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(225, 456);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(109, 55);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Quicksort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 781);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberToAdd);
            this.Controls.Add(this.doQuicksortBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.SortedList);
            this.Controls.Add(this.UnsortedList);
            this.Name = "Quicksort";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberToAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UnsortedList;
        private System.Windows.Forms.ListBox SortedList;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button doQuicksortBtn;
        private System.Windows.Forms.NumericUpDown numberToAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearBtn;
    }
}

