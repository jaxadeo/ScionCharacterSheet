namespace Scion_Character_Sheet
{
    partial class formAddKnack
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
            this.textBoxKnackName = new System.Windows.Forms.TextBox();
            this.textBoxAssociatedAttribute = new System.Windows.Forms.TextBox();
            this.textBoxKnackDescription = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKnackName
            // 
            this.textBoxKnackName.Location = new System.Drawing.Point(13, 13);
            this.textBoxKnackName.Name = "textBoxKnackName";
            this.textBoxKnackName.Size = new System.Drawing.Size(100, 20);
            this.textBoxKnackName.TabIndex = 0;
            this.textBoxKnackName.Text = "Knack Name";
            // 
            // textBoxAssociatedAttribute
            // 
            this.textBoxAssociatedAttribute.Location = new System.Drawing.Point(13, 39);
            this.textBoxAssociatedAttribute.Name = "textBoxAssociatedAttribute";
            this.textBoxAssociatedAttribute.Size = new System.Drawing.Size(100, 20);
            this.textBoxAssociatedAttribute.TabIndex = 1;
            this.textBoxAssociatedAttribute.Text = "Associated Attribute";
            // 
            // textBoxKnackDescription
            // 
            this.textBoxKnackDescription.Location = new System.Drawing.Point(13, 66);
            this.textBoxKnackDescription.Multiline = true;
            this.textBoxKnackDescription.Name = "textBoxKnackDescription";
            this.textBoxKnackDescription.Size = new System.Drawing.Size(489, 152);
            this.textBoxKnackDescription.TabIndex = 2;
            this.textBoxKnackDescription.Text = "Description";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(427, 224);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(346, 224);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // formAddKnack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxKnackDescription);
            this.Controls.Add(this.textBoxAssociatedAttribute);
            this.Controls.Add(this.textBoxKnackName);
            this.Name = "formAddKnack";
            this.Text = "Add Knack";
            this.Load += new System.EventHandler(this.formAddKnack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxKnackName;
        public System.Windows.Forms.TextBox textBoxAssociatedAttribute;
        public System.Windows.Forms.TextBox textBoxKnackDescription;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonSubmit;
    }
}