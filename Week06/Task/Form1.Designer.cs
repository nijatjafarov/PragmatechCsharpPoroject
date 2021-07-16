
namespace Task
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.massValue = new System.Windows.Forms.NumericUpDown();
            this.deliveryBox = new System.Windows.Forms.ComboBox();
            this.costValue = new System.Windows.Forms.NumericUpDown();
            this.deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.deliveryBtn = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.productList = new System.Windows.Forms.ListView();
            this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delivery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.massValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costValue)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Category1",
            "Category2",
            "Category3",
            "Category4"});
            this.categoryBox.Location = new System.Drawing.Point(12, 39);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(121, 21);
            this.categoryBox.TabIndex = 0;
            this.categoryBox.SelectedIndexChanged += new System.EventHandler(this.categoryBox_SelectedIndexChanged);
            // 
            // productBox
            // 
            this.productBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(152, 39);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(121, 21);
            this.productBox.TabIndex = 1;
            // 
            // massValue
            // 
            this.massValue.Location = new System.Drawing.Point(430, 39);
            this.massValue.Name = "massValue";
            this.massValue.Size = new System.Drawing.Size(118, 20);
            this.massValue.TabIndex = 2;
            // 
            // deliveryBox
            // 
            this.deliveryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryBox.FormattingEnabled = true;
            this.deliveryBox.Items.AddRange(new object[] {
            "Delivery option 1",
            "Delivery option 2",
            "Delivery option 3"});
            this.deliveryBox.Location = new System.Drawing.Point(291, 39);
            this.deliveryBox.Name = "deliveryBox";
            this.deliveryBox.Size = new System.Drawing.Size(121, 21);
            this.deliveryBox.TabIndex = 3;
            // 
            // costValue
            // 
            this.costValue.Location = new System.Drawing.Point(581, 39);
            this.costValue.Name = "costValue";
            this.costValue.Size = new System.Drawing.Size(134, 20);
            this.costValue.TabIndex = 4;
            // 
            // deliveryDate
            // 
            this.deliveryDate.Location = new System.Drawing.Point(733, 39);
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Size = new System.Drawing.Size(200, 20);
            this.deliveryDate.TabIndex = 5;
            this.deliveryDate.Value = new System.DateTime(2021, 7, 15, 0, 0, 0, 0);
            // 
            // deliveryBtn
            // 
            this.deliveryBtn.Location = new System.Drawing.Point(950, 37);
            this.deliveryBtn.Name = "deliveryBtn";
            this.deliveryBtn.Size = new System.Drawing.Size(75, 23);
            this.deliveryBtn.TabIndex = 6;
            this.deliveryBtn.Text = "Order";
            this.deliveryBtn.UseVisualStyleBackColor = true;
            this.deliveryBtn.Click += new System.EventHandler(this.deliveryBtn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(581, 187);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(694, 185);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 8;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(581, 272);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // productList
            // 
            this.productList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.product,
            this.delivery,
            this.mass,
            this.cost,
            this.date});
            this.productList.HideSelection = false;
            this.productList.Location = new System.Drawing.Point(15, 129);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(533, 277);
            this.productList.TabIndex = 10;
            this.productList.UseCompatibleStateImageBehavior = false;
            this.productList.View = System.Windows.Forms.View.Details;
            // 
            // category
            // 
            this.category.Text = "Catgory";
            this.category.Width = 75;
            // 
            // product
            // 
            this.product.Text = "Product";
            this.product.Width = 135;
            // 
            // delivery
            // 
            this.delivery.Text = "Delivery option";
            this.delivery.Width = 125;
            // 
            // mass
            // 
            this.mass.Text = "Mass";
            this.mass.Width = 62;
            // 
            // cost
            // 
            this.cost.Text = "Price";
            this.cost.Width = 72;
            // 
            // date
            // 
            this.date.Text = "Delivery date";
            this.date.Width = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Delivery options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price(Gucun neye catirsa)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MAss";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 437);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.deliveryBtn);
            this.Controls.Add(this.deliveryDate);
            this.Controls.Add(this.costValue);
            this.Controls.Add(this.deliveryBox);
            this.Controls.Add(this.massValue);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.categoryBox);
            this.Name = "Form1";
            this.Text = "Online Sifarish";
            ((System.ComponentModel.ISupportInitialize)(this.massValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ComboBox productBox;
        private System.Windows.Forms.NumericUpDown massValue;
        private System.Windows.Forms.ComboBox deliveryBox;
        private System.Windows.Forms.NumericUpDown costValue;
        private System.Windows.Forms.DateTimePicker deliveryDate;
        private System.Windows.Forms.Button deliveryBtn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ListView productList;
        private System.Windows.Forms.ColumnHeader category;
        private System.Windows.Forms.ColumnHeader product;
        private System.Windows.Forms.ColumnHeader delivery;
        private System.Windows.Forms.ColumnHeader mass;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

