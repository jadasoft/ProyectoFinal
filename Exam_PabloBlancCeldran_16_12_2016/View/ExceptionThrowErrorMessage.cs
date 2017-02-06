using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /**
     * This view shows relevant information form an exception.
     */
    public partial class ExceptionThrowErrorMessage : Form
    {
        public ExceptionThrowErrorMessage(Exception ex)
        {
            InitializeComponent();
            typeException.Text = ex.GetType().ToString();
            exceptionText.Text = ex.ToString();
        }
    }
}
