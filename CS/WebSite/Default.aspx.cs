using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
	protected void glCategory_Load(object sender, EventArgs e) {
		(sender as ASPxGridLookup).GridView.Width = new Unit(500, UnitType.Pixel);
	}
	protected void grid_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e) {
        throw new CallbackException("Operation is not allowed in demonstration mode");
	}
	protected void grid_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
		throw new CallbackException("Operation is not allowed in demonstration mode");
	}
}
