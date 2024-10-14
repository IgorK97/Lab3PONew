namespace Lab3POWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridViewOrderLines = new DataGridView();
            Id_OrderLine = new DataGridViewTextBoxColumn();
            OrdersId_OrderLine = new DataGridViewTextBoxColumn();
            pizzaId = new DataGridViewComboBoxColumn();
            CustomColumn = new DataGridViewCheckBoxColumn();
            PositionPrice = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            qu = new DataGridViewTextBoxColumn();
            Sizep = new DataGridViewComboBoxColumn();
            tabPage2 = new TabPage();
            button9 = new Button();
            dataGridViewOrders = new DataGridView();
            IdOrders = new DataGridViewTextBoxColumn();
            clientId_Orders = new DataGridViewTextBoxColumn();
            CourierId_Orders = new DataGridViewComboBoxColumn();
            final_price = new DataGridViewTextBoxColumn();
            addres_del = new DataGridViewTextBoxColumn();
            weight_orders = new DataGridViewTextBoxColumn();
            ordertime = new DataGridViewTextBoxColumn();
            deliverytime = new DataGridViewTextBoxColumn();
            delstatus = new DataGridViewComboBoxColumn();
            comment = new DataGridViewTextBoxColumn();
            managersId = new DataGridViewComboBoxColumn();
            tabPage3 = new TabPage();
            button10 = new Button();
            label1 = new Label();
            dataGridViewReport1 = new DataGridView();
            Idpizzas = new DataGridViewTextBoxColumn();
            NA = new DataGridViewTextBoxColumn();
            ND = new DataGridViewTextBoxColumn();
            button7 = new Button();
            button6 = new Button();
            comboBoxIngredients = new ComboBox();
            tabPage4 = new TabPage();
            label3 = new Label();
            label2 = new Label();
            button8 = new Button();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            dataGridViewReport2 = new DataGridView();
            bindingSourceOrderLines = new BindingSource(components);
            bindingSourceOrders = new BindingSource(components);
            NumberofOrder = new DataGridViewTextBoxColumn();
            KC = new DataGridViewTextBoxColumn();
            FC = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLines).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrderLines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrders).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(dataGridViewOrderLines);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Корзина";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 343);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 10;
            label6.Text = "Адрес доставки";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(118, 340);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 17);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Общий вес";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 16);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Общая цена";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(662, 11);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 11);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(311, 6);
            button4.Name = "button4";
            button4.Size = new Size(88, 35);
            button4.TabIndex = 4;
            button4.Text = "Заказать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(219, 6);
            button3.Name = "button3";
            button3.Size = new Size(86, 35);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 6);
            button2.Name = "button2";
            button2.Size = new Size(85, 37);
            button2.TabIndex = 2;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnUpdate_Click;
            // 
            // dataGridViewOrderLines
            // 
            dataGridViewOrderLines.AllowUserToAddRows = false;
            dataGridViewOrderLines.AllowUserToDeleteRows = false;
            dataGridViewOrderLines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderLines.Columns.AddRange(new DataGridViewColumn[] { Id_OrderLine, OrdersId_OrderLine, pizzaId, CustomColumn, PositionPrice, Weight, qu, Sizep });
            dataGridViewOrderLines.Location = new Point(6, 49);
            dataGridViewOrderLines.Name = "dataGridViewOrderLines";
            dataGridViewOrderLines.ReadOnly = true;
            dataGridViewOrderLines.Size = new Size(756, 263);
            dataGridViewOrderLines.TabIndex = 0;
            // 
            // Id_OrderLine
            // 
            Id_OrderLine.DataPropertyName = "id";
            Id_OrderLine.HeaderText = "Id";
            Id_OrderLine.Name = "Id_OrderLine";
            Id_OrderLine.ReadOnly = true;
            Id_OrderLine.Visible = false;
            // 
            // OrdersId_OrderLine
            // 
            OrdersId_OrderLine.DataPropertyName = "ordersId";
            OrdersId_OrderLine.HeaderText = "Номер заказа";
            OrdersId_OrderLine.Name = "OrdersId_OrderLine";
            OrdersId_OrderLine.ReadOnly = true;
            OrdersId_OrderLine.Visible = false;
            // 
            // pizzaId
            // 
            pizzaId.DataPropertyName = "pizzaId";
            pizzaId.HeaderText = "Пицца";
            pizzaId.Name = "pizzaId";
            pizzaId.ReadOnly = true;
            // 
            // CustomColumn
            // 
            CustomColumn.DataPropertyName = "custom";
            CustomColumn.HeaderText = "Пользовательская";
            CustomColumn.Name = "CustomColumn";
            CustomColumn.ReadOnly = true;
            // 
            // PositionPrice
            // 
            PositionPrice.DataPropertyName = "position_price";
            PositionPrice.HeaderText = "Цена";
            PositionPrice.Name = "PositionPrice";
            PositionPrice.ReadOnly = true;
            PositionPrice.Resizable = DataGridViewTriState.True;
            PositionPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Weight
            // 
            Weight.DataPropertyName = "weight";
            Weight.HeaderText = "Вес";
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // qu
            // 
            qu.DataPropertyName = "quantity";
            qu.HeaderText = "Количество";
            qu.Name = "qu";
            qu.ReadOnly = true;
            // 
            // Sizep
            // 
            Sizep.DataPropertyName = "pizza_sizesId";
            Sizep.HeaderText = "Размер";
            Sizep.Name = "Sizep";
            Sizep.ReadOnly = true;
            Sizep.Resizable = DataGridViewTriState.True;
            Sizep.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button9);
            tabPage2.Controls.Add(dataGridViewOrders);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Заказы";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(108, 6);
            button9.Name = "button9";
            button9.Size = new Size(108, 31);
            button9.TabIndex = 2;
            button9.Text = "Отменить заказ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { IdOrders, clientId_Orders, CourierId_Orders, final_price, addres_del, weight_orders, ordertime, deliverytime, delstatus, comment, managersId });
            dataGridViewOrders.Location = new Point(5, 43);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.Size = new Size(757, 349);
            dataGridViewOrders.TabIndex = 0;
            // 
            // IdOrders
            // 
            IdOrders.DataPropertyName = "id";
            IdOrders.HeaderText = "Номер заказа";
            IdOrders.Name = "IdOrders";
            IdOrders.ReadOnly = true;
            // 
            // clientId_Orders
            // 
            clientId_Orders.DataPropertyName = "clientId";
            clientId_Orders.HeaderText = "Клиент";
            clientId_Orders.Name = "clientId_Orders";
            clientId_Orders.ReadOnly = true;
            clientId_Orders.Visible = false;
            // 
            // CourierId_Orders
            // 
            CourierId_Orders.DataPropertyName = "courierId";
            CourierId_Orders.HeaderText = "Курьер";
            CourierId_Orders.Name = "CourierId_Orders";
            CourierId_Orders.ReadOnly = true;
            CourierId_Orders.Visible = false;
            // 
            // final_price
            // 
            final_price.DataPropertyName = "final_price";
            final_price.HeaderText = "Цена";
            final_price.Name = "final_price";
            final_price.ReadOnly = true;
            // 
            // addres_del
            // 
            addres_del.DataPropertyName = "address_del";
            addres_del.HeaderText = "Адрес";
            addres_del.Name = "addres_del";
            addres_del.ReadOnly = true;
            // 
            // weight_orders
            // 
            weight_orders.DataPropertyName = "weight";
            weight_orders.HeaderText = "Вес";
            weight_orders.Name = "weight_orders";
            weight_orders.ReadOnly = true;
            // 
            // ordertime
            // 
            ordertime.DataPropertyName = "ordertime";
            ordertime.HeaderText = "Время заказа";
            ordertime.Name = "ordertime";
            ordertime.ReadOnly = true;
            // 
            // deliverytime
            // 
            deliverytime.DataPropertyName = "deliverytime";
            deliverytime.HeaderText = "Время доставки";
            deliverytime.Name = "deliverytime";
            deliverytime.ReadOnly = true;
            // 
            // delstatus
            // 
            delstatus.DataPropertyName = "delstatusId";
            delstatus.HeaderText = "Статус";
            delstatus.Name = "delstatus";
            delstatus.ReadOnly = true;
            delstatus.Resizable = DataGridViewTriState.True;
            delstatus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // comment
            // 
            comment.DataPropertyName = "comment";
            comment.HeaderText = "Комментарий";
            comment.Name = "comment";
            comment.ReadOnly = true;
            // 
            // managersId
            // 
            managersId.DataPropertyName = "managersId";
            managersId.HeaderText = "Менеджер";
            managersId.Name = "managersId";
            managersId.ReadOnly = true;
            managersId.Resizable = DataGridViewTriState.True;
            managersId.SortMode = DataGridViewColumnSortMode.Automatic;
            managersId.Visible = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(dataGridViewReport1);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(comboBoxIngredients);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Пиццы";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(304, 11);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 5;
            button10.Text = "Найти все";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Ингредиент";
            // 
            // dataGridViewReport1
            // 
            dataGridViewReport1.AllowUserToAddRows = false;
            dataGridViewReport1.AllowUserToDeleteRows = false;
            dataGridViewReport1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport1.Columns.AddRange(new DataGridViewColumn[] { Idpizzas, NA, ND });
            dataGridViewReport1.Location = new Point(10, 48);
            dataGridViewReport1.Name = "dataGridViewReport1";
            dataGridViewReport1.ReadOnly = true;
            dataGridViewReport1.Size = new Size(752, 344);
            dataGridViewReport1.TabIndex = 3;
            // 
            // Idpizzas
            // 
            Idpizzas.DataPropertyName = "Id";
            Idpizzas.HeaderText = "Id";
            Idpizzas.Name = "Idpizzas";
            Idpizzas.ReadOnly = true;
            Idpizzas.Visible = false;
            // 
            // NA
            // 
            NA.DataPropertyName = "Name";
            NA.HeaderText = "Название";
            NA.Name = "NA";
            NA.ReadOnly = true;
            // 
            // ND
            // 
            ND.DataPropertyName = "Description";
            ND.HeaderText = "Описание";
            ND.Name = "ND";
            ND.ReadOnly = true;
            // 
            // button7
            // 
            button7.Location = new Point(409, 5);
            button7.Name = "button7";
            button7.Size = new Size(133, 36);
            button7.TabIndex = 2;
            button7.Text = "Добавить в корзину";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnAdd_Click;
            // 
            // button6
            // 
            button6.Location = new Point(223, 12);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 1;
            button6.Text = "Найти";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonGetReport1_Click;
            // 
            // comboBoxIngredients
            // 
            comboBoxIngredients.FormattingEnabled = true;
            comboBoxIngredients.Location = new Point(93, 12);
            comboBoxIngredients.Name = "comboBoxIngredients";
            comboBoxIngredients.Size = new Size(121, 23);
            comboBoxIngredients.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(numericUpDown2);
            tabPage4.Controls.Add(numericUpDown1);
            tabPage4.Controls.Add(dataGridViewReport2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Заказы за месяц";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 22);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 5;
            label3.Text = "Год";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Месяц";
            // 
            // button8
            // 
            button8.Location = new Point(392, 22);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 3;
            button8.Text = "Найти";
            button8.UseVisualStyleBackColor = true;
            button8.Click += buttonReport2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(242, 26);
            numericUpDown2.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 2;
            numericUpDown2.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(64, 22);
            numericUpDown1.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dataGridViewReport2
            // 
            dataGridViewReport2.AllowUserToAddRows = false;
            dataGridViewReport2.AllowUserToDeleteRows = false;
            dataGridViewReport2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport2.Columns.AddRange(new DataGridViewColumn[] { NumberofOrder, KC, FC });
            dataGridViewReport2.Location = new Point(4, 65);
            dataGridViewReport2.Name = "dataGridViewReport2";
            dataGridViewReport2.ReadOnly = true;
            dataGridViewReport2.Size = new Size(758, 327);
            dataGridViewReport2.TabIndex = 0;
            // 
            // NumberofOrder
            // 
            NumberofOrder.DataPropertyName = "order_id";
            NumberofOrder.HeaderText = "Номер заказа";
            NumberofOrder.Name = "NumberofOrder";
            NumberofOrder.ReadOnly = true;
            // 
            // KC
            // 
            KC.DataPropertyName = "courier_id";
            KC.HeaderText = "ФИО курьера";
            KC.Name = "KC";
            KC.ReadOnly = true;
            // 
            // FC
            // 
            FC.DataPropertyName = "Date";
            FC.HeaderText = "Дата заказа";
            FC.Name = "FC";
            FC.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderLines).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrderLines).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridViewOrderLines;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button4;
        private Button button3;
        private Button button2;
        private BindingSource bindingSourceOrderLines;
        private DataGridView dataGridViewOrders;
        private DataGridView dataGridViewReport1;
        private Button button7;
        private Button button6;
        private ComboBox comboBoxIngredients;
        private Button button8;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridViewReport2;
        private BindingSource bindingSourceOrders;
        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridViewTextBoxColumn Idpizzas;
        private DataGridViewTextBoxColumn NA;
        private DataGridViewTextBoxColumn ND;
        private DataGridViewTextBoxColumn Id_OrderLine;
        private DataGridViewTextBoxColumn OrdersId_OrderLine;
        private DataGridViewComboBoxColumn pizzaId;
        private DataGridViewCheckBoxColumn CustomColumn;
        private DataGridViewTextBoxColumn PositionPrice;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn qu;
        private DataGridViewComboBoxColumn Sizep;
        private Button button9;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button10;
        private Label label6;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn IdOrders;
        private DataGridViewTextBoxColumn clientId_Orders;
        private DataGridViewComboBoxColumn CourierId_Orders;
        private DataGridViewTextBoxColumn final_price;
        private DataGridViewTextBoxColumn addres_del;
        private DataGridViewTextBoxColumn weight_orders;
        private DataGridViewTextBoxColumn ordertime;
        private DataGridViewTextBoxColumn deliverytime;
        private DataGridViewComboBoxColumn delstatus;
        private DataGridViewTextBoxColumn comment;
        private DataGridViewComboBoxColumn managersId;
        private DataGridViewTextBoxColumn NumberofOrder;
        private DataGridViewTextBoxColumn KC;
        private DataGridViewTextBoxColumn FC;
    }
}
