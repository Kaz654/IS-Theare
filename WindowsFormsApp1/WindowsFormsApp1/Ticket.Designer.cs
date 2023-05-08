
namespace WindowsFormsApp1
{
    partial class Ticket
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
            System.Windows.Forms.Label iD_TicketLabel;
            System.Windows.Forms.Label price_TicketLabel;
            System.Windows.Forms.Label iD_PerformanceLabel;
            System.Windows.Forms.Label place_TicketLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.theareDataSet = new WindowsFormsApp1.TheareDataSet();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.TicketsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager();
            this.ticketsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ticketsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_TicketTextBox = new System.Windows.Forms.TextBox();
            this.price_TicketTextBox = new System.Windows.Forms.TextBox();
            this.place_TicketTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.performancesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.performancesTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.PerformancesTableAdapter();
            this.iD_PerformanceListBox = new System.Windows.Forms.ListBox();
            this.performancesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            iD_TicketLabel = new System.Windows.Forms.Label();
            price_TicketLabel = new System.Windows.Forms.Label();
            iD_PerformanceLabel = new System.Windows.Forms.Label();
            place_TicketLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).BeginInit();
            this.ticketsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_TicketLabel
            // 
            iD_TicketLabel.AutoSize = true;
            iD_TicketLabel.BackColor = System.Drawing.Color.Transparent;
            iD_TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_TicketLabel.Location = new System.Drawing.Point(456, 241);
            iD_TicketLabel.Name = "iD_TicketLabel";
            iD_TicketLabel.Size = new System.Drawing.Size(64, 42);
            iD_TicketLabel.TabIndex = 1;
            iD_TicketLabel.Text = "ID:";
            // 
            // price_TicketLabel
            // 
            price_TicketLabel.AutoSize = true;
            price_TicketLabel.BackColor = System.Drawing.Color.Transparent;
            price_TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            price_TicketLabel.Location = new System.Drawing.Point(401, 351);
            price_TicketLabel.Name = "price_TicketLabel";
            price_TicketLabel.Size = new System.Drawing.Size(119, 42);
            price_TicketLabel.TabIndex = 3;
            price_TicketLabel.Text = "Цена:";
            // 
            // iD_PerformanceLabel
            // 
            iD_PerformanceLabel.AutoSize = true;
            iD_PerformanceLabel.BackColor = System.Drawing.Color.Transparent;
            iD_PerformanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_PerformanceLabel.Location = new System.Drawing.Point(133, 406);
            iD_PerformanceLabel.Name = "iD_PerformanceLabel";
            iD_PerformanceLabel.Size = new System.Drawing.Size(387, 42);
            iD_PerformanceLabel.TabIndex = 5;
            iD_PerformanceLabel.Text = "Название спектакля:";
            // 
            // place_TicketLabel
            // 
            place_TicketLabel.AutoSize = true;
            place_TicketLabel.BackColor = System.Drawing.Color.Transparent;
            place_TicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            place_TicketLabel.Location = new System.Drawing.Point(383, 296);
            place_TicketLabel.Name = "place_TicketLabel";
            place_TicketLabel.Size = new System.Drawing.Size(137, 42);
            place_TicketLabel.TabIndex = 7;
            place_TicketLabel.Text = "Место:";
            // 
            // theareDataSet
            // 
            this.theareDataSet.DataSetName = "TheareDataSet";
            this.theareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.theareDataSet;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PerformancesTableAdapter = null;
            this.tableAdapterManager.StructurePerformanceTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = this.ticketsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ticketsBindingNavigator
            // 
            this.ticketsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ticketsBindingNavigator.BindingSource = this.ticketsBindingSource;
            this.ticketsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ticketsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ticketsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ticketsBindingNavigatorSaveItem});
            this.ticketsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ticketsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ticketsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ticketsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ticketsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ticketsBindingNavigator.Name = "ticketsBindingNavigator";
            this.ticketsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ticketsBindingNavigator.Size = new System.Drawing.Size(1366, 25);
            this.ticketsBindingNavigator.TabIndex = 0;
            this.ticketsBindingNavigator.Text = "bindingNavigator1";
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
            // ticketsBindingNavigatorSaveItem
            // 
            this.ticketsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ticketsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ticketsBindingNavigatorSaveItem.Image")));
            this.ticketsBindingNavigatorSaveItem.Name = "ticketsBindingNavigatorSaveItem";
            this.ticketsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ticketsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.ticketsBindingNavigatorSaveItem.Click += new System.EventHandler(this.ticketsBindingNavigatorSaveItem_Click);
            // 
            // iD_TicketTextBox
            // 
            this.iD_TicketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "ID_Ticket", true));
            this.iD_TicketTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_TicketTextBox.Location = new System.Drawing.Point(526, 241);
            this.iD_TicketTextBox.Name = "iD_TicketTextBox";
            this.iD_TicketTextBox.Size = new System.Drawing.Size(50, 49);
            this.iD_TicketTextBox.TabIndex = 2;
            // 
            // price_TicketTextBox
            // 
            this.price_TicketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "Price_Ticket", true));
            this.price_TicketTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_TicketTextBox.Location = new System.Drawing.Point(526, 351);
            this.price_TicketTextBox.Name = "price_TicketTextBox";
            this.price_TicketTextBox.Size = new System.Drawing.Size(200, 49);
            this.price_TicketTextBox.TabIndex = 4;
            // 
            // place_TicketTextBox
            // 
            this.place_TicketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketsBindingSource, "Place_Ticket", true));
            this.place_TicketTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place_TicketTextBox.Location = new System.Drawing.Point(526, 296);
            this.place_TicketTextBox.Name = "place_TicketTextBox";
            this.place_TicketTextBox.Size = new System.Drawing.Size(75, 49);
            this.place_TicketTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(590, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 55);
            this.label1.TabIndex = 9;
            this.label1.Text = "Билеты";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(128, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(840, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 55);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(484, 538);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 55);
            this.button3.TabIndex = 12;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(828, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 55);
            this.button4.TabIndex = 13;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(828, 241);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 55);
            this.button5.TabIndex = 14;
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
            // iD_PerformanceListBox
            // 
            this.iD_PerformanceListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ticketsBindingSource, "ID_Performance", true));
            this.iD_PerformanceListBox.DataSource = this.performancesBindingSource1;
            this.iD_PerformanceListBox.DisplayMember = "Name_Performance";
            this.iD_PerformanceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_PerformanceListBox.FormattingEnabled = true;
            this.iD_PerformanceListBox.ItemHeight = 42;
            this.iD_PerformanceListBox.Location = new System.Drawing.Point(526, 406);
            this.iD_PerformanceListBox.Name = "iD_PerformanceListBox";
            this.iD_PerformanceListBox.Size = new System.Drawing.Size(400, 46);
            this.iD_PerformanceListBox.TabIndex = 15;
            this.iD_PerformanceListBox.ValueMember = "ID_Performance";
            // 
            // performancesBindingSource1
            // 
            this.performancesBindingSource1.DataMember = "Performances";
            this.performancesBindingSource1.DataSource = this.theareDataSet;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.фон2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.iD_PerformanceListBox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(place_TicketLabel);
            this.Controls.Add(this.place_TicketTextBox);
            this.Controls.Add(iD_PerformanceLabel);
            this.Controls.Add(price_TicketLabel);
            this.Controls.Add(this.price_TicketTextBox);
            this.Controls.Add(iD_TicketLabel);
            this.Controls.Add(this.iD_TicketTextBox);
            this.Controls.Add(this.ticketsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Ticket";
            this.Text = "Билеты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingNavigator)).EndInit();
            this.ticketsBindingNavigator.ResumeLayout(false);
            this.ticketsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performancesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TheareDataSet theareDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private TheareDataSetTableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private TheareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ticketsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ticketsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_TicketTextBox;
        private System.Windows.Forms.TextBox price_TicketTextBox;
        private System.Windows.Forms.TextBox place_TicketTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource performancesBindingSource;
        private TheareDataSetTableAdapters.PerformancesTableAdapter performancesTableAdapter;
        private System.Windows.Forms.ListBox iD_PerformanceListBox;
        private System.Windows.Forms.BindingSource performancesBindingSource1;
    }
}