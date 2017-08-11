using Parquet;
using Parquet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParquetFileManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {

            using (Stream fs = File.OpenRead(FileNametextBox.Text))
            {
                using (var reader = new ParquetReader(fs))
                {
                    var ds = reader.Read();
                    ParquetDataGrid.DataSource = GetDataSetFromParquet( ds);
                }
            }
        }
        private DataSet GetRefDataSet()
        {
            var ds = new DataSet(
    new SchemaElement<int>("id"),
    new SchemaElement<string>("city")
);
            ds.Add(1, "London");
            ds.Add(2, "Derby");
            return ds;
        }

        private void LoadRefDataButton_Click(object sender, EventArgs e)
        {
            ParquetDataGrid.AutoGenerateColumns = true;
            //RawValues is an array. It will have 2 elements.
            //TODO convert the array elements as object
            ParquetDataGrid.DataSource = GetRefDataSet().Select(s =>  new { id=s.RawValues[0],city=s.RawValues[1] }).ToList();
            ParquetDataGrid.Refresh();
            foreach (var i in GetRefDataSet())
            {

            }
        }
        System.Data.DataSet GetDataSetFromParquet(DataSet pDataSet)
        {
            return null;
        }
    }
}