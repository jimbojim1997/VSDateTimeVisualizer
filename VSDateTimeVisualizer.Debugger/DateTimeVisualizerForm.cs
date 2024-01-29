using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VSDateTimeVisualizer.Debugger
{
    public partial class DateTimeVisualizerForm : Form
    {
        private readonly DateTime _debugValue;
        private readonly List<ExampleFormatOutput> _exampleOutputFormats = new List<ExampleFormatOutput>();

        public DateTimeVisualizerForm(DateTime debugValue)
        {
            InitializeComponent();
            _debugValue = debugValue;
        }

        private void DateTimeVisualizerForm_Load(object sender, EventArgs e)
        {
            DateTimeValue.Text = _debugValue.ToString("O");

            _exampleOutputFormats.Clear();
            CreateExampleRows(ExampleDateTimeFormats.GetStandardFormats(), ExampleFormatTable, _exampleOutputFormats);
            CreateExampleRows(ExampleDateTimeFormats.GetCustomFormats(), ExampleFormatTable, _exampleOutputFormats);

            UpdateDateTimeOutputs(_debugValue);
        }

        private void DateTimeValue_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimeOutputs(DateTimeValue.Text);
        }

        private void CustomFormatInput_TextChanged(object sender, EventArgs e)
        {
            UpdateDateTimeOutputs(DateTimeValue.Text);
        }

        private void UpdateDateTimeOutputs(string dateTimeText)
        {
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            var dateTimeStyle = System.Globalization.DateTimeStyles.None;

            if (DateTime.TryParseExact(dateTimeText, "O", culture, dateTimeStyle, out DateTime dateTime))
            {
                UpdateDateTimeOutputs(dateTime);
            }
            else
            {
                CustomFormatOutput.Text = "Invalid date format";
            }
        }

        private void UpdateDateTimeOutputs(DateTime dateTime)
        {
            var customFormat = CustomFormatInput.Text;
            try
            {
                if (customFormat.Length > 0) CustomFormatOutput.Text = dateTime.ToString(customFormat);
                else CustomFormatOutput.Text = "";
            }
            catch (FormatException e)
            {
                CustomFormatOutput.Text = e.Message;
            }

            foreach(var output in _exampleOutputFormats) output.Update(dateTime);
        }

        private void CreateExampleRows(IReadOnlyCollection<ExampleFormat> rows, TableLayoutPanel table, IList<ExampleFormatOutput> output)
        {
            int rowIndex = table.RowCount + 1;
            table.RowCount += rows.Count;

            foreach(var row in rows)
            {
                var formatLabel = new Label()
                {
                    Text = row.Label,
                    AutoSize = true
                };
                table.Controls.Add(formatLabel, 0, rowIndex);

                var descriptionLabel = new Label()
                {
                    Text = row.Description,
                    AutoSize = true
                };
                table.Controls.Add(descriptionLabel, 1, rowIndex);

                var outputLabel = new Label()
                {
                    AutoSize = true
                };
                table.Controls.Add(outputLabel, 2, rowIndex);

                output.Add(new ExampleFormatOutput(row.Format, outputLabel, row.Render));
                rowIndex++;
            }
        }
    }
}
