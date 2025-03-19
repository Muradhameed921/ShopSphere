using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EComm.Forms
{
    public class BaseForm : UserControl
    {
        public virtual bool IsFullScreen()
        {
            return true;
        }

        public virtual void OnLoad() { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
