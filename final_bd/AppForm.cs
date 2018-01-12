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
    
    public struct OpenOrder
    {
       public string Table;
       public int OrderID;

       public OpenOrder(string Table,int OrderID)
        {
            this.Table = Table;
            this.OrderID = OrderID;
        }
    }
    public struct OrderItem
    {
        public string Description;
        public int OrderID;
        public int OrderItemID;
        public string ItemState;

        public OrderItem(string Description,int OrderID,int OrderItemID,string ItemState)
        {
            this.Description = Description;
            this.OrderID = OrderID;
            this.OrderItemID = OrderItemID;
            this.ItemState = ItemState;
        }
    }


public partial class AppForm : Form
    {
        private restaurantEntities res_db = new restaurantEntities();
        private BindingList<OpenOrder> open_orders_binding_list = new BindingList<OpenOrder>();
        private BindingList<OrderItem> order_items_binding_list = new BindingList<OrderItem>();
        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        bool menu = true;
        

        public AppForm()
        {

            InitializeComponent();
            MainPanel.BringToFront();
            MenuBarPanel.BringToFront();
            OrdersListBox.DataSource = open_orders_binding_list;
            OrderItemsListBox.DataSource = order_items_binding_list;
            OrderItemsListBox.DisplayMember = "Description";
            OrdersListBox.DisplayMember = "Table";
        }


        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.BringToFront();


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
            menu = true;

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {

            if (menu == true)
            {

                MenuPanel.BringToFront();
                menu = false;
            }
            else
            {
                MenuPanel.SendToBack();
                menu = true;
            }
        }

        private void OrderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrdersListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string currentTable = ((OpenOrder)e.ListItem).Table;
            string currentOrder= ((OpenOrder)e.ListItem).OrderID.ToString();

            e.Value = currentTable + " (№" + currentOrder + "):";
        }

        private void OrderItemsListBox_Format(object sender, ListControlConvertEventArgs e)
        {
            

            string currentDescription = ((OrderItem)e.ListItem).Description;
            string currentState = ((OrderItem)e.ListItem).ItemState;
            string currentDescriptionPadded = currentDescription.PadRight(30,' ');
            e.Value = currentDescriptionPadded + currentState;
        }

        private void OrdersListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (OrdersListBox.Items.Count == 0) return;
            OpenOrder current_open_order = (OpenOrder)OrdersListBox.SelectedItem;

            var order_items_query = (from orders in res_db.TblOrders
                                     join order_items in res_db.TblOrderItems on orders.OrderID equals order_items.OrderID
                                     join products in res_db.TblProducts on order_items.ProductID equals products.ProductID
                                     where orders.OrderState.Equals("Open")
                                     where orders.OrderID.Equals(current_open_order.OrderID)
                                     select new
                                     {
                                         Description = products.Description,
                                         OrderID = orders.OrderID,
                                         OrderItemID = order_items.OrderItemID,
                                         ItemState = order_items.ItemState
                                     });

            order_items_binding_list.Clear();
            foreach (var order_item in order_items_query)
            {
                order_items_binding_list.Add(new OrderItem(order_item.Description, order_item.OrderID, order_item.OrderItemID, order_item.ItemState));
            }

           
            
        }

        

        

        void MasaButton_Click(object sender, EventArgs e)
        {
            Button table_button = (Button)sender;

            var open_orders_query = (from orders in res_db.TblOrders
                                     join tables in res_db.TblTables on orders.TableID equals tables.TableID
                                     where orders.OrderState.Equals("Open")
                                     where tables.Details.Equals(table_button.Text)
                                     select new
                                     {
                                         Table = tables.Details,
                                         OrderID = orders.OrderID
                                     });


            open_orders_binding_list.Clear();
            
            foreach (var order in open_orders_query)
            {
                open_orders_binding_list.Add(new OpenOrder(order.Table, order.OrderID));
            }
            if(open_orders_binding_list.Count!=0)
            {
                OpenOrder current_open_order = (OpenOrder)OrdersListBox.SelectedItem;

                var order_items_query = (from orders in res_db.TblOrders
                                         join order_items in res_db.TblOrderItems on orders.OrderID equals order_items.OrderID
                                         join products in res_db.TblProducts on order_items.ProductID equals products.ProductID
                                         where orders.OrderState.Equals("Open")
                                         where orders.OrderID.Equals(current_open_order.OrderID)
                                         select new
                                         {
                                             Description = products.Description,
                                             OrderID = orders.OrderID,
                                             OrderItemID = order_items.OrderItemID,
                                             ItemState = order_items.ItemState
                                         });

                order_items_binding_list.Clear();
                foreach (var order_item in order_items_query)
                {
                    order_items_binding_list.Add(new OrderItem(order_item.Description, order_item.OrderID, order_item.OrderItemID, order_item.ItemState));
                }
            }
            else
            {
                order_items_binding_list.Clear();
            }




            OrdersPanel.BringToFront();


        }


    }
}
