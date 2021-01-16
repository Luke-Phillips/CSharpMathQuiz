
namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timeLeftTextLabel = new System.Windows.Forms.Label();
            this.plusLeftOp = new System.Windows.Forms.Label();
            this.plusRightOp = new System.Windows.Forms.Label();
            this.plusOp = new System.Windows.Forms.Label();
            this.plusEquals = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.minusEquals = new System.Windows.Forms.Label();
            this.minusOp = new System.Windows.Forms.Label();
            this.minusRightOp = new System.Windows.Forms.Label();
            this.minusLeftOp = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.multEquals = new System.Windows.Forms.Label();
            this.multOp = new System.Windows.Forms.Label();
            this.multRightOp = new System.Windows.Forms.Label();
            this.multLeftOp = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.divEquals = new System.Windows.Forms.Label();
            this.divOp = new System.Windows.Forms.Label();
            this.divRightOp = new System.Windows.Forms.Label();
            this.divLeftOp = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeLeftLabel.Location = new System.Drawing.Point(266, 9);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLeftLabel.TabIndex = 0;
            // 
            // timeLeftTextLabel
            // 
            this.timeLeftTextLabel.AutoSize = true;
            this.timeLeftTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTextLabel.Location = new System.Drawing.Point(116, 8);
            this.timeLeftTextLabel.Name = "timeLeftTextLabel";
            this.timeLeftTextLabel.Size = new System.Drawing.Size(135, 31);
            this.timeLeftTextLabel.TabIndex = 1;
            this.timeLeftTextLabel.Text = "Time Left:";
            // 
            // plusLeftOp
            // 
            this.plusLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftOp.Location = new System.Drawing.Point(51, 75);
            this.plusLeftOp.Name = "plusLeftOp";
            this.plusLeftOp.Size = new System.Drawing.Size(60, 50);
            this.plusLeftOp.TabIndex = 2;
            this.plusLeftOp.Text = "?";
            // 
            // plusRightOp
            // 
            this.plusRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightOp.Location = new System.Drawing.Point(181, 75);
            this.plusRightOp.Name = "plusRightOp";
            this.plusRightOp.Size = new System.Drawing.Size(60, 50);
            this.plusRightOp.TabIndex = 3;
            this.plusRightOp.Text = "?";
            // 
            // plusOp
            // 
            this.plusOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOp.Location = new System.Drawing.Point(116, 75);
            this.plusOp.Name = "plusOp";
            this.plusOp.Size = new System.Drawing.Size(60, 50);
            this.plusOp.TabIndex = 4;
            this.plusOp.Text = "+";
            // 
            // plusEquals
            // 
            this.plusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusEquals.Location = new System.Drawing.Point(248, 75);
            this.plusEquals.Name = "plusEquals";
            this.plusEquals.Size = new System.Drawing.Size(60, 50);
            this.plusEquals.TabIndex = 5;
            this.plusEquals.Text = "=";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(315, 73);
            this.sum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 41);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.answer_Change);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(315, 121);
            this.difference.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 41);
            this.difference.TabIndex = 3;
            this.difference.ValueChanged += new System.EventHandler(this.answer_Change);
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusEquals
            // 
            this.minusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusEquals.Location = new System.Drawing.Point(248, 122);
            this.minusEquals.Name = "minusEquals";
            this.minusEquals.Size = new System.Drawing.Size(60, 50);
            this.minusEquals.TabIndex = 10;
            this.minusEquals.Text = "=";
            // 
            // minusOp
            // 
            this.minusOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusOp.Location = new System.Drawing.Point(116, 122);
            this.minusOp.Name = "minusOp";
            this.minusOp.Size = new System.Drawing.Size(60, 50);
            this.minusOp.TabIndex = 9;
            this.minusOp.Text = "-";
            // 
            // minusRightOp
            // 
            this.minusRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightOp.Location = new System.Drawing.Point(181, 122);
            this.minusRightOp.Name = "minusRightOp";
            this.minusRightOp.Size = new System.Drawing.Size(60, 50);
            this.minusRightOp.TabIndex = 8;
            this.minusRightOp.Text = "?";
            // 
            // minusLeftOp
            // 
            this.minusLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftOp.Location = new System.Drawing.Point(51, 122);
            this.minusLeftOp.Name = "minusLeftOp";
            this.minusLeftOp.Size = new System.Drawing.Size(60, 50);
            this.minusLeftOp.TabIndex = 7;
            this.minusLeftOp.Text = "?";
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(315, 167);
            this.product.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 41);
            this.product.TabIndex = 4;
            this.product.ValueChanged += new System.EventHandler(this.answer_Change);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // multEquals
            // 
            this.multEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multEquals.Location = new System.Drawing.Point(248, 169);
            this.multEquals.Name = "multEquals";
            this.multEquals.Size = new System.Drawing.Size(60, 50);
            this.multEquals.TabIndex = 15;
            this.multEquals.Text = "=";
            // 
            // multOp
            // 
            this.multOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multOp.Location = new System.Drawing.Point(116, 169);
            this.multOp.Name = "multOp";
            this.multOp.Size = new System.Drawing.Size(60, 50);
            this.multOp.TabIndex = 14;
            this.multOp.Text = "×";
            // 
            // multRightOp
            // 
            this.multRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multRightOp.Location = new System.Drawing.Point(181, 169);
            this.multRightOp.Name = "multRightOp";
            this.multRightOp.Size = new System.Drawing.Size(60, 50);
            this.multRightOp.TabIndex = 13;
            this.multRightOp.Text = "?";
            // 
            // multLeftOp
            // 
            this.multLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multLeftOp.Location = new System.Drawing.Point(51, 169);
            this.multLeftOp.Name = "multLeftOp";
            this.multLeftOp.Size = new System.Drawing.Size(60, 50);
            this.multLeftOp.TabIndex = 12;
            this.multLeftOp.Text = "?";
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(315, 214);
            this.quotient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 41);
            this.quotient.TabIndex = 5;
            this.quotient.ValueChanged += new System.EventHandler(this.answer_Change);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // divEquals
            // 
            this.divEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divEquals.Location = new System.Drawing.Point(248, 217);
            this.divEquals.Name = "divEquals";
            this.divEquals.Size = new System.Drawing.Size(60, 50);
            this.divEquals.TabIndex = 20;
            this.divEquals.Text = "=";
            // 
            // divOp
            // 
            this.divOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divOp.Location = new System.Drawing.Point(116, 217);
            this.divOp.Name = "divOp";
            this.divOp.Size = new System.Drawing.Size(60, 50);
            this.divOp.TabIndex = 19;
            this.divOp.Text = "÷";
            // 
            // divRightOp
            // 
            this.divRightOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRightOp.Location = new System.Drawing.Point(181, 217);
            this.divRightOp.Name = "divRightOp";
            this.divRightOp.Size = new System.Drawing.Size(60, 50);
            this.divRightOp.TabIndex = 18;
            this.divRightOp.Text = "?";
            // 
            // divLeftOp
            // 
            this.divLeftOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeftOp.Location = new System.Drawing.Point(51, 217);
            this.divLeftOp.Name = "divLeftOp";
            this.divLeftOp.Size = new System.Drawing.Size(60, 50);
            this.divLeftOp.TabIndex = 17;
            this.divLeftOp.Text = "?";
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(164, 285);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(172, 42);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(342, 317);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(124, 23);
            this.dateLabel.TabIndex = 21;
            this.dateLabel.Text = "date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 349);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.divEquals);
            this.Controls.Add(this.divOp);
            this.Controls.Add(this.divRightOp);
            this.Controls.Add(this.divLeftOp);
            this.Controls.Add(this.product);
            this.Controls.Add(this.multEquals);
            this.Controls.Add(this.multOp);
            this.Controls.Add(this.multRightOp);
            this.Controls.Add(this.multLeftOp);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusEquals);
            this.Controls.Add(this.minusOp);
            this.Controls.Add(this.minusRightOp);
            this.Controls.Add(this.minusLeftOp);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusEquals);
            this.Controls.Add(this.plusOp);
            this.Controls.Add(this.plusRightOp);
            this.Controls.Add(this.plusLeftOp);
            this.Controls.Add(this.timeLeftTextLabel);
            this.Controls.Add(this.timeLeftLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Luke Phillips Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label timeLeftTextLabel;
        private System.Windows.Forms.Label plusLeftOp;
        private System.Windows.Forms.Label plusRightOp;
        private System.Windows.Forms.Label plusOp;
        private System.Windows.Forms.Label plusEquals;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minusEquals;
        private System.Windows.Forms.Label minusOp;
        private System.Windows.Forms.Label minusRightOp;
        private System.Windows.Forms.Label minusLeftOp;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label multEquals;
        private System.Windows.Forms.Label multOp;
        private System.Windows.Forms.Label multRightOp;
        private System.Windows.Forms.Label multLeftOp;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label divEquals;
        private System.Windows.Forms.Label divOp;
        private System.Windows.Forms.Label divRightOp;
        private System.Windows.Forms.Label divLeftOp;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
    }
}

