﻿namespace WebAPICodeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            btn__ENTITY_CLASS__to__PascalCaseDTO = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 67);
            button1.Name = "button1";
            button1.Size = new Size(259, 23);
            button1.TabIndex = 0;
            button1.Text = "Generate Controllers";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(45, 38);
            button2.Name = "button2";
            button2.Size = new Size(259, 23);
            button2.TabIndex = 1;
            button2.Text = "Generate FullDbContext";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn__ENTITY_CLASS__to__PascalCaseDTO
            // 
            btn__ENTITY_CLASS__to__PascalCaseDTO.Location = new Point(45, 96);
            btn__ENTITY_CLASS__to__PascalCaseDTO.Name = "btn__ENTITY_CLASS__to__PascalCaseDTO";
            btn__ENTITY_CLASS__to__PascalCaseDTO.Size = new Size(259, 23);
            btn__ENTITY_CLASS__to__PascalCaseDTO.TabIndex = 2;
            btn__ENTITY_CLASS__to__PascalCaseDTO.Text = "Generate DTO class from ENTITY class";
            btn__ENTITY_CLASS__to__PascalCaseDTO.UseVisualStyleBackColor = true;
            btn__ENTITY_CLASS__to__PascalCaseDTO.Click += btn__ENTITY_CLASS__to__PascalCaseDTO_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 188);
            Controls.Add(btn__ENTITY_CLASS__to__PascalCaseDTO);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "VNS Controller Generator";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button btn__ENTITY_CLASS__to__PascalCaseDTO;
    }
}