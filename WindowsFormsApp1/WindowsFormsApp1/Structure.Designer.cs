
namespace WindowsFormsApp1
{
    partial class Structure
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
            System.Windows.Forms.Label iD_StructureLabel;
            System.Windows.Forms.Label date_StructureLabel;
            System.Windows.Forms.Label time_StructureLabel;
            System.Windows.Forms.Label role_StructureLabel;
            System.Windows.Forms.Label iD_PerformanceLabel1;
            System.Windows.Forms.Label iD_ActorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Structure));
            this.theareDataSet = new WindowsFormsApp1.TheareDataSet();
            this.structurePerformanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.structurePerformanceTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.StructurePerformanceTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager();
            this.structurePerformanceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.structurePerformanceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_StructureTextBox = new System.Windows.Forms.TextBox();
            this.date_StructureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_StructureTextBox = new System.Windows.Forms.TextBox();
            this.role_StructureTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.performancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performancesTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.PerformancesTableAdapter();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.ActorsTableAdapter();
            this.iD_ActorListBox = new System.Windows.Forms.ListBox();
            this.actorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iD_PerformanceListBox = new System.Windows.Forms.ListBox();
            this.performancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iD_StructureLabel = new System.Windows.Forms.Label();
            date_StructureLabel = new System.Windows.Forms.Label();
            time_StructureLabel = new System.Windows.Forms.Label();
            role_StructureLabel = new System.Windows.Forms.Label();
            iD_PerformanceLabel1 = new System.Windows.Forms.Label();
            iD_ActorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structurePerformanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.structurePerformanceBindingNavigator)).BeginInit();
            this.structurePerformanceBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_StructureLabel
            // 
            iD_StructureLabel.AutoSize = true;
            iD_StructureLabel.BackColor = System.Drawing.Color.Transparent;
            iD_StructureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_StructureLabel.Location = new System.Drawing.Point(380, 207);
            iD_StructureLabel.Name = "iD_StructureLabel";
            iD_StructureLabel.Size = new System.Drawing.Size(64, 42);
            iD_StructureLabel.TabIndex = 1;
            iD_StructureLabel.Text = "ID:";
            // 
            // date_StructureLabel
            // 
            date_StructureLabel.AutoSize = true;
            date_StructureLabel.BackColor = System.Drawing.Color.Transparent;
            date_StructureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_StructureLabel.Location = new System.Drawing.Point(328, 262);
            date_StructureLabel.Name = "date_StructureLabel";
            date_StructureLabel.Size = new System.Drawing.Size(116, 42);
            date_StructureLabel.TabIndex = 3;
            date_StructureLabel.Text = "Дата:";
            // 
            // time_StructureLabel
            // 
            time_StructureLabel.AutoSize = true;
            time_StructureLabel.BackColor = System.Drawing.Color.Transparent;
            time_StructureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            time_StructureLabel.Location = new System.Drawing.Point(303, 317);
            time_StructureLabel.Name = "time_StructureLabel";
            time_StructureLabel.Size = new System.Drawing.Size(141, 42);
            time_StructureLabel.TabIndex = 5;
            time_StructureLabel.Text = "Время:";
            // 
            // role_StructureLabel
            // 
            role_StructureLabel.AutoSize = true;
            role_StructureLabel.BackColor = System.Drawing.Color.Transparent;
            role_StructureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            role_StructureLabel.Location = new System.Drawing.Point(330, 372);
            role_StructureLabel.Name = "role_StructureLabel";
            role_StructureLabel.Size = new System.Drawing.Size(114, 42);
            role_StructureLabel.TabIndex = 7;
            role_StructureLabel.Text = "Роль:";
            // 
            // iD_PerformanceLabel1
            // 
            iD_PerformanceLabel1.AutoSize = true;
            iD_PerformanceLabel1.BackColor = System.Drawing.Color.Transparent;
            iD_PerformanceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_PerformanceLabel1.Location = new System.Drawing.Point(57, 427);
            iD_PerformanceLabel1.Name = "iD_PerformanceLabel1";
            iD_PerformanceLabel1.Size = new System.Drawing.Size(387, 42);
            iD_PerformanceLabel1.TabIndex = 19;
            iD_PerformanceLabel1.Text = "Название спектакля:";
            // 
            // iD_ActorLabel
            // 
            iD_ActorLabel.AutoSize = true;
            iD_ActorLabel.BackColor = System.Drawing.Color.Transparent;
            iD_ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ActorLabel.Location = new System.Drawing.Point(199, 478);
            iD_ActorLabel.Name = "iD_ActorLabel";
            iD_ActorLabel.Size = new System.Drawing.Size(245, 42);
            iD_ActorLabel.TabIndex = 20;
            iD_ActorLabel.Text = "ФИО актера:";
            // 
            // theareDataSet
            // 
            this.theareDataSet.DataSetName = "TheareDataSet";
            this.theareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // structurePerformanceBindingSource
            // 
            this.structurePerformanceBindingSource.DataMember = "StructurePerformance";
            this.structurePerformanceBindingSource.DataSource = this.theareDataSet;
            // 
            // structurePerformanceTableAdapter
            // 
            this.structurePerformanceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PerformancesTableAdapter = null;
            this.tableAdapterManager.StructurePerformanceTableAdapter = this.structurePerformanceTableAdapter;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // structurePerformanceBindingNavigator
            // 
            this.structurePerformanceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.structurePerformanceBindingNavigator.BindingSource = this.structurePerformanceBindingSource;
            this.structurePerformanceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.structurePerformanceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.structurePerformanceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.structurePerformanceBindingNavigatorSaveItem});
            this.structurePerformanceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.structurePerformanceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.structurePerformanceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.structurePerformanceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.structurePerformanceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.structurePerformanceBindingNavigator.Name = "structurePerformanceBindingNavigator";
            this.structurePerformanceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.structurePerformanceBindingNavigator.Size = new System.Drawing.Size(1366, 25);
            this.structurePerformanceBindingNavigator.TabIndex = 0;
            this.structurePerformanceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // structurePerformanceBindingNavigatorSaveItem
            // 
            this.structurePerformanceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.structurePerformanceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("structurePerformanceBindingNavigatorSaveItem.Image")));
            this.structurePerformanceBindingNavigatorSaveItem.Name = "structurePerformanceBindingNavigatorSaveItem";
            this.structurePerformanceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.structurePerformanceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.structurePerformanceBindingNavigatorSaveItem.Click += new System.EventHandler(this.structurePerformanceBindingNavigatorSaveItem_Click);
            // 
            // iD_StructureTextBox
            // 
            this.iD_StructureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.structurePerformanceBindingSource, "ID_Structure", true));
            this.iD_StructureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_StructureTextBox.Location = new System.Drawing.Point(450, 207);
            this.iD_StructureTextBox.Name = "iD_StructureTextBox";
            this.iD_StructureTextBox.Size = new System.Drawing.Size(50, 49);
            this.iD_StructureTextBox.TabIndex = 2;
            // 
            // date_StructureDateTimePicker
            // 
            this.date_StructureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.structurePerformanceBindingSource, "Date_Structure", true));
            this.date_StructureDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_StructureDateTimePicker.Location = new System.Drawing.Point(450, 262);
            this.date_StructureDateTimePicker.Name = "date_StructureDateTimePicker";
            this.date_StructureDateTimePicker.Size = new System.Drawing.Size(400, 49);
            this.date_StructureDateTimePicker.TabIndex = 4;
            // 
            // time_StructureTextBox
            // 
            this.time_StructureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.structurePerformanceBindingSource, "Time_Structure", true));
            this.time_StructureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_StructureTextBox.Location = new System.Drawing.Point(450, 317);
            this.time_StructureTextBox.Name = "time_StructureTextBox";
            this.time_StructureTextBox.Size = new System.Drawing.Size(175, 49);
            this.time_StructureTextBox.TabIndex = 6;
            // 
            // role_StructureTextBox
            // 
            this.role_StructureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.structurePerformanceBindingSource, "Role_Structure", true));
            this.role_StructureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_StructureTextBox.Location = new System.Drawing.Point(450, 372);
            this.role_StructureTextBox.Name = "role_StructureTextBox";
            this.role_StructureTextBox.Size = new System.Drawing.Size(150, 49);
            this.role_StructureTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(469, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Состав спектакля";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(169, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(881, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(525, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(927, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 55);
            this.button4.TabIndex = 17;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(927, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 55);
            this.button5.TabIndex = 18;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // performancesBindingSource
            // 
            this.performancesBindingSource.DataMember = "Performances";
            this.performancesBindingSource.DataSource = this.theareDataSet;
            // 
            // performancesTableAdapter
            // 
            this.performancesTableAdapter.ClearBeforeFill = true;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.theareDataSet;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // iD_ActorListBox
            // 
            this.iD_ActorListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.structurePerformanceBindingSource, "ID_Actor", true));
            this.iD_ActorListBox.DataSource = this.actorsBindingSource1;
            this.iD_ActorListBox.DisplayMember = "FIO_Actor";
            this.iD_ActorListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ActorListBox.FormattingEnabled = true;
            this.iD_ActorListBox.ItemHeight = 42;
            this.iD_ActorListBox.Location = new System.Drawing.Point(450, 479);
            this.iD_ActorListBox.Name = "iD_ActorListBox";
            this.iD_ActorListBox.Size = new System.Drawing.Size(550, 46);
            this.iD_ActorListBox.TabIndex = 21;
            this.iD_ActorListBox.ValueMember = "ID_Actor";
            // 
            // actorsBindingSource1
            // 
            this.actorsBindingSource1.DataMember = "Actors";
            this.actorsBindingSource1.DataSource = this.theareDataSet;
            // 
            // iD_PerformanceListBox
            // 
            this.iD_PerformanceListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.structurePerformanceBindingSource, "ID_Performance", true));
            this.iD_PerformanceListBox.DataSource = this.performancesBindingSource1;
            this.iD_PerformanceListBox.DisplayMember = "Name_Performance";
            this.iD_PerformanceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_PerformanceListBox.FormattingEnabled = true;
            this.iD_PerformanceListBox.ItemHeight = 42;
            this.iD_PerformanceListBox.Location = new System.Drawing.Point(450, 427);
            this.iD_PerformanceListBox.Name = "iD_PerformanceListBox";
            this.iD_PerformanceListBox.Size = new System.Drawing.Size(400, 46);
            this.iD_PerformanceListBox.TabIndex = 22;
            this.iD_PerformanceListBox.ValueMember = "ID_Performance";
            // 
            // performancesBindingSource1
            // 
            this.performancesBindingSource1.DataMember = "Performances";
            this.performancesBindingSource1.DataSource = this.theareDataSet;
            // 
            // Structure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.фон2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.iD_PerformanceListBox);
            this.Controls.Add(this.iD_ActorListBox);
            this.Controls.Add(iD_ActorLabel);
            this.Controls.Add(iD_PerformanceLabel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(role_StructureLabel);
            this.Controls.Add(this.role_StructureTextBox);
            this.Controls.Add(time_StructureLabel);
            this.Controls.Add(this.time_StructureTextBox);
            this.Controls.Add(date_StructureLabel);
            this.Controls.Add(this.date_StructureDateTimePicker);
            this.Controls.Add(iD_StructureLabel);
            this.Controls.Add(this.iD_StructureTextBox);
            this.Controls.Add(this.structurePerformanceBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Structure";
            this.Text = "Состав спектакля";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Structure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structurePerformanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.structurePerformanceBindingNavigator)).EndInit();
            this.structurePerformanceBindingNavigator.ResumeLayout(false);
            this.structurePerformanceBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheareDataSet theareDataSet;
        private System.Windows.Forms.BindingSource structurePerformanceBindingSource;
        private TheareDataSetTableAdapters.StructurePerformanceTableAdapter structurePerformanceTableAdapter;
        private TheareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator structurePerformanceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton structurePerformanceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_StructureTextBox;
        private System.Windows.Forms.DateTimePicker date_StructureDateTimePicker;
        private System.Windows.Forms.TextBox time_StructureTextBox;
        private System.Windows.Forms.TextBox role_StructureTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource performancesBindingSource;
        private TheareDataSetTableAdapters.PerformancesTableAdapter performancesTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private TheareDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.ListBox iD_ActorListBox;
        private System.Windows.Forms.ListBox iD_PerformanceListBox;
        private System.Windows.Forms.BindingSource actorsBindingSource1;
        private System.Windows.Forms.BindingSource performancesBindingSource1;
    }
}