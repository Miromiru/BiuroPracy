using BiuroPracy.BusinessLogic.Api;
using BiuroPracy.BusinessLogic.Api.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BiuroPracy.Controls
{
    public partial class AddEmployeeControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitControl();
            }
        }

        #region Methods

        private void InitProfession()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetProfessionals();
            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }
            ddlProfession.DataSource = dataResponse.Data;
            ddlProfession.DataTextField = "Name";
            ddlProfession.DataValueField = "Id";
            ddlProfession.DataBind();
        }

        private void InitContract()
        {
            IBiuroPracyApi api = new BiuroPracyApi();
            var dataResponse = api.GetContract();
            if (!dataResponse.Success)
            {
                Trace.Warn(dataResponse.Errors);
                return;
            }
            ddlContractOfEmployment.DataSource = dataResponse.Data;
            ddlContractOfEmployment.DataTextField = "Name";
            ddlContractOfEmployment.DataValueField = "Id";
            ddlContractOfEmployment.DataBind();
        }

        private void InitControl()
        {
            InitProfession();
            InitContract();
        }

        #endregion
    }
}