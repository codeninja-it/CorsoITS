using System.Net;
using System.Net.Sockets;

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
            string messaggio = txtMessaggio.Text;
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(destinatario, numeroPorta);
                // sono in connessione con il mio server
                NetworkStream linea = client.GetStream();
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(messaggio);
                linea.Write(buffer, 0, buffer.Length);
                client.Close();
            } catch (Exception ex)
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
                while((ricevuti = linea.Read(buffer, 0, buffer.Length)) != 0){
                    string messaggio = System.Text.Encoding.ASCII.GetString(buffer, 0, ricevuti);
                    Action inserisci = delegate { lstMessaggi.Items.Add(messaggio); };
                    lstMessaggi.Invoke(inserisci);
                }

                telefono.Close();
            }
        }
    }
}