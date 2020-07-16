using AnimeLister.lib;
using AnimeLister.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeLister.ui
{
    public partial class DetailForm : Form
    {
        private Details anim;
        public string pkgID;
        public DetailForm()
        {
            InitializeComponent();
        }

        private async void DetailForm_Load(object sender, EventArgs e)
        {
            if(pkgID != null)
            {
                getInfo();
            }
        }
        private async void getInfo()
        {
            anim = await Task.Run(() => RESTAPIConnector.GetInfo(String.Format("package/info/{0}", pkgID)));
            if (anim != null)
            {
                var detail = anim.anim[0];
                nameCatalogue.Text = detail.name_catalogue;
                rating.Text = String.Format("Rating: {0}", detail.rating);
                packageAnime.Text = detail.package_anim;
                synopsis.Text = detail.synopsis;
                StringBuilder sb = new StringBuilder();
                var index = 0;
                var count = detail.genre.Count;
                foreach (string i in detail.genre)
                {
                    if(index < count - 1)
                    {
                        sb.Append(String.Format("{0}, ",i));
                    }
                    else if(index == count -1)
                    {
                        sb.Append(i);
                    }
                    index += 1;
                }
                genres.Text = sb.ToString();
                await Task.Run(() => attachImage(detail.cover));
            }
        }
        private void attachImage(string cover)
        {
            var request = WebRequest.Create(cover);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                coverViewer.Image = Bitmap.FromStream(stream);
            }
        }

        private void btnToAnimize_Click(object sender, EventArgs e)
        {
            Process.Start(String.Format("https://animize.dvnlabs.xyz/anim/package/{0}",pkgID));
        }
    }
}
