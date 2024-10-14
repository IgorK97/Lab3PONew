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


namespace Lab3POWinForms
{
    public delegate void EPizzaNameChanged(int value);
    public delegate void EPizzaSizeChanged(int value);
    public delegate void EPizzaCountChanged(int value);
    public delegate void EPizzaIngredientChanged();


    public class AddClientForm : Form
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
        public BindingSource bindingSource1;
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            comboBoxPizzasSizes = new ComboBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            comboBoxPizzasName = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Ingredients_Name = new DataGridViewTextBoxColumn();
            Include = new DataGridViewCheckBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            weightingr = new DataGridViewTextBoxColumn();
            IdIngr = new DataGridViewTextBoxColumn();
            label2 = new Label();
            textBoxPrice = new TextBox();
            textBoxWeight = new TextBox();
            label3 = new Label();
            bindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(comboBoxPizzasSizes);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(comboBoxPizzasName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление пиццы в корзину";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(202, 205);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBoxPizzasSizes
            // 
            comboBoxPizzasSizes.FormattingEnabled = true;
            comboBoxPizzasSizes.Location = new Point(202, 175);
            comboBoxPizzasSizes.Name = "comboBoxPizzasSizes";
            comboBoxPizzasSizes.Size = new Size(121, 23);
            comboBoxPizzasSizes.TabIndex = 19;
            comboBoxPizzasSizes.SelectedIndexChanged += comboBoxPizzasSizes_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(23, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(158, 105);
            richTextBox1.TabIndex = 18;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(202, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 106);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // comboBoxPizzasName
            // 
            comboBoxPizzasName.FormattingEnabled = true;
            comboBoxPizzasName.Location = new Point(138, 25);
            comboBoxPizzasName.Name = "comboBoxPizzasName";
            comboBoxPizzasName.Size = new Size(185, 23);
            comboBoxPizzasName.TabIndex = 16;
            comboBoxPizzasName.SelectedIndexChanged += comboBoxPizzasName_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 213);
            label8.Name = "label8";
            label8.Size = new Size(128, 15);
            label8.TabIndex = 15;
            label8.Text = "Выберите количество";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 178);
            label7.Name = "label7";
            label7.Size = new Size(144, 15);
            label7.TabIndex = 14;
            label7.Text = "Выберите размер пиццы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 8;
            label1.Text = "Название пиццы";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(255, 537);
            button1.Name = "button1";
            button1.Size = new Size(119, 46);
            button1.TabIndex = 5;
            button1.Text = "Добавить в корзину";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Ingredients_Name, Include, Price, weightingr, IdIngr });
            dataGridView1.Location = new Point(14, 261);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(360, 232);
            dataGridView1.TabIndex = 6;
            dataGridView1.Click += dataGridView1_CellValueChanged;
            // 
            // Ingredients_Name
            // 
            Ingredients_Name.DataPropertyName = "C_name";
            Ingredients_Name.HeaderText = "Ингредиент";
            Ingredients_Name.Name = "Ingredients_Name";
            Ingredients_Name.ReadOnly = true;
            // 
            // Include
            // 
            Include.DataPropertyName = "active";
            Include.HeaderText = "Включение";
            Include.Name = "Include";
            // 
            // Price
            // 
            Price.DataPropertyName = "price";
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Resizable = DataGridViewTriState.True;
            Price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // weightingr
            // 
            weightingr.DataPropertyName = "weight";
            weightingr.HeaderText = "Вес";
            weightingr.Name = "weightingr";
            weightingr.ReadOnly = true;
            weightingr.Resizable = DataGridViewTriState.True;
            weightingr.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // IdIngr
            // 
            IdIngr.DataPropertyName = "id";
            IdIngr.HeaderText = "Id";
            IdIngr.Name = "IdIngr";
            IdIngr.ReadOnly = true;
            IdIngr.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 507);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Цена";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(67, 507);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 8;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(67, 534);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.ReadOnly = true;
            textBoxWeight.Size = new Size(100, 23);
            textBoxWeight.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 537);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 10;
            label3.Text = "Вес";
            // 
            // AddClientForm
            // 
            ClientSize = new Size(386, 592);
            Controls.Add(label3);
            Controls.Add(textBoxWeight);
            Controls.Add(textBoxPrice);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "AddClientForm";
            Text = "Добавление пиццы в корзину";
            Load += AddClientForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
