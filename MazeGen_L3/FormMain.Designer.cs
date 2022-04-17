namespace MazeGen_L3
{
    partial class FormMain
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
            this.pictureBoxMaze = new System.Windows.Forms.PictureBox();
            this.button_generate = new System.Windows.Forms.Button();
            this.label_width = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.label_height = new System.Windows.Forms.Label();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.checkBoxFullSolvePath = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaze)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMaze
            // 
            this.pictureBoxMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMaze.Location = new System.Drawing.Point(12, 81);
            this.pictureBoxMaze.Name = "pictureBoxMaze";
            this.pictureBoxMaze.Size = new System.Drawing.Size(499, 348);
            this.pictureBoxMaze.TabIndex = 0;
            this.pictureBoxMaze.TabStop = false;
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_generate.Location = new System.Drawing.Point(370, 12);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(137, 47);
            this.button_generate.TabIndex = 1;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.Button_generate_Click);
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(46, 7);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(37, 15);
            this.label_width.TabIndex = 5;
            this.label_width.Text = "width";
            // 
            // textBox_width
            // 
            this.textBox_width.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_width.Location = new System.Drawing.Point(34, 23);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(61, 33);
            this.textBox_width.TabIndex = 4;
            this.textBox_width.Text = "24";
            this.textBox_width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Number_KeyPress);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(125, 7);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(41, 15);
            this.label_height.TabIndex = 7;
            this.label_height.Text = "height";
            // 
            // textBox_height
            // 
            this.textBox_height.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_height.Location = new System.Drawing.Point(115, 23);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(61, 33);
            this.textBox_height.TabIndex = 6;
            this.textBox_height.Text = "16";
            this.textBox_height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Number_KeyPress);
            // 
            // button_solve
            // 
            this.button_solve.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_solve.Location = new System.Drawing.Point(220, 7);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(105, 46);
            this.button_solve.TabIndex = 8;
            this.button_solve.Text = "Solve";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.Button_solve_Click);
            // 
            // checkBoxFullSolvePath
            // 
            this.checkBoxFullSolvePath.AutoSize = true;
            this.checkBoxFullSolvePath.Location = new System.Drawing.Point(222, 56);
            this.checkBoxFullSolvePath.Name = "checkBoxFullSolvePath";
            this.checkBoxFullSolvePath.Size = new System.Drawing.Size(97, 19);
            this.checkBoxFullSolvePath.TabIndex = 9;
            this.checkBoxFullSolvePath.Text = "FullSolvePath";
            this.checkBoxFullSolvePath.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 441);
            this.Controls.Add(this.checkBoxFullSolvePath);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.textBox_height);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.pictureBoxMaze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.Text = "MazeGen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaze)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxMaze;
        private Button button_generate;
        private Label label_width;
        private TextBox textBox_width;
        private Label label_height;
        private TextBox textBox_height;
        private Button button_solve;
        private CheckBox checkBoxFullSolvePath;
    }
}