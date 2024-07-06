namespace TrigonometricCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbLeg = new System.Windows.Forms.RadioButton();
            this.rbAngle = new System.Windows.Forms.RadioButton();
            this.pnlLegInputs = new System.Windows.Forms.Panel();
            this.lblLeg = new System.Windows.Forms.Label();
            this.txtLeg = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.pnlAngleInputs = new System.Windows.Forms.Panel();
            this.lblLeg1 = new System.Windows.Forms.Label();
            this.txtLeg1 = new System.Windows.Forms.TextBox();
            this.lblLeg2 = new System.Windows.Forms.Label();
            this.txtLeg2 = new System.Windows.Forms.TextBox();
            this.lblRatio = new System.Windows.Forms.Label();
            this.rbSin = new System.Windows.Forms.RadioButton();
            this.rbCos = new System.Windows.Forms.RadioButton();
            this.rbTan = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.pnlLegInputs.SuspendLayout();
            this.pnlAngleInputs.SuspendLayout();
            this.SuspendLayout();

            
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F);
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trigonometric Calculator";
            // 
            // rbLeg
            // 
            this.rbLeg.AutoSize = true;
            this.rbLeg.Location = new System.Drawing.Point(35, 65);
            this.rbLeg.Name = "rbLeg";
            this.rbLeg.Size = new System.Drawing.Size(149, 21);
            this.rbLeg.TabIndex = 1;
            this.rbLeg.TabStop = true;
            this.rbLeg.Text = "Other leg length";
            this.rbLeg.UseVisualStyleBackColor = true;
            this.rbLeg.CheckedChanged += new System.EventHandler(this.rbLeg_CheckedChanged);
            // 
            // rbAngle
            // 
            this.rbAngle.AutoSize = true;
            this.rbAngle.Location = new System.Drawing.Point(190, 65);
            this.rbAngle.Name = "rbAngle";
            this.rbAngle.Size = new System.Drawing.Size(65, 21);
            this.rbAngle.TabIndex = 2;
            this.rbAngle.TabStop = true;
            this.rbAngle.Text = "Angle";
            this.rbAngle.UseVisualStyleBackColor = true;
            this.rbAngle.CheckedChanged += new System.EventHandler(this.rbAngle_CheckedChanged);
            // 
            // pnlLegInputs
            // 
            this.pnlLegInputs.Controls.Add(this.lblLeg);
            this.pnlLegInputs.Controls.Add(this.txtLeg);
            this.pnlLegInputs.Controls.Add(this.lblAngle);
            this.pnlLegInputs.Controls.Add(this.txtAngle);
            this.pnlLegInputs.Location = new System.Drawing.Point(35, 100);
            this.pnlLegInputs.Name = "pnlLegInputs";
            this.pnlLegInputs.Size = new System.Drawing.Size(250, 100);
            this.pnlLegInputs.TabIndex = 3;
            // 
            // lblLeg
            // 
            this.lblLeg.AutoSize = true;
            this.lblLeg.Location = new System.Drawing.Point(5, 5);
            this.lblLeg.Name = "lblLeg";
            this.lblLeg.Size = new System.Drawing.Size(80, 17);
            this.lblLeg.TabIndex = 0;
            this.lblLeg.Text = "Leg length:";
            // 
            // txtLeg
            // 
            this.txtLeg.Location = new System.Drawing.Point(100, 5);
            this.txtLeg.Name = "txtLeg";
            this.txtLeg.Size = new System.Drawing.Size(100, 22);
            this.txtLeg.TabIndex = 1;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(5, 35);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(95, 17);
            this.lblAngle.TabIndex = 2;
            this.lblAngle.Text = "Angle (degrees):";
            // 
            // txtAngle
            // 
            this.txtAngle.Location = new System.Drawing.Point(100, 35);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 22);
            this.txtAngle.TabIndex = 3;
            // 
            // pnlAngleInputs
            // 
            this.pnlAngleInputs.Controls.Add(this.lblLeg1);
            this.pnlAngleInputs.Controls.Add(this.txtLeg1);
            this.pnlAngleInputs.Controls.Add(this.lblLeg2);
            this.pnlAngleInputs.Controls.Add(this.txtLeg2);
            this.pnlAngleInputs.Location = new System.Drawing.Point(35, 100);
            this.pnlAngleInputs.Name = "pnlAngleInputs";
            this.pnlAngleInputs.Size = new System.Drawing.Size(250, 100);
            this.pnlAngleInputs.TabIndex = 4;
            // 
            // lblLeg1
            // 
            this.lblLeg1.AutoSize = true;
            this.lblLeg1.Location = new System.Drawing.Point(5, 5);
            this.lblLeg1.Name = "lblLeg1";
            this.lblLeg1.Size = new System.Drawing.Size(80, 17);
            this.lblLeg1.TabIndex = 0;
            this.lblLeg1.Text = "Leg 1 length:";
            // 
            // txtLeg1
            // 
            this.txtLeg1.Location = new System.Drawing.Point(100, 5);
            this.txtLeg1.Name = "txtLeg1";
            this.txtLeg1.Size = new System.Drawing.Size(100, 22);
            this.txtLeg1.TabIndex = 1;
            // 
            // lblLeg2
            // 
            this.lblLeg2.AutoSize = true;
            this.lblLeg2.Location = new System.Drawing.Point(5, 35);
            this.lblLeg2.Name = "lblLeg2";
            this.lblLeg2.Size = new System.Drawing.Size(80, 17);
            this.lblLeg2.TabIndex = 2;
            this.lblLeg2.Text = "Leg 2 length:";
            // 
            // txtLeg2
            // 
            this.txtLeg2.Location = new System.Drawing.Point(100, 35);
            this.txtLeg2.Name = "txtLeg2";
            this.txtLeg2.Size = new System.Drawing.Size(100, 22);
            this.txtLeg2.TabIndex = 3;
            // 
            // lblRatio
            // 
            this.lblRatio.AutoSize = true;
            this.lblRatio.Location = new System.Drawing.Point(35, 210);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(136, 17);
            this.lblRatio.TabIndex = 5;
            this.lblRatio.Text = "Trigonometric Ratio:";
            // 
            // rbSin
            // 
            this.rbSin.AutoSize = true;
            this.rbSin.Location = new System.Drawing.Point(50, 230);
            this.rbSin.Name = "rbSin";
            this.rbSin.Size = new System.Drawing.Size(45, 21);
            this.rbSin.TabIndex = 6;
            this.rbSin.TabStop = true;
            this.rbSin.Text = "Sin";
            this.rbSin.UseVisualStyleBackColor = true;
            // 
            // rbCos
            // 
            this.rbCos.AutoSize = true;
            this.rbCos.Location = new System.Drawing.Point(100, 230);
            this.rbCos.Name = "rbCos";
            this.rbCos.Size = new System.Drawing.Size(52, 21);
            this.rbCos.TabIndex = 7;
            this.rbCos.TabStop = true;
            this.rbCos.Text = "Cos";
            this.rbCos.UseVisualStyleBackColor = true;
            // 
            // rbTan
            // 
            this.rbTan.AutoSize = true;
            this.rbTan.Location = new System.Drawing.Point(160, 230);
            this.rbTan.Name = "rbTan";
            this.rbTan.Size = new System.Drawing.Size(51, 21);
            this.rbTan.TabIndex = 8;
            this.rbTan.TabStop = true;
            this.rbTan.Text = "Tan";
            this.rbTan.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Blue;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(35, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(250, 30);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(35, 300);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(130, 17);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result will appear here";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(320, 340);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbTan);
            this.Controls.Add(this.rbCos);
            this.Controls.Add(this.rbSin);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.pnlAngleInputs);
            this.Controls.Add(this.pnlLegInputs);
            this.Controls.Add(this.rbAngle);
            this.Controls.Add(this.rbLeg);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.pnlLegInputs.ResumeLayout(false);
            this.pnlLegInputs.PerformLayout();
            this.pnlAngleInputs.ResumeLayout(false);
            this.pnlAngleInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbLeg;
        private System.Windows.Forms.RadioButton rbAngle;
        private System.Windows.Forms.Panel pnlLegInputs;
        private System.Windows.Forms.Label lblLeg;
        private System.Windows.Forms.TextBox txtLeg;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Panel pnlAngleInputs;
        private System.Windows.Forms.Label lblLeg1;
        private System.Windows.Forms.TextBox txtLeg1;
        private System.Windows.Forms.Label lblLeg2;
        private System.Windows.Forms.TextBox txtLeg2;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.RadioButton rbSin;
        private System.Windows.Forms.RadioButton rbCos;
        private System.Windows.Forms.RadioButton rbTan;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
