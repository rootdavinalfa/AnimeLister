// 2020 Davin Alfarizky Putra Basudewa
// UAS - PBO4 Pak Asep Mabrur Universitas Banten Jaya

using AnimeLister.lib;
using AnimeLister.model;
using AnimeLister.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeLister
{
    public partial class MainForm : Form
    {
        static List<Anime> allList = new List<Anime>();
        int currentPage = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            initDGV();
            refreshData();
        }
        private async void refreshData()
        {
            var page = currentPage.ToString();
            //Get object from RESTAPI connector with async to avoid UI Thread Blocking
            AnimeList anim = await Task.Run(() => RESTAPIConnector.GetAnimeList($"anim/list/package/page/{page}"));

            //Check if anim on AnimeList IList is 0, if 0 then reset counter to 1 otherwise iterate
            if (anim.anim.Count == 0 && anim.error == true)
            {
                currentPage = 1;
            }
            else
            {
                foreach (Anime i in anim.anim)
                {
                    dgvAnimeList.Rows.Add(i.package_anim, i.name_anim, i.rating);
                    allList.Add(new Anime
                    {
                        package_anim = i.package_anim,
                        name_anim = i.name_anim,
                        rating = i.rating,
                        cover = i.cover
                    });
                }
                currentPage += 1;
                refreshData();
            }
        }

        private void initDGV()
        {
            dgvAnimeList.Rows.Clear();
            dgvAnimeList.Columns.Clear();
            dgvAnimeList.Columns.Add("pkg", "Package ID");
            dgvAnimeList.Columns.Add("nm", "Nama Anime");
            dgvAnimeList.Columns.Add("rate", "Rating");
            dgvAnimeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rootdavinalfa/animize");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            initDGV();
            currentPage = 1;
            refreshData();

        }

        private void dgvAnimeList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var i = e.RowIndex;
            if (dgvAnimeList.Rows.Count != 0)
            {
                var detail = new DetailForm();
                detail.pkgID = allList[i].package_anim;
                detail.ShowDialog();
            }

        }
    }
}
