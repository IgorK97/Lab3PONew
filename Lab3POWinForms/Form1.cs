using System.ComponentModel;
using System.Windows.Forms;
using BLL;
using BLL.Services;
using DAL;
using DTO;
//using Interfaces.Services;

namespace Lab3POWinForms
{
    public partial class Form1 : Form
    {
        OrderLinesService orderlinesService = new OrderLinesService();
        OrderService orderService = new OrderService();
        //ReportService reportService = new ReportService();
        int currentOrderId;
        int currentClientId;

        BindingList<IngredientShortDto> allingredients;
        List<OrderDto> allorders;
        List<OrderLineDto> allorderlines;
        List<PizzaSizesDto> allpizzasizes;
        List<PizzaDto> allpizzas;
        List<DelStatusDto> alldelstatus;
        List<CouriersDto> allcouriers;
        List<ManagerDto> allmanagers;

        AddClientForm f;
        //ORForm af;
        public Form1()
        {
            InitializeComponent();
            currentClientId = 3;

            AddClientForm.NameNotify += PizzaNameChanged;
            AddClientForm.SizeNotify += PizzaSizeChanged;
            AddClientForm.CountNotify += PizzaCountChanged;
            AddClientForm.IngredientNotify += PizzaIngredientChanged;


            loadData();

        }
        private void loadData()
        {
            allpizzas = orderlinesService.GetPizzas();
            allorders = orderService.GetAllOrders(currentClientId);

            allingredients = orderlinesService.GetIngredients(OrderLinesService.PizzaSize.Small);
            currentOrderId = orderService.GetCurrentOrder(currentClientId);

            allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
            alldelstatus = orderlinesService.GetDelStatuses();

            allpizzasizes = orderlinesService.GetPizzaSizes();
            allmanagers = orderService.GetAllManagers();
            allcouriers = orderService.GetAllCouriers();
            FillCourierCombobox();
            FillStatusCombobox();
            FillManagerCombobox();
            FillPizzaCombobox();
            FillReport1Combobox();
            FillSizesCombobox();
            bindingSourceOrders.DataSource = allorders;
            bindingSourceOrderLines.DataSource = allorderlines;
            dataGridViewOrderLines.DataSource = bindingSourceOrderLines;
            dataGridViewOrders.DataSource = bindingSourceOrders;
        }

