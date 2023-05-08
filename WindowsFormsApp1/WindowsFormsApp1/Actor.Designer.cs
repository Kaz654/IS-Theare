
namespace WindowsFormsApp1
{
    partial class Actor
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
            System.Windows.Forms.Label iD_ActorLabel;
            System.Windows.Forms.Label fIO_ActorLabel;
            System.Windows.Forms.Label gender_ActorLabel;
            System.Windows.Forms.Label telephone_ActorLabel;
            System.Windows.Forms.Label education_ActorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actor));
            this.theareDataSet = new WindowsFormsApp1.TheareDataSet();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new WindowsFormsApp1.TheareDataSetTableAdapters.ActorsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager();
            this.actorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.actorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ActorTextBox = new System.Windows.Forms.TextBox();
            this.fIO_ActorTextBox = new System.Windows.Forms.TextBox();
            this.gender_ActorTextBox = new System.Windows.Forms.TextBox();
            this.telephone_ActorTextBox = new System.Windows.Forms.TextBox();
            this.education_ActorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            iD_ActorLabel = new System.Windows.Forms.Label();
            fIO_ActorLabel = new System.Windows.Forms.Label();
            gender_ActorLabel = new System.Windows.Forms.Label();
            telephone_ActorLabel = new System.Windows.Forms.Label();
            education_ActorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingNavigator)).BeginInit();
            this.actorsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_ActorLabel
            // 
            iD_ActorLabel.AutoSize = true;
            iD_ActorLabel.BackColor = System.Drawing.Color.Transparent;
            iD_ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_ActorLabel.Location = new System.Drawing.Point(277, 224);
            iD_ActorLabel.Name = "iD_ActorLabel";
            iD_ActorLabel.Size = new System.Drawing.Size(64, 42);
            iD_ActorLabel.TabIndex = 1;
            iD_ActorLabel.Text = "ID:";
            // 
            // fIO_ActorLabel
            // 
            fIO_ActorLabel.AutoSize = true;
            fIO_ActorLabel.BackColor = System.Drawing.Color.Transparent;
            fIO_ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            fIO_ActorLabel.Location = new System.Drawing.Point(226, 279);
            fIO_ActorLabel.Name = "fIO_ActorLabel";
            fIO_ActorLabel.Size = new System.Drawing.Size(115, 42);
            fIO_ActorLabel.TabIndex = 3;
            fIO_ActorLabel.Text = "ФИО:";
            // 
            // gender_ActorLabel
            // 
            gender_ActorLabel.AutoSize = true;
            gender_ActorLabel.BackColor = System.Drawing.Color.Transparent;
            gender_ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            gender_ActorLabel.Location = new System.Drawing.Point(244, 334);
            gender_ActorLabel.Name = "gender_ActorLabel";
            gender_ActorLabel.Size = new System.Drawing.Size(97, 42);
            gender_ActorLabel.TabIndex = 5;
            gender_ActorLabel.Text = "Пол:";
            // 
            // telephone_ActorLabel
            // 
            telephone_ActorLabel.AutoSize = true;
            telephone_ActorLabel.BackColor = System.Drawing.Color.Transparent;
            telephone_ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            telephone_ActorLabel.Location = new System.Drawing.Point(154, 389);
            telephone_ActorLabel.Name = "telephone_ActorLabel";
            telephone_ActorLabel.Size = new System.Drawing.Size(187, 42);
            telephone_ActorLabel.TabIndex = 7;
            telephone_ActorLabel.Text = "Телефон:";
            // 
            // education_ActorLabel
            // 
            education_ActorLabel.AutoSize = true;
            education_ActorLabel.BackColor = System.Drawing.Color.Transparent;
            education_ActorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            education_ActorLabel.Location = new System.Drawing.Point(77, 447);
            education_ActorLabel.Name = "education_ActorLabel";
            education_ActorLabel.Size = new System.Drawing.Size(264, 42);
            education_ActorLabel.TabIndex = 9;
            education_ActorLabel.Text = "Образование:";
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
            this.tableAdapterManager.PerformancesTableAdapter = null;
            this.tableAdapterManager.StructurePerformanceTableAdapter = null;
            this.tableAdapterManager.TicketsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.TheareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actorsBindingNavigator
            // 
            this.actorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actorsBindingNavigator.BindingSource = this.actorsBindingSource;
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
            // actorsBindingNavigatorSaveItem
            // 
            this.actorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actorsBindingNavigatorSaveItem.Image")));
            this.actorsBindingNavigatorSaveItem.Name = "actorsBindingNavigatorSaveItem";
            this.actorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.actorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.actorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.actorsBindingNavigatorSaveItem_Click);
            // 
            // iD_ActorTextBox
            // 
            this.iD_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "ID_Actor", true));
            this.iD_ActorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iD_ActorTextBox.Location = new System.Drawing.Point(347, 224);
            this.iD_ActorTextBox.Name = "iD_ActorTextBox";
            this.iD_ActorTextBox.Size = new System.Drawing.Size(50, 49);
            this.iD_ActorTextBox.TabIndex = 2;
            // 
            // fIO_ActorTextBox
            // 
            this.fIO_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "FIO_Actor", true));
            this.fIO_ActorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fIO_ActorTextBox.Location = new System.Drawing.Point(347, 279);
            this.fIO_ActorTextBox.Name = "fIO_ActorTextBox";
            this.fIO_ActorTextBox.Size = new System.Drawing.Size(550, 49);
            this.fIO_ActorTextBox.TabIndex = 4;
            // 
            // gender_ActorTextBox
            // 
            this.gender_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "Gender_Actor", true));
            this.gender_ActorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender_ActorTextBox.Location = new System.Drawing.Point(347, 334);
            this.gender_ActorTextBox.Name = "gender_ActorTextBox";
            this.gender_ActorTextBox.Size = new System.Drawing.Size(50, 49);
            this.gender_ActorTextBox.TabIndex = 6;
            // 
            // telephone_ActorTextBox
            // 
            this.telephone_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "Telephone_Actor", true));
            this.telephone_ActorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephone_ActorTextBox.Location = new System.Drawing.Point(347, 389);
            this.telephone_ActorTextBox.Name = "telephone_ActorTextBox";
            this.telephone_ActorTextBox.Size = new System.Drawing.Size(250, 49);
            this.telephone_ActorTextBox.TabIndex = 8;
            // 
            // education_ActorTextBox
            // 
            this.education_ActorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "Education_Actor", true));
            this.education_ActorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.education_ActorTextBox.Location = new System.Drawing.Point(347, 444);
            this.education_ActorTextBox.Name = "education_ActorTextBox";
            this.education_ActorTextBox.Size = new System.Drawing.Size(850, 49);
            this.education_ActorTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(575, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Актеры";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(175, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 55);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(887, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 55);
            this.button2.TabIndex = 14;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(531, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 55);
            this.button3.TabIndex = 15;
            this.button3.Text = "Сохранить запись";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(903, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 55);
            this.button4.TabIndex = 16;
            this.button4.Text = "Табличный вид";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(903, 224);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(350, 55);
            this.button5.TabIndex = 17;
            this.button5.Text = "Главное меню";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Actor
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
            this.Controls.Add(education_ActorLabel);
            this.Controls.Add(this.education_ActorTextBox);
            this.Controls.Add(telephone_ActorLabel);
            this.Controls.Add(this.telephone_ActorTextBox);
            this.Controls.Add(gender_ActorLabel);
            this.Controls.Add(this.gender_ActorTextBox);
            this.Controls.Add(fIO_ActorLabel);
            this.Controls.Add(this.fIO_ActorTextBox);
            this.Controls.Add(iD_ActorLabel);
            this.Controls.Add(this.iD_ActorTextBox);
            this.Controls.Add(this.actorsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Actor";
            this.Text = "Актеры";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Actor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingNavigator)).EndInit();
            this.actorsBindingNavigator.ResumeLayout(false);
            this.actorsBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox iD_ActorTextBox;
        private System.Windows.Forms.TextBox fIO_ActorTextBox;
        private System.Windows.Forms.TextBox gender_ActorTextBox;
        private System.Windows.Forms.TextBox telephone_ActorTextBox;
        private System.Windows.Forms.TextBox education_ActorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}