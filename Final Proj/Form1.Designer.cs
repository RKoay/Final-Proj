﻿namespace Final_Proj
{
    partial class mainMenu
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.howtoplaylabel = new System.Windows.Forms.Label();
            this.instructionlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Orator Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(158, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(408, 62);
            this.titleLabel.TabIndex = 0;
            // 
            // startLabel
            // 
            this.startLabel.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startLabel.Location = new System.Drawing.Point(274, 170);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(213, 39);
            this.startLabel.TabIndex = 1;
            // 
            // howtoplaylabel
            // 
            this.howtoplaylabel.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howtoplaylabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.howtoplaylabel.Location = new System.Drawing.Point(279, 260);
            this.howtoplaylabel.Name = "howtoplaylabel";
            this.howtoplaylabel.Size = new System.Drawing.Size(213, 39);
            this.howtoplaylabel.TabIndex = 2;
            // 
            // instructionlabel
            // 
            this.instructionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.instructionlabel.Location = new System.Drawing.Point(12, 500);
            this.instructionlabel.Name = "instructionlabel";
            this.instructionlabel.Size = new System.Drawing.Size(332, 49);
            this.instructionlabel.TabIndex = 3;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 558);
            this.Controls.Add(this.instructionlabel);
            this.Controls.Add(this.howtoplaylabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "mainMenu";
            this.Text = "MAIN MENU";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainMenu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label howtoplaylabel;
        private System.Windows.Forms.Label instructionlabel;
    }
}
