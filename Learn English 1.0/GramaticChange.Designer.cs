
namespace Learn_English_1._0
{
    partial class GramaticChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.learnenglishDataSet = new Learn_English_1._0.learnenglishDataSet();
            this.learnenglishDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grammarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grammarTableAdapter = new Learn_English_1._0.learnenglishDataSetTableAdapters.grammarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.learnenglishDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnenglishDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grammarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válasszon témát:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.grammarBindingSource;
            this.comboBox1.DisplayMember = "rule_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "grammary_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nyelvtani szabály kiválasztása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // learnenglishDataSet
            // 
            this.learnenglishDataSet.DataSetName = "learnenglishDataSet";
            this.learnenglishDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // learnenglishDataSetBindingSource
            // 
            this.learnenglishDataSetBindingSource.DataSource = this.learnenglishDataSet;
            this.learnenglishDataSetBindingSource.Position = 0;
            // 
            // grammarBindingSource
            // 
            this.grammarBindingSource.DataMember = "grammar";
            this.grammarBindingSource.DataSource = this.learnenglishDataSetBindingSource;
            // 
            // grammarTableAdapter
            // 
            this.grammarTableAdapter.ClearBeforeFill = true;
            // 
            // GramaticChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "GramaticChange";
            this.Text = "Learn English 1.0";
            this.Load += new System.EventHandler(this.GramaticChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.learnenglishDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnenglishDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grammarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource learnenglishDataSetBindingSource;
        private learnenglishDataSet learnenglishDataSet;
        private System.Windows.Forms.BindingSource grammarBindingSource;
        private learnenglishDataSetTableAdapters.grammarTableAdapter grammarTableAdapter;
    }
}