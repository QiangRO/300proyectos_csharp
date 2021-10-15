namespace Library
{
    partial class ReportingTrusteeship
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
            System.Windows.Forms.Label bookNameLabel;
            System.Windows.Forms.Label bookSubjectLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label translatorLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label membershipIDLabel;
            System.Windows.Forms.Label dateAmanatLabel;
            System.Windows.Forms.Label dateBackLabel;
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tozihatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingTrusteeship));
            this.sabteAmanatBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.sabteAmanatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Library.LibraryDataSet();
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
            this.sabteAmanatBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.bookSubjectTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.translatorTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.membershipIDTextBox = new System.Windows.Forms.TextBox();
            this.dateAmanatTextBox = new System.Windows.Forms.TextBox();
            this.dateBackTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tozihatTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sabteAmanatTableAdapter = new Library.LibraryDataSetTableAdapters.SabteAmanatTableAdapter();
            this.tableAdapterManager = new Library.LibraryDataSetTableAdapters.TableAdapterManager();
            bookNameLabel = new System.Windows.Forms.Label();
            bookSubjectLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            translatorLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            membershipIDLabel = new System.Windows.Forms.Label();
            dateAmanatLabel = new System.Windows.Forms.Label();
            dateBackLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            tozihatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sabteAmanatBindingNavigator)).BeginInit();
            this.sabteAmanatBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sabteAmanatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // bookNameLabel
            // 
            bookNameLabel.AutoSize = true;
            bookNameLabel.Location = new System.Drawing.Point(575, 120);
            bookNameLabel.Name = "bookNameLabel";
            bookNameLabel.Size = new System.Drawing.Size(46, 13);
            bookNameLabel.TabIndex = 1;
            bookNameLabel.Text = "نام کتاب";
            // 
            // bookSubjectLabel
            // 
            bookSubjectLabel.AutoSize = true;
            bookSubjectLabel.Location = new System.Drawing.Point(575, 160);
            bookSubjectLabel.Name = "bookSubjectLabel";
            bookSubjectLabel.Size = new System.Drawing.Size(66, 13);
            bookSubjectLabel.TabIndex = 3;
            bookSubjectLabel.Text = "موضوع کتاب";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(575, 198);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(45, 13);
            authorLabel.TabIndex = 5;
            authorLabel.Text = "نویسنده";
            // 
            // translatorLabel
            // 
            translatorLabel.AutoSize = true;
            translatorLabel.Location = new System.Drawing.Point(575, 236);
            translatorLabel.Name = "translatorLabel";
            translatorLabel.Size = new System.Drawing.Size(33, 13);
            translatorLabel.TabIndex = 7;
            translatorLabel.Text = "مترجم";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(575, 312);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(20, 13);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "نام";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(575, 350);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(39, 13);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "فامیلی";
            // 
            // membershipIDLabel
            // 
            membershipIDLabel.AutoSize = true;
            membershipIDLabel.Location = new System.Drawing.Point(251, 200);
            membershipIDLabel.Name = "membershipIDLabel";
            membershipIDLabel.Size = new System.Drawing.Size(64, 13);
            membershipIDLabel.TabIndex = 13;
            membershipIDLabel.Text = "شماره کاربر";
            // 
            // dateAmanatLabel
            // 
            dateAmanatLabel.AutoSize = true;
            dateAmanatLabel.Location = new System.Drawing.Point(251, 124);
            dateAmanatLabel.Name = "dateAmanatLabel";
            dateAmanatLabel.Size = new System.Drawing.Size(59, 13);
            dateAmanatLabel.TabIndex = 15;
            dateAmanatLabel.Text = "تاریخ امانت";
            // 
            // dateBackLabel
            // 
            dateBackLabel.AutoSize = true;
            dateBackLabel.Location = new System.Drawing.Point(249, 163);
            dateBackLabel.Name = "dateBackLabel";
            dateBackLabel.Size = new System.Drawing.Size(68, 13);
            dateBackLabel.TabIndex = 17;
            dateBackLabel.Text = "تاریخ برگشت";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(575, 274);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(36, 13);
            iDLabel.TabIndex = 19;
            iDLabel.Text = "شماره";
            // 
            // tozihatLabel
            // 
            tozihatLabel.AutoSize = true;
            tozihatLabel.Location = new System.Drawing.Point(251, 240);
            tozihatLabel.Name = "tozihatLabel";
            tozihatLabel.Size = new System.Drawing.Size(49, 13);
            tozihatLabel.TabIndex = 21;
            tozihatLabel.Text = "توضیحات";
            // 
            // sabteAmanatBindingNavigator
            // 
            this.sabteAmanatBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sabteAmanatBindingNavigator.BindingSource = this.sabteAmanatBindingSource;
            this.sabteAmanatBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sabteAmanatBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sabteAmanatBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sabteAmanatBindingNavigatorSaveItem});
            this.sabteAmanatBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sabteAmanatBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sabteAmanatBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sabteAmanatBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sabteAmanatBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sabteAmanatBindingNavigator.Name = "sabteAmanatBindingNavigator";
            this.sabteAmanatBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sabteAmanatBindingNavigator.Size = new System.Drawing.Size(720, 25);
            this.sabteAmanatBindingNavigator.TabIndex = 0;
            this.sabteAmanatBindingNavigator.Text = "bindingNavigator1";
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
            // sabteAmanatBindingSource
            // 
            this.sabteAmanatBindingSource.DataMember = "SabteAmanat";
            this.sabteAmanatBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // sabteAmanatBindingNavigatorSaveItem
            // 
            this.sabteAmanatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sabteAmanatBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sabteAmanatBindingNavigatorSaveItem.Image")));
            this.sabteAmanatBindingNavigatorSaveItem.Name = "sabteAmanatBindingNavigatorSaveItem";
            this.sabteAmanatBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sabteAmanatBindingNavigatorSaveItem.Text = "Save Data";
            this.sabteAmanatBindingNavigatorSaveItem.Click += new System.EventHandler(this.sabteAmanatBindingNavigatorSaveItem_Click);
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "BookName", true));
            this.bookNameTextBox.Enabled = false;
            this.bookNameTextBox.Location = new System.Drawing.Point(386, 117);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.bookNameTextBox.TabIndex = 2;
            // 
            // bookSubjectTextBox
            // 
            this.bookSubjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "BookSubject", true));
            this.bookSubjectTextBox.Enabled = false;
            this.bookSubjectTextBox.Location = new System.Drawing.Point(386, 156);
            this.bookSubjectTextBox.Name = "bookSubjectTextBox";
            this.bookSubjectTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookSubjectTextBox.Size = new System.Drawing.Size(174, 20);
            this.bookSubjectTextBox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "author", true));
            this.authorTextBox.Enabled = false;
            this.authorTextBox.Location = new System.Drawing.Point(386, 193);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.authorTextBox.Size = new System.Drawing.Size(174, 20);
            this.authorTextBox.TabIndex = 6;
            // 
            // translatorTextBox
            // 
            this.translatorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "Translator", true));
            this.translatorTextBox.Enabled = false;
            this.translatorTextBox.Location = new System.Drawing.Point(386, 233);
            this.translatorTextBox.Name = "translatorTextBox";
            this.translatorTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.translatorTextBox.Size = new System.Drawing.Size(174, 20);
            this.translatorTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "FirstName", true));
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(386, 308);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.firstNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "LastName", true));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(386, 345);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lastNameTextBox.Size = new System.Drawing.Size(174, 20);
            this.lastNameTextBox.TabIndex = 12;
            // 
            // membershipIDTextBox
            // 
            this.membershipIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "membershipID", true));
            this.membershipIDTextBox.Enabled = false;
            this.membershipIDTextBox.Location = new System.Drawing.Point(56, 198);
            this.membershipIDTextBox.Name = "membershipIDTextBox";
            this.membershipIDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.membershipIDTextBox.Size = new System.Drawing.Size(179, 20);
            this.membershipIDTextBox.TabIndex = 14;
            // 
            // dateAmanatTextBox
            // 
            this.dateAmanatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "DateAmanat", true));
            this.dateAmanatTextBox.Enabled = false;
            this.dateAmanatTextBox.Location = new System.Drawing.Point(56, 120);
            this.dateAmanatTextBox.Name = "dateAmanatTextBox";
            this.dateAmanatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateAmanatTextBox.Size = new System.Drawing.Size(179, 20);
            this.dateAmanatTextBox.TabIndex = 16;
            // 
            // dateBackTextBox
            // 
            this.dateBackTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "DateBack", true));
            this.dateBackTextBox.Enabled = false;
            this.dateBackTextBox.Location = new System.Drawing.Point(56, 160);
            this.dateBackTextBox.Name = "dateBackTextBox";
            this.dateBackTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateBackTextBox.Size = new System.Drawing.Size(179, 20);
            this.dateBackTextBox.TabIndex = 18;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(386, 270);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iDTextBox.Size = new System.Drawing.Size(174, 20);
            this.iDTextBox.TabIndex = 20;
            // 
            // tozihatTextBox
            // 
            this.tozihatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sabteAmanatBindingSource, "Tozihat", true));
            this.tozihatTextBox.Enabled = false;
            this.tozihatTextBox.Location = new System.Drawing.Point(36, 237);
            this.tozihatTextBox.Multiline = true;
            this.tozihatTextBox.Name = "tozihatTextBox";
            this.tozihatTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tozihatTextBox.Size = new System.Drawing.Size(199, 88);
            this.tozihatTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "جستجو";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 431);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "ویرایش اطلاعات";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(451, 431);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "ثبت امانت";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sabteAmanatTableAdapter
            // 
            this.sabteAmanatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookDetailsTableAdapter = null;
            this.tableAdapterManager.SabteAmanatTableAdapter = this.sabteAmanatTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ReportingTrusteeship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(720, 478);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(tozihatLabel);
            this.Controls.Add(this.tozihatTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(dateBackLabel);
            this.Controls.Add(this.dateBackTextBox);
            this.Controls.Add(dateAmanatLabel);
            this.Controls.Add(this.dateAmanatTextBox);
            this.Controls.Add(membershipIDLabel);
            this.Controls.Add(this.membershipIDTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(translatorLabel);
            this.Controls.Add(this.translatorTextBox);
            this.Controls.Add(authorLabel);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(bookSubjectLabel);
            this.Controls.Add(this.bookSubjectTextBox);
            this.Controls.Add(bookNameLabel);
            this.Controls.Add(this.bookNameTextBox);
            this.Controls.Add(this.sabteAmanatBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportingTrusteeship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportingTrusteeship";
            this.Load += new System.EventHandler(this.ReportingTrusteeship_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sabteAmanatBindingNavigator)).EndInit();
            this.sabteAmanatBindingNavigator.ResumeLayout(false);
            this.sabteAmanatBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sabteAmanatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource sabteAmanatBindingSource;
        private Library.LibraryDataSetTableAdapters.SabteAmanatTableAdapter sabteAmanatTableAdapter;
        private Library.LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sabteAmanatBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sabteAmanatBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.TextBox bookSubjectTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox translatorTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox membershipIDTextBox;
        private System.Windows.Forms.TextBox dateAmanatTextBox;
        private System.Windows.Forms.TextBox dateBackTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox tozihatTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}