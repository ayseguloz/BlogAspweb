using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlogAsp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBL_HAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBL_HAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();// tableadapterda bulunan metoda ulaşıldı.
            Repeater1.DataBind();


            DataSet1TableAdapters.TBL_DENEYİMTableAdapter dt2 = new DataSet1TableAdapters.TBL_DENEYİMTableAdapter();
            Repeater2.DataSource = dt2.DeneyimListele();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGİTİMTableAdapter dt3 = new DataSet1TableAdapters.TBLEGİTİMTableAdapter();
            Repeater3.DataSource = dt3.EğitimListele();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLHOBİTableAdapter dt5 = new DataSet1TableAdapters.TBLHOBİTableAdapter();
            Repeater5.DataSource = dt5.HobiListele();
            Repeater5.DataBind();

            DataSet1TableAdapters.TBLBELGETableAdapter dt6 = new DataSet1TableAdapters.TBLBELGETableAdapter();
            Repeater6.DataSource = dt6.BelgeListele();
            Repeater6.DataBind();

            

        }
    }
}