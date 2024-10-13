//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab3POWinForms
//{
//    internal class AddClientForm
//    {
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public delegate void EPizzaNameChanged(int value);
    public delegate void EPizzaSizeChanged(int value);
    public delegate void EPizzaCountChanged(int value);
    public delegate void EPizzaIngredientChanged();


    internal class AddClientForm : Form
    {
        public static event EPizzaNameChanged NameNotify;
        public static event EPizzaSizeChanged SizeNotify;
        public static event EPizzaCountChanged CountNotify;
        public static event EPizzaIngredientChanged IngredientNotify;

        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label1;
        public PictureBox pictureBox1;
        public ComboBox comboBoxPizzasName;
        public NumericUpDown numericUpDown1;
        public ComboBox comboBoxPizzasSizes;
        public RichTextBox richTextBox1;
        public DataGridView dataGridView1;
        private Label label2;
        public TextBox textBoxPrice;
        public TextBox textBoxWeight;
        private Label label3;
        private DataGridViewTextBoxColumn Ingredients_Name;
        private DataGridViewCheckBoxColumn Include;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn weightingr;
        private DataGridViewTextBoxColumn IdIngr;
        private System.ComponentModel.IContainer components;
        public Button button1;

        //MyPizzaDeliveryContext dbContext/* = new PizzaDeliveryContext()*/;
        //private clients ncl;

        public AddClientForm(/*PizzaDeliveryContext dbContext, clients ncl*/)
        {
            InitializeComponent();
            //this.ncl = ncl;
            //this.dbContext = dbContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPizzasSizes = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPizzasName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ingredients_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Include = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightingr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdIngr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBoxPizzasSizes);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.comboBoxPizzasName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление пиццы в корзину";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(202, 205);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxPizzasSizes
            // 
            this.comboBoxPizzasSizes.FormattingEnabled = true;
            this.comboBoxPizzasSizes.Location = new System.Drawing.Point(202, 175);
            this.comboBoxPizzasSizes.Name = "comboBoxPizzasSizes";
            this.comboBoxPizzasSizes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPizzasSizes.TabIndex = 19;
            this.comboBoxPizzasSizes.SelectedIndexChanged += new System.EventHandler(this.comboBoxPizzasSizes_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(23, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(158, 105);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(202, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 106);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxPizzasName
            // 
            this.comboBoxPizzasName.FormattingEnabled = true;
            this.comboBoxPizzasName.Location = new System.Drawing.Point(138, 25);
            this.comboBoxPizzasName.Name = "comboBoxPizzasName";
            this.comboBoxPizzasName.Size = new System.Drawing.Size(185, 21);
            this.comboBoxPizzasName.TabIndex = 16;
            this.comboBoxPizzasName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPizzasName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Выберите количество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Выберите размер пиццы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название пиццы";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(255, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить в корзину";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ingredients_Name,
            this.Include,
            this.Price,
            this.weightingr,
            this.IdIngr});
            this.dataGridView1.Location = new System.Drawing.Point(14, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 232);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Ingredients_Name
            // 
            this.Ingredients_Name.DataPropertyName = "C_name";
            this.Ingredients_Name.HeaderText = "Ингредиент";
            this.Ingredients_Name.Name = "Ingredients_Name";
            this.Ingredients_Name.ReadOnly = true;
            // 
            // Include
            // 
            this.Include.DataPropertyName = "active";
            this.Include.HeaderText = "Включение";
            this.Include.Name = "Include";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // weightingr
            // 
            this.weightingr.DataPropertyName = "weight";
            this.weightingr.HeaderText = "Вес";
            this.weightingr.Name = "weightingr";
            this.weightingr.ReadOnly = true;
            this.weightingr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.weightingr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IdIngr
            // 
            this.IdIngr.DataPropertyName = "id";
            this.IdIngr.HeaderText = "Id";
            this.IdIngr.Name = "IdIngr";
            this.IdIngr.ReadOnly = true;
            this.IdIngr.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Цена";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(67, 507);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 8;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(67, 534);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeight.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вес";
            // 
            // AddClientForm
            // 
            this.ClientSize = new System.Drawing.Size(386, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddClientForm";
            this.Text = "Добавление пиццы в корзину";
            this.Load += new System.EventHandler(this.AddClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        private void button1_Click_1(object sender, EventArgs e)
        {

        }



        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }



        private void comboBoxPizzasName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (/*textBoxPrice.Text.Length > 0*/ comboBoxPizzasName.SelectedValue is int)
            {
                int index = (int)comboBoxPizzasName.SelectedValue;
                NameNotify(index);
            }
        }

        private void comboBoxPizzasSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPizzasSizes.SelectedValue is int)
            {
                int index = (int)comboBoxPizzasSizes.SelectedValue;
                SizeNotify(index);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int index = (int)numericUpDown1.Value;
            CountNotify(index);
        }

        private void dataGridView1_CellValueChanged(object sender, EventArgs e)
        {
            if (comboBoxPizzasName.SelectedValue is int)
                IngredientNotify();
        }
    }
}
