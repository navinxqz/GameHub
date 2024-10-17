using GameServer_Management.Forms;
using System;
using System.Drawing;
using System.Reflection;    //for using protedted method: OnClick
using System.Windows.Forms;

namespace GameServer_Management.Class
{
    public static class Utility
    {
        public static void ClickEvent(Control parent, EventHandler clickEvent)
        {
            if(parent == null || clickEvent == null)
            {
                throw new ArgumentNullException("Control or Event can't be null");
            }
            parent.Click += clickEvent;

            foreach (Control child in parent.Controls)
            {
                child.Click += (s, e) =>
                {
                    MethodInfo onclick = typeof(Control).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic);
                    onclick?.Invoke(parent, new object[] { e });
                };
            }
        }

        public static void BlurBg(Form f)
        {
            Form Bg = new Form();
            using (f)
            {
                Bg.StartPosition = FormStartPosition.Manual;
                Bg.FormBorderStyle = FormBorderStyle.None;
                Bg.Opacity = 0.5;
                Bg.BackColor = Color.Black;
                Bg.Size = AdminPanel.Instance(true).Size;
                Bg.Location = AdminPanel.Instance(true).Location;
                Bg.ShowInTaskbar = false;

                Bg.Show();
                f.Owner = Bg;
                f.ShowDialog(Bg);
                Bg.Dispose();
            }
        }
    }
}
