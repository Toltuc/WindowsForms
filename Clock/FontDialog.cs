using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace Clock
{
	public partial class FontDialog : Form
	{
		MainForm parent;

		// Словарь: отображаемое имя -> полный путь к файлу
		Dictionary<string, string> fontPaths = new Dictionary<string, string>();

		public FontDialog()
		{
			InitializeComponent();
			LoadFonts();
		}
		public FontDialog(MainForm parent) : this()
		{
			this.parent = parent;
		}

		private void FontDialog_Load(object sender, EventArgs e)
		{
			this.Location = new Point(parent.Location.X - this.Width / 3, parent.Location.Y + 80);
		}

		void LoadFonts()
		{
			Console.WriteLine(Application.ExecutablePath);
			string fontsDir = Path.GetFullPath(
				Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"..\..\..\Fonts"));
			Directory.SetCurrentDirectory(fontsDir);
			Console.WriteLine(Directory.GetCurrentDirectory());

			// Грузим шрифты из текущей папки и всех вложенных (SearchOption.AllDirectories)
			LoadFonts(fontsDir, "*.ttf");
			LoadFonts(fontsDir, "*.otf");
		}

		void LoadFonts(string path, string format)
		{
			// AllDirectories — ключевое: загружаем шрифты из вложенных папок тоже
			string[] files = Directory.GetFiles(path, format, SearchOption.AllDirectories);
			foreach (string fullPath in files)
			{
				string displayName = Path.GetFileName(fullPath);
				// Если имя уже есть — добавляем папку для уникальности
				if (fontPaths.ContainsKey(displayName))
					displayName = Path.GetFileName(Path.GetDirectoryName(fullPath)) + "\\" + displayName;

				fontPaths[displayName] = fullPath;
				comboBoxFonts.Items.Add(displayName);
			}
		}

		void ApplyFontExample()
		{
			if (comboBoxFonts.SelectedItem == null) return;
			string selectedKey = comboBoxFonts.SelectedItem.ToString();
			if (!fontPaths.ContainsKey(selectedKey)) return;

			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(fontPaths[selectedKey]);
			labelExample.Font = new Font(pfc.Families[0], (float)nudFontSize.Value);
		}

		private void comboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
		{
			ApplyFontExample();
		}

		private void nudFontSize_ValueChanged(object sender, EventArgs e)
		{
			ApplyFontExample();
		}

		// При нажатии OK — применяем шрифт к часам на главной форме
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (comboBoxFonts.SelectedItem == null) return;
			string selectedKey = comboBoxFonts.SelectedItem.ToString();
			if (!fontPaths.ContainsKey(selectedKey)) return;

			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(fontPaths[selectedKey]);
			parent.SetClockFont(new Font(pfc.Families[0], (float)nudFontSize.Value));
		}
	}
}
