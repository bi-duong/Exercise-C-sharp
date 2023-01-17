using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmAddOrder : Form
    {
        public frmAddOrder()
        {
            InitializeComponent();
        }
        private IMemberRepository memberRepository = new MemberRepository();
        private IOrderRepository orderRepository;
        private IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        private bool insertOrUpdate;
        private OrderObject orderInfo;
        public IOrderRepository OrderRepository { set => orderRepository = value; }
        public bool InsertOrUpdate { set => insertOrUpdate = value; }
        public OrderObject OrderInfo { set => orderInfo = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderObject order = new OrderObject
            {
                OrderID = int.Parse(txtOrderID.Text),
                MemberID = int.Parse(txtMemberID.Text),
                OrderDate = orderDatePicker.Value,
                RequiredDate = requiredDatePicker.Value,
                ShippedDate = shippedDatePicker.Value,
                Freight = Decimal.Parse(txtFreight.Text)
            };
            if (validateID())
            {
                if (insertOrUpdate)
                {
                    frmOrderDetail frmOrderDetail = new frmOrderDetail
                    {
                        Order = order,
                        OrderDetails = new List<OrderDetailObject>(),
                        IsAdmin = true
                    };
                    if (frmOrderDetail.ShowDialog() == DialogResult.OK)
                    {
                        orderRepository.AddOrder(order);
                        IEnumerable<OrderDetailObject> orderDetails = frmOrderDetail.OrderDetails;
                        foreach (OrderDetailObject orderDetail in orderDetails)
                        {
                            orderDetailRepository.AddOrderDetail(orderDetail);                            
                        }
                        DialogResult = DialogResult.OK;
                    }
                    else {
                        DialogResult = DialogResult.Cancel;
                    }
                } else
                {
                    orderRepository.UpdateOrder(order);
                    DialogResult = DialogResult.OK;
                } 
            } else
            {
                MessageBox.Show("MemberID not existed", "Add New Order - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberID.Clear();
            }
        }

        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            foreach(DateTimePicker timePicker in this.Controls.OfType<DateTimePicker>())
            {
                timePicker.CustomFormat = "MM/dd/yyyy hh:mm:ss tt";
                timePicker.Format = DateTimePickerFormat.Custom;
            }
            if (insertOrUpdate)
            {
                txtOrderID.Text = (orderRepository.GetProperNewOrderID() + 1).ToString();
                orderDatePicker.Value = DateTime.Now;
                requiredDatePicker.Value = DateTime.Now;
                shippedDatePicker.Value = DateTime.Now;
            } else
            {
                this.Text = "Update Order";
                txtOrderID.Text = orderInfo.OrderID.ToString();
                txtMemberID.Text = orderInfo.MemberID.ToString();
                orderDatePicker.Value = orderInfo.OrderDate;
                requiredDatePicker.Value = orderInfo.RequiredDate;
                shippedDatePicker.Value = orderInfo.ShippedDate;
                txtFreight.Text = orderInfo.Freight.ToString();
                btnAdd.Text = "Update";
            }
            
            
        }
        private bool validateInteger(String Integer)
        {
            String regex = "^[0-9]+$";
            return Regex.IsMatch(Integer, regex);
        }
        private bool validateID()
        {
            if (memberRepository.GetMember(int.Parse(txtMemberID.Text)) != null) return true;
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private bool validateDecimal(String Integer)
        {
            String regex = "^\\d+(\\.)?\\d*$";
            return Regex.IsMatch(Integer, regex);
        }
        private void validateForm()
        {
            bool enabled = true;
            if (!validateInteger(txtMemberID.Text)) enabled = false;
            if (!validateDecimal(txtFreight.Text)) enabled = false;
            btnAdd.Enabled = enabled;
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtMemberID_Validated(object sender, EventArgs e)
        {

        }

        private void txtMemberID_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtFreight_Validated(object sender, EventArgs e)
        {

        }

        private void txtFreight_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
