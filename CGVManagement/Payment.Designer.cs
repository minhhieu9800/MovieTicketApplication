namespace CGVManagement
{
    partial class Payment
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nameMovieLabel;
            System.Windows.Forms.Label theaterLabel;
            System.Windows.Forms.Label seatLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label timeLabel;
            System.Windows.Forms.Label timeStartedLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label billLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.cGVManagementDataSet2 = new CGVManagement.CGVManagementDataSet2();
            this.tblCGVsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCGVsTableAdapter = new CGVManagement.CGVManagementDataSet2TableAdapters.tblCGVsTableAdapter();
            this.tableAdapterManager = new CGVManagement.CGVManagementDataSet2TableAdapters.TableAdapterManager();
            this.tblCGVsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblCGVsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblCGVsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nameMovieTextBox = new System.Windows.Forms.TextBox();
            this.theaterTextBox = new System.Windows.Forms.TextBox();
            this.seatTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.timeStartedTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            nameMovieLabel = new System.Windows.Forms.Label();
            theaterLabel = new System.Windows.Forms.Label();
            seatLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            timeStartedLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            billLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cGVManagementDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCGVsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCGVsBindingNavigator)).BeginInit();
            this.tblCGVsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCGVsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(16, 33);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // nameMovieLabel
            // 
            nameMovieLabel.AutoSize = true;
            nameMovieLabel.Location = new System.Drawing.Point(16, 59);
            nameMovieLabel.Name = "nameMovieLabel";
            nameMovieLabel.Size = new System.Drawing.Size(68, 13);
            nameMovieLabel.TabIndex = 2;
            nameMovieLabel.Text = "name Movie:";
            // 
            // theaterLabel
            // 
            theaterLabel.AutoSize = true;
            theaterLabel.Location = new System.Drawing.Point(16, 85);
            theaterLabel.Name = "theaterLabel";
            theaterLabel.Size = new System.Drawing.Size(43, 13);
            theaterLabel.TabIndex = 4;
            theaterLabel.Text = "theater:";
            // 
            // seatLabel
            // 
            seatLabel.AutoSize = true;
            seatLabel.Location = new System.Drawing.Point(16, 111);
            seatLabel.Name = "seatLabel";
            seatLabel.Size = new System.Drawing.Size(30, 13);
            seatLabel.TabIndex = 6;
            seatLabel.Text = "seat:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(16, 138);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(31, 13);
            dateLabel.TabIndex = 8;
            dateLabel.Text = "date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(16, 163);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(29, 13);
            timeLabel.TabIndex = 10;
            timeLabel.Text = "time:";
            // 
            // timeStartedLabel
            // 
            timeStartedLabel.AutoSize = true;
            timeStartedLabel.Location = new System.Drawing.Point(16, 189);
            timeStartedLabel.Name = "timeStartedLabel";
            timeStartedLabel.Size = new System.Drawing.Size(66, 13);
            timeStartedLabel.TabIndex = 12;
            timeStartedLabel.Text = "time Started:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(16, 215);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "address:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(16, 241);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(80, 13);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "phone Number:";
            // 
            // billLabel
            // 
            billLabel.AutoSize = true;
            billLabel.Location = new System.Drawing.Point(15, 267);
            billLabel.Name = "billLabel";
            billLabel.Size = new System.Drawing.Size(22, 13);
            billLabel.TabIndex = 25;
            billLabel.Text = "bill:";
            // 
            // cGVManagementDataSet2
            // 
            this.cGVManagementDataSet2.DataSetName = "CGVManagementDataSet2";
            this.cGVManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCGVsBindingSource
            // 
            this.tblCGVsBindingSource.DataMember = "tblCGVs";
            this.tblCGVsBindingSource.DataSource = this.cGVManagementDataSet2;
            // 
            // tblCGVsTableAdapter
            // 
            this.tblCGVsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCGVsTableAdapter = this.tblCGVsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CGVManagement.CGVManagementDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCGVsBindingNavigator
            // 
            this.tblCGVsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblCGVsBindingNavigator.BindingSource = this.tblCGVsBindingSource;
            this.tblCGVsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblCGVsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblCGVsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblCGVsBindingNavigatorSaveItem});
            this.tblCGVsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblCGVsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblCGVsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblCGVsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblCGVsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblCGVsBindingNavigator.Name = "tblCGVsBindingNavigator";
            this.tblCGVsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblCGVsBindingNavigator.Size = new System.Drawing.Size(1372, 25);
            this.tblCGVsBindingNavigator.TabIndex = 0;
            this.tblCGVsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tblCGVsBindingNavigatorSaveItem
            // 
            this.tblCGVsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblCGVsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblCGVsBindingNavigatorSaveItem.Image")));
            this.tblCGVsBindingNavigatorSaveItem.Name = "tblCGVsBindingNavigatorSaveItem";
            this.tblCGVsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblCGVsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblCGVsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblCGVsBindingNavigatorSaveItem_Click);
            // 
            // tblCGVsDataGridView
            // 
            this.tblCGVsDataGridView.AutoGenerateColumns = false;
            this.tblCGVsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCGVsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tblCGVsDataGridView.DataSource = this.tblCGVsBindingSource;
            this.tblCGVsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.tblCGVsDataGridView.Name = "tblCGVsDataGridView";
            this.tblCGVsDataGridView.Size = new System.Drawing.Size(1041, 410);
            this.tblCGVsDataGridView.TabIndex = 1;
            this.tblCGVsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblCGVsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nameMovie";
            this.dataGridViewTextBoxColumn2.HeaderText = "nameMovie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "theater";
            this.dataGridViewTextBoxColumn3.HeaderText = "theater";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "seat";
            this.dataGridViewTextBoxColumn4.HeaderText = "seat";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn6.HeaderText = "time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "timeStarted";
            this.dataGridViewTextBoxColumn7.HeaderText = "timeStarted";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn8.HeaderText = "address";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "phoneNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "phoneNumber";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "bill";
            this.dataGridViewTextBoxColumn10.HeaderText = "bill";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(billLabel);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.billTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(iDLabel);
            this.groupBox1.Controls.Add(this.iDTextBox);
            this.groupBox1.Controls.Add(nameMovieLabel);
            this.groupBox1.Controls.Add(this.nameMovieTextBox);
            this.groupBox1.Controls.Add(theaterLabel);
            this.groupBox1.Controls.Add(this.theaterTextBox);
            this.groupBox1.Controls.Add(seatLabel);
            this.groupBox1.Controls.Add(this.seatTextBox);
            this.groupBox1.Controls.Add(dateLabel);
            this.groupBox1.Controls.Add(this.dateDateTimePicker);
            this.groupBox1.Controls.Add(timeLabel);
            this.groupBox1.Controls.Add(this.timeTextBox);
            this.groupBox1.Controls.Add(timeStartedLabel);
            this.groupBox1.Controls.Add(this.timeStartedTextBox);
            this.groupBox1.Controls.Add(addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(phoneNumberLabel);
            this.groupBox1.Controls.Add(this.phoneNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1047, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 412);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(230, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "PrintBill";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // billTextBox
            // 
            this.billTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "bill", true));
            this.billTextBox.Location = new System.Drawing.Point(102, 264);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(200, 20);
            this.billTextBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bill:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(203, 291);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Normal";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 291);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Student";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(102, 30);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 1;
            // 
            // nameMovieTextBox
            // 
            this.nameMovieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "nameMovie", true));
            this.nameMovieTextBox.Location = new System.Drawing.Point(102, 56);
            this.nameMovieTextBox.Name = "nameMovieTextBox";
            this.nameMovieTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameMovieTextBox.TabIndex = 3;
            // 
            // theaterTextBox
            // 
            this.theaterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "theater", true));
            this.theaterTextBox.Location = new System.Drawing.Point(102, 82);
            this.theaterTextBox.Name = "theaterTextBox";
            this.theaterTextBox.Size = new System.Drawing.Size(200, 20);
            this.theaterTextBox.TabIndex = 5;
            // 
            // seatTextBox
            // 
            this.seatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "seat", true));
            this.seatTextBox.Location = new System.Drawing.Point(102, 108);
            this.seatTextBox.Name = "seatTextBox";
            this.seatTextBox.Size = new System.Drawing.Size(200, 20);
            this.seatTextBox.TabIndex = 7;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCGVsBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(102, 134);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 9;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "time", true));
            this.timeTextBox.Location = new System.Drawing.Point(102, 160);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(200, 20);
            this.timeTextBox.TabIndex = 11;
            // 
            // timeStartedTextBox
            // 
            this.timeStartedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "timeStarted", true));
            this.timeStartedTextBox.Location = new System.Drawing.Point(102, 186);
            this.timeStartedTextBox.Name = "timeStartedTextBox";
            this.timeStartedTextBox.Size = new System.Drawing.Size(200, 20);
            this.timeStartedTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(102, 212);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 15;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCGVsBindingSource, "phoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(102, 238);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneNumberTextBox.TabIndex = 17;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tblCGVsDataGridView);
            this.Controls.Add(this.tblCGVsBindingNavigator);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cGVManagementDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCGVsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCGVsBindingNavigator)).EndInit();
            this.tblCGVsBindingNavigator.ResumeLayout(false);
            this.tblCGVsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCGVsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CGVManagementDataSet2 cGVManagementDataSet2;
        private System.Windows.Forms.BindingSource tblCGVsBindingSource;
        private CGVManagementDataSet2TableAdapters.tblCGVsTableAdapter tblCGVsTableAdapter;
        private CGVManagementDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblCGVsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tblCGVsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tblCGVsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nameMovieTextBox;
        private System.Windows.Forms.TextBox theaterTextBox;
        private System.Windows.Forms.TextBox seatTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox timeStartedTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox billTextBox;
    }
}