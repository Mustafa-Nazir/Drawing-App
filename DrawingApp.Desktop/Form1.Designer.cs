namespace DrawingApp.Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.Panel();
            this.toolsPanel = new System.Windows.Forms.Panel();
            this.fileTools = new System.Windows.Forms.TableLayoutPanel();
            this.modifireTools = new System.Windows.Forms.TableLayoutPanel();
            this.colors = new System.Windows.Forms.TableLayoutPanel();
            this.shapeTools = new System.Windows.Forms.TableLayoutPanel();
            this.ShapeToolLabel = new System.Windows.Forms.Label();
            this.ColorToolLabel = new System.Windows.Forms.Label();
            this.ModifierToolLabel = new System.Windows.Forms.Label();
            this.FileToolLabel = new System.Windows.Forms.Label();
            this.toolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 4);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(962, 769);
            this.canvas.TabIndex = 0;
            // 
            // toolsPanel
            // 
            this.toolsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolsPanel.Controls.Add(this.FileToolLabel);
            this.toolsPanel.Controls.Add(this.ModifierToolLabel);
            this.toolsPanel.Controls.Add(this.ColorToolLabel);
            this.toolsPanel.Controls.Add(this.ShapeToolLabel);
            this.toolsPanel.Controls.Add(this.fileTools);
            this.toolsPanel.Controls.Add(this.modifireTools);
            this.toolsPanel.Controls.Add(this.colors);
            this.toolsPanel.Controls.Add(this.shapeTools);
            this.toolsPanel.Location = new System.Drawing.Point(980, 4);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(190, 769);
            this.toolsPanel.TabIndex = 1;
            // 
            // fileTools
            // 
            this.fileTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTools.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.fileTools.ColumnCount = 3;
            this.fileTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.fileTools.Location = new System.Drawing.Point(3, 575);
            this.fileTools.Name = "fileTools";
            this.fileTools.RowCount = 1;
            this.fileTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.fileTools.Size = new System.Drawing.Size(182, 70);
            this.fileTools.TabIndex = 3;
            // 
            // modifireTools
            // 
            this.modifireTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modifireTools.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.modifireTools.ColumnCount = 3;
            this.modifireTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modifireTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modifireTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.modifireTools.Location = new System.Drawing.Point(3, 473);
            this.modifireTools.Name = "modifireTools";
            this.modifireTools.RowCount = 1;
            this.modifireTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.modifireTools.Size = new System.Drawing.Size(182, 66);
            this.modifireTools.TabIndex = 2;
            // 
            // colors
            // 
            this.colors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colors.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.colors.ColumnCount = 3;
            this.colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.colors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.colors.Location = new System.Drawing.Point(3, 241);
            this.colors.Name = "colors";
            this.colors.RowCount = 3;
            this.colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.6124F));
            this.colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.3876F));
            this.colors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.colors.Size = new System.Drawing.Size(182, 196);
            this.colors.TabIndex = 1;
            // 
            // shapeTools
            // 
            this.shapeTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeTools.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.shapeTools.ColumnCount = 2;
            this.shapeTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shapeTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shapeTools.Location = new System.Drawing.Point(3, 28);
            this.shapeTools.Name = "shapeTools";
            this.shapeTools.RowCount = 2;
            this.shapeTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shapeTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.shapeTools.Size = new System.Drawing.Size(182, 183);
            this.shapeTools.TabIndex = 0;
            // 
            // ShapeToolLabel
            // 
            this.ShapeToolLabel.AutoSize = true;
            this.ShapeToolLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShapeToolLabel.Location = new System.Drawing.Point(3, 5);
            this.ShapeToolLabel.Name = "ShapeToolLabel";
            this.ShapeToolLabel.Size = new System.Drawing.Size(83, 20);
            this.ShapeToolLabel.TabIndex = 4;
            this.ShapeToolLabel.Text = "Çizim Şekli";
            // 
            // ColorToolLabel
            // 
            this.ColorToolLabel.AutoSize = true;
            this.ColorToolLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorToolLabel.Location = new System.Drawing.Point(3, 218);
            this.ColorToolLabel.Name = "ColorToolLabel";
            this.ColorToolLabel.Size = new System.Drawing.Size(93, 20);
            this.ColorToolLabel.TabIndex = 5;
            this.ColorToolLabel.Text = "Renk Seçimi";
            // 
            // ModifierToolLabel
            // 
            this.ModifierToolLabel.AutoSize = true;
            this.ModifierToolLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ModifierToolLabel.Location = new System.Drawing.Point(3, 450);
            this.ModifierToolLabel.Name = "ModifierToolLabel";
            this.ModifierToolLabel.Size = new System.Drawing.Size(105, 20);
            this.ModifierToolLabel.TabIndex = 6;
            this.ModifierToolLabel.Text = "Şekil İşlemleri";
            // 
            // FileToolLabel
            // 
            this.FileToolLabel.AutoSize = true;
            this.FileToolLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FileToolLabel.Location = new System.Drawing.Point(3, 552);
            this.FileToolLabel.Name = "FileToolLabel";
            this.FileToolLabel.Size = new System.Drawing.Size(116, 20);
            this.FileToolLabel.TabIndex = 7;
            this.FileToolLabel.Text = "Dosya İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 785);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel canvas;
        private Panel toolsPanel;
        private TableLayoutPanel shapeTools;
        private TableLayoutPanel colors;
        private TableLayoutPanel modifireTools;
        private TableLayoutPanel fileTools;
        private Label FileToolLabel;
        private Label ModifierToolLabel;
        private Label ColorToolLabel;
        private Label ShapeToolLabel;
    }
}