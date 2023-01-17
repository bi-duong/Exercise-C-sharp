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
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        private IOrderRepository orderRepository;
        private IOrderDetailRepository detailRepository;
        private DateTime startDate;
        private DateTime endDate;
        private List<DateSales> report = new List<DateSales>();
        private BindingSource source;
        public IOrderRepository OrderRepository { set => orderRepository = value; }
        public IOrderDetailRepository DetailRepository { set => detailRepository = value; }
        public DateTime StartDate { set => startDate = value; }
        public DateTime EndDate { set => endDate = value; }

        private void frmSales_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadReport();
        }
        private void LoadReport()
        {          
            try
            {
                source = new BindingSource();
                source.DataSource = report;
                dvgData.DataSource = null;
                dvgData.DataSource = source;
                if (report.Count() == 0)
                {               
                    MessageBox.Show("No order history.", "Order Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dvgData.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Order list");
            }
        }
        private void LoadData()
        {
            for (DateTime date = startDate.Date; date <= endDate.Date; date= date.AddDays(1))
            {
                IEnumerable<OrderObject> ordersInDate = orderRepository.GetAllOrders().Where(order => order.OrderDate.Date.Equals(date));
                int orderCount = ordersInDate.Count();
                Decimal totalInDate = 0;
                if (orderCount > 0)
                {
                    foreach (var order in ordersInDate)
                    {
                        IEnumerable<OrderDetailObject> orderDetail = detailRepository.GetOrderDetailByID(order.OrderID);
                        Decimal orderTotal = 0;
                        foreach (var detail in orderDetail)
                        {
                            Decimal productTotal = detail.UnitPrice * detail.Quantity - (Decimal)detail.Discount;
                            orderTotal += productTotal;
                        }
                        totalInDate += orderTotal;
                    }
                }
                DateSales salesOfDate = new DateSales
                {
                    Date = date,
                    Total = totalInDate,
                    OrderCount = orderCount,
                };
                report.Add(salesOfDate);
            }
            report = report.OrderByDescending(dateReport => dateReport.Total).ToList();
        }
    }
}
