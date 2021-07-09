
namespace Task6
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
            this.markaQutusu = new System.Windows.Forms.ComboBox();
            this.modelQutusu = new System.Windows.Forms.ComboBox();
            this.yanacaqQutusu = new System.Windows.Forms.ComboBox();
            this.banQutusu = new System.Windows.Forms.ComboBox();
            this.suretQutusu = new System.Windows.Forms.ComboBox();
            this.ilSecimi = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.marka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yanacaq = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.suret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.il = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.elaveEt = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rengBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markaQutusu
            // 
            this.markaQutusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markaQutusu.FormattingEnabled = true;
            this.markaQutusu.Items.AddRange(new object[] {
            "Masin1",
            "Masin2",
            "Masin3"});
            this.markaQutusu.Location = new System.Drawing.Point(48, 37);
            this.markaQutusu.Name = "markaQutusu";
            this.markaQutusu.Size = new System.Drawing.Size(121, 21);
            this.markaQutusu.TabIndex = 0;
            this.markaQutusu.SelectedIndexChanged += new System.EventHandler(this.markaQutusu_SelectedIndexChanged);
            // 
            // modelQutusu
            // 
            this.modelQutusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelQutusu.FormattingEnabled = true;
            this.modelQutusu.Location = new System.Drawing.Point(191, 37);
            this.modelQutusu.Name = "modelQutusu";
            this.modelQutusu.Size = new System.Drawing.Size(121, 21);
            this.modelQutusu.TabIndex = 1;
            // 
            // yanacaqQutusu
            // 
            this.yanacaqQutusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yanacaqQutusu.FormattingEnabled = true;
            this.yanacaqQutusu.Items.AddRange(new object[] {
            "Benzin",
            "Dizel"});
            this.yanacaqQutusu.Location = new System.Drawing.Point(333, 37);
            this.yanacaqQutusu.Name = "yanacaqQutusu";
            this.yanacaqQutusu.Size = new System.Drawing.Size(121, 21);
            this.yanacaqQutusu.TabIndex = 3;
            // 
            // banQutusu
            // 
            this.banQutusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banQutusu.FormattingEnabled = true;
            this.banQutusu.Items.AddRange(new object[] {
            "Minivan",
            "SUV",
            "Sedan"});
            this.banQutusu.Location = new System.Drawing.Point(476, 37);
            this.banQutusu.Name = "banQutusu";
            this.banQutusu.Size = new System.Drawing.Size(121, 21);
            this.banQutusu.TabIndex = 2;
            // 
            // suretQutusu
            // 
            this.suretQutusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suretQutusu.FormattingEnabled = true;
            this.suretQutusu.Items.AddRange(new object[] {
            "Avtomatik",
            "Mexaniki"});
            this.suretQutusu.Location = new System.Drawing.Point(622, 37);
            this.suretQutusu.Name = "suretQutusu";
            this.suretQutusu.Size = new System.Drawing.Size(121, 21);
            this.suretQutusu.TabIndex = 4;
            // 
            // ilSecimi
            // 
            this.ilSecimi.Location = new System.Drawing.Point(543, 117);
            this.ilSecimi.Name = "ilSecimi";
            this.ilSecimi.Size = new System.Drawing.Size(200, 20);
            this.ilSecimi.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.marka,
            this.model,
            this.yanacaq,
            this.ban,
            this.suret,
            this.il,
            this.reng});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(48, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 294);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // marka
            // 
            this.marka.Text = "Marka";
            // 
            // model
            // 
            this.model.Text = "Model";
            // 
            // yanacaq
            // 
            this.yanacaq.Text = "Yanacaq novu";
            // 
            // ban
            // 
            this.ban.Text = "Ban novu";
            // 
            // suret
            // 
            this.suret.Text = "Suret qutusu";
            this.suret.Width = 74;
            // 
            // il
            // 
            this.il.Text = "Buraxilis ili";
            // 
            // reng
            // 
            this.reng.Text = "Reng";
            // 
            // elaveEt
            // 
            this.elaveEt.Location = new System.Drawing.Point(668, 211);
            this.elaveEt.Name = "elaveEt";
            this.elaveEt.Size = new System.Drawing.Size(75, 23);
            this.elaveEt.TabIndex = 7;
            this.elaveEt.Text = "Elave Et";
            this.elaveEt.UseVisualStyleBackColor = true;
            this.elaveEt.Click += new System.EventHandler(this.elaveEt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yanacaq novu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ban novu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(619, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Suret qutusu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Buraxilis ili";
            // 
            // rengBtn
            // 
            this.rengBtn.Location = new System.Drawing.Point(668, 164);
            this.rengBtn.Name = "rengBtn";
            this.rengBtn.Size = new System.Drawing.Size(75, 23);
            this.rengBtn.TabIndex = 14;
            this.rengBtn.Text = "Reng Sec";
            this.rengBtn.UseVisualStyleBackColor = true;
            this.rengBtn.Click += new System.EventHandler(this.rengBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rengBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elaveEt);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ilSecimi);
            this.Controls.Add(this.suretQutusu);
            this.Controls.Add(this.yanacaqQutusu);
            this.Controls.Add(this.banQutusu);
            this.Controls.Add(this.modelQutusu);
            this.Controls.Add(this.markaQutusu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox markaQutusu;
        private System.Windows.Forms.ComboBox modelQutusu;
        private System.Windows.Forms.ComboBox yanacaqQutusu;
        private System.Windows.Forms.ComboBox banQutusu;
        private System.Windows.Forms.ComboBox suretQutusu;
        private System.Windows.Forms.DateTimePicker ilSecimi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader marka;
        private System.Windows.Forms.ColumnHeader model;
        private System.Windows.Forms.ColumnHeader yanacaq;
        private System.Windows.Forms.ColumnHeader ban;
        private System.Windows.Forms.ColumnHeader suret;
        private System.Windows.Forms.ColumnHeader il;
        private System.Windows.Forms.Button elaveEt;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button rengBtn;
        private System.Windows.Forms.ColumnHeader reng;
    }
}

