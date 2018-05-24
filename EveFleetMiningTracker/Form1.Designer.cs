namespace EveFleetMiningTracker
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
            this.minerInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.minerList = new System.Windows.Forms.ListBox();
            this.oreList = new System.Windows.Forms.ListBox();
            this.oreInputBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oreInputButton = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.clipboardExport = new System.Windows.Forms.Button();
            this.instructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minerInput
            // 
            this.minerInput.Location = new System.Drawing.Point(153, 6);
            this.minerInput.Name = "minerInput";
            this.minerInput.Size = new System.Drawing.Size(121, 22);
            this.minerInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miner Name to input";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Miner to list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minerList
            // 
            this.minerList.FormattingEnabled = true;
            this.minerList.ItemHeight = 16;
            this.minerList.Location = new System.Drawing.Point(15, 38);
            this.minerList.Name = "minerList";
            this.minerList.Size = new System.Drawing.Size(170, 468);
            this.minerList.TabIndex = 3;
            this.minerList.SelectedIndexChanged += new System.EventHandler(this.minerList_SelectedIndexChanged);
            // 
            // oreList
            // 
            this.oreList.FormattingEnabled = true;
            this.oreList.ItemHeight = 16;
            this.oreList.Location = new System.Drawing.Point(192, 38);
            this.oreList.Name = "oreList";
            this.oreList.Size = new System.Drawing.Size(214, 468);
            this.oreList.TabIndex = 4;
            // 
            // oreInputBox
            // 
            this.oreInputBox.Location = new System.Drawing.Point(413, 38);
            this.oreInputBox.Name = "oreInputBox";
            this.oreInputBox.Size = new System.Drawing.Size(298, 468);
            this.oreInputBox.TabIndex = 5;
            this.oreInputBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Use this box to input\r\nore to the selected\r\nminer on the left.";
            // 
            // oreInputButton
            // 
            this.oreInputButton.Location = new System.Drawing.Point(413, 9);
            this.oreInputButton.Name = "oreInputButton";
            this.oreInputButton.Size = new System.Drawing.Size(298, 23);
            this.oreInputButton.TabIndex = 7;
            this.oreInputButton.Text = "Add Ore to selected";
            this.oreInputButton.UseVisualStyleBackColor = true;
            this.oreInputButton.Click += new System.EventHandler(this.oreInputButton_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(15, 517);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 8;
            // 
            // clipboardExport
            // 
            this.clipboardExport.Location = new System.Drawing.Point(717, 9);
            this.clipboardExport.Name = "clipboardExport";
            this.clipboardExport.Size = new System.Drawing.Size(187, 23);
            this.clipboardExport.TabIndex = 9;
            this.clipboardExport.Text = "Copy List to ClipBoard";
            this.clipboardExport.UseVisualStyleBackColor = true;
            this.clipboardExport.Click += new System.EventHandler(this.clipboardExport_Click);
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Location = new System.Drawing.Point(717, 121);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(356, 289);
            this.instructions.TabIndex = 10;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1075, 546);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.clipboardExport);
            this.Controls.Add(this.error);
            this.Controls.Add(this.oreInputButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oreInputBox);
            this.Controls.Add(this.oreList);
            this.Controls.Add(this.minerList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minerInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minerInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox minerList;
        private System.Windows.Forms.ListBox oreList;
        private System.Windows.Forms.RichTextBox oreInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button oreInputButton;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button clipboardExport;
        private System.Windows.Forms.Label instructions;
    }
}

