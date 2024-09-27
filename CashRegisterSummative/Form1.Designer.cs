namespace CashRegisterSummative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.trainsLabel = new System.Windows.Forms.Label();
            this.trainsInput = new System.Windows.Forms.TextBox();
            this.tracksLabel = new System.Windows.Forms.Label();
            this.tracksInput = new System.Windows.Forms.TextBox();
            this.accessoriesLabel = new System.Windows.Forms.Label();
            this.accessoriesInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.calculateChangeButton = new System.Windows.Forms.Button();
            this.trainPriceLabel = new System.Windows.Forms.Label();
            this.trackPriceLabel = new System.Windows.Forms.Label();
            this.accessoryPriceLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Teal;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1029, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Divo\'s Model Trains";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.ForeColor = System.Drawing.Color.Black;
            this.receiptOutput.Location = new System.Drawing.Point(578, 36);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(392, 511);
            this.receiptOutput.TabIndex = 1;
            // 
            // trainsLabel
            // 
            this.trainsLabel.AutoSize = true;
            this.trainsLabel.Location = new System.Drawing.Point(54, 57);
            this.trainsLabel.Name = "trainsLabel";
            this.trainsLabel.Size = new System.Drawing.Size(151, 20);
            this.trainsLabel.TabIndex = 2;
            this.trainsLabel.Text = "Number of Trains:";
            // 
            // trainsInput
            // 
            this.trainsInput.Location = new System.Drawing.Point(216, 54);
            this.trainsInput.Name = "trainsInput";
            this.trainsInput.Size = new System.Drawing.Size(134, 26);
            this.trainsInput.TabIndex = 3;
            // 
            // tracksLabel
            // 
            this.tracksLabel.AutoSize = true;
            this.tracksLabel.Location = new System.Drawing.Point(1, 99);
            this.tracksLabel.Name = "tracksLabel";
            this.tracksLabel.Size = new System.Drawing.Size(204, 20);
            this.tracksLabel.TabIndex = 4;
            this.tracksLabel.Text = "Number of Track Pieces:";
            // 
            // tracksInput
            // 
            this.tracksInput.Location = new System.Drawing.Point(216, 99);
            this.tracksInput.Name = "tracksInput";
            this.tracksInput.Size = new System.Drawing.Size(134, 26);
            this.tracksInput.TabIndex = 5;
            // 
            // accessoriesLabel
            // 
            this.accessoriesLabel.AutoSize = true;
            this.accessoriesLabel.Location = new System.Drawing.Point(6, 141);
            this.accessoriesLabel.Name = "accessoriesLabel";
            this.accessoriesLabel.Size = new System.Drawing.Size(199, 20);
            this.accessoriesLabel.TabIndex = 6;
            this.accessoriesLabel.Text = "Number of Accessories:";
            // 
            // accessoriesInput
            // 
            this.accessoriesInput.Location = new System.Drawing.Point(216, 141);
            this.accessoriesInput.Name = "accessoriesInput";
            this.accessoriesInput.Size = new System.Drawing.Size(134, 26);
            this.accessoriesInput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.Location = new System.Drawing.Point(169, 187);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(96, 29);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(123, 239);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(82, 20);
            this.subtotalLabel.TabIndex = 9;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(161, 279);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(42, 20);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(149, 317);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(54, 20);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total:";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Location = new System.Drawing.Point(113, 386);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(90, 20);
            this.tenderedLabel.TabIndex = 12;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(129, 470);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(76, 20);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change:";
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.Black;
            this.printReceiptButton.Location = new System.Drawing.Point(155, 518);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(124, 29);
            this.printReceiptButton.TabIndex = 14;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(209, 383);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(141, 26);
            this.tenderedInput.TabIndex = 15;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.White;
            this.subtotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subtotalOutput.Location = new System.Drawing.Point(213, 239);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(137, 20);
            this.subtotalOutput.TabIndex = 16;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.White;
            this.taxOutput.ForeColor = System.Drawing.Color.Black;
            this.taxOutput.Location = new System.Drawing.Point(213, 279);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(137, 20);
            this.taxOutput.TabIndex = 17;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.ForeColor = System.Drawing.Color.Black;
            this.totalOutput.Location = new System.Drawing.Point(209, 317);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(141, 20);
            this.totalOutput.TabIndex = 18;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.White;
            this.changeOutput.ForeColor = System.Drawing.Color.Black;
            this.changeOutput.Location = new System.Drawing.Point(208, 470);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(142, 20);
            this.changeOutput.TabIndex = 19;
            // 
            // calculateChangeButton
            // 
            this.calculateChangeButton.BackColor = System.Drawing.Color.Black;
            this.calculateChangeButton.Location = new System.Drawing.Point(141, 427);
            this.calculateChangeButton.Name = "calculateChangeButton";
            this.calculateChangeButton.Size = new System.Drawing.Size(171, 29);
            this.calculateChangeButton.TabIndex = 20;
            this.calculateChangeButton.Text = "Calculate Change";
            this.calculateChangeButton.UseVisualStyleBackColor = false;
            this.calculateChangeButton.Click += new System.EventHandler(this.calculateChangeButton_Click);
            // 
            // trainPriceLabel
            // 
            this.trainPriceLabel.AutoSize = true;
            this.trainPriceLabel.Location = new System.Drawing.Point(356, 57);
            this.trainPriceLabel.Name = "trainPriceLabel";
            this.trainPriceLabel.Size = new System.Drawing.Size(144, 20);
            this.trainPriceLabel.TabIndex = 21;
            this.trainPriceLabel.Text = "Price: $100/Train";
            // 
            // trackPriceLabel
            // 
            this.trackPriceLabel.AutoSize = true;
            this.trackPriceLabel.Location = new System.Drawing.Point(356, 99);
            this.trackPriceLabel.Name = "trackPriceLabel";
            this.trackPriceLabel.Size = new System.Drawing.Size(138, 20);
            this.trackPriceLabel.TabIndex = 22;
            this.trackPriceLabel.Text = "Price: $50/Track";
            // 
            // accessoryPriceLabel
            // 
            this.accessoryPriceLabel.AutoSize = true;
            this.accessoryPriceLabel.Location = new System.Drawing.Point(356, 144);
            this.accessoryPriceLabel.Name = "accessoryPriceLabel";
            this.accessoryPriceLabel.Size = new System.Drawing.Size(176, 20);
            this.accessoryPriceLabel.TabIndex = 23;
            this.accessoryPriceLabel.Text = "Price: $25/Accessory";
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Black;
            this.newOrderButton.Location = new System.Drawing.Point(708, 561);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(129, 29);
            this.newOrderButton.TabIndex = 24;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 602);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.accessoryPriceLabel);
            this.Controls.Add(this.trackPriceLabel);
            this.Controls.Add(this.trainPriceLabel);
            this.Controls.Add(this.calculateChangeButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.accessoriesInput);
            this.Controls.Add(this.accessoriesLabel);
            this.Controls.Add(this.tracksInput);
            this.Controls.Add(this.tracksLabel);
            this.Controls.Add(this.trainsInput);
            this.Controls.Add(this.trainsLabel);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Divo\'s Model Trains";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Label trainsLabel;
        private System.Windows.Forms.TextBox trainsInput;
        private System.Windows.Forms.Label tracksLabel;
        private System.Windows.Forms.TextBox tracksInput;
        private System.Windows.Forms.Label accessoriesLabel;
        private System.Windows.Forms.TextBox accessoriesInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button calculateChangeButton;
        private System.Windows.Forms.Label trainPriceLabel;
        private System.Windows.Forms.Label trackPriceLabel;
        private System.Windows.Forms.Label accessoryPriceLabel;
        private System.Windows.Forms.Button newOrderButton;
    }
}

