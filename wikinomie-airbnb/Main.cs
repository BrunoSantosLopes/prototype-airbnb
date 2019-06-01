using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WikinomieAirbnb.Models;
using WikinomieAirbnb.Models.Observatory;

namespace WikinomieAirbnb
{
    public partial class Main : Form
    {
        CowabooService cowabooService = new CowabooService();

        public Main()
        {
            InitializeComponent();

            SetupTags();
            SetuplvEntries();
        }

        private void SetupTags()
        {
            List<string> tags = cowabooService.GetTags();
            if (tags.Count > 0)
            {
                DisplaycbObservatory(tags);
                DisplaylbTagsList(tags);
            }
            else
            {
                lbCoWaBooOut.Text = "Aucune connexion avec CoWaBoo";
                btnSubmit.Enabled = false;
            }
        }

        private void DisplaycbObservatory(List<string> tags)
        {
            cbObservatory.Items.AddRange(tags.ToArray());
            cbObservatory.SelectedIndex = 0;
        }

        private void DisplaylbTagsList(List<string> tags)
        {
            lbTagsList.Items.AddRange(tags.ToArray());
            lbTagsList.SelectedIndex = 0;
        }

        private void LbTagsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            string tag = (string)listBox.SelectedItem;
            DisplayTagEntries(tag);
        }

        private void DisplayTagEntries(string tag)
        {
            if (!string.IsNullOrEmpty(tag))
            {
                List<Entry> entries = cowabooService.GetTagsValues(tag);
                SetupDatalcEntries(entries);
            }
        }

        private void SetupDatalcEntries(List<Entry> entries)
        {
            lvEntries.Items.Clear();

            foreach (Entry entry in entries)
            {
                ListViewItem lvItem = new ListViewItem(entry.Tags);
                lvItem.SubItems.Add(entry.Value);
                lvEntries.Items.Add(lvItem);
            }

            lvEntries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SetuplvEntries()
        {
            lvEntries.GridLines = true;
            lvEntries.AllowColumnReorder = true;
            lvEntries.LabelEdit = true;
            lvEntries.FullRowSelect = true;
            lvEntries.Sorting = SortOrder.Ascending;
            lvEntries.View = View.Details;
            lvEntries.Columns.Add("Canton");
            lvEntries.Columns.Add("Nombre d'offre");
            lvEntries.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            epEntry.Clear();
            ManageSendEntry();
            btnSubmit.Enabled = true;

        }

        private void ManageSendEntry()
        {
            SendEntry entry = CreateEntry();
            if (VerifyEntry(entry))
            {
                if (cowabooService.SendEntry(entry))
                {
                    RefreshView(entry.ObservatoryId);
                }
                else
                {
                    epEntry.SetError(btnSubmit, "Invalid request");
                }
            }
        }

        private void RefreshView(string tag)
        {
            tbTag.Text = "";
            tbValue.Text = "";
            DisplayTagEntries(tag);
        }

        private bool VerifyEntry(SendEntry entry)
        {
            bool isGoodEntry = true;

            if (string.IsNullOrEmpty(entry.ObservatoryId))
            {
                isGoodEntry = false;
                epEntry.SetError(cbObservatory, "Observatory not provided");
                epEntry.BlinkRate = 0;
            }
            if (string.IsNullOrEmpty(entry.SecretKey))
            {
                isGoodEntry = false;
                epEntry.SetError(tbSecretKey, "Secret Key not provided");
                epEntry.BlinkRate = 0;
            }
            if (string.IsNullOrEmpty(entry.Tags))
            {
                isGoodEntry = false;
                epEntry.SetError(tbTag, "Tag not provided");
                epEntry.BlinkRate = 0;
            }
            if (string.IsNullOrEmpty(entry.Value))
            {
                isGoodEntry = false;
                epEntry.SetError(tbValue, "Value not provided");
                epEntry.BlinkRate = 0;
            }

            return isGoodEntry;
        }

        private SendEntry CreateEntry()
        {
            SendEntry entry = new SendEntry()
            {
                ObservatoryId = cbObservatory.SelectedItem.ToString(),
                SecretKey = tbSecretKey.Text,
                Tags = tbTag.Text,
                Value = tbValue.Text
            };

            return entry;
        }
    }
}
