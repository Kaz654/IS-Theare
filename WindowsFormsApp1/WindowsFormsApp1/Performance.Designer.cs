
namespace WindowsFormsApp1
{
    partial class Performance
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
            System.Windows.Forms.Label iD_PerformanceLabel;
            System.Windows.Forms.Label name_PerformanceLabel;
            System.Windows.Forms.Label regisser_PerformanceLabel;
            System.Windows.Forms.Label annotation_PerformanceLabel;
            System.Windows.Forms.Label date_PerformanceLabel;
            System.Windows.Forms.Label time_PerformanceLabel;
            System.Windows.Forms.Label genre_PerformanceLabel;
            System.Windows.Forms.Label type_PerformanceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Performance));
            this.theareDataSet = new WindowsFormsApp1.TheareDataSet();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.ActorsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager();
            this.performancesTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.PerformancesTableAdapter();
            this.actorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.performancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.actorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.name_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.regisser_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.annotation_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.date_PerformanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.time_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.genre_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.type_PerformanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            iD_PerformanceLabel = new System.Windows.Forms.Label();
            name_PerformanceLabel = new System.Windows.Forms.Label();
            regisser_PerformanceLabel = new System.Windows.Forms.Label();
            annotation_PerformanceLabel = new System.Windows.Forms.Label();
            date_PerformanceLabel = new System.Windows.Forms.Label();
            time_PerformanceLabel = new System.Windows.Forms.Label();
            genre_PerformanceLabel = new System.Windows.Forms.Label();
            type_PerformanceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingNavigator)).BeginInit();
            this.actorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_PerformanceLabel
            // 
            iD_PerformanceLabel.AutoSize = true;
            iD_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            iD_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_PerformanceLabel.Location = new System.Drawing.Point(227, 170);
            iD_PerformanceLabel.Name = "iD_PerformanceLabel";
            iD_PerformanceLabel.Size = new System.Drawing.Size(64, 42);
            iD_PerformanceLabel.TabIndex = 1;
            iD_PerformanceLabel.Text = "ID:";
            // 
            // name_PerformanceLabel
            // 
            name_PerformanceLabel.AutoSize = true;
            name_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            name_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            name_PerformanceLabel.Location = new System.Drawing.Point(92, 225);
            name_PerformanceLabel.Name = "name_PerformanceLabel";
            name_PerformanceLabel.Size = new System.Drawing.Size(199, 42);
            name_PerformanceLabel.TabIndex = 3;
            name_PerformanceLabel.Text = "Название:";
            // 
            // regisser_PerformanceLabel
            // 
            regisser_PerformanceLabel.AutoSize = true;
            regisser_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            regisser_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            regisser_PerformanceLabel.Location = new System.Drawing.Point(109, 280);
            regisser_PerformanceLabel.Name = "regisser_PerformanceLabel";
            regisser_PerformanceLabel.Size = new System.Drawing.Size(182, 42);
            regisser_PerformanceLabel.TabIndex = 5;
            regisser_PerformanceLabel.Text = "Режисер:";
            // 
            // annotation_PerformanceLabel
            // 
            annotation_PerformanceLabel.AutoSize = true;
            annotation_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            annotation_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            annotation_PerformanceLabel.Location = new System.Drawing.Point(96, 335);
            annotation_PerformanceLabel.Name = "annotation_PerformanceLabel";
            annotation_PerformanceLabel.Size = new System.Drawing.Size(195, 42);
            annotation_PerformanceLabel.TabIndex = 7;
            annotation_PerformanceLabel.Text = "Анотация:";
            // 
            // date_PerformanceLabel
            // 
            date_PerformanceLabel.AutoSize = true;
            date_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            date_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            date_PerformanceLabel.Location = new System.Drawing.Point(175, 441);
            date_PerformanceLabel.Name = "date_PerformanceLabel";
            date_PerformanceLabel.Size = new System.Drawing.Size(116, 42);
            date_PerformanceLabel.TabIndex = 9;
            date_PerformanceLabel.Text = "Дата:";
            // 
            // time_PerformanceLabel
            // 
            time_PerformanceLabel.AutoSize = true;
            time_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            time_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            time_PerformanceLabel.Location = new System.Drawing.Point(150, 496);
            time_PerformanceLabel.Name = "time_PerformanceLabel";
            time_PerformanceLabel.Size = new System.Drawing.Size(141, 42);
            time_PerformanceLabel.TabIndex = 11;
            time_PerformanceLabel.Text = "Время:";
            // 
            // genre_PerformanceLabel
            // 
            genre_PerformanceLabel.AutoSize = true;
            genre_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            genre_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genre_PerformanceLabel.Location = new System.Drawing.Point(167, 551);
            genre_PerformanceLabel.Name = "genre_PerformanceLabel";
            genre_PerformanceLabel.Size = new System.Drawing.Size(124, 42);
            genre_PerformanceLabel.TabIndex = 13;
            genre_PerformanceLabel.Text = "Жанр:";
            // 
            // type_PerformanceLabel
            // 
            type_PerformanceLabel.AutoSize = true;
            type_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            type_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            type_PerformanceLabel.Location = new System.Drawing.Point(198, 606);
            type_PerformanceLabel.Name = "type_PerformanceLabel";
            type_PerformanceLabel.Size = new System.Drawing.Size(93, 42);
            type_PerformanceLabel.TabIndex = 15;
            type_PerformanceLabel.Text = "Тип:";
            // 
            // theareDataSet
            // 
            this.theareDataSet.DataSetName = "TheareDataSet";
            this.theareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = this.actorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PerformancesTableAdapter = this.performancesTableAdapter;
            this.tableAdapterManager.StructurePerformanceTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // performancesTableAdapter
            // 
            this.performancesTableAdapter.ClearBeforeFill = true;
            // 
            // actorsBindingNavigator
            // 
            this.actorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actorsBindingNavigator.BindingSource = this.performancesBindingSource;
            this.actorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actorsBindingNavigatorSaveItem});
            this.actorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actorsBindingNavigator.Name = "actorsBindingNavigator";
            this.actorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actorsBindingNavigator.Size = new System.Drawing.Size(1366, 25);
            this.actorsBindingNavigator.TabIndex = 0;
            this.actorsBindingNavigator.Text = "bindingNavigator1";
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
            // performancesBindingSource
            // 
            this.performancesBindingSource.DataMember = "Performances";
            this.performancesBindingSource.DataSource = this.theareDataSet;
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // actorsBindingNavigatorSaveItem
            // 
            this.actorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actorsBindingNavigatorSaveItem.Image")));
            this.actorsBindingNavigatorSaveItem.Name = "actorsBindingNavigatorSaveItem";
            this.actorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.actorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.actorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.actorsBindingNavigatorSaveItem_Click);
            // 
            // iD_PerformanceTextBox
            // 
            this.iD_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "ID_Performance", true));
            this.iD_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_PerformanceTextBox.Location = new System.Drawing.Point(297, 170);
            this.iD_PerformanceTextBox.Name = "iD_PerformanceTextBox";
            this.iD_PerformanceTextBox.Size = new System.Drawing.Size(50, 49);
            this.iD_PerformanceTextBox.TabIndex = 2;
            // 
            // name_PerformanceTextBox
            // 
            this.name_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Name_Performance", true));
            this.name_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_PerformanceTextBox.Location = new System.Drawing.Point(297, 225);
            this.name_PerformanceTextBox.Name = "name_PerformanceTextBox";
            this.name_PerformanceTextBox.Size = new System.Drawing.Size(400, 49);
            this.name_PerformanceTextBox.TabIndex = 4;
            // 
            // regisser_PerformanceTextBox
            // 
            this.regisser_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Regisser_Performance", true));
            this.regisser_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regisser_PerformanceTextBox.Location = new System.Drawing.Point(297, 280);
            this.regisser_PerformanceTextBox.Name = "regisser_PerformanceTextBox";
            this.regisser_PerformanceTextBox.Size = new System.Drawing.Size(500, 49);
            this.regisser_PerformanceTextBox.TabIndex = 6;
            // 
            // annotation_PerformanceTextBox
            // 
            this.annotation_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Annotation_Performance", true));
            this.annotation_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.annotation_PerformanceTextBox.Location = new System.Drawing.Point(297, 335);
            this.annotation_PerformanceTextBox.Multiline = true;
            this.annotation_PerformanceTextBox.Name = "annotation_PerformanceTextBox";
            this.annotation_PerformanceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.annotation_PerformanceTextBox.Size = new System.Drawing.Size(500, 100);
            this.annotation_PerformanceTextBox.TabIndex = 8;
            // 
            // date_PerformanceDateTimePicker
            // 
            this.date_PerformanceDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.performancesBindingSource, "Date_Performance", true));
            this.date_PerformanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_PerformanceDateTimePicker.Location = new System.Drawing.Point(297, 441);
            this.date_PerformanceDateTimePicker.Name = "date_PerformanceDateTimePicker";
            this.date_PerformanceDateTimePicker.Size = new System.Drawing.Size(400, 49);
            this.date_PerformanceDateTimePicker.TabIndex = 10;
            // 
            // time_PerformanceTextBox
            // 
            this.time_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Time_Performance", true));
            this.time_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_PerformanceTextBox.Location = new System.Drawing.Point(297, 496);
            this.time_PerformanceTextBox.Name = "time_PerformanceTextBox";
            this.time_PerformanceTextBox.Size = new System.Drawing.Size(200, 49);
            this.time_PerformanceTextBox.TabIndex = 12;
            // 
            // genre_PerformanceTextBox
            // 
            this.genre_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Genre_Performance", true));
            this.genre_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre_PerformanceTextBox.Location = new System.Drawing.Point(297, 551);
            this.genre_PerformanceTextBox.Name = "genre_PerformanceTextBox";
            this.genre_PerformanceTextBox.Size = new System.Drawing.Size(300, 49);
            this.genre_PerformanceTextBox.TabIndex = 14;
            // 
            // type_PerformanceTextBox
            // 
            this.type_PerformanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.performancesBindingSource, "Type_Performance", true));
            this.type_PerformanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_PerformanceTextBox.Location = new System.Drawing.Point(297, 606);
            this.type_PerformanceTextBox.Name = "type_PerformanceTextBox";
            this.type_PerformanceTextBox.Size = new System.Drawing.Size(200, 49);
            this.type_PerformanceTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(507, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 55);
            this.label1.TabIndex = 17;
            this.label1.Text = "Спектакли";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(903, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 55);
            this.button1.TabIndex = 18;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(903, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 55);
            this.button2.TabIndex = 19;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(903, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 55);
            this.button3.TabIndex = 20;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(903, 496);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 50);
            this.button4.TabIndex = 21;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(903, 602);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 50);
            this.button5.TabIndex = 22;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.фон2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(type_PerformanceLabel);
            this.Controls.Add(this.type_PerformanceTextBox);
            this.Controls.Add(genre_PerformanceLabel);
            this.Controls.Add(this.genre_PerformanceTextBox);
            this.Controls.Add(time_PerformanceLabel);
            this.Controls.Add(this.time_PerformanceTextBox);
            this.Controls.Add(date_PerformanceLabel);
            this.Controls.Add(this.date_PerformanceDateTimePicker);
            this.Controls.Add(annotation_PerformanceLabel);
            this.Controls.Add(this.annotation_PerformanceTextBox);
            this.Controls.Add(regisser_PerformanceLabel);
            this.Controls.Add(this.regisser_PerformanceTextBox);
            this.Controls.Add(name_PerformanceLabel);
            this.Controls.Add(this.name_PerformanceTextBox);
            this.Controls.Add(iD_PerformanceLabel);
            this.Controls.Add(this.iD_PerformanceTextBox);
            this.Controls.Add(this.actorsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Performance";
            this.Text = "Спектакли";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Performance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingNavigator)).EndInit();
            this.actorsBindingNavigator.ResumeLayout(false);
            this.actorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheareDataSet theareDataSet;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private TheareDataSetTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private TheareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actorsBindingNavigatorSaveItem;
        private TheareDataSetTableAdapters.PerformancesTableAdapter performancesTableAdapter;
        private System.Windows.Forms.BindingSource performancesBindingSource;
        private System.Windows.Forms.TextBox iD_PerformanceTextBox;
        private System.Windows.Forms.TextBox name_PerformanceTextBox;
        private System.Windows.Forms.TextBox regisser_PerformanceTextBox;
        private System.Windows.Forms.TextBox annotation_PerformanceTextBox;
        private System.Windows.Forms.DateTimePicker date_PerformanceDateTimePicker;
        private System.Windows.Forms.TextBox time_PerformanceTextBox;
        private System.Windows.Forms.TextBox genre_PerformanceTextBox;
        private System.Windows.Forms.TextBox type_PerformanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}