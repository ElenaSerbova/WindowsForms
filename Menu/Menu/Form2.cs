using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {

        ToolStripMenuItem fileMenuItem;
        ToolStripMenuItem editMenuItem;
        ToolStripMenuItem helpMenuItem;

        StatusStrip statusBar;
        ToolStripItem statusBarLabel;

        ToolStrip toolBar;

        ContextMenuStrip contextMenu;

        public Form2()
        {
            InitializeComponent();

            //ContextMenu
            contextMenu = new ContextMenuStrip();
            contextMenu.Items.Add("Copy");
            contextMenu.Items.Add("Cut");
            contextMenu.Items.Add("Paste");

            this.ContextMenuStrip = contextMenu;


            //ToolStrip
            toolBar = new ToolStrip();
            toolBar.Parent = this;

            ToolStripButton saveButton = new ToolStripButton();
            saveButton.Click += SaveMenuItem_Click;
            saveButton.Image = Image.FromFile("./icons/save.png");

            toolBar.Items.Add(saveButton);

            //Status Bar
            statusBar = new StatusStrip();
            statusBar.Parent = this;
            statusBarLabel = statusBar.Items.Add("Status text");

            //File menu item
            fileMenuItem = new ToolStripMenuItem("File");
           
            //New menu item
            fileMenuItem.DropDownItems.Add("New", null, FileNewMenuItem_Click);

            //Open menu item
            var openMenuItem = fileMenuItem.DropDownItems.Add("Open");
            openMenuItem.Click += OpenMenuItem_Click;

            //Save menu item
            var saveMenuItem = new ToolStripMenuItem("Save");
            saveMenuItem.Click += SaveMenuItem_Click;
            saveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveMenuItem.ShowShortcutKeys = true;
            saveMenuItem.Image = Image.FromFile("./icons/save.png");
            fileMenuItem.DropDownItems.Add(saveMenuItem);


            editMenuItem = new ToolStripMenuItem("Edit");
            helpMenuItem = new ToolStripMenuItem("Help");
            
            //Main menu
            this.MainMenuStrip = new MenuStrip();
            //this.MainMenuStrip.Parent = this;
            this.Controls.Add(this.MainMenuStrip);

            this.MainMenuStrip.Items.Add(fileMenuItem);
            this.MainMenuStrip.Items.Add(editMenuItem);
            this.MainMenuStrip.Items.Add(helpMenuItem);


        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save file");
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open file");
        }

        void FileNewMenuItem_Click(object sender, EventArgs args)
        {
            MessageBox.Show("New file");
        }
    }
}
