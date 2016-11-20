using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scion_Character_Sheet
{
    class formAddKnack
    {
        public static DialogResult InitializeComponent(ref string outputKnack, ref string outputAttribute, ref string outputDescription)
        {
            Form knackForm = new Form();
            TextBox textBoxKnackName = new System.Windows.Forms.TextBox();
            TextBox textBoxAssociatedAttribute = new System.Windows.Forms.TextBox();
            TextBox textBoxKnackDescription = new System.Windows.Forms.TextBox();
            Button buttonCancel = new System.Windows.Forms.Button();
            Button buttonSubmit = new System.Windows.Forms.Button();
            knackForm.SuspendLayout();
            // 
            // textBoxKnackName
            // 
            textBoxKnackName.Location = new System.Drawing.Point(13, 13);
            textBoxKnackName.Name = "textBoxKnackName";
            textBoxKnackName.Size = new System.Drawing.Size(100, 20);
            textBoxKnackName.TabIndex = 0;
            textBoxKnackName.Text = "Knack Name";
            // 
            // textBoxAssociatedAttribute
            // 
            textBoxAssociatedAttribute.Location = new System.Drawing.Point(13, 39);
            textBoxAssociatedAttribute.Name = "textBoxAssociatedAttribute";
            textBoxAssociatedAttribute.Size = new System.Drawing.Size(100, 20);
            textBoxAssociatedAttribute.TabIndex = 1;
            textBoxAssociatedAttribute.Text = "Associated Attribute";
            // 
            // textBoxKnackDescription
            // 
            textBoxKnackDescription.Location = new System.Drawing.Point(13, 66);
            textBoxKnackDescription.Multiline = true;
            textBoxKnackDescription.Name = "textBoxKnackDescription";
            textBoxKnackDescription.Size = new System.Drawing.Size(489, 152);
            textBoxKnackDescription.TabIndex = 2;
            textBoxKnackDescription.Text = "Description";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(427, 224);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(75, 23);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.DialogResult = DialogResult.Cancel;
            knackForm.CancelButton = buttonCancel;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new System.Drawing.Point(346, 224);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new System.Drawing.Size(75, 23);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.DialogResult = DialogResult.OK;
            knackForm.AcceptButton = buttonSubmit;
            // 
            // formAddKnack
            // 
            knackForm.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            knackForm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            knackForm.ClientSize = new System.Drawing.Size(514, 261);
            knackForm.Controls.Add(buttonSubmit);
            knackForm.Controls.Add(buttonCancel);
            knackForm.Controls.Add(textBoxKnackDescription);
            knackForm.Controls.Add(textBoxAssociatedAttribute);
            knackForm.Controls.Add(textBoxKnackName);
            knackForm.Name = "formAddKnack";
            knackForm.Text = "Add Knack";
            knackForm.ResumeLayout(false);
            knackForm.PerformLayout();

            DialogResult dialogResult = knackForm.ShowDialog();
            outputKnack = textBoxKnackName.Text;
            outputDescription = textBoxKnackDescription.Text;
            outputAttribute = textBoxAssociatedAttribute.Text;
            return dialogResult;
        }


        private Form knackForm;
        private System.Windows.Forms.TextBox textBoxKnackName;
        private System.Windows.Forms.TextBox textBoxAssociatedAttribute;
        private System.Windows.Forms.TextBox textBoxKnackDescription;
        private System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonSubmit;

        public formAddKnack(ref string outputKnack, ref string outputAttribute, ref string outputDescription)
        {            
            InitializeComponent(ref outputKnack, ref outputAttribute, ref outputDescription);
            
        }
        private void submitContent(ref string outputKnack, ref string outputAttribute, ref string outputDescription)
        {
            

        }

    }
}
