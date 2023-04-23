using System;
using Misq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mofkey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Create your app instance
            App app = new App(instanceName.Text, tokenName.Text);
            Me user = await (Task<Me>) app.Authorize();
//            var user = await app.Authorize();
//System.Threading.Tasks.Task<Misq.Me> user = await app.Authorize();
// Let's post a message to Misskey
            user.Request("notes/create", new Dictionary<string, object> {
                { "text", messageText.Text }
 });
        }
    }
}
