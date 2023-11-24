namespace mtemu
{
    partial class CallsForm
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
            if (disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallsForm));
            this.callList = new System.Windows.Forms.ListView();
            this.columnAddr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameCommand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperand1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOperand2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listLabel = new System.Windows.Forms.Label();
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAddCall = new System.Windows.Forms.Button();
            this.buttonDeleteCall = new System.Windows.Forms.Button();
            this.buttonSaveCall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCall = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCodeCall = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNameCall = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditCommand = new System.Windows.Forms.Button();
            this.buttonDeleteCommand = new System.Windows.Forms.Button();
            this.buttonCreateCommand = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.columnCallFunction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCodeFunction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNameFunction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOperand2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOperand1 = new System.Windows.Forms.TextBox();
            this.cc1TextLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.textBoxNameCommand = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.currentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // callList
            // 
            this.callList.AutoArrange = false;
            this.callList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.callList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAddr,
            this.columnNameCommand,
            this.columnOperand1,
            this.columnOperand2});
            this.callList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callList.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.callList.FullRowSelect = true;
            this.callList.GridLines = true;
            this.callList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.callList.HideSelection = false;
            this.callList.Location = new System.Drawing.Point(14, 56);
            this.callList.Margin = new System.Windows.Forms.Padding(4);
            this.callList.MultiSelect = false;
            this.callList.Name = "callList";
            this.callList.Size = new System.Drawing.Size(550, 550);
            this.callList.TabIndex = 1;
            this.callList.TabStop = false;
            this.callList.UseCompatibleStateImageBehavior = false;
            this.callList.View = System.Windows.Forms.View.Details;
            // 
            // columnAddr
            // 
            this.columnAddr.Text = "Адрес";
            this.columnAddr.Width = 80;
            // 
            // columnNameCommand
            // 
            this.columnNameCommand.Text = "Команда";
            this.columnNameCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNameCommand.Width = 100;
            // 
            // columnOperand1
            // 
            this.columnOperand1.Text = "Операнд 1";
            this.columnOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOperand1.Width = 100;
            // 
            // columnOperand2
            // 
            this.columnOperand2.Text = "Операнд 2";
            this.columnOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnOperand2.Width = 100;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.listLabel.Location = new System.Drawing.Point(129, 14);
            this.listLabel.Margin = new System.Windows.Forms.Padding(4);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(300, 33);
            this.listLabel.TabIndex = 3;
            this.listLabel.Text = "Программный уровень";
            // 
            // buttonAddCall
            // 
            this.buttonAddCall.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonAddCall.Location = new System.Drawing.Point(155, 35);
            this.buttonAddCall.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAddCall.Name = "buttonAddCall";
            this.buttonAddCall.Size = new System.Drawing.Size(118, 36);
            this.buttonAddCall.TabIndex = 11;
            this.buttonAddCall.Text = "Добавить";
            this.formToolTip.SetToolTip(this.buttonAddCall, "Ctrl + Enter");
            this.buttonAddCall.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCall
            // 
            this.buttonDeleteCall.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonDeleteCall.Location = new System.Drawing.Point(25, 35);
            this.buttonDeleteCall.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDeleteCall.Name = "buttonDeleteCall";
            this.buttonDeleteCall.Size = new System.Drawing.Size(118, 36);
            this.buttonDeleteCall.TabIndex = 0;
            this.buttonDeleteCall.TabStop = false;
            this.buttonDeleteCall.Text = "Удалить";
            this.formToolTip.SetToolTip(this.buttonDeleteCall, "Ctrl + Del");
            this.buttonDeleteCall.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCall
            // 
            this.buttonSaveCall.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonSaveCall.Location = new System.Drawing.Point(285, 35);
            this.buttonSaveCall.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSaveCall.Name = "buttonSaveCall";
            this.buttonSaveCall.Size = new System.Drawing.Size(118, 36);
            this.buttonSaveCall.TabIndex = 12;
            this.buttonSaveCall.Text = "Сохранить";
            this.formToolTip.SetToolTip(this.buttonSaveCall, "Enter");
            this.buttonSaveCall.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxCall);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxCodeCall);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.textBoxNameCall);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.buttonEditCommand);
            this.panel2.Controls.Add(this.buttonDeleteCommand);
            this.panel2.Controls.Add(this.buttonCreateCommand);
            this.panel2.Location = new System.Drawing.Point(920, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 421);
            this.panel2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 10F);
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Адрес вызова";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCall
            // 
            this.textBoxCall.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxCall.Location = new System.Drawing.Point(3, 211);
            this.textBoxCall.Margin = new System.Windows.Forms.Padding(6, 3, 0, 6);
            this.textBoxCall.MaxLength = 8;
            this.textBoxCall.Name = "textBoxCall";
            this.textBoxCall.Size = new System.Drawing.Size(172, 31);
            this.textBoxCall.TabIndex = 22;
            this.textBoxCall.Text = "00000000";
            this.textBoxCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCall.WordWrap = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Consolas", 10F);
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Код";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCodeCall
            // 
            this.textBoxCodeCall.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxCodeCall.Location = new System.Drawing.Point(6, 139);
            this.textBoxCodeCall.Margin = new System.Windows.Forms.Padding(6, 3, 0, 6);
            this.textBoxCodeCall.MaxLength = 8;
            this.textBoxCodeCall.Name = "textBoxCodeCall";
            this.textBoxCodeCall.Size = new System.Drawing.Size(172, 31);
            this.textBoxCodeCall.TabIndex = 20;
            this.textBoxCodeCall.Text = "00000000";
            this.textBoxCodeCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCodeCall.WordWrap = false;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Consolas", 10F);
            this.labelName.Location = new System.Drawing.Point(4, 40);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(172, 22);
            this.labelName.TabIndex = 18;
            this.labelName.Text = "Функция";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameCall
            // 
            this.textBoxNameCall.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxNameCall.Location = new System.Drawing.Point(4, 68);
            this.textBoxNameCall.Margin = new System.Windows.Forms.Padding(6, 3, 0, 6);
            this.textBoxNameCall.MaxLength = 8;
            this.textBoxNameCall.Name = "textBoxNameCall";
            this.textBoxNameCall.Size = new System.Drawing.Size(172, 31);
            this.textBoxNameCall.TabIndex = 18;
            this.textBoxNameCall.Text = "00000000";
            this.textBoxNameCall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameCall.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Новая команда";
            // 
            // buttonEditCommand
            // 
            this.buttonEditCommand.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonEditCommand.Location = new System.Drawing.Point(4, 317);
            this.buttonEditCommand.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditCommand.Name = "buttonEditCommand";
            this.buttonEditCommand.Size = new System.Drawing.Size(171, 46);
            this.buttonEditCommand.TabIndex = 6;
            this.buttonEditCommand.TabStop = false;
            this.buttonEditCommand.Text = "Редактировать";
            this.buttonEditCommand.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCommand
            // 
            this.buttonDeleteCommand.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonDeleteCommand.Location = new System.Drawing.Point(4, 371);
            this.buttonDeleteCommand.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteCommand.Name = "buttonDeleteCommand";
            this.buttonDeleteCommand.Size = new System.Drawing.Size(172, 46);
            this.buttonDeleteCommand.TabIndex = 5;
            this.buttonDeleteCommand.TabStop = false;
            this.buttonDeleteCommand.Text = "Удалить";
            this.buttonDeleteCommand.UseVisualStyleBackColor = true;
            // 
            // buttonCreateCommand
            // 
            this.buttonCreateCommand.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonCreateCommand.Location = new System.Drawing.Point(4, 263);
            this.buttonCreateCommand.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateCommand.Name = "buttonCreateCommand";
            this.buttonCreateCommand.Size = new System.Drawing.Size(171, 46);
            this.buttonCreateCommand.TabIndex = 4;
            this.buttonCreateCommand.TabStop = false;
            this.buttonCreateCommand.Text = "Создать";
            this.buttonCreateCommand.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.listViewCommand);
            this.panel3.Location = new System.Drawing.Point(569, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 600);
            this.panel3.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Пул команд:";
            // 
            // listViewCommand
            // 
            this.listViewCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCallFunction,
            this.columnCodeFunction,
            this.columnNameFunction});
            this.listViewCommand.FullRowSelect = true;
            this.listViewCommand.GridLines = true;
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(3, 39);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(339, 550);
            this.listViewCommand.TabIndex = 0;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            this.listViewCommand.View = System.Windows.Forms.View.Details;
            // 
            // columnCallFunction
            // 
            this.columnCallFunction.Text = "Вызов";
            // 
            // columnCodeFunction
            // 
            this.columnCodeFunction.Text = "Код";
            this.columnCodeFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnNameFunction
            // 
            this.columnNameFunction.Text = "Функция";
            this.columnNameFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnNameFunction.Width = 100;
            // 
            // buttonAuto
            // 
            this.buttonAuto.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonAuto.Location = new System.Drawing.Point(10, 94);
            this.buttonAuto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(165, 46);
            this.buttonAuto.TabIndex = 4;
            this.buttonAuto.TabStop = false;
            this.buttonAuto.Text = "Авто";
            this.buttonAuto.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonReset.Location = new System.Drawing.Point(9, 40);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(166, 46);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.TabStop = false;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonStep
            // 
            this.buttonStep.Font = new System.Drawing.Font("Consolas", 9F);
            this.buttonStep.Location = new System.Drawing.Point(9, 148);
            this.buttonStep.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(166, 46);
            this.buttonStep.TabIndex = 3;
            this.buttonStep.TabStop = false;
            this.buttonStep.Text = "Шаг";
            this.buttonStep.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Отладка";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStep);
            this.panel1.Controls.Add(this.buttonReset);
            this.panel1.Controls.Add(this.buttonAuto);
            this.panel1.Location = new System.Drawing.Point(920, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 204);
            this.panel1.TabIndex = 15;
            // 
            // currentPanel
            // 
            this.currentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPanel.Controls.Add(this.label3);
            this.currentPanel.Controls.Add(this.textBoxOperand2);
            this.currentPanel.Controls.Add(this.label2);
            this.currentPanel.Controls.Add(this.textBoxOperand1);
            this.currentPanel.Controls.Add(this.cc1TextLabel);
            this.currentPanel.Controls.Add(this.buttonAddCall);
            this.currentPanel.Controls.Add(this.currentLabel);
            this.currentPanel.Controls.Add(this.buttonDeleteCall);
            this.currentPanel.Controls.Add(this.buttonSaveCall);
            this.currentPanel.Controls.Add(this.textBoxNameCommand);
            this.currentPanel.Location = new System.Drawing.Point(14, 614);
            this.currentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.Padding = new System.Windows.Forms.Padding(9);
            this.currentPanel.Size = new System.Drawing.Size(897, 81);
            this.currentPanel.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 10F);
            this.label3.Location = new System.Drawing.Point(766, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOperand2
            // 
            this.textBoxOperand2.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxOperand2.Location = new System.Drawing.Point(766, 39);
            this.textBoxOperand2.Margin = new System.Windows.Forms.Padding(6, 3, 0, 6);
            this.textBoxOperand2.MaxLength = 8;
            this.textBoxOperand2.Name = "textBoxOperand2";
            this.textBoxOperand2.Size = new System.Drawing.Size(114, 31);
            this.textBoxOperand2.TabIndex = 16;
            this.textBoxOperand2.Text = "00000000";
            this.textBoxOperand2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOperand2.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 10F);
            this.label2.Location = new System.Drawing.Point(643, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOperand1
            // 
            this.textBoxOperand1.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxOperand1.Location = new System.Drawing.Point(643, 39);
            this.textBoxOperand1.Margin = new System.Windows.Forms.Padding(6, 3, 0, 6);
            this.textBoxOperand1.MaxLength = 8;
            this.textBoxOperand1.Name = "textBoxOperand1";
            this.textBoxOperand1.Size = new System.Drawing.Size(114, 31);
            this.textBoxOperand1.TabIndex = 14;
            this.textBoxOperand1.Text = "00000000";
            this.textBoxOperand1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOperand1.WordWrap = false;
            // 
            // cc1TextLabel
            // 
            this.cc1TextLabel.Font = new System.Drawing.Font("Consolas", 10F);
            this.cc1TextLabel.Location = new System.Drawing.Point(521, 6);
            this.cc1TextLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 3);
            this.cc1TextLabel.Name = "cc1TextLabel";
            this.cc1TextLabel.Size = new System.Drawing.Size(114, 22);
            this.cc1TextLabel.TabIndex = 13;
            this.cc1TextLabel.Text = "Type";
            this.cc1TextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.currentLabel.Location = new System.Drawing.Point(0, 1);
            this.currentLabel.Margin = new System.Windows.Forms.Padding(6);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentLabel.Size = new System.Drawing.Size(240, 32);
            this.currentLabel.TabIndex = 0;
            this.currentLabel.Text = "Редактирование";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameCommand
            // 
            this.textBoxNameCommand.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxNameCommand.Location = new System.Drawing.Point(521, 39);
            this.textBoxNameCommand.Margin = new System.Windows.Forms.Padding(6, 3, 0, 6);
            this.textBoxNameCommand.MaxLength = 8;
            this.textBoxNameCommand.Name = "textBoxNameCommand";
            this.textBoxNameCommand.Size = new System.Drawing.Size(114, 31);
            this.textBoxNameCommand.TabIndex = 10;
            this.textBoxNameCommand.Text = "00000000";
            this.textBoxNameCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNameCommand.WordWrap = false;
            // 
            // CallsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1152, 705);
            this.Controls.Add(this.currentPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listLabel);
            this.Controls.Add(this.callList);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CallsForm";
            this.Text = "Программный уровень";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CallsFormClosing_);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.currentPanel.ResumeLayout(false);
            this.currentPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label listLabel;
        public System.Windows.Forms.ListView callList;
        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonEditCommand;
        private System.Windows.Forms.Button buttonDeleteCommand;
        private System.Windows.Forms.Button buttonCreateCommand;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listViewCommand;
        private System.Windows.Forms.ColumnHeader columnCallFunction;
        private System.Windows.Forms.ColumnHeader columnCodeFunction;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel currentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOperand2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOperand1;
        private System.Windows.Forms.Label cc1TextLabel;
        private System.Windows.Forms.Button buttonAddCall;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Button buttonDeleteCall;
        private System.Windows.Forms.Button buttonSaveCall;
        private System.Windows.Forms.TextBox textBoxNameCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnAddr;
        private System.Windows.Forms.ColumnHeader columnNameCommand;
        private System.Windows.Forms.ColumnHeader columnOperand1;
        private System.Windows.Forms.ColumnHeader columnOperand2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCodeCall;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxNameCall;
        private System.Windows.Forms.ColumnHeader columnNameFunction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCall;
    }
}
