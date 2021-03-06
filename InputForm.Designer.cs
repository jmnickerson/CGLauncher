﻿using System.Windows.Forms;
namespace CGLauncher
{
    partial class InputForm
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
            this.primaryActionLabel = new System.Windows.Forms.Label();
            this.secondaryActionLabel = new System.Windows.Forms.Label();
            this.primaryActionBox = new System.Windows.Forms.TextBox();
            this.secondaryActionBox = new System.Windows.Forms.TextBox();
            this.action1Box = new System.Windows.Forms.TextBox();
            this.action6Box = new System.Windows.Forms.TextBox();
            this.action3Box = new System.Windows.Forms.TextBox();
            this.action4Box = new System.Windows.Forms.TextBox();
            this.action2Box = new System.Windows.Forms.TextBox();
            this.action5Box = new System.Windows.Forms.TextBox();
            this.action1label = new System.Windows.Forms.Label();
            this.action6label = new System.Windows.Forms.Label();
            this.action5label = new System.Windows.Forms.Label();
            this.action4label = new System.Windows.Forms.Label();
            this.action3label = new System.Windows.Forms.Label();
            this.action2label = new System.Windows.Forms.Label();
            this.blockBox = new System.Windows.Forms.TextBox();
            this.blocklabel = new System.Windows.Forms.Label();
            this.dodgeBox = new System.Windows.Forms.TextBox();
            this.dodgelabel = new System.Windows.Forms.Label();
            this.jumpBox = new System.Windows.Forms.TextBox();
            this.jumplabel = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.applybutton = new System.Windows.Forms.Button();
            this.interactlabel = new System.Windows.Forms.Label();
            this.interactBox = new System.Windows.Forms.TextBox();
            this.actionBox = new System.Windows.Forms.GroupBox();
            this.combatBox = new System.Windows.Forms.GroupBox();
            this.parryBox = new System.Windows.Forms.TextBox();
            this.parrylabel = new System.Windows.Forms.Label();
            this.movementBox = new System.Windows.Forms.GroupBox();
            this.backBox = new System.Windows.Forms.TextBox();
            this.forwardlabel2 = new System.Windows.Forms.Label();
            this.backlabel = new System.Windows.Forms.Label();
            this.rightlabel = new System.Windows.Forms.Label();
            this.rightBox = new System.Windows.Forms.TextBox();
            this.forwardBox = new System.Windows.Forms.TextBox();
            this.leftlabel = new System.Windows.Forms.Label();
            this.leftBox = new System.Windows.Forms.TextBox();
            this.keyboardRadioButton = new System.Windows.Forms.RadioButton();
            this.controllerRadioButton = new System.Windows.Forms.RadioButton();
            this.actionBox.SuspendLayout();
            this.combatBox.SuspendLayout();
            this.movementBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // primaryActionLabel
            // 
            this.primaryActionLabel.AutoSize = true;
            this.primaryActionLabel.Location = new System.Drawing.Point(24, 32);
            this.primaryActionLabel.Name = "primaryActionLabel";
            this.primaryActionLabel.Size = new System.Drawing.Size(77, 13);
            this.primaryActionLabel.TabIndex = 21;
            this.primaryActionLabel.Text = "Primary Action:";
            // 
            // secondaryActionLabel
            // 
            this.secondaryActionLabel.AutoSize = true;
            this.secondaryActionLabel.Location = new System.Drawing.Point(11, 58);
            this.secondaryActionLabel.Name = "secondaryActionLabel";
            this.secondaryActionLabel.Size = new System.Drawing.Size(94, 13);
            this.secondaryActionLabel.TabIndex = 22;
            this.secondaryActionLabel.Text = "Secondary Action:";
            // 
            // primaryActionBox
            // 
            this.primaryActionBox.BackColor = System.Drawing.SystemColors.Window;
            this.primaryActionBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.primaryActionBox.Location = new System.Drawing.Point(109, 29);
            this.primaryActionBox.Multiline = true;
            this.primaryActionBox.Name = "primaryActionBox";
            this.primaryActionBox.Size = new System.Drawing.Size(70, 20);
            this.primaryActionBox.TabIndex = 1;
            this.primaryActionBox.Tag = "";
            this.primaryActionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.primaryActionBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.primaryActionBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.primaryActionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.primaryActionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.primaryActionBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // secondaryActionBox
            // 
            this.secondaryActionBox.Location = new System.Drawing.Point(109, 55);
            this.secondaryActionBox.Multiline = true;
            this.secondaryActionBox.Name = "secondaryActionBox";
            this.secondaryActionBox.Size = new System.Drawing.Size(70, 20);
            this.secondaryActionBox.TabIndex = 2;
            this.secondaryActionBox.Tag = "";
            this.secondaryActionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.secondaryActionBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.secondaryActionBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.secondaryActionBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.secondaryActionBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.secondaryActionBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action1Box
            // 
            this.action1Box.Location = new System.Drawing.Point(109, 81);
            this.action1Box.Multiline = true;
            this.action1Box.Name = "action1Box";
            this.action1Box.Size = new System.Drawing.Size(70, 20);
            this.action1Box.TabIndex = 3;
            this.action1Box.Tag = "";
            this.action1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.action1Box.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.action1Box.Enter += new System.EventHandler(this.textBox_Enter);
            this.action1Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.action1Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.action1Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action6Box
            // 
            this.action6Box.Location = new System.Drawing.Point(109, 211);
            this.action6Box.Multiline = true;
            this.action6Box.Name = "action6Box";
            this.action6Box.Size = new System.Drawing.Size(70, 20);
            this.action6Box.TabIndex = 8;
            this.action6Box.Tag = "";
            this.action6Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.action6Box.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.action6Box.Enter += new System.EventHandler(this.textBox_Enter);
            this.action6Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.action6Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.action6Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action3Box
            // 
            this.action3Box.Location = new System.Drawing.Point(109, 133);
            this.action3Box.Multiline = true;
            this.action3Box.Name = "action3Box";
            this.action3Box.Size = new System.Drawing.Size(70, 20);
            this.action3Box.TabIndex = 5;
            this.action3Box.Tag = "";
            this.action3Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.action3Box.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.action3Box.Enter += new System.EventHandler(this.textBox_Enter);
            this.action3Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.action3Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.action3Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action4Box
            // 
            this.action4Box.Location = new System.Drawing.Point(109, 159);
            this.action4Box.Multiline = true;
            this.action4Box.Name = "action4Box";
            this.action4Box.Size = new System.Drawing.Size(70, 20);
            this.action4Box.TabIndex = 6;
            this.action4Box.Tag = "";
            this.action4Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.action4Box.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.action4Box.Enter += new System.EventHandler(this.textBox_Enter);
            this.action4Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.action4Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.action4Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action2Box
            // 
            this.action2Box.Location = new System.Drawing.Point(109, 107);
            this.action2Box.Multiline = true;
            this.action2Box.Name = "action2Box";
            this.action2Box.Size = new System.Drawing.Size(70, 20);
            this.action2Box.TabIndex = 4;
            this.action2Box.Tag = "";
            this.action2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.action2Box.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.action2Box.Enter += new System.EventHandler(this.textBox_Enter);
            this.action2Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.action2Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.action2Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action5Box
            // 
            this.action5Box.Location = new System.Drawing.Point(109, 185);
            this.action5Box.Multiline = true;
            this.action5Box.Name = "action5Box";
            this.action5Box.Size = new System.Drawing.Size(70, 20);
            this.action5Box.TabIndex = 7;
            this.action5Box.Tag = "";
            this.action5Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.action5Box.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.action5Box.Enter += new System.EventHandler(this.textBox_Enter);
            this.action5Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.action5Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.action5Box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // action1label
            // 
            this.action1label.AutoSize = true;
            this.action1label.Location = new System.Drawing.Point(52, 84);
            this.action1label.Name = "action1label";
            this.action1label.Size = new System.Drawing.Size(49, 13);
            this.action1label.TabIndex = 23;
            this.action1label.Text = "Action 1:";
            // 
            // action6label
            // 
            this.action6label.AutoSize = true;
            this.action6label.Location = new System.Drawing.Point(52, 214);
            this.action6label.Name = "action6label";
            this.action6label.Size = new System.Drawing.Size(49, 13);
            this.action6label.TabIndex = 28;
            this.action6label.Text = "Action 6:";
            // 
            // action5label
            // 
            this.action5label.AutoSize = true;
            this.action5label.Location = new System.Drawing.Point(52, 188);
            this.action5label.Name = "action5label";
            this.action5label.Size = new System.Drawing.Size(49, 13);
            this.action5label.TabIndex = 27;
            this.action5label.Text = "Action 5:";
            // 
            // action4label
            // 
            this.action4label.AutoSize = true;
            this.action4label.Location = new System.Drawing.Point(52, 162);
            this.action4label.Name = "action4label";
            this.action4label.Size = new System.Drawing.Size(49, 13);
            this.action4label.TabIndex = 26;
            this.action4label.Text = "Action 4:";
            // 
            // action3label
            // 
            this.action3label.AutoSize = true;
            this.action3label.Location = new System.Drawing.Point(52, 136);
            this.action3label.Name = "action3label";
            this.action3label.Size = new System.Drawing.Size(49, 13);
            this.action3label.TabIndex = 25;
            this.action3label.Text = "Action 3:";
            // 
            // action2label
            // 
            this.action2label.AutoSize = true;
            this.action2label.Location = new System.Drawing.Point(52, 110);
            this.action2label.Name = "action2label";
            this.action2label.Size = new System.Drawing.Size(49, 13);
            this.action2label.TabIndex = 24;
            this.action2label.Text = "Action 2:";
            // 
            // blockBox
            // 
            this.blockBox.Location = new System.Drawing.Point(74, 28);
            this.blockBox.Multiline = true;
            this.blockBox.Name = "blockBox";
            this.blockBox.Size = new System.Drawing.Size(70, 20);
            this.blockBox.TabIndex = 10;
            this.blockBox.Tag = "";
            this.blockBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.blockBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.blockBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.blockBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.blockBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.blockBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // blocklabel
            // 
            this.blocklabel.AutoSize = true;
            this.blocklabel.Location = new System.Drawing.Point(29, 31);
            this.blocklabel.Name = "blocklabel";
            this.blocklabel.Size = new System.Drawing.Size(37, 13);
            this.blocklabel.TabIndex = 30;
            this.blocklabel.Text = "Block:";
            // 
            // dodgeBox
            // 
            this.dodgeBox.Location = new System.Drawing.Point(74, 54);
            this.dodgeBox.Multiline = true;
            this.dodgeBox.Name = "dodgeBox";
            this.dodgeBox.Size = new System.Drawing.Size(70, 20);
            this.dodgeBox.TabIndex = 11;
            this.dodgeBox.Tag = "";
            this.dodgeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dodgeBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.dodgeBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.dodgeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.dodgeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.dodgeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // dodgelabel
            // 
            this.dodgelabel.AutoSize = true;
            this.dodgelabel.Location = new System.Drawing.Point(25, 57);
            this.dodgelabel.Name = "dodgelabel";
            this.dodgelabel.Size = new System.Drawing.Size(45, 13);
            this.dodgelabel.TabIndex = 31;
            this.dodgelabel.Text = "Dodge: ";
            // 
            // jumpBox
            // 
            this.jumpBox.Location = new System.Drawing.Point(74, 80);
            this.jumpBox.Multiline = true;
            this.jumpBox.Name = "jumpBox";
            this.jumpBox.Size = new System.Drawing.Size(70, 20);
            this.jumpBox.TabIndex = 12;
            this.jumpBox.Tag = "";
            this.jumpBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.jumpBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.jumpBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.jumpBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.jumpBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.jumpBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // jumplabel
            // 
            this.jumplabel.AutoSize = true;
            this.jumplabel.Location = new System.Drawing.Point(31, 83);
            this.jumplabel.Name = "jumplabel";
            this.jumplabel.Size = new System.Drawing.Size(35, 13);
            this.jumplabel.TabIndex = 32;
            this.jumplabel.Text = "Jump:";
            this.jumplabel.Click += new System.EventHandler(this.jumplabel_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(297, 344);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(75, 23);
            this.closebutton.TabIndex = 20;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(112, 344);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 18;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // applybutton
            // 
            this.applybutton.Location = new System.Drawing.Point(206, 344);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(75, 23);
            this.applybutton.TabIndex = 19;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = true;
            // 
            // interactlabel
            // 
            this.interactlabel.AutoSize = true;
            this.interactlabel.Location = new System.Drawing.Point(59, 242);
            this.interactlabel.Name = "interactlabel";
            this.interactlabel.Size = new System.Drawing.Size(46, 13);
            this.interactlabel.TabIndex = 29;
            this.interactlabel.Text = "Interact:";
            // 
            // interactBox
            // 
            this.interactBox.Location = new System.Drawing.Point(109, 239);
            this.interactBox.Multiline = true;
            this.interactBox.Name = "interactBox";
            this.interactBox.Size = new System.Drawing.Size(70, 20);
            this.interactBox.TabIndex = 9;
            this.interactBox.Tag = "";
            this.interactBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.interactBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.interactBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.interactBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.interactBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.interactBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // actionBox
            // 
            this.actionBox.Controls.Add(this.primaryActionLabel);
            this.actionBox.Controls.Add(this.secondaryActionLabel);
            this.actionBox.Controls.Add(this.interactBox);
            this.actionBox.Controls.Add(this.primaryActionBox);
            this.actionBox.Controls.Add(this.secondaryActionBox);
            this.actionBox.Controls.Add(this.interactlabel);
            this.actionBox.Controls.Add(this.action1Box);
            this.actionBox.Controls.Add(this.action6Box);
            this.actionBox.Controls.Add(this.action3Box);
            this.actionBox.Controls.Add(this.action4Box);
            this.actionBox.Controls.Add(this.action2Box);
            this.actionBox.Controls.Add(this.action5Box);
            this.actionBox.Controls.Add(this.action1label);
            this.actionBox.Controls.Add(this.action6label);
            this.actionBox.Controls.Add(this.action2label);
            this.actionBox.Controls.Add(this.action5label);
            this.actionBox.Controls.Add(this.action3label);
            this.actionBox.Controls.Add(this.action4label);
            this.actionBox.Location = new System.Drawing.Point(21, 12);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(209, 277);
            this.actionBox.TabIndex = 50;
            this.actionBox.TabStop = false;
            this.actionBox.Text = "Actions";
            this.actionBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // combatBox
            // 
            this.combatBox.Controls.Add(this.parryBox);
            this.combatBox.Controls.Add(this.parrylabel);
            this.combatBox.Controls.Add(this.blocklabel);
            this.combatBox.Controls.Add(this.blockBox);
            this.combatBox.Controls.Add(this.dodgeBox);
            this.combatBox.Controls.Add(this.dodgelabel);
            this.combatBox.Controls.Add(this.jumpBox);
            this.combatBox.Controls.Add(this.jumplabel);
            this.combatBox.Location = new System.Drawing.Point(259, 13);
            this.combatBox.Name = "combatBox";
            this.combatBox.Size = new System.Drawing.Size(172, 148);
            this.combatBox.TabIndex = 60;
            this.combatBox.TabStop = false;
            this.combatBox.Text = "Combat";
            // 
            // parryBox
            // 
            this.parryBox.Location = new System.Drawing.Point(74, 106);
            this.parryBox.Multiline = true;
            this.parryBox.Name = "parryBox";
            this.parryBox.Size = new System.Drawing.Size(70, 20);
            this.parryBox.TabIndex = 13;
            this.parryBox.Tag = "";
            this.parryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parryBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.parryBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.parryBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.parryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.parryBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // parrylabel
            // 
            this.parrylabel.AutoSize = true;
            this.parrylabel.Location = new System.Drawing.Point(31, 109);
            this.parrylabel.Name = "parrylabel";
            this.parrylabel.Size = new System.Drawing.Size(34, 13);
            this.parrylabel.TabIndex = 33;
            this.parrylabel.Text = "Parry:";
            // 
            // movementBox
            // 
            this.movementBox.Controls.Add(this.backBox);
            this.movementBox.Controls.Add(this.forwardlabel2);
            this.movementBox.Controls.Add(this.backlabel);
            this.movementBox.Controls.Add(this.rightlabel);
            this.movementBox.Controls.Add(this.rightBox);
            this.movementBox.Controls.Add(this.forwardBox);
            this.movementBox.Controls.Add(this.leftlabel);
            this.movementBox.Controls.Add(this.leftBox);
            this.movementBox.Location = new System.Drawing.Point(259, 179);
            this.movementBox.Name = "movementBox";
            this.movementBox.Size = new System.Drawing.Size(172, 133);
            this.movementBox.TabIndex = 80;
            this.movementBox.TabStop = false;
            this.movementBox.Text = "Movement";
            // 
            // backBox
            // 
            this.backBox.Location = new System.Drawing.Point(76, 97);
            this.backBox.Multiline = true;
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(70, 20);
            this.backBox.TabIndex = 17;
            this.backBox.Tag = "";
            this.backBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.backBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.backBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.backBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.backBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.backBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // forwardlabel2
            // 
            this.forwardlabel2.AutoSize = true;
            this.forwardlabel2.Location = new System.Drawing.Point(22, 24);
            this.forwardlabel2.Name = "forwardlabel2";
            this.forwardlabel2.Size = new System.Drawing.Size(48, 13);
            this.forwardlabel2.TabIndex = 34;
            this.forwardlabel2.Text = "Forward:";
            // 
            // backlabel
            // 
            this.backlabel.AutoSize = true;
            this.backlabel.Location = new System.Drawing.Point(35, 100);
            this.backlabel.Name = "backlabel";
            this.backlabel.Size = new System.Drawing.Size(35, 13);
            this.backlabel.TabIndex = 37;
            this.backlabel.Text = "Back:";
            // 
            // rightlabel
            // 
            this.rightlabel.AutoSize = true;
            this.rightlabel.Location = new System.Drawing.Point(35, 74);
            this.rightlabel.Name = "rightlabel";
            this.rightlabel.Size = new System.Drawing.Size(35, 13);
            this.rightlabel.TabIndex = 36;
            this.rightlabel.Text = "Right:";
            // 
            // rightBox
            // 
            this.rightBox.Location = new System.Drawing.Point(76, 71);
            this.rightBox.Multiline = true;
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(70, 20);
            this.rightBox.TabIndex = 16;
            this.rightBox.Tag = "";
            this.rightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rightBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.rightBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.rightBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.rightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.rightBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // forwardBox
            // 
            this.forwardBox.Location = new System.Drawing.Point(76, 19);
            this.forwardBox.Multiline = true;
            this.forwardBox.Name = "forwardBox";
            this.forwardBox.Size = new System.Drawing.Size(70, 20);
            this.forwardBox.TabIndex = 14;
            this.forwardBox.Tag = "";
            this.forwardBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forwardBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.forwardBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.forwardBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.forwardBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.forwardBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // leftlabel
            // 
            this.leftlabel.AutoSize = true;
            this.leftlabel.Location = new System.Drawing.Point(42, 48);
            this.leftlabel.Name = "leftlabel";
            this.leftlabel.Size = new System.Drawing.Size(28, 13);
            this.leftlabel.TabIndex = 35;
            this.leftlabel.Text = "Left:";
            // 
            // leftBox
            // 
            this.leftBox.Location = new System.Drawing.Point(76, 45);
            this.leftBox.Multiline = true;
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(70, 20);
            this.leftBox.TabIndex = 15;
            this.leftBox.Tag = "";
            this.leftBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.leftBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.leftBox.Enter += new System.EventHandler(this.textBox_Enter);
            this.leftBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtShortcut_KeyDown);
            this.leftBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_keypress);
            this.leftBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            // 
            // keyboardRadioButton
            // 
            this.keyboardRadioButton.AutoSize = true;
            this.keyboardRadioButton.Location = new System.Drawing.Point(35, 296);
            this.keyboardRadioButton.Name = "keyboardRadioButton";
            this.keyboardRadioButton.Size = new System.Drawing.Size(70, 17);
            this.keyboardRadioButton.TabIndex = 81;
            this.keyboardRadioButton.TabStop = true;
            this.keyboardRadioButton.Text = "Keyboard";
            this.keyboardRadioButton.UseVisualStyleBackColor = true;
            this.keyboardRadioButton.CheckedChanged += new System.EventHandler(this.keyboardRadioButton_CheckedChanged);
            // 
            // controllerRadioButton
            // 
            this.controllerRadioButton.AutoSize = true;
            this.controllerRadioButton.Location = new System.Drawing.Point(131, 295);
            this.controllerRadioButton.Name = "controllerRadioButton";
            this.controllerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.controllerRadioButton.TabIndex = 82;
            this.controllerRadioButton.TabStop = true;
            this.controllerRadioButton.Text = "Controller";
            this.controllerRadioButton.UseVisualStyleBackColor = true;
            this.controllerRadioButton.CheckedChanged += new System.EventHandler(this.controllerRadioButton_CheckedChanged);
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 379);
            this.Controls.Add(this.controllerRadioButton);
            this.Controls.Add(this.keyboardRadioButton);
            this.Controls.Add(this.movementBox);
            this.Controls.Add(this.combatBox);
            this.Controls.Add(this.actionBox);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.closebutton);
            this.Name = "InputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Settings";
            this.actionBox.ResumeLayout(false);
            this.actionBox.PerformLayout();
            this.combatBox.ResumeLayout(false);
            this.combatBox.PerformLayout();
            this.movementBox.ResumeLayout(false);
            this.movementBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label primaryActionLabel;
        private System.Windows.Forms.Label secondaryActionLabel;
        private System.Windows.Forms.TextBox primaryActionBox;
        private System.Windows.Forms.TextBox secondaryActionBox;
        private System.Windows.Forms.TextBox action1Box;
        private System.Windows.Forms.TextBox action6Box;
        private System.Windows.Forms.TextBox action3Box;
        private System.Windows.Forms.TextBox action4Box;
        private System.Windows.Forms.TextBox action2Box;
        private System.Windows.Forms.TextBox action5Box;
        private System.Windows.Forms.Label action1label;
        private System.Windows.Forms.Label action6label;
        private System.Windows.Forms.Label action5label;
        private System.Windows.Forms.Label action4label;
        private System.Windows.Forms.Label action3label;
        private System.Windows.Forms.Label action2label;
        private System.Windows.Forms.TextBox blockBox;
        private System.Windows.Forms.Label blocklabel;
        private System.Windows.Forms.TextBox dodgeBox;
        private System.Windows.Forms.Label dodgelabel;
        private System.Windows.Forms.TextBox jumpBox;
        private System.Windows.Forms.Label jumplabel;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Label interactlabel;
        private System.Windows.Forms.TextBox interactBox;
        private System.Windows.Forms.GroupBox actionBox;
        private System.Windows.Forms.GroupBox combatBox;
        private System.Windows.Forms.TextBox parryBox;
        private System.Windows.Forms.Label parrylabel;
        private System.Windows.Forms.GroupBox movementBox;
        private System.Windows.Forms.TextBox backBox;
        private System.Windows.Forms.Label forwardlabel2;
        private System.Windows.Forms.Label backlabel;
        private System.Windows.Forms.Label rightlabel;
        private System.Windows.Forms.TextBox rightBox;
        private System.Windows.Forms.TextBox forwardBox;
        private System.Windows.Forms.Label leftlabel;
        private System.Windows.Forms.TextBox leftBox;
        private RadioButton keyboardRadioButton;
        private RadioButton controllerRadioButton;
    }
}