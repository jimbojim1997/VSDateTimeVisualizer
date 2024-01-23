namespace VSDateTimeVisualizer.Debugger
{
    partial class DateTimeVisualizerForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimeVisualizerForm));
            this.CustomFormatInput = new System.Windows.Forms.TextBox();
            this.CustomFormatOutput = new System.Windows.Forms.TextBox();
            this.DateTimeValue = new System.Windows.Forms.TextBox();
            this.ExampleFormatTable = new System.Windows.Forms.TableLayoutPanel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.ExampleFormatTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomFormatInput
            // 
            this.CustomFormatInput.Location = new System.Drawing.Point(12, 38);
            this.CustomFormatInput.Name = "CustomFormatInput";
            this.CustomFormatInput.Size = new System.Drawing.Size(221, 20);
            this.CustomFormatInput.TabIndex = 1;
            this.CustomFormatInput.Text = "O";
            this.CustomFormatInput.TextChanged += new System.EventHandler(this.CustomFormatInput_TextChanged);
            // 
            // CustomFormatOutput
            // 
            this.CustomFormatOutput.Location = new System.Drawing.Point(12, 64);
            this.CustomFormatOutput.Name = "CustomFormatOutput";
            this.CustomFormatOutput.ReadOnly = true;
            this.CustomFormatOutput.Size = new System.Drawing.Size(221, 20);
            this.CustomFormatOutput.TabIndex = 2;
            // 
            // DateTimeValue
            // 
            this.DateTimeValue.Location = new System.Drawing.Point(12, 12);
            this.DateTimeValue.Name = "DateTimeValue";
            this.DateTimeValue.Size = new System.Drawing.Size(221, 20);
            this.DateTimeValue.TabIndex = 0;
            this.DateTimeValue.TextChanged += new System.EventHandler(this.DateTimeValue_TextChanged);
            // 
            // ExampleFormatTable
            // 
            this.ExampleFormatTable.AutoScroll = true;
            this.ExampleFormatTable.ColumnCount = 3;
            this.ExampleFormatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.ExampleFormatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExampleFormatTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExampleFormatTable.Controls.Add(label1, 0, 0);
            this.ExampleFormatTable.Controls.Add(label2, 1, 0);
            this.ExampleFormatTable.Controls.Add(label3, 2, 0);
            this.ExampleFormatTable.Location = new System.Drawing.Point(12, 90);
            this.ExampleFormatTable.Name = "ExampleFormatTable";
            this.ExampleFormatTable.RowCount = 1;
            this.ExampleFormatTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ExampleFormatTable.Size = new System.Drawing.Size(494, 348);
            this.ExampleFormatTable.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 0;
            label1.Text = "Format";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(63, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 13);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(280, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 13);
            label3.TabIndex = 2;
            label3.Text = "Result";
            // 
            // DateTimeVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.ExampleFormatTable);
            this.Controls.Add(this.DateTimeValue);
            this.Controls.Add(this.CustomFormatOutput);
            this.Controls.Add(this.CustomFormatInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateTimeVisualizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Date Time Visualizer";
            this.Load += new System.EventHandler(this.DateTimeVisualizerForm_Load);
            this.ExampleFormatTable.ResumeLayout(false);
            this.ExampleFormatTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CustomFormatInput;
        private System.Windows.Forms.TextBox CustomFormatOutput;
        private System.Windows.Forms.TextBox DateTimeValue;
        private System.Windows.Forms.TableLayoutPanel ExampleFormatTable;
    }
}