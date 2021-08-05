
namespace Pharmacy_management
{
    partial class billing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billing));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billsLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.billMedSelect = new System.Windows.Forms.ComboBox();
            this.billMedAvailable = new System.Windows.Forms.Label();
            this.billMedQty = new Bunifu.UI.WinForms.BunifuTextBox();
            this.billingAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.medDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.printBillBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // billsLabel
            // 
            this.billsLabel.BackColor = System.Drawing.Color.Transparent;
            this.billsLabel.Font = new System.Drawing.Font("Imprint MT Shadow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billsLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.billsLabel.Location = new System.Drawing.Point(67, 12);
            this.billsLabel.Name = "billsLabel";
            this.billsLabel.Size = new System.Drawing.Size(398, 59);
            this.billsLabel.TabIndex = 2;
            this.billsLabel.Text = "Bills and Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // billMedSelect
            // 
            this.billMedSelect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.billMedSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billMedSelect.Font = new System.Drawing.Font("Malgun Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billMedSelect.ForeColor = System.Drawing.Color.DarkGreen;
            this.billMedSelect.FormattingEnabled = true;
            this.billMedSelect.Location = new System.Drawing.Point(67, 118);
            this.billMedSelect.Margin = new System.Windows.Forms.Padding(4);
            this.billMedSelect.Name = "billMedSelect";
            this.billMedSelect.Size = new System.Drawing.Size(135, 23);
            this.billMedSelect.TabIndex = 35;
            this.billMedSelect.Text = "Select Medicine";
            this.billMedSelect.SelectedIndexChanged += new System.EventHandler(this.billMedSelect_SelectedIndexChanged);
            this.billMedSelect.SelectionChangeCommitted += new System.EventHandler(this.billMedSelect_SelectionChangeCommitted);
            // 
            // billMedAvailable
            // 
            this.billMedAvailable.AutoSize = true;
            this.billMedAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billMedAvailable.ForeColor = System.Drawing.Color.DarkGreen;
            this.billMedAvailable.Location = new System.Drawing.Point(64, 165);
            this.billMedAvailable.Name = "billMedAvailable";
            this.billMedAvailable.Size = new System.Drawing.Size(117, 16);
            this.billMedAvailable.TabIndex = 36;
            this.billMedAvailable.Text = "Available Stock";
            this.billMedAvailable.Visible = false;
            // 
            // billMedQty
            // 
            this.billMedQty.AcceptsReturn = false;
            this.billMedQty.AcceptsTab = false;
            this.billMedQty.AnimationSpeed = 200;
            this.billMedQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.billMedQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.billMedQty.BackColor = System.Drawing.Color.Gainsboro;
            this.billMedQty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billMedQty.BackgroundImage")));
            this.billMedQty.BorderColorActive = System.Drawing.Color.DarkGreen;
            this.billMedQty.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.billMedQty.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.billMedQty.BorderColorIdle = System.Drawing.Color.Green;
            this.billMedQty.BorderRadius = 10;
            this.billMedQty.BorderThickness = 3;
            this.billMedQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.billMedQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.billMedQty.DefaultFont = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billMedQty.DefaultText = "";
            this.billMedQty.FillColor = System.Drawing.Color.Gainsboro;
            this.billMedQty.ForeColor = System.Drawing.Color.DarkGreen;
            this.billMedQty.HideSelection = true;
            this.billMedQty.IconLeft = null;
            this.billMedQty.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.billMedQty.IconPadding = 10;
            this.billMedQty.IconRight = null;
            this.billMedQty.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.billMedQty.Lines = new string[0];
            this.billMedQty.Location = new System.Drawing.Point(67, 202);
            this.billMedQty.MaxLength = 32767;
            this.billMedQty.MinimumSize = new System.Drawing.Size(1, 1);
            this.billMedQty.Modified = false;
            this.billMedQty.Multiline = false;
            this.billMedQty.Name = "billMedQty";
            stateProperties5.BorderColor = System.Drawing.Color.DarkGreen;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.billMedQty.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.billMedQty.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.billMedQty.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Green;
            stateProperties8.FillColor = System.Drawing.Color.Gainsboro;
            stateProperties8.ForeColor = System.Drawing.Color.DarkGreen;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.billMedQty.OnIdleState = stateProperties8;
            this.billMedQty.Padding = new System.Windows.Forms.Padding(3);
            this.billMedQty.PasswordChar = '\0';
            this.billMedQty.PlaceholderForeColor = System.Drawing.Color.Green;
            this.billMedQty.PlaceholderText = "Qunatity";
            this.billMedQty.ReadOnly = false;
            this.billMedQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.billMedQty.SelectedText = "";
            this.billMedQty.SelectionLength = 0;
            this.billMedQty.SelectionStart = 0;
            this.billMedQty.ShortcutsEnabled = true;
            this.billMedQty.Size = new System.Drawing.Size(114, 52);
            this.billMedQty.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.billMedQty.TabIndex = 37;
            this.billMedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.billMedQty.TextMarginBottom = 0;
            this.billMedQty.TextMarginLeft = 0;
            this.billMedQty.TextMarginTop = 9;
            this.billMedQty.TextPlaceholder = "Qunatity";
            this.billMedQty.UseSystemPasswordChar = false;
            this.billMedQty.WordWrap = true;
            // 
            // billingAddBtn
            // 
            this.billingAddBtn.BorderRadius = 8;
            this.billingAddBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.billingAddBtn.BorderThickness = 1;
            this.billingAddBtn.CheckedState.Parent = this.billingAddBtn;
            this.billingAddBtn.CustomImages.Parent = this.billingAddBtn;
            this.billingAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.billingAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.billingAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.billingAddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.billingAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.billingAddBtn.DisabledState.Parent = this.billingAddBtn;
            this.billingAddBtn.FillColor = System.Drawing.Color.LightGreen;
            this.billingAddBtn.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.billingAddBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingAddBtn.ForeColor = System.Drawing.Color.Black;
            this.billingAddBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.billingAddBtn.HoverState.Parent = this.billingAddBtn;
            this.billingAddBtn.Location = new System.Drawing.Point(67, 293);
            this.billingAddBtn.Name = "billingAddBtn";
            this.billingAddBtn.ShadowDecoration.Parent = this.billingAddBtn;
            this.billingAddBtn.Size = new System.Drawing.Size(114, 45);
            this.billingAddBtn.TabIndex = 38;
            this.billingAddBtn.Text = "Add to bill";
            this.billingAddBtn.Click += new System.EventHandler(this.billingAddBtn_Click);
            // 
            // medDetails
            // 
            this.medDetails.AllowDrop = true;
            this.medDetails.AllowUserToAddRows = false;
            this.medDetails.AllowUserToResizeColumns = false;
            this.medDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.medDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.medDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.medDetails.BackgroundColor = System.Drawing.Color.White;
            this.medDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.medDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.medDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.medDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.medName,
            this.quantity,
            this.unitPrice,
            this.totalPrice});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.medDetails.EnableHeadersVisualStyles = false;
            this.medDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.medDetails.Location = new System.Drawing.Point(287, 90);
            this.medDetails.Name = "medDetails";
            this.medDetails.ReadOnly = true;
            this.medDetails.RowHeadersVisible = false;
            this.medDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.medDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medDetails.Size = new System.Drawing.Size(665, 248);
            this.medDetails.TabIndex = 39;
            this.medDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGreen;
            this.medDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(201)))));
            this.medDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.medDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.medDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.medDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.medDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.medDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(235)))), ((int)(((byte)(199)))));
            this.medDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGreen;
            this.medDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.medDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.medDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.medDetails.ThemeStyle.HeaderStyle.Height = 23;
            this.medDetails.ThemeStyle.ReadOnly = true;
            this.medDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(219)))));
            this.medDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.medDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.medDetails.ThemeStyle.RowsStyle.Height = 22;
            this.medDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(214)))), ((int)(((byte)(134)))));
            this.medDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ID
            // 
            this.ID.HeaderText = "Med_ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // medName
            // 
            this.medName.HeaderText = "Med_Name";
            this.medName.Name = "medName";
            this.medName.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit_Price";
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // totalAmount
            // 
            this.totalAmount.BackColor = System.Drawing.Color.Transparent;
            this.totalAmount.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.ForeColor = System.Drawing.Color.DarkGreen;
            this.totalAmount.Location = new System.Drawing.Point(411, 363);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(3, 2);
            this.totalAmount.TabIndex = 40;
            this.totalAmount.Text = null;
            // 
            // printBillBtn
            // 
            this.printBillBtn.BorderColor = System.Drawing.Color.PaleGreen;
            this.printBillBtn.BorderRadius = 20;
            this.printBillBtn.BorderThickness = 1;
            this.printBillBtn.CheckedState.Parent = this.printBillBtn;
            this.printBillBtn.CustomImages.Parent = this.printBillBtn;
            this.printBillBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBillBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBillBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBillBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBillBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBillBtn.DisabledState.Parent = this.printBillBtn;
            this.printBillBtn.FillColor = System.Drawing.Color.LawnGreen;
            this.printBillBtn.FillColor2 = System.Drawing.Color.MediumTurquoise;
            this.printBillBtn.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBillBtn.ForeColor = System.Drawing.Color.Black;
            this.printBillBtn.HoverState.Parent = this.printBillBtn;
            this.printBillBtn.Location = new System.Drawing.Point(563, 422);
            this.printBillBtn.Name = "printBillBtn";
            this.printBillBtn.ShadowDecoration.Parent = this.printBillBtn;
            this.printBillBtn.Size = new System.Drawing.Size(114, 45);
            this.printBillBtn.TabIndex = 41;
            this.printBillBtn.Text = "Print bill";
            this.printBillBtn.Click += new System.EventHandler(this.printBillBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BorderRadius = 8;
            this.guna2GradientButton1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Chartreuse;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Green;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(79, 422);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(87, 45);
            this.guna2GradientButton1.TabIndex = 42;
            this.guna2GradientButton1.Text = "Back";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1023, 548);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.printBillBtn);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.medDetails);
            this.Controls.Add(this.billingAddBtn);
            this.Controls.Add(this.billMedQty);
            this.Controls.Add(this.billMedAvailable);
            this.Controls.Add(this.billMedSelect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.billsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Medicine";
            this.Load += new System.EventHandler(this.billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel billsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox billMedSelect;
        private System.Windows.Forms.Label billMedAvailable;
        private Bunifu.UI.WinForms.BunifuTextBox billMedQty;
        private Guna.UI2.WinForms.Guna2GradientButton billingAddBtn;
        private Guna.UI2.WinForms.Guna2DataGridView medDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn medName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel totalAmount;
        private Guna.UI2.WinForms.Guna2GradientButton printBillBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}