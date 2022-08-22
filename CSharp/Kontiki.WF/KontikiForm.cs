using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontiki.WF
{
	public partial class KontikiForm : Form
	{
		private static string _connectionFileName = "kontiki_connections.xml";
		public static HapKontikiManager KontikiManager = new HapKontikiManager();

		public KontikiForm()
		{
			InitializeComponent();

			this.PrepareKontikiConnection();
		}

		private void PrepareKontikiConnection(string connectionName = "default")
		{
			KontikiManager.ConnectionManager.Load(_connectionFileName);
			KontikiConnection connection = KontikiManager.ConnectionManager.Connections[connectionName];
			KontikiManager.ConnectionManager.TestConnection(connection);

			if (connection.IsOnline)
			{
				MessageBox.Show($"Connection {connectionName} is online");
			}
			else
			{
				MessageBox.Show($"Connection {connectionName} is NOT online");
			}
		}
	}
}
