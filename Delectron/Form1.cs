using SocketMessaging;
using SocketMessaging.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Text;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Delectron
{
    public partial class Form1 : Form
    {
        public TcpServer server;
        public TcpClient client;
        public string mioIndirizzo;

        public Form1()
        {
            InitializeComponent();
            mioIndirizzo = Dns.GetHostName();
            this.Text = $"Chat - {mioIndirizzo}";
            txtDestinatario.Text = mioIndirizzo;
            // imposto il server
            server = new TcpServer();
            server.Connected += IngressoRichiesta;
            server.Start(4065);
        }

        private void IngressoRichiesta(object sender, ConnectionEventArgs e)
        {
            e.Connection.ReceivedRaw += AnalisiRichiesta;
        }

        public void AnalisiRichiesta(object sender, EventArgs e)
        {
            var connessione = sender as Connection;
            byte[] bytes = connessione.Receive();
            string richiesta = Encoding.ASCII.GetString(bytes);
            Action inserisci = delegate { lstMessaggi.Items.Add($"client\t{richiesta}"); };
            lstMessaggi.Invoke(inserisci);
            string[] comando = richiesta.Split("|");
            string risposta = "";
            switch (comando[0])
            {
                case "0": // handshake iniziale
                    risposta = "1|3.6|PROTOCOL VERSION||";
                    break;
                case "26": // nome del programma in esecuzione
                    risposta = @"26|C:\provaccia.txt|COMMAND SUCCESSFUL||";
                    break;
                case "305": // feed, speed e overrides
                    Random rand = new Random();
                    int feedProgrammata = 1000;
                    int feedAttuale = rand.Next(0, feedProgrammata);
                    int speedProgrammata = 3000;
                    int speedAttuale = rand.Next(0, speedProgrammata);
                    risposta = $"305|{feedProgrammata}|{feedAttuale}|{speedProgrammata}|{speedAttuale}|100|100|100|COMMAND SUCCESSFUL||";
                    break;
                default: // comando sconosciuto
                    risposta = $"-1|1|{comando[0]}|INVALID COMMAND|Unknown Command||";
                    break;
            }

            byte[] pacchetto = Encoding.ASCII.GetBytes(risposta + "\n");
            //Just echo the received data back to the same client
            connessione.Send(pacchetto);
        }

        private void RispostaServer(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = client.Receive();
                string messaggio = Encoding.ASCII.GetString(bytes);
                Action inserisci = delegate { lstMessaggi.Items.Add($"server\t{messaggio}"); };
                lstMessaggi.Invoke(inserisci);
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnInvia_Click(object sender, EventArgs e)
        {
            // imposto il client
            IPAddress indirizzo = Dns.GetHostAddresses(txtDestinatario.Text).First();
            client = TcpClient.Connect(indirizzo, 4065);
            client.ReceivedRaw += RispostaServer;
            client.Send($"{txtMessaggio.Text}\n");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}