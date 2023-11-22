using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private SqlConnection connect;
        List<String> list;
        int i = 0 ;

        string _connectectionString = "server=.; database=cauhoi;integrated security=true";
        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
        }
        private void kt()
        {
            connect = new SqlConnection(_connectectionString);
            connect.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from cauhoi", connect);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataSet.Tables[0].TableName = "txt";

            var dt = dataSet.Tables["txt"].Rows[0][1];

            
            
            foreach (DataRow row in dataSet.Tables["txt"].Rows)
            {
                list.Add(row["txt"].ToString());           
            }
            textBox1.Text = list[i];

            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kt();
            i++;
            textBox1.Text = list[i];
            

            //connect = new SqlConnection(_connectectionString);
            //connect.Open();
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from cauhoi", connect);
            //DataSet dataSet = new DataSet();
            //dataAdapter.Fill(dataSet);
            //dataSet.Tables[0].TableName = "txt";

            //textBox1.Clear();
            //textBox1.Text = dataSet.Tables[0].Rows[0]["txt"].ToString();
            //textBox1.Clear();
            //textBox1.Text = dataSet.Tables[0].Rows[1]["txt"].ToString();
            //textBox1.Clear();
            //textBox1.Text = dataSet.Tables[0].Rows[2]["txt"].ToString();
   
            
            //string selectString = "select txt from cauhoi where id =  "+ 1 +" ";
            //SqlCommand cmd = new SqlCommand(selectString, connect);
            //cmd.ExecuteScalar();
             
           
        }

       

        

        
    }
}
