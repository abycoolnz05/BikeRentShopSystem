namespace BikeRentingSystem
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewBikes = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewRentals = new System.Windows.Forms.DataGridView();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCustID = new System.Windows.Forms.Label();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.lblLname = new System.Windows.Forms.Label();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.AddCustbtn = new System.Windows.Forms.Button();
            this.textBoxBikeID = new System.Windows.Forms.TextBox();
            this.lblBikeID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.lblRentalCost = new System.Windows.Forms.Label();
            this.textBoxRentalCost = new System.Windows.Forms.TextBox();
            this.AddBikebtn = new System.Windows.Forms.Button();
            this.btnIssueBike = new System.Windows.Forms.Button();
            this.btnReturnBike = new System.Windows.Forms.Button();
            this.DeleteCustbtn = new System.Windows.Forms.Button();
            this.DeleteBikebtn = new System.Windows.Forms.Button();
            this.bikeRentalDataSet = new BikeRentingSystem.BikeRentalDataSet();
            this.bikeRentalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikes)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeRentalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeRentalDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1027, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewCustomer);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1019, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToOrderColumns = true;
            this.dataGridViewCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1025, 308);
            this.dataGridViewCustomer.TabIndex = 0;
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            this.dataGridViewCustomer.DoubleClick += new System.EventHandler(this.dataGridViewCustomer_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Maroon;
            this.tabPage2.Controls.Add(this.dataGridViewBikes);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1019, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bikes";
            // 
            // dataGridViewBikes
            // 
            this.dataGridViewBikes.AllowUserToOrderColumns = true;
            this.dataGridViewBikes.AutoGenerateColumns = false;
            this.dataGridViewBikes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewBikes.DataSource = this.bikeRentalDataSetBindingSource;
            this.dataGridViewBikes.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewBikes.Name = "dataGridViewBikes";
            this.dataGridViewBikes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBikes.Size = new System.Drawing.Size(1025, 308);
            this.dataGridViewBikes.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewRentals);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1019, 308);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRentals
            // 
            this.dataGridViewRentals.AllowUserToOrderColumns = true;
            this.dataGridViewRentals.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridViewRentals.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewRentals.Name = "dataGridViewRentals";
            this.dataGridViewRentals.Size = new System.Drawing.Size(1025, 308);
            this.dataGridViewRentals.TabIndex = 1;
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textSearch.Location = new System.Drawing.Point(624, 4);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(251, 27);
            this.textSearch.TabIndex = 1;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Red;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(888, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCustID.Location = new System.Drawing.Point(22, 368);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(18, 13);
            this.lblCustID.TabIndex = 35;
            this.lblCustID.Text = "ID";
            // 
            // textBoxCustID
            // 
            this.textBoxCustID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxCustID.Location = new System.Drawing.Point(25, 384);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(31, 20);
            this.textBoxCustID.TabIndex = 36;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFname.Location = new System.Drawing.Point(59, 368);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 37;
            this.lblFname.Text = "First Name";
            // 
            // textBoxFname
            // 
            this.textBoxFname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxFname.Location = new System.Drawing.Point(62, 384);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(96, 20);
            this.textBoxFname.TabIndex = 38;
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLname.Location = new System.Drawing.Point(161, 368);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 39;
            this.lblLname.Text = "Last Name";
            // 
            // textBoxLname
            // 
            this.textBoxLname.Location = new System.Drawing.Point(164, 384);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(100, 20);
            this.textBoxLname.TabIndex = 40;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddress.Location = new System.Drawing.Point(20, 453);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 41;
            this.lblAddress.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(73, 450);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(191, 20);
            this.textBoxAddress.TabIndex = 42;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 422);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 43;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(104, 419);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(160, 20);
            this.textBoxPhone.TabIndex = 44;
            // 
            // AddCustbtn
            // 
            this.AddCustbtn.BackColor = System.Drawing.Color.Maroon;
            this.AddCustbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustbtn.ForeColor = System.Drawing.Color.White;
            this.AddCustbtn.Location = new System.Drawing.Point(270, 375);
            this.AddCustbtn.Name = "AddCustbtn";
            this.AddCustbtn.Size = new System.Drawing.Size(110, 54);
            this.AddCustbtn.TabIndex = 45;
            this.AddCustbtn.Text = "Add Customer";
            this.AddCustbtn.UseVisualStyleBackColor = false;
            this.AddCustbtn.Click += new System.EventHandler(this.AddCustbtn_Click_1);
            // 
            // textBoxBikeID
            // 
            this.textBoxBikeID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxBikeID.Location = new System.Drawing.Point(403, 384);
            this.textBoxBikeID.Name = "textBoxBikeID";
            this.textBoxBikeID.Size = new System.Drawing.Size(31, 20);
            this.textBoxBikeID.TabIndex = 46;
            // 
            // lblBikeID
            // 
            this.lblBikeID.AutoSize = true;
            this.lblBikeID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBikeID.Location = new System.Drawing.Point(400, 368);
            this.lblBikeID.Name = "lblBikeID";
            this.lblBikeID.Size = new System.Drawing.Size(18, 13);
            this.lblBikeID.TabIndex = 47;
            this.lblBikeID.Text = "ID";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Location = new System.Drawing.Point(437, 368);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(440, 384);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(162, 20);
            this.textBoxTitle.TabIndex = 49;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblYear.Location = new System.Drawing.Point(605, 368);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 50;
            this.lblYear.Text = "Year";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(608, 386);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(68, 20);
            this.textBoxYear.TabIndex = 51;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblType.Location = new System.Drawing.Point(403, 419);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 52;
            this.lblType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(440, 415);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(159, 20);
            this.textBoxType.TabIndex = 53;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRating.Location = new System.Drawing.Point(400, 450);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 54;
            this.lblRating.Text = "Rating";
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(440, 443);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(68, 20);
            this.textBoxRating.TabIndex = 55;
            // 
            // lblRentalCost
            // 
            this.lblRentalCost.AutoSize = true;
            this.lblRentalCost.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRentalCost.Location = new System.Drawing.Point(519, 449);
            this.lblRentalCost.Name = "lblRentalCost";
            this.lblRentalCost.Size = new System.Drawing.Size(62, 13);
            this.lblRentalCost.TabIndex = 56;
            this.lblRentalCost.Text = "Rental Cost";
            // 
            // textBoxRentalCost
            // 
            this.textBoxRentalCost.Location = new System.Drawing.Point(587, 443);
            this.textBoxRentalCost.Name = "textBoxRentalCost";
            this.textBoxRentalCost.Size = new System.Drawing.Size(89, 20);
            this.textBoxRentalCost.TabIndex = 57;
            // 
            // AddBikebtn
            // 
            this.AddBikebtn.BackColor = System.Drawing.Color.Red;
            this.AddBikebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBikebtn.ForeColor = System.Drawing.Color.White;
            this.AddBikebtn.Location = new System.Drawing.Point(682, 368);
            this.AddBikebtn.Name = "AddBikebtn";
            this.AddBikebtn.Size = new System.Drawing.Size(114, 55);
            this.AddBikebtn.TabIndex = 58;
            this.AddBikebtn.Text = "Add Bike";
            this.AddBikebtn.UseVisualStyleBackColor = false;
            // 
            // btnIssueBike
            // 
            this.btnIssueBike.BackColor = System.Drawing.Color.Gold;
            this.btnIssueBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBike.ForeColor = System.Drawing.Color.Maroon;
            this.btnIssueBike.Location = new System.Drawing.Point(830, 375);
            this.btnIssueBike.Name = "btnIssueBike";
            this.btnIssueBike.Size = new System.Drawing.Size(88, 87);
            this.btnIssueBike.TabIndex = 59;
            this.btnIssueBike.Text = "Issue Bike";
            this.btnIssueBike.UseVisualStyleBackColor = false;
            // 
            // btnReturnBike
            // 
            this.btnReturnBike.BackColor = System.Drawing.Color.LightGreen;
            this.btnReturnBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBike.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnReturnBike.Location = new System.Drawing.Point(937, 375);
            this.btnReturnBike.Name = "btnReturnBike";
            this.btnReturnBike.Size = new System.Drawing.Size(84, 87);
            this.btnReturnBike.TabIndex = 60;
            this.btnReturnBike.Text = "Return Bike";
            this.btnReturnBike.UseVisualStyleBackColor = false;
            // 
            // DeleteCustbtn
            // 
            this.DeleteCustbtn.BackColor = System.Drawing.Color.Black;
            this.DeleteCustbtn.ForeColor = System.Drawing.Color.White;
            this.DeleteCustbtn.Location = new System.Drawing.Point(270, 437);
            this.DeleteCustbtn.Name = "DeleteCustbtn";
            this.DeleteCustbtn.Size = new System.Drawing.Size(110, 37);
            this.DeleteCustbtn.TabIndex = 61;
            this.DeleteCustbtn.Text = "Delete Customer !";
            this.DeleteCustbtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBikebtn
            // 
            this.DeleteBikebtn.BackColor = System.Drawing.Color.Black;
            this.DeleteBikebtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBikebtn.Location = new System.Drawing.Point(682, 429);
            this.DeleteBikebtn.Name = "DeleteBikebtn";
            this.DeleteBikebtn.Size = new System.Drawing.Size(114, 37);
            this.DeleteBikebtn.TabIndex = 62;
            this.DeleteBikebtn.Text = "Delete Bike!";
            this.DeleteBikebtn.UseVisualStyleBackColor = false;
            // 
            // bikeRentalDataSet
            // 
            this.bikeRentalDataSet.DataSetName = "BikeRentalDataSet";
            this.bikeRentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bikeRentalDataSetBindingSource
            // 
            this.bikeRentalDataSetBindingSource.DataSource = this.bikeRentalDataSet;
            this.bikeRentalDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1051, 496);
            this.Controls.Add(this.DeleteBikebtn);
            this.Controls.Add(this.DeleteCustbtn);
            this.Controls.Add(this.btnReturnBike);
            this.Controls.Add(this.btnIssueBike);
            this.Controls.Add(this.AddBikebtn);
            this.Controls.Add(this.textBoxRentalCost);
            this.Controls.Add(this.lblRentalCost);
            this.Controls.Add(this.textBoxRating);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBikeID);
            this.Controls.Add(this.textBoxBikeID);
            this.Controls.Add(this.AddCustbtn);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.textBoxCustID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bike Rental System";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikes)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeRentalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeRentalDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewBikes;
        private System.Windows.Forms.DataGridView dataGridViewRentals;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button AddCustbtn;
        private System.Windows.Forms.TextBox textBoxBikeID;
        private System.Windows.Forms.Label lblBikeID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label lblRentalCost;
        private System.Windows.Forms.TextBox textBoxRentalCost;
        private System.Windows.Forms.Button AddBikebtn;
        private System.Windows.Forms.Button btnIssueBike;
        private System.Windows.Forms.Button btnReturnBike;
        private System.Windows.Forms.Button DeleteCustbtn;
        private System.Windows.Forms.Button DeleteBikebtn;
        private System.Windows.Forms.BindingSource bikeRentalDataSetBindingSource;
        private BikeRentalDataSet bikeRentalDataSet;
    }
}

