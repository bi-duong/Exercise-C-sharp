using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }
        private MemberObject member;
        private IOrderRepository orderRepository = new OrderRepository();
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private BindingSource source;

        public IOrderRepository OrderRepository { set => orderRepository = value; }
        public MemberObject Member { set => member = value; }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            orderDetailRepository.GetOrderDetailByID(0);
            var orders = orderRepository.GetAllOrders();
            if (!member.Admin) orders = orders.Where(order => order.MemberID == member.MemberID);
            LoadOrderList(orders);
            btnDetail.Text = "Update detail";
            if (!member.Admin)
            {
                btnDetail.Text = "View Detail";
                btnAdd.Visible= false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                grbReport.Visible = false;
            }
        }
        public void LoadOrderList(IEnumerable<OrderObject> orderList)
        {
            var orders = orderList;            
            try
            {
                source = new BindingSource();
                source.DataSource = orders;
                dvgData.DataSource = null;
                dvgData.DataSource = source;
                if (orders.Count() > 0)
                {
                    for (int i = 2; i < 5; i++)
                    {
                        dvgData.Columns[i].DefaultCellStyle.Format = " HH:mm:ss dd/MM/yyyy";
                    }
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDetail.Visible = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDetail.Visible = false;
                    dvgData.Visible = false;
                    MessageBox.Show("No order history.", "Order Management",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddOrder addOrderForm = new frmAddOrder
            {
                OrderRepository = orderRepository,
                InsertOrUpdate = true
            };
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList(orderRepository.GetAllOrders());
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OrderObject order = dvgData.CurrentRow.DataBoundItem as OrderObject;
            frmAddOrder updateOrderForm = new frmAddOrder
            {              
                OrderRepository = orderRepository,
                InsertOrUpdate = false,
                OrderInfo = order 
            };
            if (updateOrderForm.ShowDialog() == DialogResult.OK)
            {
                int index = dvgData.CurrentRow.Index;
                LoadOrderList(orderRepository.GetAllOrders());
                source.Position = index;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OrderObject order = dvgData.CurrentRow.DataBoundItem as OrderObject;
            DialogResult d = MessageBox.Show("Do you really want to remove this order ?", "Order Management - Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                orderDetailRepository.RemoveAllDetail(order.OrderID);
                orderRepository.RemoveOrder(order.OrderID);
                LoadOrderList(orderRepository.GetAllOrders());
            }
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            OrderObject order = dvgData.CurrentRow.DataBoundItem as OrderObject;
            frmOrderDetail orderDetailForm = new frmOrderDetail
            {
                Order = order,
                IsAdmin = member.Admin,
                OrderDetails = orderDetailRepository.GetOrderDetailByID(order.OrderID).ToList()
            };
            if (orderDetailForm.ShowDialog() == DialogResult.OK)
            {
                int index = dvgData.CurrentRow.Index;
                List<OrderDetailObject> orderDetails = orderDetailForm.OrderDetails;
                orderDetailRepository.RemoveAllDetail(order.OrderID);
                foreach (OrderDetailObject orderDetail in orderDetails)
                {
                    orderDetailRepository.AddOrderDetail(orderDetail);
                }
                LoadOrderList(orderRepository.GetAllOrders());
                source.Position = index;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            frmSales report = new frmSales
            {
                StartDate = startDatePicker.Value,
                EndDate = endDatePicker.Value,
                OrderRepository = orderRepository,
                DetailRepository = orderDetailRepository
            };
            if (report.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
