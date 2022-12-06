using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            processoParallelo.RunWorkerAsync();
            string mioIndirizzo = Dns.GetHostName();
            this.Text = $"Chat - {mioIndirizzo}";
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            int numeroPorta = 4065;
            string destinatario = txtDestinatario.Text;
            string messaggio = "||0";
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(destinatario, numeroPorta);
                // sono in connessione con il mio server
                NetworkStream linea = client.GetStream();

                // start reading from the socket
                byte[] risposta = new byte[2048];
                var tRisposta = linea.ReadAsync(risposta, 0, risposta.Length);

                byte[] buffer = Encoding.ASCII.GetBytes(messaggio);
                linea.Write(buffer, 0, buffer.Length);
                
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{destinatario} non è attualmente online!", "Errore...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void processoParallelo_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TcpListener server = new TcpListener(4065);
            server.Start();
            while (true)
            {
                TcpClient telefono = server.AcceptTcpClient();
                NetworkStream linea = telefono.GetStream();

                byte[] buffer = new byte[256];
                int ricevuti = 0;
                while ((ricevuti = linea.Read(buffer, 0, buffer.Length)) != 0)
                {
                    string messaggio = Encoding.ASCII.GetString(buffer, 0, ricevuti);
                    Action inserisci = delegate { lstMessaggi.Items.Add(messaggio); };
                    lstMessaggi.Invoke(inserisci);
                }
                buffer = Encoding.ASCII.GetBytes("1|3.6|PROTOCOL VERSION||");
                linea.Write(buffer, 0, buffer.Length);
                //telefono.Close();
            }
        }

        private void txtDestinatario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstMessaggi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}