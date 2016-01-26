using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace DateTimeFormat
{
    public partial class MainForm : Form
    {
        private List<CultureInfo> cultureInfos;
        private bool loading = false;
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loading = true;		// disable some events
            
            comboBoxCultures.DisplayMember = "Name";
            cultureInfos = new List<CultureInfo>(CultureInfo.GetCultures(CultureTypes.SpecificCultures));
            cultureInfos.Sort(CompareCultureInfo);
            
            comboBoxCultures.DataSource = cultureInfos;

            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            for (int i = 0; i < cultureInfos.Count; i++)
            {
                if (cultureInfos[i].Name == currentCulture.Name)
                {
                    comboBoxCultures.SelectedIndex = i;
                    break;
                }
            }
            
            DateTime selectedDateTime = DateTime.Now;
            dtpDate.Value = selectedDateTime;
            dtpTime.Value = selectedDateTime;
            
            FillTable();
            UpdateDates();
            
            loading = false;
        }
        
        
        private int CompareCultureInfo(CultureInfo a, CultureInfo b)
        {
            return string.Compare(a.Name, b.Name);
        }

        private void FillTable()
        {
            dataTableFormats.Clear();
            dataTableFormats.Rows.Add(new object[] { "d", "Short date pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "D", "Long date pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "t", "Short time pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "T", "Long time pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "f", "Full date/time pattern (short time)", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "F", "Full date/time pattern (long time)", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "g", "General date/time pattern (short time)", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "G", "General date/time pattern (long time)", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "m", "Month day pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "r", "RFC1123 pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "s", "Sortable date/time pattern; conforms to ISO 8601", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "u", "Universal sortable date/time pattern", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "U", "Full date and time (long date and long time) using universal time", String.Empty });
            dataTableFormats.Rows.Add(new object[] { "y", "Year month pattern", String.Empty });
        }
        
        private void UpdateDates()
        {
            DateTime dt = GetSelectedDateTime();
            CultureInfo ci = GetSelectedCulture();
            
            foreach (DataRow row in dataTableFormats.Rows)
            {
                row[2] = dt.ToString(row[0].ToString(), ci);
            }
            
            UpdateToStringDate();
            
        }

        private void UpdateToStringDate()
        {
            DateTime dt = GetSelectedDateTime();
            CultureInfo ci = GetSelectedCulture();

            try
            {
                textBoxToStringResult.Text = dt.ToString(textBoxFormatString.Text, ci);
            }
            catch (FormatException ex)
            {
                textBoxToStringResult.Text = " - FormatException " + ex.Message + " -";
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            loading = true;
            dtpTime.Value = dtpDate.Value;
            loading = false;
            UpdateDates();
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            loading = true;
            dtpDate.Value = dtpTime.Value;
            loading = false;
            UpdateDates();
        }

        private void comboBoxCultures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            UpdateDates();
        }

        private void linkLabelFormatSpecifier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://msdn.microsoft.com/en-us/library/c6dw49cz(v=vs.110).aspx");
        }

        private void textBoxFormatString_TextChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            UpdateToStringDate();
        }

        private void checkBoxInvariantCulture_CheckedChanged(object sender, EventArgs e)
        {
            if (loading)
                return;
            comboBoxCultures.Enabled = !checkBoxInvariantCulture.Checked;
            UpdateDates();
        }


        private void buttonTryParse_Click(object sender, EventArgs e)
        {
            DateTime dt;
            bool parsed;
            CultureInfo ci = GetSelectedCulture();
            string result;
            
            // TryParse
            parsed = DateTime.TryParse(textBoxDateString.Text, ci, DateTimeStyles.None, out dt);
            if (parsed)
                result = dt.ToString("s");
            else
                result = "- Parse failed -";
            
            textBoxTryParseResult.Text = result;
            
            // TryParseExact
            string[] expectedFormats = textBoxExpectedFormats.Text.Split(';');
            parsed = DateTime.TryParseExact(textBoxDateString.Text, expectedFormats, ci, DateTimeStyles.None, out dt);
            if (parsed)
                result = dt.ToString("s");
            else
                result = "- Parse failed -";
            
            textBoxTryParseExactResult.Text = result;
            
        }


        private CultureInfo GetSelectedCulture()
        {
            CultureInfo ci;
            if (checkBoxInvariantCulture.Checked)
                ci = CultureInfo.InvariantCulture;
            else
                ci = (CultureInfo)comboBoxCultures.SelectedItem;
            
            return ci;
        }
        
        
        private DateTime GetSelectedDateTime()
        {
            return dtpDate.Value;
        }

    }
}