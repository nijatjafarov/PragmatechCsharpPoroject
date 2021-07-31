
namespace Task1
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.pizzaQuantity = new System.Windows.Forms.NumericUpDown();
            this.pizzaSize = new System.Windows.Forms.ComboBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.addToCardBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.listPizzas = new System.Windows.Forms.ListBox();
            this.listShopping = new System.Windows.Forms.ListBox();
            this.thin = new System.Windows.Forms.RadioButton();
            this.thick = new System.Windows.Forms.RadioButton();
            this.ingridientsGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pizzaQuantity)).BeginInit();
            this.ingridientsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizza Sifarishi";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Pendirli";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 17);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Sosisli";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 67);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(67, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Zeytunlu";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 91);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(70, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Gobelekli";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 114);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.Text = "Pul biberli";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(111, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(61, 17);
            this.checkBox6.TabIndex = 7;
            this.checkBox6.Text = "Soganli";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(111, 43);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "Yashil biber";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(111, 67);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(68, 17);
            this.checkBox8.TabIndex = 5;
            this.checkBox8.Text = "Kolbasali";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(111, 91);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(70, 17);
            this.checkBox9.TabIndex = 10;
            this.checkBox9.Text = "Toyuq eti";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(111, 114);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(98, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "Dana bastirmali";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // pizzaQuantity
            // 
            this.pizzaQuantity.Location = new System.Drawing.Point(15, 494);
            this.pizzaQuantity.Name = "pizzaQuantity";
            this.pizzaQuantity.Size = new System.Drawing.Size(120, 20);
            this.pizzaQuantity.TabIndex = 11;
            // 
            // pizzaSize
            // 
            this.pizzaSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaSize.FormattingEnabled = true;
            this.pizzaSize.Items.AddRange(new object[] {
            "Kicik",
            "Orta",
            "Boyuk",
            "Maxi"});
            this.pizzaSize.Location = new System.Drawing.Point(12, 62);
            this.pizzaSize.Name = "pizzaSize";
            this.pizzaSize.Size = new System.Drawing.Size(215, 21);
            this.pizzaSize.TabIndex = 13;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(152, 491);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 14;
            this.calculateBtn.Text = "Hesabla";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // addToCardBtn
            // 
            this.addToCardBtn.Location = new System.Drawing.Point(433, 492);
            this.addToCardBtn.Name = "addToCardBtn";
            this.addToCardBtn.Size = new System.Drawing.Size(104, 23);
            this.addToCardBtn.TabIndex = 15;
            this.addToCardBtn.Text = "Sebete elave et";
            this.addToCardBtn.UseVisualStyleBackColor = true;
            this.addToCardBtn.Click += new System.EventHandler(this.addToCardBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(679, 491);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(99, 23);
            this.buyBtn.TabIndex = 16;
            this.buyBtn.Text = "Sifarishi tesdiqle";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(316, 494);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(100, 20);
            this.quantity.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pizzanin Olchusu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pizza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Eded:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 496);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Miqdar:";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(630, 496);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(0, 13);
            this.price.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total Mebleg:";
            // 
            // listPizzas
            // 
            this.listPizzas.FormattingEnabled = true;
            this.listPizzas.Items.AddRange(new object[] {
            "Klassik",
            "Qarishiq",
            "Pendirli",
            "Kolbasali",
            "Italiano",
            "Mexicano"});
            this.listPizzas.Location = new System.Drawing.Point(13, 116);
            this.listPizzas.Name = "listPizzas";
            this.listPizzas.Size = new System.Drawing.Size(214, 147);
            this.listPizzas.TabIndex = 24;
            // 
            // listShopping
            // 
            this.listShopping.FormattingEnabled = true;
            this.listShopping.Location = new System.Drawing.Point(249, 62);
            this.listShopping.Name = "listShopping";
            this.listShopping.Size = new System.Drawing.Size(529, 394);
            this.listShopping.TabIndex = 25;
            // 
            // thin
            // 
            this.thin.AutoSize = true;
            this.thin.Checked = true;
            this.thin.Location = new System.Drawing.Point(15, 269);
            this.thin.Name = "thin";
            this.thin.Size = new System.Drawing.Size(80, 17);
            this.thin.TabIndex = 26;
            this.thin.TabStop = true;
            this.thin.Text = "Ince kenarli";
            this.thin.UseVisualStyleBackColor = true;
            // 
            // thick
            // 
            this.thick.AutoSize = true;
            this.thick.Location = new System.Drawing.Point(124, 269);
            this.thick.Name = "thick";
            this.thick.Size = new System.Drawing.Size(83, 17);
            this.thick.TabIndex = 27;
            this.thick.TabStop = true;
            this.thick.Text = "Qalin kenarli";
            this.thick.UseVisualStyleBackColor = true;
            // 
            // ingridientsGroup
            // 
            this.ingridientsGroup.Controls.Add(this.checkBox1);
            this.ingridientsGroup.Controls.Add(this.checkBox2);
            this.ingridientsGroup.Controls.Add(this.checkBox3);
            this.ingridientsGroup.Controls.Add(this.checkBox4);
            this.ingridientsGroup.Controls.Add(this.checkBox5);
            this.ingridientsGroup.Controls.Add(this.checkBox6);
            this.ingridientsGroup.Controls.Add(this.checkBox7);
            this.ingridientsGroup.Controls.Add(this.checkBox8);
            this.ingridientsGroup.Controls.Add(this.checkBox9);
            this.ingridientsGroup.Controls.Add(this.checkBox10);
            this.ingridientsGroup.Location = new System.Drawing.Point(15, 318);
            this.ingridientsGroup.Name = "ingridientsGroup";
            this.ingridientsGroup.Size = new System.Drawing.Size(212, 143);
            this.ingridientsGroup.TabIndex = 28;
            this.ingridientsGroup.TabStop = false;
            this.ingridientsGroup.Text = "Inqridientler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.ingridientsGroup);
            this.Controls.Add(this.thick);
            this.Controls.Add(this.thin);
            this.Controls.Add(this.listShopping);
            this.Controls.Add(this.listPizzas);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.addToCardBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.pizzaSize);
            this.Controls.Add(this.pizzaQuantity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pizzaQuantity)).EndInit();
            this.ingridientsGroup.ResumeLayout(false);
            this.ingridientsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.NumericUpDown pizzaQuantity;
        private System.Windows.Forms.ComboBox pizzaSize;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button addToCardBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listPizzas;
        private System.Windows.Forms.ListBox listShopping;
        private System.Windows.Forms.RadioButton thin;
        private System.Windows.Forms.RadioButton thick;
        private System.Windows.Forms.GroupBox ingridientsGroup;
    }
}

