using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class ControlNavegacion
    {
        private List<UserControl> userControlList = new List<UserControl>();
        private Panel panel;

        public ControlNavegacion(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                // set every UserControl's dock style to fill so that it will occupy the space inside the panel
                userControlList[i].Dock = DockStyle.Fill;
                // add all the UserControl inside the panel
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void HideActual(int index)
        {
            userControlList[index].Hide();
        }

        public void Display(int index)
        {
            if (index < userControlList.Count())
            {
                userControlList[index].Show();
                userControlList[index].BringToFront(); // display only the selected UserControl using index
            }
        }
    }
}