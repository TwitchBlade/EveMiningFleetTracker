using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EveFleetMiningTracker
{
    public partial class Form1 : Form
    {

        Dictionary<string, Dictionary<string, int>> playerOresTotal;

        public Form1()
        {
            InitializeComponent();
            playerOresTotal = new Dictionary<string, Dictionary<string, int>>();
        }

        private void minerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            oreList.Items.Clear();
            if (minerList.SelectedItem == null) return;
            string selectedMiner = (string)minerList.SelectedItem;
            foreach (KeyValuePair<string, int> oreTotal in playerOresTotal[selectedMiner])
            {
                string oreString = string.Format("{0} x {1}", oreTotal.Key, oreTotal.Value);
                oreList.Items.Add(oreString);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string minerName = minerInput.Text;
            minerList.Items.Add(minerName);
            playerOresTotal.Add(minerName, new Dictionary<string, int>());
        }

        private void oreInputButton_Click(object sender, EventArgs e)
        {
            error.Text = "Everything is fine, Nothing suspicious going on here";
            if (minerList.SelectedItem == null) return;
            string selectedMiner = (string)minerList.SelectedItem;
            Dictionary<string, int> oreTotals = new Dictionary<string, int>();
            string oreInput = oreInputBox.Text;
            string[] oreLines = oreInput.Replace("\r", "").Split("\n".ToCharArray());
            try
            {
                foreach (string oreLine in oreLines)
                {
                    string[] lineParts = oreLine.Split("\t".ToCharArray());
                    string name = lineParts[0];
                    int quantity = string.IsNullOrEmpty(lineParts[1]) ? 1 : int.Parse(lineParts[1], NumberStyles.AllowThousands);
                    string group = lineParts[2];
                    string size = lineParts[3];
                    string slot = lineParts[4];
                    decimal volume = decimal.Parse(lineParts[5].Replace(" m3", ""));
                    decimal price = decimal.Parse(lineParts[6].Replace(" ISK", ""));
                    oreTotals.Add(name, quantity);
                }
            }
            catch (Exception ex)
            {
                error.Text = ex.Message;
                return;
            }
            foreach (string name in oreTotals.Keys)
            {
                int quantity = oreTotals[name];
                if (!playerOresTotal[selectedMiner].ContainsKey(name))
                {
                    playerOresTotal[selectedMiner].Add(name, 0);
                }
                playerOresTotal[selectedMiner][name] += quantity;
                oreList.Items.Clear();
                if (minerList.SelectedItem == null) return;
                string selectedMiner1 = (string)minerList.SelectedItem;
                foreach (KeyValuePair<string, int> oreTotal in playerOresTotal[selectedMiner1])
                {
                    string oreString = string.Format("{0} x {1}", oreTotal.Key, oreTotal.Value);
                    oreList.Items.Add(oreString);
                }
            }
        }

        private void clipboardExport_Click(object sender, EventArgs e)
        {
            string clip = "";
            foreach (String word in oreList.Items)
            {
                clip = clip + "\n" + word;
            }
            Clipboard.SetText(clip);
        }
    }
}
