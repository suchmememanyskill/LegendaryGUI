using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LegendaryGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormConsole.Console = rtb_console;
            HideAllPanels();
            Config.Read();

            LaunchProcess proc = new LaunchProcess("-V");
            proc.WaitOnExit = true;
            proc.Run();
            if (proc.Output.Count > 0)
                if (proc.Output[0].StartsWith("modded legendary"))
                    mi_forceLaunch.Visible = true;
        }

        private void HideAllPanels()
        {
            // Hide panels
            pnl_installed.Hide();
            pnl_home.Hide();
            pnl_forceLaunch.Hide();
            pnl_allgames.Hide();
            pnl_notInstalled.Hide();

            // Deselect all menu objects
            mi_home.BackColor = Color.FromArgb(64,64,64);
            mi_Installed.BackColor = Color.FromArgb(64, 64, 64);
            mi_forceLaunch.BackColor = Color.FromArgb(64, 64, 64);
            mi_notInstalled.BackColor = Color.FromArgb(64, 64, 64);
            mi_allgames.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void mi_home_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnl_home.Show();
            mi_home.BackColor = Color.FromKnownColor(KnownColor.Highlight);
        }

        private void rtb_console_TextChanged(object sender, EventArgs e)
        {
            rtb_console.SelectionStart = rtb_console.Text.Length;
            rtb_console.ScrollToCaret();
        }

        private void mi_Installed_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnl_installed.Show();
            mi_Installed.BackColor = Color.FromKnownColor(KnownColor.Highlight);

            LaunchProcess proc = new LaunchProcess("list-installed");
            proc.ReturnFunc = HandleInstalledOutput;
            proc.Run();
        }

        private void HandleInstalledOutput(LaunchProcess proc)
        {
            List<GameInfo> games = new List<GameInfo>();
            foreach (string line in proc.Output)
            {
                if (line.StartsWith(" *"))
                {
                    games.Add(new GameInfo(line, true));
                }
            }

            ListViewSafeWriter lv = new ListViewSafeWriter(installed_lv);
            lv.Clear();

            foreach (GameInfo info in games)
            {
                ListViewItem li = new ListViewItem(info.Name);
                li.SubItems.Add(info.AppName);
                li.SubItems.Add(info.Version);
                li.SubItems.Add(info.Size);
                lv.Add(li);
            }

            FormConsole.WriteLine("Parsing done!");
        }

        private void installed_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (installed_lv.SelectedItems.Count >= 1)
                btn_installed_launch.Enabled = true;
            else
                btn_installed_launch.Enabled = false;
        }

        private void btn_installed_launch_Click(object sender, EventArgs e)
        {
            string toLaunch = installed_lv.SelectedItems[0].SubItems[1].Text;
            LaunchProcess proc = new LaunchProcess($"launch {toLaunch}");
            proc.Run();
        }

        private void showVersion(LaunchProcess proc)
        {
            MessageBox.Show(proc.Output[0], "Version info");
        }

        private void btn_home_verInfo_Click(object sender, EventArgs e)
        {
            LaunchProcess proc = new LaunchProcess($"-V");
            proc.ReturnFunc = showVersion;
            proc.Run(); 
        }

        private void RefreshForceLaunch()
        {
            lv_forceLaunch.Items.Clear();
            foreach (var item in Config.config.ForceLaunchGames)
            {
                ListViewItem li = new ListViewItem(item.Name);
                li.SubItems.Add(item.AppName);
                li.SubItems.Add(item.Version);
                li.SubItems.Add(item.Size);
                li.SubItems.Add(item.GamePath);
                lv_forceLaunch.Items.Add(li);
            }
        }

        private void mi_forceLaunch_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnl_forceLaunch.Show();
            mi_forceLaunch.BackColor = Color.FromKnownColor(KnownColor.Highlight);

            RefreshForceLaunch();
        }

        private void mi_notInstalled_Click(object sender, EventArgs e)
        {

        }

        private void btn_forceLaunch_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_appname.Text) || string.IsNullOrEmpty(tb_version.Text) || string.IsNullOrEmpty(tb_size.Text) || string.IsNullOrEmpty(tb_path.Text))
            {
                lbl_forceLaunch_status.Text = "Status: Not all fields are filled!";
                return;
            }

            if (!File.Exists(tb_path.Text))
            {
                lbl_forceLaunch_status.Text = "Status: Path does not exist!";
                return;
            }

            foreach (var item in Config.config.ForceLaunchGames)
            {
                if (item.Name == tb_name.Text)
                {
                    lbl_forceLaunch_status.Text = "Status: App already registered!";
                    return;
                }
            }

            ForceGameInfo info = new ForceGameInfo(tb_name.Text, tb_appname.Text, tb_version.Text, tb_size.Text, tb_path.Text);
            Config.config.ForceLaunchGames.Add(info);
            Config.Write();
            RefreshForceLaunch();
            lbl_forceLaunch_status.Text = "Status: Added";
        }

        private void HandleAllGamesOutput(LaunchProcess proc)
        {
            List<GameInfo> games = new List<GameInfo>();
            foreach (string line in proc.Output)
            {
                if (line.StartsWith(" *"))
                {
                    games.Add(new GameInfo(line, false));
                }
            }

            ListViewSafeWriter lv = new ListViewSafeWriter(lv_allGames);
            lv.Clear();

            foreach (GameInfo info in games)
            {
                ListViewItem li = new ListViewItem(info.Name);
                li.SubItems.Add(info.AppName);
                li.SubItems.Add(info.Version);
                lv.Add(li);
            }

            FormConsole.WriteLine("Parsing done!");
        }

        private void mi_allgames_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            pnl_allgames.Show();
            mi_allgames.BackColor = Color.FromKnownColor(KnownColor.Highlight);

            LaunchProcess proc = new LaunchProcess($"list-games");
            proc.ReturnFunc = HandleAllGamesOutput;
            proc.Run();
        }

        private void btn_forceLaunch_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Config.config.ForceLaunchGames.Count; i++)
            {
                if (Config.config.ForceLaunchGames[i].Name == lv_forceLaunch.SelectedItems[0].Text)
                {
                    Config.config.ForceLaunchGames.RemoveAt(i);
                }
            }

            RefreshForceLaunch();
        }

        private void lv_forceLaunch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_forceLaunch.SelectedItems.Count >= 1)
            {
                btn_forceLaunch_remove.Enabled = true;
                btn_forceLaunch_launch.Enabled = true;
            }
            else
            {
                btn_forceLaunch_remove.Enabled = false;
                btn_forceLaunch_launch.Enabled = false;
            }
        }

        private void btn_forceLaunch_launch_Click(object sender, EventArgs e)
        {
            string toLaunch = lv_forceLaunch.SelectedItems[0].SubItems[1].Text;
            string gamePath = lv_forceLaunch.SelectedItems[0].SubItems[4].Text;
            LaunchProcess proc = new LaunchProcess($"force-launch {toLaunch} {gamePath}");
            proc.Run();
        }
    }
}
