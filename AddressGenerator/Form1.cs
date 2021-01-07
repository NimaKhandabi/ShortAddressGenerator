using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressGenerator
{
    public partial class Form1 : Form
    {
        private string longAddress;
        private string shortAddress;
        private string shortAddressR;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void txLongAddresst_TextChanged(object sender, EventArgs e)
        {
            longAddress = txtLongAddress.Text;
        }

        private void txtGenerate_Click(object sender, EventArgs e)
        {
            AddressDbContext ctx = new AddressDbContext();
            //ctx.Database.EnsureDeleted();
            ctx.Database.EnsureCreated();

            if (ctx.LongCodes.FirstOrDefault(lc => lc.Address == txtLongAddress.Text) != null)
            {
                var lc = ctx.LongCodes.FirstOrDefault(lc => lc.Address == txtLongAddress.Text);
                var sc = ctx.ShortCodes.Find(lc.LongCodeID);
                shortAddress = sc.Address;
                txtShortAddress.Text = shortAddress;
            }
            else
            {
                Generator gn = new Generator();
                Models.LongCode lc = new Models.LongCode
                {
                    Address = longAddress
                };
                lc.ShortCode = new Models.ShortCode()
                {
                    LongCodeId = lc.LongCodeID,
                    Address = gn.ShortAddressGenerator(6, longAddress)
                };

                shortAddress = lc.ShortCode.Address;
                txtShortAddress.Text = shortAddress;
                ctx.LongCodes.Add(lc);
                ctx.SaveChanges();
            }
        }


        private void btnGeneratorR_Click(object sender, EventArgs e)
        {
            AddressDbContext ctx = new AddressDbContext();
            ctx.Database.EnsureCreated();

            if (ctx.ShortCodes.FirstOrDefault(sc => sc.Address == txtShortAddressR.Text) != null)
            {
                var sc = ctx.ShortCodes.FirstOrDefault(sc => sc.Address == txtShortAddressR.Text);
                var lc = ctx.LongCodes.Find(sc.LongCodeId);
                shortAddressR = lc.Address;
                txtLongAddressR.Text = shortAddressR;
            }
            else
            {
                txtLongAddressR.Text = "Not Found!";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
