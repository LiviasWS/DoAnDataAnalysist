using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class UCFilterItemCheckBoxList : UserControl
    {
        private int cornerRadius = 20;
        string title;
        List<string> itemList;

        public UCFilterItemCheckBoxList(string title, List<String> itemList)
        {
            InitializeComponent();
            this.title = title;
            this.itemList = itemList;
        }

        private void UCFilterItem_Load(object sender, EventArgs e)
        {
            lblTitle.Text = title;
            for (int i=0; i< itemList.Count; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = itemList[i];
                flpList.Controls.Add(checkBox);
            }

            GraphicsPath path = new GraphicsPath();
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);

            int r = cornerRadius;

            path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);                            
            path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);                    
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);            
            path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);                   
            path.CloseAllFigures();

            this.Region = new Region(path);

        }

    }
}