        private void FillSizesCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["Sizep"]).DataSource =
                allpizzasizes;
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["Sizep"]).DisplayMember =
                "Name";
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["Sizep"]).ValueMember =
                "Id";
        }
        private void FillStatusCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatus"]).DataSource =
                alldelstatus;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatus"]).DisplayMember =
                "description";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["delstatus"]).ValueMember =
                "Id";
        }

        private void FillManagerCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["managersId"]).DataSource =
                allmanagers;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["managersId"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["managersId"]).ValueMember =
                "Id";
        }

        private void FillPizzaCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["pizzaId"]).DataSource =
                allpizzas;
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["pizzaId"]).DisplayMember =
                "C_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrderLines.Columns["pizzaId"]).ValueMember =
                "Id";
        }

        private void FillReport1Combobox()
        {
            comboBoxIngredients.DataSource = allingredients;
            comboBoxIngredients.DisplayMember = "C_name";
            comboBoxIngredients.ValueMember = "id";
        }

        private void FillCourierCombobox()
        {
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).DataSource =
                allcouriers;
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).DisplayMember =
                "first_name";
            ((DataGridViewComboBoxColumn)dataGridViewOrders.Columns["CourierId_Orders"]).ValueMember =
                "Id";
        }


        private void buttonSaveClients_Click(object sender, EventArgs e)
        {

            bool res = Validate();
            if (res)
            {
                //dbContext.clients.Load();
                ////dataGridViewClients.Refresh();
                //allClients = dbContext.clients.Local.ToList();
                //dataGridViewOrderLines.DataSource = null;
                //dataGridViewOrderLines.DataSource = allClients;
                //dataGridViewOrderLines.Refresh();

            }

        }

        private void buttonGetReport1_Click(object sender, EventArgs e)
        {
            dataGridViewReport1.DataSource = ReportService.ReportPizzas((int)comboBoxIngredients.SelectedValue);
        }



        private void buttonReport2_Click(object sender, EventArgs e)
        {
            dataGridViewReport2.DataSource = ReportService.ExecuteSP((int)numericUpDown1.Value, (int)numericUpDown2.Value, currentClientId);
        }
        private void buttonSaveOrders_Click(object sender, EventArgs e)
        {

            bool res = Validate();
            if (res)
            {
                //LoadCouriers();
                //LoadStatuses();
                //dataGridViewOrders.DataSource = null;
                //LoadOrders();
                //dataGridViewClients.DataSource = null;
                //dataGridViewClients.Refresh();

            }

        }

        public void PizzaNameChanged(int p_id)
        {
            PizzaDto p = allpizzas.Where(i => i.Id == p_id).FirstOrDefault();
            if (p != null)
            {
                f.pictureBox1.Image = ByteToImage(p.pizzaimage);
                f.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                f.richTextBox1.Text = p.description;

                f.comboBoxPizzasSizes.DataSource = allpizzasizes;
                f.comboBoxPizzasSizes.DisplayMember = "name";
                f.comboBoxPizzasSizes.ValueMember = "Id";
                f.comboBoxPizzasSizes.SelectedIndex = 0;

                //f.dataGridView1.DataSource = null;
                allingredients = orderlinesService.GetIngredients(OrderLinesService.PizzaSize.Small);
                f.dataGridView1.DataSource = allingredients;

                decimal count = f.numericUpDown1.Value;


                decimal p_price, p_weight/*, base_price, base_weight*/;
                OrderLinesService.PizzaSize ps;
                ps = (OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue;
                (p_price, p_weight) = orderlinesService.GetConcretePriceAndWeight(p.Id, ps, count);
                //(base_price, base_weight) = orderlinesService.GetBasePriceAndWeight(ps);
                //p_price += base_price;
                //p_weight += base_weight;

                f.textBoxPrice.Text = p_price.ToString();
                f.textBoxWeight.Text = p_weight.ToString();



            }
        }

        public void PizzaSizeChanged(int ps_id)
        {
            int p_id = (int)f.comboBoxPizzasName.SelectedValue;

            OrderLinesService.PizzaSize ps;

            ps = (OrderLinesService.PizzaSize)ps_id;

            //f.dataGridView1.DataSource = null;
            allingredients = orderlinesService.GetIngredients(ps);
            f.dataGridView1.DataSource = allingredients;

            decimal count = f.numericUpDown1.Value;


            decimal p_price, p_weight/*, base_price, base_weight*/;
            (p_price, p_weight) = orderlinesService.PriceAndWeightCalculation(allingredients, ps, p_id, count);/*orderlinesService.GetConcretePriceAndWeight(p_id, ps, count)*/;



            f.textBoxPrice.Text = p_price.ToString();
            f.textBoxWeight.Text = p_weight.ToString();


        }

        public void PizzaCountChanged(int pc_id)
        {
            decimal p_price, p_weight/*, base_price, base_weight*/;
            int p_id = (int)f.comboBoxPizzasName.SelectedValue;

            OrderLinesService.PizzaSize ps;
            ps = (OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue;
            decimal count = f.numericUpDown1.Value;

            //(p_price, p_weight) = orderlinesService.GetConcretePriceAndWeight(p_id, ps, pc_id);
            (p_price, p_weight) = orderlinesService.PriceAndWeightCalculation(allingredients, ps, p_id, count);/*orderlinesService.GetConcretePriceAndWeight(p_id, ps, count)*/;

            f.textBoxPrice.Text = p_price.ToString();
            f.textBoxWeight.Text = p_weight.ToString();
        }

        public void PizzaIngredientChanged()
        {
            int indexrow = getSelectedRow(f.dataGridView1);
            int add_id = (int)f.dataGridView1.Rows[indexrow].Cells[0].Value;
            decimal p_price, p_weight/*, base_price, base_weight*/;
            int p_id = (int)f.comboBoxPizzasName.SelectedValue;

            OrderLinesService.PizzaSize ps;
            ps = (OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue;
            decimal count = f.numericUpDown1.Value;

            //(p_price, p_weight) = orderlinesService.GetConcretePriceAndWeight(p_id, ps, pc_id);
            orderlinesService.ChangeAdditionalItems(allingredients, add_id);
            (p_price, p_weight) = orderlinesService.PriceAndWeightCalculation(allingredients, ps, p_id, count);/*orderlinesService.GetConcretePriceAndWeight(p_id, ps, count)*/;

            f.textBoxPrice.Text = p_price.ToString();
            f.textBoxWeight.Text = p_weight.ToString();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewReport1);
            if (index != -1)
            {
                int p_id = 0;
                bool converted = Int32.TryParse(dataGridViewReport1[0, index].Value.ToString(), out p_id);
                if (converted == false)
                    return;
                PizzaDto p = allpizzas.Where(i => i.Id == p_id).FirstOrDefault();
                if (p != null)
                {
                    f = new AddClientForm(/*dbContext, null*/);

                    f.comboBoxPizzasName.DataSource = allpizzas;
                    f.comboBoxPizzasName.DisplayMember = "C_name";
                    f.comboBoxPizzasName.ValueMember = "Id";
                    f.comboBoxPizzasName.SelectedValue = p.Id;

                    f.pictureBox1.Image = ByteToImage(p.pizzaimage);
                    f.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    f.richTextBox1.Text = p.description;

                    f.comboBoxPizzasSizes.DataSource = allpizzasizes;
                    f.comboBoxPizzasSizes.DisplayMember = "name";
                    f.comboBoxPizzasSizes.ValueMember = "Id";
                    f.comboBoxPizzasSizes.SelectedIndex = 0;

                    decimal count = f.numericUpDown1.Value;


                    f.dataGridView1.DataSource = allingredients;

                    decimal p_price, p_weight/*, base_price, base_weight*/;
                    OrderLinesService.PizzaSize ps;
                    ps = (OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue;
                    (p_price, p_weight) = orderlinesService.GetConcretePriceAndWeight(p.Id, ps, count);
                    //(base_price, base_weight) = orderlinesService.GetBasePriceAndWeight(ps);
                    //p_price += base_price;
                    //p_weight += base_weight;

                    f.textBoxPrice.Text = p_price.ToString();
                    f.textBoxWeight.Text = p_weight.ToString();

                    DialogResult result = f.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                        return;


                    //Дальше идет создание строки заказа

                    OrderLineDto orderLine = new OrderLineDto();
                    orderLine.ordersId = currentOrderId;
                    orderLine.pizzaId = (int)f.comboBoxPizzasName.SelectedValue;
                    orderLine.quantity = (int)f.numericUpDown1.Value;
                    orderLine.addedingredientsId = new List<int>();
                    double finalol_price;
                    //bool qe = Int32.TryParse(f.textBoxPrice.Text, out finalol_price);
                    finalol_price = Convert.ToDouble(f.textBoxPrice.Text);
                    orderLine.position_price = (decimal)finalol_price;

                    double finalol_weight;
                    finalol_weight = Convert.ToDouble(f.textBoxWeight.Text);

                    //Int32.TryParse(f.textBoxWeight.Text, out finalol_weight);

                    orderLine.weight = (decimal)finalol_weight;

                    orderLine.pizza_sizesId = (int)f.comboBoxPizzasSizes.SelectedValue;
                    bool cu = false;
                    for (int i = 0; i < f.dataGridView1.RowCount; i++)
                        if ((bool)f.dataGridView1.Rows[i].Cells[4].Value == true)
                        {
                            cu = true;
                            orderLine.addedingredientsId.Add((int)f.dataGridView1.Rows[i].Cells[0].Value);
                        }
                    orderLine.custom = cu;
                    orderlinesService.CreateOrderLine(orderLine);
                    allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
                    bindingSourceOrderLines.DataSource = allorderlines;
                    decimal price_res, weight_res;
                    (price_res, weight_res) = orderService.UpdateOrder(currentOrderId);
                    textBox1.Text = price_res.ToString();
                    textBox2.Text = weight_res.ToString();
                    FillSizesCombobox();
                    MessageBox.Show("Новый товар добавлен в корзину");
                }

            }
            else MessageBox.Show("Выберите пиццу, которую хотите поместить в корзину");


        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private int getSelectedRow(DataGridView dgv)
        {
            int index = -1;
            if (dgv.SelectedRows.Count > 0 || dgv.SelectedCells.Count == 1)
            {
                if (dgv.SelectedRows.Count > 0)
                    index = dgv.SelectedRows[0].Index;
                else index = dgv.SelectedCells[0].RowIndex;
            }
            return index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewOrderLines);
            if (index != -1)
            {
                int id = 0;
                bool converted = Int32.TryParse(dataGridViewOrderLines[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                //dbContext.clients.Remove(dbContext.clients.Find(id));
                //dbContext.SaveChanges();

                orderlinesService.DeleteOrderLine(id);
                bindingSourceOrderLines.DataSource = orderlinesService.GetAllOrderLines(currentOrderId);
                decimal price_res, weight_res;
                (price_res, weight_res) = orderService.UpdateOrder(currentOrderId);
                textBox1.Text = price_res.ToString();
                textBox2.Text = weight_res.ToString();
                MessageBox.Show("Товар из корзины удален");

                //dataGridViewClients.DataSource = null;
                //dataGridViewClients.DataSource = dbContext.clients;
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewOrderLines);
            if (index != -1)
            {
                int p_id = 0;
                bool converted = Int32.TryParse(dataGridViewOrderLines[0, index].Value.ToString(), out p_id);
                if (converted == false)
                    return;
                OrderLineDto? p = allorderlines.Where(i => i.Id == p_id).FirstOrDefault();
                if (p != null)
                {
                    f = new AddClientForm(/*dbContext, null*/);

                    PizzaDto? myp = allpizzas.Where(i => i.Id == p.pizzaId).FirstOrDefault();

                    f.comboBoxPizzasName.DataSource = allpizzas;
                    f.comboBoxPizzasName.DisplayMember = "C_name";
                    f.comboBoxPizzasName.ValueMember = "Id";
                    f.comboBoxPizzasName.SelectedValue = myp.Id;

                    f.pictureBox1.Image = ByteToImage(myp.pizzaimage);
                    f.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    f.richTextBox1.Text = myp.description;

                    f.comboBoxPizzasSizes.DataSource = allpizzasizes;
                    f.comboBoxPizzasSizes.DisplayMember = "name";
                    f.comboBoxPizzasSizes.ValueMember = "Id";
                    f.comboBoxPizzasSizes.SelectedValue = p.pizza_sizesId;

                    f.numericUpDown1.Value = p.quantity;

                    decimal count = f.numericUpDown1.Value;



                    allingredients = orderlinesService.GetConcreteIngredients((OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue, p.Id);
                    f.dataGridView1.DataSource = allingredients;
                    decimal p_price, p_weight/*, base_price, base_weight*/;
                    OrderLinesService.PizzaSize ps;
                    ps = (OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue;
                    (p_price, p_weight) = orderlinesService.GetConcretePriceAndWeight(p.pizzaId, ps, count);
                    //(base_price, base_weight) = orderlinesService.GetBasePriceAndWeight(ps);
                    //p_price += base_price;
                    //p_weight += base_weight;

                    f.textBoxPrice.Text = p_price.ToString();
                    f.textBoxWeight.Text = p_weight.ToString();

                    DialogResult result = f.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                        return;


                    //Дальше идет создание строки заказа

                    //OrderLineDto orderLine = new OrderLineDto();
                    //orderLine.ordersId = currentOrderId;
                    p.pizzaId = (int)f.comboBoxPizzasName.SelectedValue;
                    p.quantity = (int)f.numericUpDown1.Value;

                    double finalol_price;
                    finalol_price = Convert.ToDouble(f.textBoxPrice.Text);
                    //Int32.TryParse(f.textBoxPrice.Text, out finalol_price);

                    p.position_price = (decimal)finalol_price;

                    double finalol_weight;
                    //Int32.TryParse(f.textBoxWeight.Text, out finalol_weight);
                    finalol_weight = Convert.ToDouble(f.textBoxWeight.Text);

                    p.weight = (decimal)finalol_weight;

                    p.pizza_sizesId = (int)f.comboBoxPizzasSizes.SelectedValue;
                    bool cu = false;
                    for (int i = 0; i < f.dataGridView1.RowCount && !cu; i++)
                        if ((bool)f.dataGridView1.Rows[i].Cells[4].Value == true)
                            cu = true;
                    p.custom = cu;
                    orderlinesService.UpdateOrderLine(p);
                    allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
                    bindingSourceOrderLines.DataSource = allorderlines;
                    decimal price_res, weight_res;
                    (price_res, weight_res) = orderService.UpdateOrder(currentOrderId);
                    textBox1.Text = price_res.ToString();
                    textBox2.Text = weight_res.ToString();
                    //orderlinesService.CreateOrderLine(orderLine);
                    //allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
                    //bindingSourceOrderLines.DataSource = allorderlines;
                    MessageBox.Show("Товар в корзине обновлен");
                    FillSizesCombobox();
                }

            }
            else MessageBox.Show("Товар в корзине не был выбран");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string deladdress = textBox3.Text;
            if (orderService.SubmitOrder(currentOrderId, deladdress))
            {
                currentOrderId = orderService.GetCurrentOrder(currentClientId);
                allorders = orderService.GetAllOrders(currentClientId);
                bindingSourceOrders.DataSource = allorders;
                allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
                bindingSourceOrderLines.DataSource = allorderlines;
                textBox1.Text = "";
                textBox2.Text = "";
                MessageBox.Show("Заказ оформлен");

                FillCourierCombobox();
                FillStatusCombobox();
                FillManagerCombobox();
                FillPizzaCombobox();
                FillReport1Combobox();
                FillSizesCombobox();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridViewReport1.DataSource = ReportService.ReportPizzas(null);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewOrders);
            if (index != -1)
            {
                int p_id = 0;
                bool converted = Int32.TryParse(dataGridViewOrders.Rows[index].Cells[1].Value.ToString(), out p_id);
                if (converted == false)
                    return;
                orderService.CancelOrder(p_id);
                allorders = orderService.GetAllOrders(currentClientId);
                bindingSourceOrders.DataSource = allorders;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = getSelectedRow(dataGridViewOrders);
            if (index != -1)
            {
                int p_id = 0;
                bool converted = Int32.TryParse(dataGridViewReport1[0, index].Value.ToString(), out p_id);
                if (converted == false)
                    return;
                PizzaDto p = allpizzas.Where(i => i.Id == p_id).FirstOrDefault();
                if (p != null)
                {
                    f = new AddClientForm(/*dbContext, null*/);

                    f.comboBoxPizzasName.DataSource = allpizzas;
                    f.comboBoxPizzasName.DisplayMember = "C_name";
                    f.comboBoxPizzasName.ValueMember = "Id";
                    f.comboBoxPizzasName.SelectedValue = p.Id;

                    f.pictureBox1.Image = ByteToImage(p.pizzaimage);
                    f.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                    f.richTextBox1.Text = p.description;

                    f.comboBoxPizzasSizes.DataSource = allpizzasizes;
                    f.comboBoxPizzasSizes.DisplayMember = "name";
                    f.comboBoxPizzasSizes.ValueMember = "Id";
                    f.comboBoxPizzasSizes.SelectedIndex = 0;

                    decimal count = f.numericUpDown1.Value;


                    f.dataGridView1.DataSource = allingredients;

                    decimal p_price, p_weight/*, base_price, base_weight*/;
                    OrderLinesService.PizzaSize ps;
                    ps = (OrderLinesService.PizzaSize)f.comboBoxPizzasSizes.SelectedValue;
                    (p_price, p_weight) = orderlinesService.GetConcretePriceAndWeight(p.Id, ps, count);
                    //(base_price, base_weight) = orderlinesService.GetBasePriceAndWeight(ps);
                    //p_price += base_price;
                    //p_weight += base_weight;

                    f.textBoxPrice.Text = p_price.ToString();
                    f.textBoxWeight.Text = p_weight.ToString();

                    DialogResult result = f.ShowDialog(this);


                    if (result == DialogResult.Cancel)
                        return;


                    //Дальше идет создание строки заказа

                    OrderLineDto orderLine = new OrderLineDto();
                    orderLine.ordersId = currentOrderId;
                    orderLine.pizzaId = (int)f.comboBoxPizzasName.SelectedValue;
                    orderLine.quantity = (int)f.numericUpDown1.Value;
                    orderLine.addedingredientsId = new List<int>();
                    double finalol_price;
                    //bool qe = Int32.TryParse(f.textBoxPrice.Text, out finalol_price);
                    finalol_price = Convert.ToDouble(f.textBoxPrice.Text);
                    orderLine.position_price = (decimal)finalol_price;

                    double finalol_weight;
                    finalol_weight = Convert.ToDouble(f.textBoxWeight.Text);

                    //Int32.TryParse(f.textBoxWeight.Text, out finalol_weight);

                    orderLine.weight = (decimal)finalol_weight;

                    orderLine.pizza_sizesId = (int)f.comboBoxPizzasSizes.SelectedValue;
                    bool cu = false;
                    for (int i = 0; i < f.dataGridView1.RowCount; i++)
                        if ((bool)f.dataGridView1.Rows[i].Cells[4].Value == true)
                        {
                            cu = true;
                            orderLine.addedingredientsId.Add((int)f.dataGridView1.Rows[i].Cells[0].Value);
                        }
                    orderLine.custom = cu;
                    orderlinesService.CreateOrderLine(orderLine);
                    allorderlines = orderlinesService.GetAllOrderLines(currentOrderId);
                    bindingSourceOrderLines.DataSource = allorderlines;
                    decimal price_res, weight_res;
                    (price_res, weight_res) = orderService.UpdateOrder(currentOrderId);
                    textBox1.Text = price_res.ToString();
                    textBox2.Text = weight_res.ToString();
                    FillSizesCombobox();
                    MessageBox.Show("Новый товар добавлен в корзину");
                }

            }
            else MessageBox.Show("Выберите пиццу, которую хотите поместить в корзину");


        }
    }
}
