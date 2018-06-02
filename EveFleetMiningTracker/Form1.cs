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

        //Dictionary<string, Dictionary<string, int>> playerOresTotal;
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> testTotals;

        private void updateList()
        {
            oreList.Items.Clear();
            if (minerList.SelectedItem == null) return;
            string selectedMiner = (string)minerList.SelectedItem;
            foreach (KeyValuePair<string, Dictionary<string, string>> oreTotal in testTotals[selectedMiner])
            {
                string oreString = string.Format("{0} x {1}", oreTotal.Key, testTotals[selectedMiner][oreTotal.Key]["quantity"]);
                oreList.Items.Add(oreString);
            }
        }

        private string updateQuanity(string currentNumber, string addNumber)
        {
            int curNumber = int.Parse(currentNumber);
            int nextNumber = int.Parse(addNumber);
            int returnNumber = curNumber + nextNumber;
            return returnNumber.ToString();
        }


        private string updateVolume(string currentDecimal, string addDecimal)
        {
            decimal currDecimal = decimal.Parse(currentDecimal.Replace(" m3", ""));
            decimal addDec = decimal.Parse(addDecimal.Replace(" m3", ""));
            decimal finalDec = addDec + currDecimal;
            return finalDec.ToString() + " m3";
        }

        private string updatePrice(string currentPrice, string addPrice)
        {
            string commaRemove = currentPrice.Replace(",", "");
            string commRemove = addPrice.Replace(",", "");
            decimal currPrice = decimal.Parse(commaRemove.Replace(" ISK", ""));
            decimal addPric = decimal.Parse(commRemove.Replace(" ISK", ""));
            decimal finalPrice = addPric + currPrice;
            string finalPriceString = string.Format("{0:0,0.00}", finalPrice.ToString());
            return finalPriceString + " ISK";
        }

        public Form1()
        {
            InitializeComponent();
            //playerOresTotal = new Dictionary<string, Dictionary<string, int>>();
            testTotals = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();
        }

        private void minerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string minerName = minerInput.Text;
            minerList.Items.Add(minerName);
            //playerOresTotal.Add(minerName, new Dictionary<string, int>());
            testTotals.Add(minerName, new Dictionary<string, Dictionary<string, string>>());
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
                    string quantity = lineParts[1];
                    string group = lineParts[2];
                    string size = lineParts[3];
                    string slot = lineParts[4];
                    string volume = lineParts[5];
                    string price = lineParts[6];
                    if (!testTotals[selectedMiner].ContainsKey(name))
                    {
                        testTotals[selectedMiner].Add(name, new Dictionary<string, string>());
                        testTotals[selectedMiner][name].Add("quantity", quantity);
                        testTotals[selectedMiner][name].Add("group", group);
                        testTotals[selectedMiner][name].Add("size", size);
                        testTotals[selectedMiner][name].Add("slot", slot);
                        testTotals[selectedMiner][name].Add("volume", volume);
                        testTotals[selectedMiner][name].Add("price", price);
                    }
                    else
                    {
                        testTotals[selectedMiner][name]["quantity"] = updateQuanity(testTotals[selectedMiner][name]["quantity"], quantity);
                        testTotals[selectedMiner][name]["volume"] = updateVolume(testTotals[selectedMiner][name]["volume"], volume);
                        testTotals[selectedMiner][name]["price"] = updatePrice(testTotals[selectedMiner][name]["price"], price);
                    }
                }
            }
            
            catch (Exception ex)
            {
                error.Text = ex.Message;
                return;
            }
            updateList();
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

        private void createSave_Click(object sender, EventArgs e)
        {
            /*try
            {
                
            }
            catch (Exception ex)
            {
                error.Text = ex.Message;
            }*/
        }
    }
}
