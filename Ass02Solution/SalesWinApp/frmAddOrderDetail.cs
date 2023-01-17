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
    public partial class frmAddOrderDetail : Form
    {
        public frmAddOrderDetail()
        {
            InitializeComponent();
        }
        private IProductRepository productRepository = new ProductRepository();
        private List<OrderDetailObject> orderDetails;
        private OrderDetailObject orderDetail;
        private OrderObject order;
        private bool insertOrUpdate;
        public OrderDetailObject OrderDetail { get => orderDetail; set => orderDetail = value; }
        public bool InsertOrUpdate { set => insertOrUpdate = value; }

        public OrderObject Order { set => order = value; }
        public List<OrderDetailObject> OrderDetails { set => orderDetails = value; }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(cboProduct.SelectedItem.ToString().Split('.')[0]);
            orderDetail = new OrderDetailObject
            {
                OrderID = order.OrderID,
                ProductID = productID,
                ProductName = productRepository.GetProductById(productID).ProductName,
                UnitPrice = Decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Discount = Double.Parse(txtDiscount.Text)
            };
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cboProduct.SelectedIndex = 0;
            txtQuantity.Clear();
            txtDiscount.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmAddOrderDetail_Load(object sender, EventArgs e)
        {
            var productList = productRepository.GetAllProducts();
            if (orderDetails.Count > 0)
            {
                foreach (OrderDetailObject orderDetail in orderDetails)
                {
                    productList = productList.Where(product => product.ProductId != orderDetail.ProductID);
                }

            }
            LoadProductComboBox(productList);
            if (!insertOrUpdate)
            {
                String item = orderDetail.ProductID.ToString() + ". " + orderDetail.ProductName;
                cboProduct.Items.Insert(1, item);
                cboProduct.SelectedIndex = 1;
                txtQuantity.Text = orderDetail.Quantity.ToString();
                txtDiscount.Text = orderDetail.Discount.ToString();             
                btnAdd.Text = "Update";
            } else
            {

            }
        }
        private void LoadProductComboBox(IEnumerable<ProductObject> list)
        {
            cboProduct.Items.Insert(0, "-- Select --");
            foreach (ProductObject product in list)
            {
                String item = product.ProductId.ToString() + ". " + product.ProductName;
                cboProduct.Items.Add(item);
            }
            cboProduct.SelectedIndex = 0;
        }

        private void cboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProduct.SelectedIndex != 0)
            {
                int productId = int.Parse(cboProduct.SelectedItem.ToString().Split('.')[0]);
                ProductObject product = productRepository.GetProductById(productId);
                txtUnitPrice.Text = product.UnitPrice.ToString();
            }
            validateForm();
        }
        private void validateForm()
        {
            bool enabled = true;
            if (cboProduct.SelectedIndex == 0) enabled = false;
            if (!validateInteger(txtQuantity.Text)) enabled = false;
            if (!validateFloat(txtDiscount.Text)) enabled = false;
            btnAdd.Enabled = enabled;
        }
        private bool validateInteger(String Integer)
        {
            String regex = "^[0-9]+$";
            return Regex.IsMatch(Integer, regex);
        }
        private bool validateFloat(String Integer)
        {
            String regex = "^\\d+(\\.)?\\d*$";
            return Regex.IsMatch(Integer, regex);
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            validateForm();
        }
    }
}
