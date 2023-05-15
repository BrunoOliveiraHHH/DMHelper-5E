namespace DMWorkshop
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.lbl_Monster = new System.Windows.Forms.Label();
            this.lbl_Item = new System.Windows.Forms.Label();
            this.lbl_Spells = new System.Windows.Forms.Label();
            this.lbl_Npcs = new System.Windows.Forms.Label();
            this.btn_Npcs = new System.Windows.Forms.Button();
            this.btn_Items = new System.Windows.Forms.Button();
            this.btn_Monsters = new System.Windows.Forms.Button();
            this.btn_Spells = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Monster
            // 
            this.lbl_Monster.AutoSize = true;
            this.lbl_Monster.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Monster.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Monster.ForeColor = System.Drawing.Color.White;
            this.lbl_Monster.Location = new System.Drawing.Point(230, 265);
            this.lbl_Monster.Name = "lbl_Monster";
            this.lbl_Monster.Size = new System.Drawing.Size(109, 26);
            this.lbl_Monster.TabIndex = 1;
            this.lbl_Monster.Text = "Monstros";
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Item.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Item.ForeColor = System.Drawing.Color.White;
            this.lbl_Item.Location = new System.Drawing.Point(249, 501);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(62, 26);
            this.lbl_Item.TabIndex = 3;
            this.lbl_Item.Text = "Itens";
            // 
            // lbl_Spells
            // 
            this.lbl_Spells.AutoSize = true;
            this.lbl_Spells.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Spells.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Spells.ForeColor = System.Drawing.Color.White;
            this.lbl_Spells.Location = new System.Drawing.Point(815, 265);
            this.lbl_Spells.Name = "lbl_Spells";
            this.lbl_Spells.Size = new System.Drawing.Size(87, 26);
            this.lbl_Spells.TabIndex = 5;
            this.lbl_Spells.Text = "Magias";
            // 
            // lbl_Npcs
            // 
            this.lbl_Npcs.AutoSize = true;
            this.lbl_Npcs.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Npcs.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Npcs.ForeColor = System.Drawing.Color.White;
            this.lbl_Npcs.Location = new System.Drawing.Point(823, 501);
            this.lbl_Npcs.Name = "lbl_Npcs";
            this.lbl_Npcs.Size = new System.Drawing.Size(70, 26);
            this.lbl_Npcs.TabIndex = 7;
            this.lbl_Npcs.Text = "NPCs";
            // 
            // btn_Npcs
            // 
            this.btn_Npcs.Image = global::DMWorkshop.Properties.Resources.button;
            this.btn_Npcs.Location = new System.Drawing.Point(783, 338);
            this.btn_Npcs.Name = "btn_Npcs";
            this.btn_Npcs.Size = new System.Drawing.Size(150, 160);
            this.btn_Npcs.TabIndex = 8;
            this.btn_Npcs.UseVisualStyleBackColor = true;
            // 
            // btn_Items
            // 
            this.btn_Items.Image = global::DMWorkshop.Properties.Resources.button;
            this.btn_Items.Location = new System.Drawing.Point(209, 338);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.Size = new System.Drawing.Size(150, 160);
            this.btn_Items.TabIndex = 9;
            this.btn_Items.UseVisualStyleBackColor = true;
            // 
            // btn_Monsters
            // 
            this.btn_Monsters.Image = global::DMWorkshop.Properties.Resources.button;
            this.btn_Monsters.Location = new System.Drawing.Point(209, 102);
            this.btn_Monsters.Name = "btn_Monsters";
            this.btn_Monsters.Size = new System.Drawing.Size(150, 160);
            this.btn_Monsters.TabIndex = 10;
            this.btn_Monsters.UseVisualStyleBackColor = true;
            // 
            // btn_Spells
            // 
            this.btn_Spells.Image = global::DMWorkshop.Properties.Resources.button;
            this.btn_Spells.Location = new System.Drawing.Point(783, 102);
            this.btn_Spells.Name = "btn_Spells";
            this.btn_Spells.Size = new System.Drawing.Size(150, 160);
            this.btn_Spells.TabIndex = 11;
            this.btn_Spells.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DMWorkshop.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Spells);
            this.Controls.Add(this.btn_Monsters);
            this.Controls.Add(this.btn_Items);
            this.Controls.Add(this.btn_Npcs);
            this.Controls.Add(this.lbl_Npcs);
            this.Controls.Add(this.lbl_Spells);
            this.Controls.Add(this.lbl_Item);
            this.Controls.Add(this.lbl_Monster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Monster;
        private Label lbl_Item;
        private Label lbl_Spells;
        private Label lbl_Npcs;
        private Button btn_Npcs;
        private Button btn_Items;
        private Button btn_Monsters;
        private Button btn_Spells;
    }
}