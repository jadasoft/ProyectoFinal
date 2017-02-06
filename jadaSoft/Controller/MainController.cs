using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using jadaSoft;
using System.Windows.Forms;





namespace Controller
{

   

    class MainController
    {

        protected Form1 mainView { get; }
        protected JADAEntities db { get; }

        public MainController()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainView = new Form1();
            db = new JADAEntities();
            //initListeners();
        }

        /**
         * Adds the main listeners to the windows.
         */
        //private void initListeners()
        //{
        //    //User/Contact data.
        //    this.mainView.contactsDataGrid.SelectionChanged += contactsSelectionChanged;
        //    this.mainView.userAdd.MouseClick += (a, b) => {
        //        contacte ctc = new contacte();
        //        ctc.nom = this.mainView.contactName.Text;
        //        this.db.contactes.Add(ctc);
        //        this.trySyncDB();
        //        this.populateContacts();
        //    };
        //    this.mainView.userDel.MouseClick += (a, b) => {
        //        contacte ct = this.getSelectedContact();
        //        this.db.telefons.RemoveRange(ct.telefons);
        //        this.db.SaveChanges();
        //        this.db.contactes.Remove(ct);
        //        this.trySyncDB();
        //        this.populateContacts();
        //    };
        //    this.mainView.userSave.MouseClick += (a, b) => {
        //        contacte dbc = getSelectedContact();
        //        dbc.nom = this.mainView.contactName.Text;
        //        this.trySyncDB();
        //        this.populateContacts();
        //    };
        //    //Detail listeners.
        //    this.mainView.detailsDatagrid.SelectionChanged += detailsSelectionChanged;
        //    this.mainView.phoneAdd.MouseClick += (a, b) =>
        //    {
        //        telefon tlf = new telefon();
        //        tlf.telefon1 = this.mainView.detailPhone.Text;
        //        tlf.descripcio = this.mainView.detailDesc.Text;
        //        tlf.contacte = this.getSelectedContact();
        //        tlf.idcontacte = this.getSelectedContact().id;
        //        this.db.telefons.Add(tlf);
        //        this.trySyncDB();
        //        this.populatePhones();
        //    };
        //    this.mainView.phoneDel.MouseClick += (a, b) =>
        //    {
        //        this.db.telefons.Remove(this.getSelectedPhone());
        //        this.trySyncDB();
        //        this.populatePhones();
        //    };
        //    this.mainView.phoneSave.MouseClick += (a, b) =>
        //    {
        //        telefon tlf = getSelectedPhone();
        //        tlf.telefon1 = this.mainView.detailPhone.Text;
        //        tlf.descripcio = this.mainView.detailDesc.Text;
        //        this.trySyncDB();
        //        this.populatePhones();
        //    };
        //}

        /**
         * Attempts to synchronize the database elements.
         * if an exception is thrown during the transaction, this is aborted and a message is shown.
         */
        //public void trySyncDB()
        //{
        //    try
        //    {
        //        this.db.SaveChanges();
        //        //Si des-comentes aquesta linea es pot veure el "Exception handling".
        //        //throw new Exception("BLABLABLA!");
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionThrowErrorMessage msg = new ExceptionThrowErrorMessage(ex);
        //        msg.ShowDialog();
        //    }
        //}

        /**
         * Called on selection changed on the contacts list.
        // */
        //private void contactsSelectionChanged(object sender, EventArgs args)
        //{
        //    contacte ct = this.getSelectedContact();
        //    if (ct != null)
        //    {
        //        this.mainView.contactName.Text = ct.nom;
        //    }
        //    this.populatePhones();
        //}

        //private void detailsSelectionChanged(object sender, EventArgs args)
        //{
        //    telefon tlf = this.getSelectedPhone();
        //    if (tlf != null)
        //    {
        //        this.mainView.detailPhone.Text = tlf.telefon1;
        //        this.mainView.detailDesc.Text = tlf.descripcio;
        //    }
        //}

        /**
         * Gets the contacts data grid view.
         */
        //protected DataGridView getContactsGrid()
        //{
        //    return this.mainView.contactsDataGrid;
        //}

        /**
         * Gets the phones data grid.
         */
        //protected DataGridView getPhonesGrid()
        //{
        //    return this.mainView.detailsDatagrid;
        //}

        /**
         * looks up and casts to contact entity the selected row.
        // */
        //public contacte getSelectedContact()
        //{
        //    if (getContactsGrid().SelectedRows.Count <= 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return getSelectedContactRaw().castFrom(this.db.contactes);
        //    }
        //}

        //public ContactDTO getSelectedContactRaw()
        //{
        //    if (getContactsGrid().SelectedRows.Count <= 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return ContactDTO.castFromRow(getContactsGrid().SelectedRows[0].Cells);
        //    }
        //}

        //public telefon getSelectedPhone()
        //{
        //    if (getPhonesGrid().SelectedRows.Count <= 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return this.getSelectedPhoneRaw().castFrom(this.db.telefons);
        //    }
        //}

        //public PhoneDTO getSelectedPhoneRaw()
        //{
        //    if (getPhonesGrid().SelectedRows.Count <= 0)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return PhoneDTO.castFromRow(getPhonesGrid().SelectedRows[0].Cells);
        //    }
        //}

        ///**
        // * Refreshes the view from data of the database.
        // */
        //private void populateContacts()
        //{
        //    getContactsGrid().DataSource = this.db.contactes.ToArray().Select((ctc) => new ContactDTO(ctc)).ToList();
        //}

        ///**
        // * Refreshes the view from the data of the database, crossed with the selected contact.
        // */
        //private void populatePhones()
        //{
        //    contacte contact = getSelectedContact();
        //    if (contact != null)
        //    {
        //        getPhonesGrid().DataSource = contact.telefons.ToArray().Select((tlf) => new PhoneDTO(tlf)).ToList();
        //    }
        //}

        ///**
        // * Populates the main data grid and runs the application thread.
        // */
        public void start()
        {
           // populateContacts();
            this.run();
        }

        /**
         * Windows forms thread initializer.
         */
        [STAThread]
        protected void run()
        {
            try
            {
                Application.Run(this.mainView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
              //  ExceptionThrowErrorMessage msg = new ExceptionThrowErrorMessage(ex);
               // msg.ShowDialog();
            }
        }

    }
}
