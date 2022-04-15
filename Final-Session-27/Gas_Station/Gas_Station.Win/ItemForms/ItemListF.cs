using Gas_Station.Shared;
using Gas_Station.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Station.Win.ItemForms
{
    public partial class ItemListF : Form
    {
        private HttpClient _client;
        private List<ItemListViewModel> _itemList;
        private ItemListViewModel _selectedItem;
        public ItemListF(HttpClient httpClient)
        {
            InitializeComponent();
            _client = httpClient;
        }

        private async Task LoadItemsFromServer()
        {
            _itemList = await _client.GetFromJsonAsync<List<ItemListViewModel>>("item");
        }

        private async Task RefreshItemList()
        {
            grvItemList.DataSource = null;

            await LoadItemsFromServer();
            grvItemList.DataSource=_itemList;

            grvItemList.Update();
            grvItemList.Refresh();
            grvItemList.Columns["ID"].Visible = false;
            SetOrderItemGridView();

        }

        private async void ItemListF_Load(object sender, EventArgs e)
        {
            await RefreshItemList();

            grvItemList.ReadOnly = true;
        }

        private async void bntRefresh_Click(object sender, EventArgs e)
        {
            await RefreshItemList();
        }

        private async void btnAddItem_Click(object sender, EventArgs e)
        {
            var frmCustomerList = new ItemEditF(_client);
            frmCustomerList.ShowDialog();
            await RefreshItemList();
        }

        private async void btnEditItem_Click(object sender, EventArgs e)
        {
            if (grvItemList.SelectedRows.Count != 1)
                return;

            _selectedItem = (ItemListViewModel)grvItemList.SelectedRows[index: 0].DataBoundItem;
            var frmCustomerList = new ItemEditF(_client, _selectedItem);
            frmCustomerList.ShowDialog();
            await RefreshItemList();
        }

        private async void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (grvItemList.SelectedRows.Count != 1)
                return;

            _selectedItem = (ItemListViewModel)grvItemList.SelectedRows[index: 0].DataBoundItem;
            _client.DeleteAsync($"item/{_selectedItem.ID}");
            await RefreshItemList();
        }

        private void SetOrderItemGridView()
        {
            grvItemList.Columns["Description"].DisplayIndex=0;
            grvItemList.Columns["Code"].DisplayIndex = 1;
            grvItemList.Columns["ItemType"].DisplayIndex = 2;
            grvItemList.Columns["Cost"].DisplayIndex = 3;
            grvItemList.Columns["Price"].DisplayIndex = 4;
        }

        private void grvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
