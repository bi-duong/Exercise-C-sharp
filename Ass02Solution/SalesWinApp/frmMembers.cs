using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }
        private MemberObject member;
        private IMemberRepository memberRepository;
        private BindingSource source;
        public IMemberRepository MemberRepository { set => memberRepository = value; }
        public MemberObject Member { set => member = value; }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            LoadMemberList(memberRepository.GetAllMembers());
            LoadComboBoxFilter();         
            if (!member.Admin)
            {
                btnAdd.Visible = false;
                btnRemove.Visible = false;
                grbFilter.Visible = false;
            }                    
        }      
        private void LoadComboBoxFilter()
        {
            cboCity.Items.Clear();
            cboCountry.Items.Clear();
            cboCity.Items.Insert(0, "-- Select --");
            cboCountry.Items.Insert(0, "-- Select --");
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            foreach (MemberObject member in memberRepository.GetAllMembers())
            {
                if (!cboCity.Items.Contains(member.City)) cboCity.Items.Add(member.City);
                if (!cboCountry.Items.Contains(member.Country)) cboCountry.Items.Add(member.Country);
            }
        }
        public void LoadMemberList(IEnumerable<MemberObject> memberList)
        {
            var members = memberList;
            if (!member.Admin) members = members.Where(mem => mem.MemberID == member.MemberID);
            try
            {
                source = new BindingSource();
                source.DataSource = members;
                dvgData.DataSource = null;
                dvgData.DataSource = source;
                if (!member.Admin) dvgData.Columns["Admin"].Visible = false;
                if (members.Count() == 0)
                {
                    btnRemove.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnRemove.Enabled = true;
                    btnUpdate.Enabled = true;
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMember addMemberForm = new frmAddMember
            {
                IsAdmin = member.Admin,
                MemberRepository = memberRepository,
                InsertOrUpdate = true
            };
            if (addMemberForm.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(memberRepository.GetAllMembers());              
                LoadComboBoxFilter();
                source.Position = source.Count - 1;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MemberObject member = dvgData.CurrentRow.DataBoundItem as MemberObject;
            frmAddMember updateMemberForm = new frmAddMember
            {
                IsAdmin = member.Admin,
                MemberRepository = memberRepository,
                InsertOrUpdate = false,
                memberInfo = member
            };   
            if (updateMemberForm.ShowDialog() == DialogResult.OK)
            {
                int index = dvgData.CurrentRow.Index;
                LoadMemberList(memberRepository.GetAllMembers());                
                if (member.Admin) LoadComboBoxFilter();
                source.Position = index;
            }
        }       
        public List<MemberObject> filterMemberList()
        {
            var result = memberRepository.GetAllMembers();
            if (txtID.Text.Length > 0) result = result.Where(member => member.MemberID.ToString().Contains(txtID.Text));
            if (txtName.Text.Length > 0) result = result.Where(member => member.MemberName.ToUpper().Contains(txtName.Text.ToUpper()));           
            if (cboCity.SelectedIndex > 0) result = result.Where(member => member.City.Equals(cboCity.SelectedItem.ToString()));
            if (cboCountry.SelectedIndex > 0) result = result.Where(member => member.Country.Equals(cboCountry.SelectedItem.ToString()));
            return result.ToList();
        }

        public List<MemberObject> SortMemberListByNameDescending(List<MemberObject> list)
        {
            return list.OrderByDescending(member => member.MemberName).ToList();
        }

        public List<MemberObject> SortMemberListByID(List<MemberObject> list)
        {
            return list.OrderBy(member => member.MemberID).ToList();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            List<MemberObject> result = filterMemberList();
            LoadMemberList(result);
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            List<MemberObject> result = filterMemberList();
            LoadMemberList(result);
        }

        private void cboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MemberObject> result = filterMemberList();
            LoadMemberList(result);
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<MemberObject> result = filterMemberList();
            LoadMemberList(result);
        }
        private void btnSortByName_Click(object sender, EventArgs e)
        {
            List<MemberObject> list = filterMemberList();
            if (btnSortByName.Text.Equals("Sort by name (Descending)"))
            {
                btnSortByName.Text = "Sort By ID";
                
                LoadMemberList(SortMemberListByNameDescending(list));
            } else
            {
                btnSortByName.Text = "Sort by name (Descending)";
                LoadMemberList(SortMemberListByID(list));
            }
        }     
        private void btnRemove_Click(object sender, EventArgs e)
        {
            MemberObject mem = dvgData.CurrentRow.DataBoundItem as MemberObject;
            DialogResult d = MessageBox.Show("Do you really want to remove this member ?", "Member Management - Remove", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (!mem.Admin)
                {
                    memberRepository.RemoveMember(mem.MemberID);
                    LoadMemberList(memberRepository.GetAllMembers());
                    LoadComboBoxFilter();
                }
                else MessageBox.Show("Member with role ADMIN cannot be removed.", "Remove member - Error ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dvgData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', 8);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
            btnSortByName.Text = "Sort by name (Descending)";
        }
    }
}
