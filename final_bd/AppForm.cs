using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_bd
{
    
   
    


public partial class AppForm : Form
    {
        private restaurantEntities res_db = new restaurantEntities();
        private BindingList<TblOrders> open_orders_binding_list = new BindingList<TblOrders>();
        private BindingList<OrderItem> order_items_binding_list = new BindingList<OrderItem>();
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        bool show_menuPanel = false;
        bool show_ordersPanel = false;
        bool show_billingPanel = false;
        List<int> guest_count_list = new List<int>();


        List<Button> table_buttons = new List<Button>();
        TblTables current_table=new TblTables();
        TblOrders current_open_order = new TblOrders();
        TblEmployees currentEmployee = new TblEmployees();
        public AppForm(TblEmployees loggedEmployee)
        {
            
            
            currentEmployee = loggedEmployee;
            
            InitializeComponent();
            MainPanel.BringToFront();
            MenuBarPanel.BringToFront();
           
            TablesButton.Hide();
            TableLabel.Hide();
            OrdersButton.Hide();
            OrderNrLabel.Hide();

            table_buttons.Add(Table1Button);
            table_buttons.Add(Table2Button);
            table_buttons.Add(Table3Button);
            table_buttons.Add(Table4Button);
            table_buttons.Add(Table5Button);
            table_buttons.Add(Table6Button);
            table_buttons.Add(Table7Button);
            table_buttons.Add(Table8Button);
            table_buttons.Add(Table9Button);
            table_buttons.Add(BarButton);
            UpdateTableButtons();
            for(int i=1;i<31;i++)
            {
                guest_count_list.Add(i);
            }
            GuestCountListBox.DataSource = guest_count_list;
            OrdersListBox.DataSource = open_orders_binding_list;
            OrderItemsListBox.DataSource = order_items_binding_list;
            OrderItemsListBox.DisplayMember = "Description";
            OrdersListBox.DisplayMember = "Table";
            CreateProductsTabbedPanel();
            AddItemsToProductsTabbedPanel();
        }

        private void AddItemsToProductsTabbedPanel()
        {
            int i = 0;
            foreach (TabPage tp in ProductsTabControl.TabPages)
            {
                var products_by_type_query = res_db.TblProducts.Where(x=>x.ProductType==i);
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                foreach (TblProducts product in products_by_type_query)
                {
                    Button prod_button = new Button();

                    prod_button.Size = new Size(161, 145);
                    prod_button.Font = new Font(prod_button.Font.FontFamily, 8);
                    prod_button.FlatStyle = FlatStyle.Flat;
                    prod_button.FlatAppearance.BorderColor = Color.Black;
                    prod_button.BackColor = Color.Gray;
                    prod_button.ForeColor = Color.Black;
                    prod_button.Text = product.Description;
                    prod_button.TextAlign = ContentAlignment.BottomCenter;
                    prod_button.Tag = product;
                    prod_button.Click += new EventHandler(AddProductToCurrentOrder);
                    flp.Controls.Add(prod_button);
                    flp.BackColor = Color.White;
                }
                tp.AutoScroll = true;
                tp.Controls.Add(flp);
                i++;
            }

        }

        private void AddProductToCurrentOrder(object sender ,EventArgs e)
        {
            Button product_button = (Button)sender;

            TblProducts product = (TblProducts)product_button.Tag;

            TblOrderItems multiple_product = res_db.TblOrderItems.FirstOrDefault(x => x.OrderID == current_open_order.OrderID && x.ProductID==product.ProductID);




            if (multiple_product==null)
            {
                TblOrderItems item = new TblOrderItems()
                {
                    OrderID = current_open_order.OrderID,
                    ProductID = product.ProductID,
                    ItemState = "Ready",
                    Quantity = 1
                };
                res_db.TblOrderItems.Add(item);
                res_db.SaveChanges();
            }
            else
            {
               
                multiple_product.OrderID = current_open_order.OrderID;
                multiple_product.Quantity+=1;
                res_db.Entry(multiple_product).State = System.Data.Entity.EntityState.Modified;
                res_db.SaveChanges();
            }
            UpdateCurrentOrderItems();



        }

        private void CreateProductsTabbedPanel()
        {
            var product_types_query = (from pt in res_db.TblProductTypes            
                                       select pt);
            foreach (var type in product_types_query)
            {
                ProductsTabControl.TabPages.Add(type.ProductType.ToString(), type.Description.ToString());
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MainPanel.BringToFront();


        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 650;
                mouseY = MousePosition.Y - 35;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void MenuBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MenuBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void MainPanel_MouseClick(object sender, MouseEventArgs e)
        {

            MainPanel.BringToFront();
            show_menuPanel = false;
           
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

            if (show_menuPanel == false)
            {

                MenuPanel.BringToFront();
                show_menuPanel = true;
            }
            else
            {
                MenuPanel.SendToBack();
                show_menuPanel = false;
            }
        }

        private void OrdersListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string currentTable = ((TblOrders)e.ListItem).TableID.ToString();
            string currentOrder= ((TblOrders)e.ListItem).OrderID.ToString();

            e.Value = currentTable + " (№" + currentOrder + "):";
        }

        private void OrderItemsListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            double SubTotal = (double)((OrderItem)e.ListItem).Price * ((OrderItem)e.ListItem).Quantity;
            double Price = (double)((OrderItem)e.ListItem).Price;
            string currentDescription = ((OrderItem)e.ListItem).Description.PadRight(28);
            string currentQuantity = ((OrderItem)e.ListItem).Quantity.ToString().PadRight(8);
            string currentPrice =string.Format("{0:0.00}",Price).PadRight(8);
            string currentSubTotal = string.Format("{0:0.00}",SubTotal);
           
            e.Value = currentDescription + currentQuantity + currentPrice + currentSubTotal;
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
           
            Button table_button = (Button)sender;
            current_table.TableID = Int32.Parse(table_button.Text);



            UpdateCurrentTableOpenOrders();

                if (open_orders_binding_list.Count != 0)
                {
                    current_open_order = (TblOrders)OrdersListBox.SelectedItem;
                    OrderNrLabel.Text = "#" + current_open_order.OrderID.ToString();
                    UpdateCurrentOrderItems();                    
                    BillingPanel.BringToFront();
                    TablesButton.Show();
                    OrdersButton.Show();
                    TableLabel.Show();
                    OrderNrLabel.Show();
                    OrderNrLabel.BringToFront();
                    show_billingPanel = true ;

            }
                else
                {
                    GuestCountPanel.BringToFront();
                  
                }
            
           
            
        }

        private void UpdateCurrentTableOpenOrders()
        {
            var query = res_db.TblOrders.Where(s => s.TableID == current_table.TableID);
            open_orders_binding_list.Clear();
            foreach (var order in query)
            {
                open_orders_binding_list.Add(order);
            }
        }

        private void UpdateCurrentOrderItems()
        {
            
            var query = res_db.OrderItem.Where(s => s.OrderID == current_open_order.OrderID);
            order_items_binding_list.Clear();
            foreach (var item in query)
            {
                order_items_binding_list.Add(item);
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            GuestCountPanel.BringToFront();
        }

        private void GuestCountPanelCloseButton_Click(object sender, EventArgs e)
        {
            GuestCountPanel.SendToBack();
        }  

        private void TablesButton_Click(object sender, EventArgs e)
        {
            show_billingPanel = false;
            show_ordersPanel = false;
            TablesButton.Hide();
            OrdersButton.Hide();
            OrderNrLabel.Hide();
            TableLabel.Hide();
            UpdateTableButtons();
            MainPanel.BringToFront();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            if (show_ordersPanel == false)
            {
                OrdersPanel.BringToFront();
                show_ordersPanel = true;
            }
            else
            {
                OrdersPanel.SendToBack();
                GuestCountPanel.SendToBack();
                show_ordersPanel = false;
            }
        }

        private void GuestCountListBox_Click(object sender, EventArgs e)
        {
           
            TblOrders newOrder = new TblOrders { Guests = (int)GuestCountListBox.SelectedItem, TableID = current_table.TableID, EmployeeID = currentEmployee.EmployeeID, OrderState = "Open", Datetime = DateTime.Now };
            res_db.TblOrders.Add(newOrder);
            res_db.SaveChanges();


            UpdateCurrentTableOpenOrders();
            OrdersListBox.SelectedItem = open_orders_binding_list[open_orders_binding_list.Count-1];
            order_items_binding_list.Clear();

            current_open_order = (TblOrders)OrdersListBox.SelectedItem;
            OrderNrLabel.Text = "#" + current_open_order.OrderID.ToString();
            if (show_billingPanel == false)
            {
                TablesButton.Show();
                OrdersButton.Show();
                TableLabel.Show();
                OrderNrLabel.Show();
                OrderNrLabel.BringToFront();
                show_billingPanel = true;
            }
            BillingPanel.BringToFront();
            show_ordersPanel = false;
        }

        private void OrdersListBox_Click(object sender, EventArgs e)
        {
            if (open_orders_binding_list.Count == 0) return;
            current_open_order = (TblOrders)OrdersListBox.SelectedItem;
            OrderNrLabel.Text = "#" + current_open_order.OrderID.ToString();
            UpdateCurrentOrderItems();
        }

        private void BillingPanel_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductsTabControl_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateTableButtons()
        {
            foreach (Button table_button in table_buttons)
            {
                current_table.TableID = Int32.Parse(table_button.Text);
                UpdateCurrentTableOpenOrders();

                if (open_orders_binding_list.Count != 0)
                    table_button.BackColor = Color.DodgerBlue;

            }
        }
    }
}
