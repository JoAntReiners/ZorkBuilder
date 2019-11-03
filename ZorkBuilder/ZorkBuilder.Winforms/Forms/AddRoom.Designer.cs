﻿namespace ZorkBuilder.Winforms
{
    partial class AddRoomForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.RoomNameTextbox = new System.Windows.Forms.TextBox();
            this.RoomNameLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(142, 49);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(61, 49);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "&Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // RoomNameTextbox
            // 
            this.RoomNameTextbox.Location = new System.Drawing.Point(11, 23);
            this.RoomNameTextbox.Name = "RoomNameTextbox";
            this.RoomNameTextbox.Size = new System.Drawing.Size(206, 20);
            this.RoomNameTextbox.TabIndex = 1;
            this.RoomNameTextbox.TextChanged += new System.EventHandler(this.RoomNameTextbox_TextChanged);
            // 
            // RoomNameLable
            // 
            this.RoomNameLable.AutoSize = true;
            this.RoomNameLable.Location = new System.Drawing.Point(11, 7);
            this.RoomNameLable.Name = "RoomNameLable";
            this.RoomNameLable.Size = new System.Drawing.Size(66, 13);
            this.RoomNameLable.TabIndex = 0;
            this.RoomNameLable.Text = "Room Name";
            // 
            // AddRoomForm
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(229, 79);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.RoomNameTextbox);
            this.Controls.Add(this.RoomNameLable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox RoomNameTextbox;
        private System.Windows.Forms.Label RoomNameLable;
    }
}