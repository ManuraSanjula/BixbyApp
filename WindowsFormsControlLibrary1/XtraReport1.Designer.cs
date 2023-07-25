namespace WindowsFormsControlLibrary1
{
    partial class XtraReport1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery1 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode1 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("CartAndOrder", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode2 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode3 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Item", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode4 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode5 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Quantity", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode6 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Price", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery2 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode7 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("productPurchases", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode8 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode9 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("orderId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode10 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("cutomerId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode11 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ownerId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode12 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("isDeliverd", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode13 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("isRefund", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery3 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode14 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Order", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode15 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode16 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Items", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode17 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode18 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Price", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode19 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Confirm", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery4 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode20 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ShopItem", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode21 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode22 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Name", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode23 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Description", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode24 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalComments", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode25 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Price", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode26 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Pics", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Array);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode27 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("publish", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode28 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("FirstName", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode29 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("LastName", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode30 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Email", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode31 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Pic", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode32 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("loveThisProduct", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery5 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode33 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Comment", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode34 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode35 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("UserComment", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode36 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode37 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ShopItem", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery6 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode38 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("UserShop", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode39 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode40 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode41 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Item", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode42 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalSuccessfulOrders", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode43 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalRefunds", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode44 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalViews", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailReport3 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailReport4 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.DetailReport5 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader5 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader6 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader7 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader8 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader9 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader10 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader11 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader12 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table6 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table7 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table8 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table9 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table10 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table11 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table12 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.mongoDBDataSource1 = new DevExpress.DataAccess.MongoDB.MongoDBDataSource(this.components);
            this.GroupHeader13 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader14 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader15 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader16 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader17 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader18 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader19 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader20 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader21 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader22 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader23 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader24 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader25 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.table13 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table14 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table15 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table16 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table17 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table18 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table19 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table20 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table21 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table22 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table23 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table24 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table25 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader26 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader27 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader28 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader29 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader30 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader31 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader32 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader33 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader34 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader35 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader36 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader37 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader38 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader39 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader40 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader41 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader42 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader43 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter3 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.table26 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table27 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table28 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table29 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table30 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table31 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table32 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table33 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table34 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table35 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table36 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table37 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table38 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table39 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table40 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table41 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow41 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table42 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow42 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table43 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow43 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader44 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader45 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader46 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader47 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader48 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader49 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader50 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader51 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader52 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader53 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader54 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader55 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader56 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail4 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter4 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.table44 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow44 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table45 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow45 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table46 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow46 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table47 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow47 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table48 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow48 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table49 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow49 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table50 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow50 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table51 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow51 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table52 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow52 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table53 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow53 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table54 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow54 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table55 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow55 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table56 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow56 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label5 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader57 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader58 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader59 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader60 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader61 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader62 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader63 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader64 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader65 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader66 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader67 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader68 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader69 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader70 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail5 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter5 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.table57 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow57 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell113 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell114 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table58 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow58 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell115 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell116 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table59 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow59 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table60 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow60 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table61 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow61 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table62 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow62 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table63 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow63 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table64 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow64 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table65 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow65 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table66 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow66 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table67 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow67 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table68 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow68 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table69 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow69 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table70 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow70 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label6 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader71 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader72 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader73 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader74 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader75 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader76 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader77 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader78 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader79 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader80 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader81 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader82 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader83 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader84 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader85 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupHeader86 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail6 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter6 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.table71 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow71 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell142 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table72 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow72 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell143 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table73 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow73 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell145 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table74 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow74 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table75 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow75 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table76 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow76 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table77 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow77 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell153 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell154 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table78 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow78 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell155 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell156 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table79 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow79 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell157 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell158 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table80 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow80 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell159 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell160 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table81 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow81 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell161 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell162 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table82 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow82 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell163 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell164 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table83 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow83 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell165 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell166 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table84 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow84 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell167 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell168 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table85 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow85 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell169 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell170 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table86 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow86 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell171 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell172 = new DevExpress.XtraReports.UI.XRTableCell();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader1,
            this.GroupHeader2,
            this.GroupHeader3,
            this.GroupHeader4,
            this.GroupHeader5,
            this.GroupHeader6,
            this.GroupHeader7,
            this.GroupHeader8,
            this.GroupHeader9,
            this.GroupHeader10,
            this.GroupHeader11,
            this.GroupHeader12,
            this.Detail1,
            this.GroupFooter1});
            this.DetailReport.DataMember = "Users";
            this.DetailReport.DataSource = this.mongoDBDataSource1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader13,
            this.GroupHeader14,
            this.GroupHeader15,
            this.GroupHeader16,
            this.GroupHeader17,
            this.GroupHeader18,
            this.GroupHeader19,
            this.GroupHeader20,
            this.GroupHeader21,
            this.GroupHeader22,
            this.GroupHeader23,
            this.GroupHeader24,
            this.GroupHeader25,
            this.Detail2,
            this.GroupFooter2});
            this.DetailReport1.DataMember = "CartAndOrder";
            this.DetailReport1.DataSource = this.mongoDBDataSource1;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader26,
            this.GroupHeader27,
            this.GroupHeader28,
            this.GroupHeader29,
            this.GroupHeader30,
            this.GroupHeader31,
            this.GroupHeader32,
            this.GroupHeader33,
            this.GroupHeader34,
            this.GroupHeader35,
            this.GroupHeader36,
            this.GroupHeader37,
            this.GroupHeader38,
            this.GroupHeader39,
            this.GroupHeader40,
            this.GroupHeader41,
            this.GroupHeader42,
            this.GroupHeader43,
            this.Detail3,
            this.GroupFooter3});
            this.DetailReport2.DataMember = "productPurchases";
            this.DetailReport2.DataSource = this.mongoDBDataSource1;
            this.DetailReport2.Level = 2;
            this.DetailReport2.Name = "DetailReport2";
            // 
            // DetailReport3
            // 
            this.DetailReport3.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader44,
            this.GroupHeader45,
            this.GroupHeader46,
            this.GroupHeader47,
            this.GroupHeader48,
            this.GroupHeader49,
            this.GroupHeader50,
            this.GroupHeader51,
            this.GroupHeader52,
            this.GroupHeader53,
            this.GroupHeader54,
            this.GroupHeader55,
            this.GroupHeader56,
            this.Detail4,
            this.GroupFooter4});
            this.DetailReport3.DataMember = "Order";
            this.DetailReport3.DataSource = this.mongoDBDataSource1;
            this.DetailReport3.Level = 3;
            this.DetailReport3.Name = "DetailReport3";
            // 
            // DetailReport4
            // 
            this.DetailReport4.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader57,
            this.GroupHeader58,
            this.GroupHeader59,
            this.GroupHeader60,
            this.GroupHeader61,
            this.GroupHeader62,
            this.GroupHeader63,
            this.GroupHeader64,
            this.GroupHeader65,
            this.GroupHeader66,
            this.GroupHeader67,
            this.GroupHeader68,
            this.GroupHeader69,
            this.GroupHeader70,
            this.Detail5,
            this.GroupFooter5});
            this.DetailReport4.DataMember = "ShopItem";
            this.DetailReport4.DataSource = this.mongoDBDataSource1;
            this.DetailReport4.Level = 4;
            this.DetailReport4.Name = "DetailReport4";
            // 
            // DetailReport5
            // 
            this.DetailReport5.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader71,
            this.GroupHeader72,
            this.GroupHeader73,
            this.GroupHeader74,
            this.GroupHeader75,
            this.GroupHeader76,
            this.GroupHeader77,
            this.GroupHeader78,
            this.GroupHeader79,
            this.GroupHeader80,
            this.GroupHeader81,
            this.GroupHeader82,
            this.GroupHeader83,
            this.GroupHeader84,
            this.GroupHeader85,
            this.GroupHeader86,
            this.Detail6,
            this.GroupFooter6});
            this.DetailReport5.DataMember = "Comment";
            this.DetailReport5.DataSource = this.mongoDBDataSource1;
            this.DetailReport5.Level = 5;
            this.DetailReport5.Name = "DetailReport5";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(450F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(450F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(450F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(900F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "NIBM-App";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("EmailVerify", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 27F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Pic", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 27F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.GroupHeader3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Password", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader3.HeightF = 27F;
            this.GroupHeader3.Level = 3;
            this.GroupHeader3.Name = "GroupHeader3";
            // 
            // GroupHeader4
            // 
            this.GroupHeader4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table4});
            this.GroupHeader4.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Address", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader4.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader4.HeightF = 27F;
            this.GroupHeader4.Level = 4;
            this.GroupHeader4.Name = "GroupHeader4";
            // 
            // GroupHeader5
            // 
            this.GroupHeader5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table5});
            this.GroupHeader5.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Email", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader5.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader5.HeightF = 27F;
            this.GroupHeader5.Level = 5;
            this.GroupHeader5.Name = "GroupHeader5";
            // 
            // GroupHeader6
            // 
            this.GroupHeader6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table6});
            this.GroupHeader6.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader6.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader6.HeightF = 27F;
            this.GroupHeader6.Level = 6;
            this.GroupHeader6.Name = "GroupHeader6";
            // 
            // GroupHeader7
            // 
            this.GroupHeader7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table7});
            this.GroupHeader7.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("FirstName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader7.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader7.HeightF = 27F;
            this.GroupHeader7.Level = 7;
            this.GroupHeader7.Name = "GroupHeader7";
            // 
            // GroupHeader8
            // 
            this.GroupHeader8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table8});
            this.GroupHeader8.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader8.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader8.HeightF = 27F;
            this.GroupHeader8.Level = 8;
            this.GroupHeader8.Name = "GroupHeader8";
            // 
            // GroupHeader9
            // 
            this.GroupHeader9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table9});
            this.GroupHeader9.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader9.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader9.HeightF = 27F;
            this.GroupHeader9.Level = 9;
            this.GroupHeader9.Name = "GroupHeader9";
            // 
            // GroupHeader10
            // 
            this.GroupHeader10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table10});
            this.GroupHeader10.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader10.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader10.HeightF = 27F;
            this.GroupHeader10.Level = 10;
            this.GroupHeader10.Name = "GroupHeader10";
            // 
            // GroupHeader11
            // 
            this.GroupHeader11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table11});
            this.GroupHeader11.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader11.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader11.HeightF = 27F;
            this.GroupHeader11.Level = 11;
            this.GroupHeader11.Name = "GroupHeader11";
            // 
            // GroupHeader12
            // 
            this.GroupHeader12.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table12});
            this.GroupHeader12.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader12.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader12.HeightF = 27F;
            this.GroupHeader12.Level = 12;
            this.GroupHeader12.Name = "GroupHeader12";
            // 
            // Detail1
            // 
            this.Detail1.HeightF = 0F;
            this.Detail1.Name = "Detail1";
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label2});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 6F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table1.Name = "table1";
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.StyleName = "GroupCaption2";
            this.tableCell1.Text = "EMAIL VERIFY";
            this.tableCell1.Weight = 1445302.375D;
            // 
            // tableCell2
            // 
            this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[EmailVerify]")});
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.StyleName = "GroupData2";
            this.tableCell2.Weight = 13300297D;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "GroupCaption2";
            this.tableCell3.Text = "PIC";
            this.tableCell3.Weight = 444027.40625D;
            // 
            // tableCell4
            // 
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Pic]")});
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "GroupData2";
            this.tableCell4.Weight = 14301572D;
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table3.Name = "table3";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5,
            this.tableCell6});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 1D;
            // 
            // tableCell5
            // 
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "GroupCaption2";
            this.tableCell5.Text = "PASSWORD";
            this.tableCell5.Weight = 0.083866984049479162D;
            // 
            // tableCell6
            // 
            this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Password]")});
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "GroupData2";
            this.tableCell6.Weight = 0.91613301595052088D;
            // 
            // table4
            // 
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table4.Name = "table4";
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
            this.table4.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Weight = 1D;
            // 
            // tableCell7
            // 
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "GroupCaption2";
            this.tableCell7.Text = "ADDRESS";
            this.tableCell7.Weight = 1049027.375D;
            // 
            // tableCell8
            // 
            this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Address]")});
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "GroupData2";
            this.tableCell8.Weight = 13696572D;
            // 
            // table5
            // 
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table5.Name = "table5";
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10});
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Weight = 1D;
            // 
            // tableCell9
            // 
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "GroupCaption2";
            this.tableCell9.Text = "EMAIL";
            this.tableCell9.Weight = 0.048494851854112411D;
            // 
            // tableCell10
            // 
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Email]")});
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "GroupData2";
            this.tableCell10.Weight = 0.95150519476996531D;
            // 
            // table6
            // 
            this.table6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table6.Name = "table6";
            this.table6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow6});
            this.table6.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow6
            // 
            this.tableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell11,
            this.tableCell12});
            this.tableRow6.Name = "tableRow6";
            this.tableRow6.Weight = 1D;
            // 
            // tableCell11
            // 
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "GroupCaption2";
            this.tableCell11.Text = "LAST NAME";
            this.tableCell11.Weight = 1226127.375D;
            // 
            // tableCell12
            // 
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LastName]")});
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "GroupData2";
            this.tableCell12.Weight = 13519472D;
            // 
            // table7
            // 
            this.table7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table7.Name = "table7";
            this.table7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow7});
            this.table7.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow7
            // 
            this.tableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell13,
            this.tableCell14});
            this.tableRow7.Name = "tableRow7";
            this.tableRow7.Weight = 1D;
            // 
            // tableCell13
            // 
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "GroupCaption2";
            this.tableCell13.Text = "FIRST NAME";
            this.tableCell13.Weight = 0.086689292060004336D;
            // 
            // tableCell14
            // 
            this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FirstName]")});
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "GroupData2";
            this.tableCell14.Weight = 0.91331075032552078D;
            // 
            // table8
            // 
            this.table8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table8.Name = "table8";
            this.table8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow8});
            this.table8.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow8
            // 
            this.tableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15,
            this.tableCell16});
            this.tableRow8.Name = "tableRow8";
            this.tableRow8.Weight = 1D;
            // 
            // tableCell15
            // 
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.StyleName = "GroupCaption2";
            this.tableCell15.Text = " ID MACHINE";
            this.tableCell15.Weight = 0.0881066640218099D;
            // 
            // tableCell16
            // 
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.StyleName = "GroupData2";
            this.tableCell16.Weight = 0.91189337836371531D;
            // 
            // table9
            // 
            this.table9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table9.Name = "table9";
            this.table9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow9});
            this.table9.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow9
            // 
            this.tableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell17,
            this.tableCell18});
            this.tableRow9.Name = "tableRow9";
            this.tableRow9.Weight = 1D;
            // 
            // tableCell17
            // 
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.StyleName = "GroupCaption2";
            this.tableCell17.Text = " ID CREATION TIME";
            this.tableCell17.Weight = 0.12912963019476997D;
            // 
            // tableCell18
            // 
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.StyleName = "GroupData2";
            this.tableCell18.Weight = 0.870870361328125D;
            // 
            // table10
            // 
            this.table10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table10.Name = "table10";
            this.table10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow10});
            this.table10.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow10
            // 
            this.tableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell19,
            this.tableCell20});
            this.tableRow10.Name = "tableRow10";
            this.tableRow10.Weight = 1D;
            // 
            // tableCell19
            // 
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.StyleName = "GroupCaption2";
            this.tableCell19.Text = " ID INCREMENT";
            this.tableCell19.Weight = 1539077.375D;
            // 
            // tableCell20
            // 
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.StyleName = "GroupData2";
            this.tableCell20.Weight = 13206522D;
            // 
            // table11
            // 
            this.table11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table11.Name = "table11";
            this.table11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow11});
            this.table11.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow11
            // 
            this.tableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell21,
            this.tableCell22});
            this.tableRow11.Name = "tableRow11";
            this.tableRow11.Weight = 1D;
            // 
            // tableCell21
            // 
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.StyleName = "GroupCaption2";
            this.tableCell21.Text = " ID PID";
            this.tableCell21.Weight = 736077.3125D;
            // 
            // tableCell22
            // 
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.StyleName = "GroupData2";
            this.tableCell22.Weight = 14009522D;
            // 
            // table12
            // 
            this.table12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table12.Name = "table12";
            this.table12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow12});
            this.table12.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow12
            // 
            this.tableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell23,
            this.tableCell24});
            this.tableRow12.Name = "tableRow12";
            this.tableRow12.Weight = 1D;
            // 
            // tableCell23
            // 
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.StyleName = "GroupCaption2";
            this.tableCell23.Text = " ID TIMESTAMP";
            this.tableCell23.Weight = 1528627.375D;
            // 
            // tableCell24
            // 
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.StyleName = "GroupData2";
            this.tableCell24.Weight = 13216972D;
            // 
            // label2
            // 
            this.label2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label2.Name = "label2";
            this.label2.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label2.StyleName = "GroupFooterBackground3";
            this.label2.StylePriority.UseBorders = false;
            // 
            // mongoDBDataSource1
            // 
            this.mongoDBDataSource1.ConnectionName = "Online";
            this.mongoDBDataSource1.Name = "mongoDBDataSource1";
            mongoDBQuery1.ActualName = "CartAndOrder";
            mongoDBQuery1.Alias = null;
            mongoDBQuery1.CollectionName = "CartAndOrder";
            mongoDBQuery1.DatabaseName = "BixByApp";
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode2);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode3);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode4);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode5);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode6);
            mongoDBQuery1.Schema = mongoDBSchemaNode1;
            mongoDBQuery2.ActualName = "productPurchases";
            mongoDBQuery2.Alias = null;
            mongoDBQuery2.CollectionName = "productPurchases";
            mongoDBQuery2.DatabaseName = "BixByApp";
            mongoDBSchemaNode7.Nodes.Add(mongoDBSchemaNode8);
            mongoDBSchemaNode7.Nodes.Add(mongoDBSchemaNode9);
            mongoDBSchemaNode7.Nodes.Add(mongoDBSchemaNode10);
            mongoDBSchemaNode7.Nodes.Add(mongoDBSchemaNode11);
            mongoDBSchemaNode7.Nodes.Add(mongoDBSchemaNode12);
            mongoDBSchemaNode7.Nodes.Add(mongoDBSchemaNode13);
            mongoDBQuery2.Schema = mongoDBSchemaNode7;
            mongoDBQuery3.ActualName = "Order";
            mongoDBQuery3.Alias = null;
            mongoDBQuery3.CollectionName = "Order";
            mongoDBQuery3.DatabaseName = "BixByApp";
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode15);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode16);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode17);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode18);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode19);
            mongoDBQuery3.Schema = mongoDBSchemaNode14;
            mongoDBQuery4.ActualName = "ShopItem";
            mongoDBQuery4.Alias = null;
            mongoDBQuery4.CollectionName = "ShopItem";
            mongoDBQuery4.DatabaseName = "BixByApp";
            mongoDBSchemaNode27.Nodes.Add(mongoDBSchemaNode28);
            mongoDBSchemaNode27.Nodes.Add(mongoDBSchemaNode29);
            mongoDBSchemaNode27.Nodes.Add(mongoDBSchemaNode30);
            mongoDBSchemaNode27.Nodes.Add(mongoDBSchemaNode31);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode21);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode22);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode23);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode24);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode25);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode26);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode27);
            mongoDBSchemaNode20.Nodes.Add(mongoDBSchemaNode32);
            mongoDBQuery4.Schema = mongoDBSchemaNode20;
            mongoDBQuery5.ActualName = "Comment";
            mongoDBQuery5.Alias = null;
            mongoDBQuery5.CollectionName = "Comment";
            mongoDBQuery5.DatabaseName = "BixByApp";
            mongoDBSchemaNode33.Nodes.Add(mongoDBSchemaNode34);
            mongoDBSchemaNode33.Nodes.Add(mongoDBSchemaNode35);
            mongoDBSchemaNode33.Nodes.Add(mongoDBSchemaNode36);
            mongoDBSchemaNode33.Nodes.Add(mongoDBSchemaNode37);
            mongoDBQuery5.Schema = mongoDBSchemaNode33;
            mongoDBQuery6.ActualName = "UserShop";
            mongoDBQuery6.Alias = null;
            mongoDBQuery6.CollectionName = "UserShop";
            mongoDBQuery6.DatabaseName = "BixByApp";
            mongoDBSchemaNode38.Nodes.Add(mongoDBSchemaNode39);
            mongoDBSchemaNode38.Nodes.Add(mongoDBSchemaNode40);
            mongoDBSchemaNode38.Nodes.Add(mongoDBSchemaNode41);
            mongoDBSchemaNode38.Nodes.Add(mongoDBSchemaNode42);
            mongoDBSchemaNode38.Nodes.Add(mongoDBSchemaNode43);
            mongoDBSchemaNode38.Nodes.Add(mongoDBSchemaNode44);
            mongoDBQuery6.Schema = mongoDBSchemaNode38;
            this.mongoDBDataSource1.Queries.AddRange(new DevExpress.DataAccess.MongoDB.MongoDBQuery[] {
            mongoDBQuery1,
            mongoDBQuery2,
            mongoDBQuery3,
            mongoDBQuery4,
            mongoDBQuery5,
            mongoDBQuery6});
            this.mongoDBDataSource1.ResultSchemaSerializable = resources.GetString("mongoDBDataSource1.ResultSchemaSerializable");
            // 
            // GroupHeader13
            // 
            this.GroupHeader13.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table13});
            this.GroupHeader13.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Price", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader13.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader13.HeightF = 27F;
            this.GroupHeader13.Level = 1;
            this.GroupHeader13.Name = "GroupHeader13";
            // 
            // GroupHeader14
            // 
            this.GroupHeader14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table14});
            this.GroupHeader14.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Quantity", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader14.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader14.HeightF = 27F;
            this.GroupHeader14.Level = 2;
            this.GroupHeader14.Name = "GroupHeader14";
            // 
            // GroupHeader15
            // 
            this.GroupHeader15.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table15});
            this.GroupHeader15.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader15.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader15.HeightF = 27F;
            this.GroupHeader15.Level = 3;
            this.GroupHeader15.Name = "GroupHeader15";
            // 
            // GroupHeader16
            // 
            this.GroupHeader16.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table16});
            this.GroupHeader16.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader16.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader16.HeightF = 27F;
            this.GroupHeader16.Level = 4;
            this.GroupHeader16.Name = "GroupHeader16";
            // 
            // GroupHeader17
            // 
            this.GroupHeader17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table17});
            this.GroupHeader17.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader17.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader17.HeightF = 27F;
            this.GroupHeader17.Level = 5;
            this.GroupHeader17.Name = "GroupHeader17";
            // 
            // GroupHeader18
            // 
            this.GroupHeader18.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table18});
            this.GroupHeader18.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader18.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader18.HeightF = 27F;
            this.GroupHeader18.Level = 6;
            this.GroupHeader18.Name = "GroupHeader18";
            // 
            // GroupHeader19
            // 
            this.GroupHeader19.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table19});
            this.GroupHeader19.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader19.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader19.HeightF = 27F;
            this.GroupHeader19.Level = 7;
            this.GroupHeader19.Name = "GroupHeader19";
            // 
            // GroupHeader20
            // 
            this.GroupHeader20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table20});
            this.GroupHeader20.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader20.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader20.HeightF = 27F;
            this.GroupHeader20.Level = 8;
            this.GroupHeader20.Name = "GroupHeader20";
            // 
            // GroupHeader21
            // 
            this.GroupHeader21.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table21});
            this.GroupHeader21.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader21.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader21.HeightF = 27F;
            this.GroupHeader21.Level = 9;
            this.GroupHeader21.Name = "GroupHeader21";
            // 
            // GroupHeader22
            // 
            this.GroupHeader22.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table22});
            this.GroupHeader22.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader22.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader22.HeightF = 27F;
            this.GroupHeader22.Level = 10;
            this.GroupHeader22.Name = "GroupHeader22";
            // 
            // GroupHeader23
            // 
            this.GroupHeader23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table23});
            this.GroupHeader23.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader23.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader23.HeightF = 27F;
            this.GroupHeader23.Level = 11;
            this.GroupHeader23.Name = "GroupHeader23";
            // 
            // GroupHeader24
            // 
            this.GroupHeader24.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table24});
            this.GroupHeader24.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader24.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader24.HeightF = 27F;
            this.GroupHeader24.Level = 12;
            this.GroupHeader24.Name = "GroupHeader24";
            // 
            // GroupHeader25
            // 
            this.GroupHeader25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table25});
            this.GroupHeader25.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader25.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader25.HeightF = 27F;
            this.GroupHeader25.Level = 13;
            this.GroupHeader25.Name = "GroupHeader25";
            // 
            // Detail2
            // 
            this.Detail2.HeightF = 0F;
            this.Detail2.Name = "Detail2";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label3});
            this.GroupFooter2.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter2.HeightF = 6F;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // table13
            // 
            this.table13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table13.Name = "table13";
            this.table13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow13});
            this.table13.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow13
            // 
            this.tableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell25,
            this.tableCell26});
            this.tableRow13.Name = "tableRow13";
            this.tableRow13.Weight = 1D;
            // 
            // tableCell25
            // 
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.StyleName = "GroupCaption2";
            this.tableCell25.Text = "PRICE";
            this.tableCell25.Weight = 0.047798597547743057D;
            // 
            // tableCell26
            // 
            this.tableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")});
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.StyleName = "GroupData2";
            this.tableCell26.Weight = 0.95220140245225693D;
            // 
            // table14
            // 
            this.table14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table14.Name = "table14";
            this.table14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow14});
            this.table14.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow14
            // 
            this.tableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell27,
            this.tableCell28});
            this.tableRow14.Name = "tableRow14";
            this.tableRow14.Weight = 1D;
            // 
            // tableCell27
            // 
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.StyleName = "GroupCaption2";
            this.tableCell27.Text = "QUANTITY";
            this.tableCell27.Weight = 1090552.375D;
            // 
            // tableCell28
            // 
            this.tableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.StyleName = "GroupData2";
            this.tableCell28.Weight = 13655047D;
            // 
            // table15
            // 
            this.table15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table15.Name = "table15";
            this.table15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow15});
            this.table15.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow15
            // 
            this.tableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell29,
            this.tableCell30});
            this.tableRow15.Name = "tableRow15";
            this.tableRow15.Weight = 1D;
            // 
            // tableCell29
            // 
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.StyleName = "GroupCaption2";
            this.tableCell29.Text = "USER";
            this.tableCell29.Weight = 0.044261385599772135D;
            // 
            // tableCell30
            // 
            this.tableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User]")});
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.StyleName = "GroupData2";
            this.tableCell30.Weight = 0.9557386610243056D;
            // 
            // table16
            // 
            this.table16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table16.Name = "table16";
            this.table16.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow16});
            this.table16.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow16
            // 
            this.tableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell31,
            this.tableCell32});
            this.tableRow16.Name = "tableRow16";
            this.tableRow16.Weight = 1D;
            // 
            // tableCell31
            // 
            this.tableCell31.Name = "tableCell31";
            this.tableCell31.StyleName = "GroupCaption2";
            this.tableCell31.Text = "ITEM CREATION TIME";
            this.tableCell31.Weight = 0.14327226426866319D;
            // 
            // tableCell32
            // 
            this.tableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.CreationTime]")});
            this.tableCell32.Name = "tableCell32";
            this.tableCell32.StyleName = "GroupData2";
            this.tableCell32.Weight = 0.85672770182291669D;
            // 
            // table17
            // 
            this.table17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table17.Name = "table17";
            this.table17.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow17});
            this.table17.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow17
            // 
            this.tableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell33,
            this.tableCell34});
            this.tableRow17.Name = "tableRow17";
            this.tableRow17.Weight = 1D;
            // 
            // tableCell33
            // 
            this.tableCell33.Name = "tableCell33";
            this.tableCell33.StyleName = "GroupCaption2";
            this.tableCell33.Text = "ITEM INCREMENT";
            this.tableCell33.Weight = 0.11851799011230468D;
            // 
            // tableCell34
            // 
            this.tableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Increment]")});
            this.tableCell34.Name = "tableCell34";
            this.tableCell34.StyleName = "GroupData2";
            this.tableCell34.Weight = 0.8814820014105903D;
            // 
            // table18
            // 
            this.table18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table18.Name = "table18";
            this.table18.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow18});
            this.table18.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow18
            // 
            this.tableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell35,
            this.tableCell36});
            this.tableRow18.Name = "tableRow18";
            this.tableRow18.Weight = 1D;
            // 
            // tableCell35
            // 
            this.tableCell35.Name = "tableCell35";
            this.tableCell35.StyleName = "GroupCaption2";
            this.tableCell35.Text = "ITEM PID";
            this.tableCell35.Weight = 0.064061075846354162D;
            // 
            // tableCell36
            // 
            this.tableCell36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Pid]")});
            this.tableCell36.Name = "tableCell36";
            this.tableCell36.StyleName = "GroupData2";
            this.tableCell36.Weight = 0.93593892415364588D;
            // 
            // table19
            // 
            this.table19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table19.Name = "table19";
            this.table19.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow19});
            this.table19.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow19
            // 
            this.tableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell37,
            this.tableCell38});
            this.tableRow19.Name = "tableRow19";
            this.tableRow19.Weight = 1D;
            // 
            // tableCell37
            // 
            this.tableCell37.Name = "tableCell37";
            this.tableCell37.StyleName = "GroupCaption2";
            this.tableCell37.Text = "ITEM MACHINE";
            this.tableCell37.Weight = 1507727.375D;
            // 
            // tableCell38
            // 
            this.tableCell38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Machine]")});
            this.tableCell38.Name = "tableCell38";
            this.tableCell38.StyleName = "GroupData2";
            this.tableCell38.Weight = 13237872D;
            // 
            // table20
            // 
            this.table20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table20.Name = "table20";
            this.table20.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow20});
            this.table20.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow20
            // 
            this.tableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell39,
            this.tableCell40});
            this.tableRow20.Name = "tableRow20";
            this.tableRow20.Weight = 1D;
            // 
            // tableCell39
            // 
            this.tableCell39.Name = "tableCell39";
            this.tableCell39.StyleName = "GroupCaption2";
            this.tableCell39.Text = "ITEM TIMESTAMP";
            this.tableCell39.Weight = 0.11780930413140191D;
            // 
            // tableCell40
            // 
            this.tableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Timestamp]")});
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.StyleName = "GroupData2";
            this.tableCell40.Weight = 0.88219068739149309D;
            // 
            // table21
            // 
            this.table21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table21.Name = "table21";
            this.table21.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow21});
            this.table21.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow21
            // 
            this.tableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell41,
            this.tableCell42});
            this.tableRow21.Name = "tableRow21";
            this.tableRow21.Weight = 1D;
            // 
            // tableCell41
            // 
            this.tableCell41.Name = "tableCell41";
            this.tableCell41.StyleName = "GroupCaption2";
            this.tableCell41.Text = " ID CREATION TIME";
            this.tableCell41.Weight = 0.12912963019476997D;
            // 
            // tableCell42
            // 
            this.tableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.StyleName = "GroupData2";
            this.tableCell42.Weight = 0.870870361328125D;
            // 
            // table22
            // 
            this.table22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table22.Name = "table22";
            this.table22.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow22});
            this.table22.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow22
            // 
            this.tableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell43,
            this.tableCell44});
            this.tableRow22.Name = "tableRow22";
            this.tableRow22.Weight = 1D;
            // 
            // tableCell43
            // 
            this.tableCell43.Name = "tableCell43";
            this.tableCell43.StyleName = "GroupCaption2";
            this.tableCell43.Text = " ID INCREMENT";
            this.tableCell43.Weight = 1539077.375D;
            // 
            // tableCell44
            // 
            this.tableCell44.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell44.Name = "tableCell44";
            this.tableCell44.StyleName = "GroupData2";
            this.tableCell44.Weight = 13206522D;
            // 
            // table23
            // 
            this.table23.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table23.Name = "table23";
            this.table23.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow23});
            this.table23.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow23
            // 
            this.tableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell45,
            this.tableCell46});
            this.tableRow23.Name = "tableRow23";
            this.tableRow23.Weight = 1D;
            // 
            // tableCell45
            // 
            this.tableCell45.Name = "tableCell45";
            this.tableCell45.StyleName = "GroupCaption2";
            this.tableCell45.Text = " ID PID";
            this.tableCell45.Weight = 736077.3125D;
            // 
            // tableCell46
            // 
            this.tableCell46.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell46.Name = "tableCell46";
            this.tableCell46.StyleName = "GroupData2";
            this.tableCell46.Weight = 14009522D;
            // 
            // table24
            // 
            this.table24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table24.Name = "table24";
            this.table24.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow24});
            this.table24.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow24
            // 
            this.tableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell47,
            this.tableCell48});
            this.tableRow24.Name = "tableRow24";
            this.tableRow24.Weight = 1D;
            // 
            // tableCell47
            // 
            this.tableCell47.Name = "tableCell47";
            this.tableCell47.StyleName = "GroupCaption2";
            this.tableCell47.Text = " ID MACHINE";
            this.tableCell47.Weight = 0.0881066640218099D;
            // 
            // tableCell48
            // 
            this.tableCell48.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell48.Name = "tableCell48";
            this.tableCell48.StyleName = "GroupData2";
            this.tableCell48.Weight = 0.91189337836371531D;
            // 
            // table25
            // 
            this.table25.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table25.Name = "table25";
            this.table25.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow25});
            this.table25.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow25
            // 
            this.tableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell49,
            this.tableCell50});
            this.tableRow25.Name = "tableRow25";
            this.tableRow25.Weight = 1D;
            // 
            // tableCell49
            // 
            this.tableCell49.Name = "tableCell49";
            this.tableCell49.StyleName = "GroupCaption2";
            this.tableCell49.Text = " ID TIMESTAMP";
            this.tableCell49.Weight = 1528627.375D;
            // 
            // tableCell50
            // 
            this.tableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell50.Name = "tableCell50";
            this.tableCell50.StyleName = "GroupData2";
            this.tableCell50.Weight = 13216972D;
            // 
            // label3
            // 
            this.label3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label3.Name = "label3";
            this.label3.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label3.StyleName = "GroupFooterBackground3";
            this.label3.StylePriority.UseBorders = false;
            // 
            // GroupHeader26
            // 
            this.GroupHeader26.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table26});
            this.GroupHeader26.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("isRefund", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader26.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader26.HeightF = 27F;
            this.GroupHeader26.Level = 1;
            this.GroupHeader26.Name = "GroupHeader26";
            // 
            // GroupHeader27
            // 
            this.GroupHeader27.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table27});
            this.GroupHeader27.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("isDeliverd", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader27.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader27.HeightF = 27F;
            this.GroupHeader27.Level = 2;
            this.GroupHeader27.Name = "GroupHeader27";
            // 
            // GroupHeader28
            // 
            this.GroupHeader28.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table28});
            this.GroupHeader28.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ownerId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader28.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader28.HeightF = 27F;
            this.GroupHeader28.Level = 3;
            this.GroupHeader28.Name = "GroupHeader28";
            // 
            // GroupHeader29
            // 
            this.GroupHeader29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table29});
            this.GroupHeader29.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader29.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader29.HeightF = 27F;
            this.GroupHeader29.Level = 4;
            this.GroupHeader29.Name = "GroupHeader29";
            // 
            // GroupHeader30
            // 
            this.GroupHeader30.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table30});
            this.GroupHeader30.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader30.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader30.HeightF = 27F;
            this.GroupHeader30.Level = 5;
            this.GroupHeader30.Name = "GroupHeader30";
            // 
            // GroupHeader31
            // 
            this.GroupHeader31.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table31});
            this.GroupHeader31.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader31.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader31.HeightF = 27F;
            this.GroupHeader31.Level = 6;
            this.GroupHeader31.Name = "GroupHeader31";
            // 
            // GroupHeader32
            // 
            this.GroupHeader32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table32});
            this.GroupHeader32.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader32.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader32.HeightF = 27F;
            this.GroupHeader32.Level = 7;
            this.GroupHeader32.Name = "GroupHeader32";
            // 
            // GroupHeader33
            // 
            this.GroupHeader33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table33});
            this.GroupHeader33.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader33.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader33.HeightF = 27F;
            this.GroupHeader33.Level = 8;
            this.GroupHeader33.Name = "GroupHeader33";
            // 
            // GroupHeader34
            // 
            this.GroupHeader34.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table34});
            this.GroupHeader34.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader34.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader34.HeightF = 27F;
            this.GroupHeader34.Level = 9;
            this.GroupHeader34.Name = "GroupHeader34";
            // 
            // GroupHeader35
            // 
            this.GroupHeader35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table35});
            this.GroupHeader35.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader35.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader35.HeightF = 27F;
            this.GroupHeader35.Level = 10;
            this.GroupHeader35.Name = "GroupHeader35";
            // 
            // GroupHeader36
            // 
            this.GroupHeader36.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table36});
            this.GroupHeader36.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader36.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader36.HeightF = 27F;
            this.GroupHeader36.Level = 11;
            this.GroupHeader36.Name = "GroupHeader36";
            // 
            // GroupHeader37
            // 
            this.GroupHeader37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table37});
            this.GroupHeader37.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader37.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader37.HeightF = 27F;
            this.GroupHeader37.Level = 12;
            this.GroupHeader37.Name = "GroupHeader37";
            // 
            // GroupHeader38
            // 
            this.GroupHeader38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table38});
            this.GroupHeader38.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader38.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader38.HeightF = 27F;
            this.GroupHeader38.Level = 13;
            this.GroupHeader38.Name = "GroupHeader38";
            // 
            // GroupHeader39
            // 
            this.GroupHeader39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table39});
            this.GroupHeader39.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader39.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader39.HeightF = 27F;
            this.GroupHeader39.Level = 14;
            this.GroupHeader39.Name = "GroupHeader39";
            // 
            // GroupHeader40
            // 
            this.GroupHeader40.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table40});
            this.GroupHeader40.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader40.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader40.HeightF = 27F;
            this.GroupHeader40.Level = 15;
            this.GroupHeader40.Name = "GroupHeader40";
            // 
            // GroupHeader41
            // 
            this.GroupHeader41.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table41});
            this.GroupHeader41.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader41.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader41.HeightF = 27F;
            this.GroupHeader41.Level = 16;
            this.GroupHeader41.Name = "GroupHeader41";
            // 
            // GroupHeader42
            // 
            this.GroupHeader42.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table42});
            this.GroupHeader42.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader42.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader42.HeightF = 27F;
            this.GroupHeader42.Level = 17;
            this.GroupHeader42.Name = "GroupHeader42";
            // 
            // GroupHeader43
            // 
            this.GroupHeader43.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table43});
            this.GroupHeader43.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader43.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader43.HeightF = 27F;
            this.GroupHeader43.Level = 18;
            this.GroupHeader43.Name = "GroupHeader43";
            // 
            // Detail3
            // 
            this.Detail3.HeightF = 0F;
            this.Detail3.Name = "Detail3";
            // 
            // GroupFooter3
            // 
            this.GroupFooter3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label4});
            this.GroupFooter3.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter3.HeightF = 6F;
            this.GroupFooter3.Name = "GroupFooter3";
            // 
            // table26
            // 
            this.table26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table26.Name = "table26";
            this.table26.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow26});
            this.table26.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow26
            // 
            this.tableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell51,
            this.tableCell52});
            this.tableRow26.Name = "tableRow26";
            this.tableRow26.Weight = 1D;
            // 
            // tableCell51
            // 
            this.tableCell51.Name = "tableCell51";
            this.tableCell51.StyleName = "GroupCaption2";
            this.tableCell51.Text = "IS REFUND";
            this.tableCell51.Weight = 1142802.375D;
            // 
            // tableCell52
            // 
            this.tableCell52.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[isRefund]")});
            this.tableCell52.Name = "tableCell52";
            this.tableCell52.StyleName = "GroupData2";
            this.tableCell52.Weight = 13602797D;
            // 
            // table27
            // 
            this.table27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table27.Name = "table27";
            this.table27.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow27});
            this.table27.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow27
            // 
            this.tableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell53,
            this.tableCell54});
            this.tableRow27.Name = "tableRow27";
            this.tableRow27.Weight = 1D;
            // 
            // tableCell53
            // 
            this.tableCell53.Name = "tableCell53";
            this.tableCell53.StyleName = "GroupCaption2";
            this.tableCell53.Text = "IS DELIVERD";
            this.tableCell53.Weight = 0.08882778591579861D;
            // 
            // tableCell54
            // 
            this.tableCell54.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[isDeliverd]")});
            this.tableCell54.Name = "tableCell54";
            this.tableCell54.StyleName = "GroupData2";
            this.tableCell54.Weight = 0.91117221408420135D;
            // 
            // table28
            // 
            this.table28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table28.Name = "table28";
            this.table28.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow28});
            this.table28.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow28
            // 
            this.tableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell55,
            this.tableCell56});
            this.tableRow28.Name = "tableRow28";
            this.tableRow28.Weight = 1D;
            // 
            // tableCell55
            // 
            this.tableCell55.Name = "tableCell55";
            this.tableCell55.StyleName = "GroupCaption2";
            this.tableCell55.Text = "OWNER ID";
            this.tableCell55.Weight = 1090552.375D;
            // 
            // tableCell56
            // 
            this.tableCell56.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ownerId]")});
            this.tableCell56.Name = "tableCell56";
            this.tableCell56.StyleName = "GroupData2";
            this.tableCell56.Weight = 13655047D;
            // 
            // table29
            // 
            this.table29.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table29.Name = "table29";
            this.table29.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow29});
            this.table29.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow29
            // 
            this.tableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell57,
            this.tableCell58});
            this.tableRow29.Name = "tableRow29";
            this.tableRow29.Weight = 1D;
            // 
            // tableCell57
            // 
            this.tableCell57.Name = "tableCell57";
            this.tableCell57.StyleName = "GroupCaption2";
            this.tableCell57.Text = "CUTOMER ID CREATION TIME";
            this.tableCell57.Weight = 0.19348949856228298D;
            // 
            // tableCell58
            // 
            this.tableCell58.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.CreationTime]")});
            this.tableCell58.Name = "tableCell58";
            this.tableCell58.StyleName = "GroupData2";
            this.tableCell58.Weight = 0.80651048448350693D;
            // 
            // table30
            // 
            this.table30.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table30.Name = "table30";
            this.table30.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow30});
            this.table30.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow30
            // 
            this.tableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell59,
            this.tableCell60});
            this.tableRow30.Name = "tableRow30";
            this.tableRow30.Weight = 1D;
            // 
            // tableCell59
            // 
            this.tableCell59.Name = "tableCell59";
            this.tableCell59.StyleName = "GroupCaption2";
            this.tableCell59.Text = "CUTOMER ID INCREMENT";
            this.tableCell59.Weight = 0.16873523288302952D;
            // 
            // tableCell60
            // 
            this.tableCell60.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Increment]")});
            this.tableCell60.Name = "tableCell60";
            this.tableCell60.StyleName = "GroupData2";
            this.tableCell60.Weight = 0.83126478407118054D;
            // 
            // table31
            // 
            this.table31.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table31.Name = "table31";
            this.table31.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow31});
            this.table31.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow31
            // 
            this.tableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell61,
            this.tableCell62});
            this.tableRow31.Name = "tableRow31";
            this.tableRow31.Weight = 1D;
            // 
            // tableCell61
            // 
            this.tableCell61.Name = "tableCell61";
            this.tableCell61.StyleName = "GroupCaption2";
            this.tableCell61.Text = "CUTOMER ID PID";
            this.tableCell61.Weight = 0.11427830166286893D;
            // 
            // tableCell62
            // 
            this.tableCell62.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Pid]")});
            this.tableCell62.Name = "tableCell62";
            this.tableCell62.StyleName = "GroupData2";
            this.tableCell62.Weight = 0.88572170681423612D;
            // 
            // table32
            // 
            this.table32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table32.Name = "table32";
            this.table32.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow32});
            this.table32.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow32
            // 
            this.tableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell63,
            this.tableCell64});
            this.tableRow32.Name = "tableRow32";
            this.tableRow32.Weight = 1D;
            // 
            // tableCell63
            // 
            this.tableCell63.Name = "tableCell63";
            this.tableCell63.StyleName = "GroupCaption2";
            this.tableCell63.Text = "CUTOMER ID MACHINE";
            this.tableCell63.Weight = 0.15246653238932292D;
            // 
            // tableCell64
            // 
            this.tableCell64.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Machine]")});
            this.tableCell64.Name = "tableCell64";
            this.tableCell64.StyleName = "GroupData2";
            this.tableCell64.Weight = 0.84753350151909723D;
            // 
            // table33
            // 
            this.table33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table33.Name = "table33";
            this.table33.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow33});
            this.table33.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow33
            // 
            this.tableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell65,
            this.tableCell66});
            this.tableRow33.Name = "tableRow33";
            this.tableRow33.Weight = 1D;
            // 
            // tableCell65
            // 
            this.tableCell65.Name = "tableCell65";
            this.tableCell65.StyleName = "GroupCaption2";
            this.tableCell65.Text = "CUTOMER ID TIMESTAMP";
            this.tableCell65.Weight = 0.16802654690212673D;
            // 
            // tableCell66
            // 
            this.tableCell66.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Timestamp]")});
            this.tableCell66.Name = "tableCell66";
            this.tableCell66.StyleName = "GroupData2";
            this.tableCell66.Weight = 0.83197347005208333D;
            // 
            // table34
            // 
            this.table34.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table34.Name = "table34";
            this.table34.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow34});
            this.table34.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow34
            // 
            this.tableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell67,
            this.tableCell68});
            this.tableRow34.Name = "tableRow34";
            this.tableRow34.Weight = 1D;
            // 
            // tableCell67
            // 
            this.tableCell67.Name = "tableCell67";
            this.tableCell67.StyleName = "GroupCaption2";
            this.tableCell67.Text = "ORDER ID CREATION TIME";
            this.tableCell67.Weight = 0.17510718451605903D;
            // 
            // tableCell68
            // 
            this.tableCell68.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.CreationTime]")});
            this.tableCell68.Name = "tableCell68";
            this.tableCell68.StyleName = "GroupData2";
            this.tableCell68.Weight = 0.82489284939236107D;
            // 
            // table35
            // 
            this.table35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table35.Name = "table35";
            this.table35.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow35});
            this.table35.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow35
            // 
            this.tableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell69,
            this.tableCell70});
            this.tableRow35.Name = "tableRow35";
            this.tableRow35.Weight = 1D;
            // 
            // tableCell69
            // 
            this.tableCell69.Name = "tableCell69";
            this.tableCell69.StyleName = "GroupCaption2";
            this.tableCell69.Text = "ORDER ID INCREMENT";
            this.tableCell69.Weight = 0.15035290188259548D;
            // 
            // tableCell70
            // 
            this.tableCell70.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Increment]")});
            this.tableCell70.Name = "tableCell70";
            this.tableCell70.StyleName = "GroupData2";
            this.tableCell70.Weight = 0.84964708116319443D;
            // 
            // table36
            // 
            this.table36.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table36.Name = "table36";
            this.table36.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow36});
            this.table36.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow36
            // 
            this.tableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell71,
            this.tableCell72});
            this.tableRow36.Name = "tableRow36";
            this.tableRow36.Weight = 1D;
            // 
            // tableCell71
            // 
            this.tableCell71.Name = "tableCell71";
            this.tableCell71.StyleName = "GroupCaption2";
            this.tableCell71.Text = "ORDER ID PID";
            this.tableCell71.Weight = 0.09589599609375D;
            // 
            // tableCell72
            // 
            this.tableCell72.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Pid]")});
            this.tableCell72.Name = "tableCell72";
            this.tableCell72.StyleName = "GroupData2";
            this.tableCell72.Weight = 0.90410400390625D;
            // 
            // table37
            // 
            this.table37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table37.Name = "table37";
            this.table37.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow37});
            this.table37.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow37
            // 
            this.tableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell73,
            this.tableCell74});
            this.tableRow37.Name = "tableRow37";
            this.tableRow37.Weight = 1D;
            // 
            // tableCell73
            // 
            this.tableCell73.Name = "tableCell73";
            this.tableCell73.StyleName = "GroupCaption2";
            this.tableCell73.Text = "ORDER ID MACHINE";
            this.tableCell73.Weight = 0.13408420986599393D;
            // 
            // tableCell74
            // 
            this.tableCell74.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Machine]")});
            this.tableCell74.Name = "tableCell74";
            this.tableCell74.StyleName = "GroupData2";
            this.tableCell74.Weight = 0.86591579861111112D;
            // 
            // table38
            // 
            this.table38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table38.Name = "table38";
            this.table38.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow38});
            this.table38.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow38
            // 
            this.tableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell75,
            this.tableCell76});
            this.tableRow38.Name = "tableRow38";
            this.tableRow38.Weight = 1D;
            // 
            // tableCell75
            // 
            this.tableCell75.Name = "tableCell75";
            this.tableCell75.StyleName = "GroupCaption2";
            this.tableCell75.Text = "ORDER ID TIMESTAMP";
            this.tableCell75.Weight = 0.14964421590169272D;
            // 
            // tableCell76
            // 
            this.tableCell76.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Timestamp]")});
            this.tableCell76.Name = "tableCell76";
            this.tableCell76.StyleName = "GroupData2";
            this.tableCell76.Weight = 0.85035576714409722D;
            // 
            // table39
            // 
            this.table39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table39.Name = "table39";
            this.table39.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow39});
            this.table39.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow39
            // 
            this.tableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell77,
            this.tableCell78});
            this.tableRow39.Name = "tableRow39";
            this.tableRow39.Weight = 1D;
            // 
            // tableCell77
            // 
            this.tableCell77.Name = "tableCell77";
            this.tableCell77.StyleName = "GroupCaption2";
            this.tableCell77.Text = " ID CREATION TIME";
            this.tableCell77.Weight = 0.12912963019476997D;
            // 
            // tableCell78
            // 
            this.tableCell78.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell78.Name = "tableCell78";
            this.tableCell78.StyleName = "GroupData2";
            this.tableCell78.Weight = 0.870870361328125D;
            // 
            // table40
            // 
            this.table40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table40.Name = "table40";
            this.table40.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow40});
            this.table40.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow40
            // 
            this.tableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell79,
            this.tableCell80});
            this.tableRow40.Name = "tableRow40";
            this.tableRow40.Weight = 1D;
            // 
            // tableCell79
            // 
            this.tableCell79.Name = "tableCell79";
            this.tableCell79.StyleName = "GroupCaption2";
            this.tableCell79.Text = " ID INCREMENT";
            this.tableCell79.Weight = 1539077.375D;
            // 
            // tableCell80
            // 
            this.tableCell80.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell80.Name = "tableCell80";
            this.tableCell80.StyleName = "GroupData2";
            this.tableCell80.Weight = 13206522D;
            // 
            // table41
            // 
            this.table41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table41.Name = "table41";
            this.table41.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow41});
            this.table41.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow41
            // 
            this.tableRow41.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell81,
            this.tableCell82});
            this.tableRow41.Name = "tableRow41";
            this.tableRow41.Weight = 1D;
            // 
            // tableCell81
            // 
            this.tableCell81.Name = "tableCell81";
            this.tableCell81.StyleName = "GroupCaption2";
            this.tableCell81.Text = " ID PID";
            this.tableCell81.Weight = 736077.3125D;
            // 
            // tableCell82
            // 
            this.tableCell82.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell82.Name = "tableCell82";
            this.tableCell82.StyleName = "GroupData2";
            this.tableCell82.Weight = 14009522D;
            // 
            // table42
            // 
            this.table42.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table42.Name = "table42";
            this.table42.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow42});
            this.table42.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow42
            // 
            this.tableRow42.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell83,
            this.tableCell84});
            this.tableRow42.Name = "tableRow42";
            this.tableRow42.Weight = 1D;
            // 
            // tableCell83
            // 
            this.tableCell83.Name = "tableCell83";
            this.tableCell83.StyleName = "GroupCaption2";
            this.tableCell83.Text = " ID MACHINE";
            this.tableCell83.Weight = 0.0881066640218099D;
            // 
            // tableCell84
            // 
            this.tableCell84.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell84.Name = "tableCell84";
            this.tableCell84.StyleName = "GroupData2";
            this.tableCell84.Weight = 0.91189337836371531D;
            // 
            // table43
            // 
            this.table43.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table43.Name = "table43";
            this.table43.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow43});
            this.table43.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow43
            // 
            this.tableRow43.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell85,
            this.tableCell86});
            this.tableRow43.Name = "tableRow43";
            this.tableRow43.Weight = 1D;
            // 
            // tableCell85
            // 
            this.tableCell85.Name = "tableCell85";
            this.tableCell85.StyleName = "GroupCaption2";
            this.tableCell85.Text = " ID TIMESTAMP";
            this.tableCell85.Weight = 1528627.375D;
            // 
            // tableCell86
            // 
            this.tableCell86.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell86.Name = "tableCell86";
            this.tableCell86.StyleName = "GroupData2";
            this.tableCell86.Weight = 13216972D;
            // 
            // label4
            // 
            this.label4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label4.Name = "label4";
            this.label4.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label4.StyleName = "GroupFooterBackground3";
            this.label4.StylePriority.UseBorders = false;
            // 
            // GroupHeader44
            // 
            this.GroupHeader44.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table44});
            this.GroupHeader44.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Confirm", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader44.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader44.HeightF = 27F;
            this.GroupHeader44.Level = 1;
            this.GroupHeader44.Name = "GroupHeader44";
            // 
            // GroupHeader45
            // 
            this.GroupHeader45.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table45});
            this.GroupHeader45.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Price", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader45.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader45.HeightF = 27F;
            this.GroupHeader45.Level = 2;
            this.GroupHeader45.Name = "GroupHeader45";
            // 
            // GroupHeader46
            // 
            this.GroupHeader46.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table46});
            this.GroupHeader46.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader46.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader46.HeightF = 27F;
            this.GroupHeader46.Level = 3;
            this.GroupHeader46.Name = "GroupHeader46";
            // 
            // GroupHeader47
            // 
            this.GroupHeader47.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table47});
            this.GroupHeader47.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Items.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader47.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader47.HeightF = 27F;
            this.GroupHeader47.Level = 4;
            this.GroupHeader47.Name = "GroupHeader47";
            // 
            // GroupHeader48
            // 
            this.GroupHeader48.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table48});
            this.GroupHeader48.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Items.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader48.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader48.HeightF = 27F;
            this.GroupHeader48.Level = 5;
            this.GroupHeader48.Name = "GroupHeader48";
            // 
            // GroupHeader49
            // 
            this.GroupHeader49.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table49});
            this.GroupHeader49.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Items.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader49.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader49.HeightF = 27F;
            this.GroupHeader49.Level = 6;
            this.GroupHeader49.Name = "GroupHeader49";
            // 
            // GroupHeader50
            // 
            this.GroupHeader50.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table50});
            this.GroupHeader50.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Items.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader50.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader50.HeightF = 27F;
            this.GroupHeader50.Level = 7;
            this.GroupHeader50.Name = "GroupHeader50";
            // 
            // GroupHeader51
            // 
            this.GroupHeader51.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table51});
            this.GroupHeader51.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Items.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader51.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader51.HeightF = 27F;
            this.GroupHeader51.Level = 8;
            this.GroupHeader51.Name = "GroupHeader51";
            // 
            // GroupHeader52
            // 
            this.GroupHeader52.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table52});
            this.GroupHeader52.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader52.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader52.HeightF = 27F;
            this.GroupHeader52.Level = 9;
            this.GroupHeader52.Name = "GroupHeader52";
            // 
            // GroupHeader53
            // 
            this.GroupHeader53.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table53});
            this.GroupHeader53.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader53.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader53.HeightF = 27F;
            this.GroupHeader53.Level = 10;
            this.GroupHeader53.Name = "GroupHeader53";
            // 
            // GroupHeader54
            // 
            this.GroupHeader54.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table54});
            this.GroupHeader54.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader54.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader54.HeightF = 27F;
            this.GroupHeader54.Level = 11;
            this.GroupHeader54.Name = "GroupHeader54";
            // 
            // GroupHeader55
            // 
            this.GroupHeader55.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table55});
            this.GroupHeader55.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader55.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader55.HeightF = 27F;
            this.GroupHeader55.Level = 12;
            this.GroupHeader55.Name = "GroupHeader55";
            // 
            // GroupHeader56
            // 
            this.GroupHeader56.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table56});
            this.GroupHeader56.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader56.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader56.HeightF = 27F;
            this.GroupHeader56.Level = 13;
            this.GroupHeader56.Name = "GroupHeader56";
            // 
            // Detail4
            // 
            this.Detail4.HeightF = 0F;
            this.Detail4.Name = "Detail4";
            // 
            // GroupFooter4
            // 
            this.GroupFooter4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label5});
            this.GroupFooter4.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter4.HeightF = 6F;
            this.GroupFooter4.Name = "GroupFooter4";
            // 
            // table44
            // 
            this.table44.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table44.Name = "table44";
            this.table44.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow44});
            this.table44.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow44
            // 
            this.tableRow44.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell87,
            this.tableCell88});
            this.tableRow44.Name = "tableRow44";
            this.tableRow44.Weight = 1D;
            // 
            // tableCell87
            // 
            this.tableCell87.Name = "tableCell87";
            this.tableCell87.StyleName = "GroupCaption2";
            this.tableCell87.Text = "CONFIRM";
            this.tableCell87.Weight = 0.068294542100694439D;
            // 
            // tableCell88
            // 
            this.tableCell88.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Confirm]")});
            this.tableCell88.Name = "tableCell88";
            this.tableCell88.StyleName = "GroupData2";
            this.tableCell88.Weight = 0.93170545789930559D;
            // 
            // table45
            // 
            this.table45.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table45.Name = "table45";
            this.table45.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow45});
            this.table45.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow45
            // 
            this.tableRow45.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell89,
            this.tableCell90});
            this.tableRow45.Name = "tableRow45";
            this.tableRow45.Weight = 1D;
            // 
            // tableCell89
            // 
            this.tableCell89.Name = "tableCell89";
            this.tableCell89.StyleName = "GroupCaption2";
            this.tableCell89.Text = "PRICE";
            this.tableCell89.Weight = 0.047798597547743057D;
            // 
            // tableCell90
            // 
            this.tableCell90.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")});
            this.tableCell90.Name = "tableCell90";
            this.tableCell90.StyleName = "GroupData2";
            this.tableCell90.Weight = 0.95220140245225693D;
            // 
            // table46
            // 
            this.table46.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table46.Name = "table46";
            this.table46.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow46});
            this.table46.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow46
            // 
            this.tableRow46.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell91,
            this.tableCell92});
            this.tableRow46.Name = "tableRow46";
            this.tableRow46.Weight = 1D;
            // 
            // tableCell91
            // 
            this.tableCell91.Name = "tableCell91";
            this.tableCell91.StyleName = "GroupCaption2";
            this.tableCell91.Text = "USER";
            this.tableCell91.Weight = 0.044261385599772135D;
            // 
            // tableCell92
            // 
            this.tableCell92.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User]")});
            this.tableCell92.Name = "tableCell92";
            this.tableCell92.StyleName = "GroupData2";
            this.tableCell92.Weight = 0.9557386610243056D;
            // 
            // table47
            // 
            this.table47.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table47.Name = "table47";
            this.table47.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow47});
            this.table47.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow47
            // 
            this.tableRow47.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell93,
            this.tableCell94});
            this.tableRow47.Name = "tableRow47";
            this.tableRow47.Weight = 1D;
            // 
            // tableCell93
            // 
            this.tableCell93.Name = "tableCell93";
            this.tableCell93.StyleName = "GroupCaption2";
            this.tableCell93.Text = "ITEMS CREATION TIME";
            this.tableCell93.Weight = 0.15176406860351563D;
            // 
            // tableCell94
            // 
            this.tableCell94.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items.CreationTime]")});
            this.tableCell94.Name = "tableCell94";
            this.tableCell94.StyleName = "GroupData2";
            this.tableCell94.Weight = 0.84823594835069449D;
            // 
            // table48
            // 
            this.table48.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table48.Name = "table48";
            this.table48.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow48});
            this.table48.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow48
            // 
            this.tableRow48.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell95,
            this.tableCell96});
            this.tableRow48.Name = "tableRow48";
            this.tableRow48.Weight = 1D;
            // 
            // tableCell95
            // 
            this.tableCell95.Name = "tableCell95";
            this.tableCell95.StyleName = "GroupCaption2";
            this.tableCell95.Text = "ITEMS INCREMENT";
            this.tableCell95.Weight = 0.12700978597005208D;
            // 
            // tableCell96
            // 
            this.tableCell96.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items.Increment]")});
            this.tableCell96.Name = "tableCell96";
            this.tableCell96.StyleName = "GroupData2";
            this.tableCell96.Weight = 0.87299018012152774D;
            // 
            // table49
            // 
            this.table49.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table49.Name = "table49";
            this.table49.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow49});
            this.table49.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow49
            // 
            this.tableRow49.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell97,
            this.tableCell98});
            this.tableRow49.Name = "tableRow49";
            this.tableRow49.Weight = 1D;
            // 
            // tableCell97
            // 
            this.tableCell97.Name = "tableCell97";
            this.tableCell97.StyleName = "GroupCaption2";
            this.tableCell97.Text = "ITEMS PID";
            this.tableCell97.Weight = 0.07255287170410156D;
            // 
            // tableCell98
            // 
            this.tableCell98.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items.Pid]")});
            this.tableCell98.Name = "tableCell98";
            this.tableCell98.StyleName = "GroupData2";
            this.tableCell98.Weight = 0.92744717068142357D;
            // 
            // table50
            // 
            this.table50.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table50.Name = "table50";
            this.table50.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow50});
            this.table50.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow50
            // 
            this.tableRow50.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell99,
            this.tableCell100});
            this.tableRow50.Name = "tableRow50";
            this.tableRow50.Weight = 1D;
            // 
            // tableCell99
            // 
            this.tableCell99.Name = "tableCell99";
            this.tableCell99.StyleName = "GroupCaption2";
            this.tableCell99.Text = "ITEMS MACHINE";
            this.tableCell99.Weight = 0.11074110243055556D;
            // 
            // tableCell100
            // 
            this.tableCell100.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items.Machine]")});
            this.tableCell100.Name = "tableCell100";
            this.tableCell100.StyleName = "GroupData2";
            this.tableCell100.Weight = 0.88925889756944443D;
            // 
            // table51
            // 
            this.table51.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table51.Name = "table51";
            this.table51.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow51});
            this.table51.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow51
            // 
            this.tableRow51.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell101,
            this.tableCell102});
            this.tableRow51.Name = "tableRow51";
            this.tableRow51.Weight = 1D;
            // 
            // tableCell101
            // 
            this.tableCell101.Name = "tableCell101";
            this.tableCell101.StyleName = "GroupCaption2";
            this.tableCell101.Text = "ITEMS TIMESTAMP";
            this.tableCell101.Weight = 0.12630109998914932D;
            // 
            // tableCell102
            // 
            this.tableCell102.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Items.Timestamp]")});
            this.tableCell102.Name = "tableCell102";
            this.tableCell102.StyleName = "GroupData2";
            this.tableCell102.Weight = 0.87369886610243053D;
            // 
            // table52
            // 
            this.table52.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table52.Name = "table52";
            this.table52.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow52});
            this.table52.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow52
            // 
            this.tableRow52.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell103,
            this.tableCell104});
            this.tableRow52.Name = "tableRow52";
            this.tableRow52.Weight = 1D;
            // 
            // tableCell103
            // 
            this.tableCell103.Name = "tableCell103";
            this.tableCell103.StyleName = "GroupCaption2";
            this.tableCell103.Text = " ID CREATION TIME";
            this.tableCell103.Weight = 0.12912963019476997D;
            // 
            // tableCell104
            // 
            this.tableCell104.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell104.Name = "tableCell104";
            this.tableCell104.StyleName = "GroupData2";
            this.tableCell104.Weight = 0.870870361328125D;
            // 
            // table53
            // 
            this.table53.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table53.Name = "table53";
            this.table53.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow53});
            this.table53.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow53
            // 
            this.tableRow53.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell105,
            this.tableCell106});
            this.tableRow53.Name = "tableRow53";
            this.tableRow53.Weight = 1D;
            // 
            // tableCell105
            // 
            this.tableCell105.Name = "tableCell105";
            this.tableCell105.StyleName = "GroupCaption2";
            this.tableCell105.Text = " ID INCREMENT";
            this.tableCell105.Weight = 1539077.375D;
            // 
            // tableCell106
            // 
            this.tableCell106.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell106.Name = "tableCell106";
            this.tableCell106.StyleName = "GroupData2";
            this.tableCell106.Weight = 13206522D;
            // 
            // table54
            // 
            this.table54.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table54.Name = "table54";
            this.table54.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow54});
            this.table54.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow54
            // 
            this.tableRow54.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell107,
            this.tableCell108});
            this.tableRow54.Name = "tableRow54";
            this.tableRow54.Weight = 1D;
            // 
            // tableCell107
            // 
            this.tableCell107.Name = "tableCell107";
            this.tableCell107.StyleName = "GroupCaption2";
            this.tableCell107.Text = " ID PID";
            this.tableCell107.Weight = 736077.3125D;
            // 
            // tableCell108
            // 
            this.tableCell108.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell108.Name = "tableCell108";
            this.tableCell108.StyleName = "GroupData2";
            this.tableCell108.Weight = 14009522D;
            // 
            // table55
            // 
            this.table55.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table55.Name = "table55";
            this.table55.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow55});
            this.table55.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow55
            // 
            this.tableRow55.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell109,
            this.tableCell110});
            this.tableRow55.Name = "tableRow55";
            this.tableRow55.Weight = 1D;
            // 
            // tableCell109
            // 
            this.tableCell109.Name = "tableCell109";
            this.tableCell109.StyleName = "GroupCaption2";
            this.tableCell109.Text = " ID MACHINE";
            this.tableCell109.Weight = 0.0881066640218099D;
            // 
            // tableCell110
            // 
            this.tableCell110.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell110.Name = "tableCell110";
            this.tableCell110.StyleName = "GroupData2";
            this.tableCell110.Weight = 0.91189337836371531D;
            // 
            // table56
            // 
            this.table56.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table56.Name = "table56";
            this.table56.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow56});
            this.table56.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow56
            // 
            this.tableRow56.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell111,
            this.tableCell112});
            this.tableRow56.Name = "tableRow56";
            this.tableRow56.Weight = 1D;
            // 
            // tableCell111
            // 
            this.tableCell111.Name = "tableCell111";
            this.tableCell111.StyleName = "GroupCaption2";
            this.tableCell111.Text = " ID TIMESTAMP";
            this.tableCell111.Weight = 1528627.375D;
            // 
            // tableCell112
            // 
            this.tableCell112.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell112.Name = "tableCell112";
            this.tableCell112.StyleName = "GroupData2";
            this.tableCell112.Weight = 13216972D;
            // 
            // label5
            // 
            this.label5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label5.Name = "label5";
            this.label5.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label5.StyleName = "GroupFooterBackground3";
            this.label5.StylePriority.UseBorders = false;
            // 
            // GroupHeader57
            // 
            this.GroupHeader57.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table57});
            this.GroupHeader57.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("loveThisProduct", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader57.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader57.HeightF = 27F;
            this.GroupHeader57.Level = 1;
            this.GroupHeader57.Name = "GroupHeader57";
            // 
            // GroupHeader58
            // 
            this.GroupHeader58.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table58});
            this.GroupHeader58.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.Pic", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader58.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader58.HeightF = 27F;
            this.GroupHeader58.Level = 2;
            this.GroupHeader58.Name = "GroupHeader58";
            // 
            // GroupHeader59
            // 
            this.GroupHeader59.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table59});
            this.GroupHeader59.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.Email", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader59.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader59.HeightF = 27F;
            this.GroupHeader59.Level = 3;
            this.GroupHeader59.Name = "GroupHeader59";
            // 
            // GroupHeader60
            // 
            this.GroupHeader60.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table60});
            this.GroupHeader60.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader60.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader60.HeightF = 27F;
            this.GroupHeader60.Level = 4;
            this.GroupHeader60.Name = "GroupHeader60";
            // 
            // GroupHeader61
            // 
            this.GroupHeader61.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table61});
            this.GroupHeader61.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.FirstName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader61.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader61.HeightF = 27F;
            this.GroupHeader61.Level = 5;
            this.GroupHeader61.Name = "GroupHeader61";
            // 
            // GroupHeader62
            // 
            this.GroupHeader62.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table62});
            this.GroupHeader62.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Price", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader62.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader62.HeightF = 27F;
            this.GroupHeader62.Level = 6;
            this.GroupHeader62.Name = "GroupHeader62";
            // 
            // GroupHeader63
            // 
            this.GroupHeader63.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table63});
            this.GroupHeader63.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TotalComments", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader63.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader63.HeightF = 27F;
            this.GroupHeader63.Level = 7;
            this.GroupHeader63.Name = "GroupHeader63";
            // 
            // GroupHeader64
            // 
            this.GroupHeader64.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table64});
            this.GroupHeader64.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Description", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader64.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader64.HeightF = 27F;
            this.GroupHeader64.Level = 8;
            this.GroupHeader64.Name = "GroupHeader64";
            // 
            // GroupHeader65
            // 
            this.GroupHeader65.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table65});
            this.GroupHeader65.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader65.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader65.HeightF = 27F;
            this.GroupHeader65.Level = 9;
            this.GroupHeader65.Name = "GroupHeader65";
            // 
            // GroupHeader66
            // 
            this.GroupHeader66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table66});
            this.GroupHeader66.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader66.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader66.HeightF = 27F;
            this.GroupHeader66.Level = 10;
            this.GroupHeader66.Name = "GroupHeader66";
            // 
            // GroupHeader67
            // 
            this.GroupHeader67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table67});
            this.GroupHeader67.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader67.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader67.HeightF = 27F;
            this.GroupHeader67.Level = 11;
            this.GroupHeader67.Name = "GroupHeader67";
            // 
            // GroupHeader68
            // 
            this.GroupHeader68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table68});
            this.GroupHeader68.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader68.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader68.HeightF = 27F;
            this.GroupHeader68.Level = 12;
            this.GroupHeader68.Name = "GroupHeader68";
            // 
            // GroupHeader69
            // 
            this.GroupHeader69.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table69});
            this.GroupHeader69.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader69.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader69.HeightF = 27F;
            this.GroupHeader69.Level = 13;
            this.GroupHeader69.Name = "GroupHeader69";
            // 
            // GroupHeader70
            // 
            this.GroupHeader70.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table70});
            this.GroupHeader70.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader70.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader70.HeightF = 27F;
            this.GroupHeader70.Level = 14;
            this.GroupHeader70.Name = "GroupHeader70";
            // 
            // Detail5
            // 
            this.Detail5.HeightF = 0F;
            this.Detail5.Name = "Detail5";
            // 
            // GroupFooter5
            // 
            this.GroupFooter5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label6});
            this.GroupFooter5.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter5.HeightF = 6F;
            this.GroupFooter5.Name = "GroupFooter5";
            // 
            // table57
            // 
            this.table57.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table57.Name = "table57";
            this.table57.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow57});
            this.table57.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow57
            // 
            this.tableRow57.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell113,
            this.tableCell114});
            this.tableRow57.Name = "tableRow57";
            this.tableRow57.Weight = 1D;
            // 
            // tableCell113
            // 
            this.tableCell113.Name = "tableCell113";
            this.tableCell113.StyleName = "GroupCaption2";
            this.tableCell113.Text = "LOVE THIS PRODUCT";
            this.tableCell113.Weight = 0.14257600572374132D;
            // 
            // tableCell114
            // 
            this.tableCell114.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[loveThisProduct]")});
            this.tableCell114.Name = "tableCell114";
            this.tableCell114.StyleName = "GroupData2";
            this.tableCell114.Weight = 0.85742397732204856D;
            // 
            // table58
            // 
            this.table58.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table58.Name = "table58";
            this.table58.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow58});
            this.table58.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow58
            // 
            this.tableRow58.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell115,
            this.tableCell116});
            this.tableRow58.Name = "tableRow58";
            this.tableRow58.Weight = 1D;
            // 
            // tableCell115
            // 
            this.tableCell115.Name = "tableCell115";
            this.tableCell115.StyleName = "GroupCaption2";
            this.tableCell115.Text = "PUBLISH PIC";
            this.tableCell115.Weight = 1320177.375D;
            // 
            // tableCell116
            // 
            this.tableCell116.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.Pic]")});
            this.tableCell116.Name = "tableCell116";
            this.tableCell116.StyleName = "GroupData2";
            this.tableCell116.Weight = 13425422D;
            // 
            // table59
            // 
            this.table59.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table59.Name = "table59";
            this.table59.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow59});
            this.table59.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow59
            // 
            this.tableRow59.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell117,
            this.tableCell118});
            this.tableRow59.Name = "tableRow59";
            this.tableRow59.Weight = 1D;
            // 
            // tableCell117
            // 
            this.tableCell117.Name = "tableCell117";
            this.tableCell117.StyleName = "GroupCaption2";
            this.tableCell117.Text = "PUBLISH EMAIL";
            this.tableCell117.Weight = 0.1079125722249349D;
            // 
            // tableCell118
            // 
            this.tableCell118.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.Email]")});
            this.tableCell118.Name = "tableCell118";
            this.tableCell118.StyleName = "GroupData2";
            this.tableCell118.Weight = 0.89208747016059031D;
            // 
            // table60
            // 
            this.table60.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table60.Name = "table60";
            this.table60.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow60});
            this.table60.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow60
            // 
            this.tableRow60.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell119,
            this.tableCell120});
            this.tableRow60.Name = "tableRow60";
            this.tableRow60.Weight = 1D;
            // 
            // tableCell119
            // 
            this.tableCell119.Name = "tableCell119";
            this.tableCell119.StyleName = "GroupCaption2";
            this.tableCell119.Text = "PUBLISH LAST NAME";
            this.tableCell119.Weight = 0.14256980048285589D;
            // 
            // tableCell120
            // 
            this.tableCell120.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.LastName]")});
            this.tableCell120.Name = "tableCell120";
            this.tableCell120.StyleName = "GroupData2";
            this.tableCell120.Weight = 0.8574302164713542D;
            // 
            // table61
            // 
            this.table61.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table61.Name = "table61";
            this.table61.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow61});
            this.table61.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow61
            // 
            this.tableRow61.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell121,
            this.tableCell122});
            this.tableRow61.Name = "tableRow61";
            this.tableRow61.Weight = 1D;
            // 
            // tableCell121
            // 
            this.tableCell121.Name = "tableCell121";
            this.tableCell121.StyleName = "GroupCaption2";
            this.tableCell121.Text = "PUBLISH FIRST NAME";
            this.tableCell121.Weight = 0.14610700819227432D;
            // 
            // tableCell122
            // 
            this.tableCell122.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.FirstName]")});
            this.tableCell122.Name = "tableCell122";
            this.tableCell122.StyleName = "GroupData2";
            this.tableCell122.Weight = 0.85389295789930553D;
            // 
            // table62
            // 
            this.table62.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table62.Name = "table62";
            this.table62.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow62});
            this.table62.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow62
            // 
            this.tableRow62.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell123,
            this.tableCell124});
            this.tableRow62.Name = "tableRow62";
            this.tableRow62.Weight = 1D;
            // 
            // tableCell123
            // 
            this.tableCell123.Name = "tableCell123";
            this.tableCell123.StyleName = "GroupCaption2";
            this.tableCell123.Text = "PRICE";
            this.tableCell123.Weight = 0.047798597547743057D;
            // 
            // tableCell124
            // 
            this.tableCell124.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")});
            this.tableCell124.Name = "tableCell124";
            this.tableCell124.StyleName = "GroupData2";
            this.tableCell124.Weight = 0.95220140245225693D;
            // 
            // table63
            // 
            this.table63.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table63.Name = "table63";
            this.table63.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow63});
            this.table63.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow63
            // 
            this.tableRow63.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell125,
            this.tableCell126});
            this.tableRow63.Name = "tableRow63";
            this.tableRow63.Weight = 1D;
            // 
            // tableCell125
            // 
            this.tableCell125.Name = "tableCell125";
            this.tableCell125.StyleName = "GroupCaption2";
            this.tableCell125.Text = "TOTAL COMMENTS";
            this.tableCell125.Weight = 0.12911719428168403D;
            // 
            // tableCell126
            // 
            this.tableCell126.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalComments]")});
            this.tableCell126.Name = "tableCell126";
            this.tableCell126.StyleName = "GroupData2";
            this.tableCell126.Weight = 0.87088283962673607D;
            // 
            // table64
            // 
            this.table64.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table64.Name = "table64";
            this.table64.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow64});
            this.table64.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow64
            // 
            this.tableRow64.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell127,
            this.tableCell128});
            this.tableRow64.Name = "tableRow64";
            this.tableRow64.Weight = 1D;
            // 
            // tableCell127
            // 
            this.tableCell127.Name = "tableCell127";
            this.tableCell127.StyleName = "GroupCaption2";
            this.tableCell127.Text = "DESCRIPTION";
            this.tableCell127.Weight = 0.09589599609375D;
            // 
            // tableCell128
            // 
            this.tableCell128.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.tableCell128.Name = "tableCell128";
            this.tableCell128.StyleName = "GroupData2";
            this.tableCell128.Weight = 0.90410400390625D;
            // 
            // table65
            // 
            this.table65.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table65.Name = "table65";
            this.table65.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow65});
            this.table65.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow65
            // 
            this.tableRow65.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell129,
            this.tableCell130});
            this.tableRow65.Name = "tableRow65";
            this.tableRow65.Weight = 1D;
            // 
            // tableCell129
            // 
            this.tableCell129.Name = "tableCell129";
            this.tableCell129.StyleName = "GroupCaption2";
            this.tableCell129.Text = "NAME";
            this.tableCell129.Weight = 683827.375D;
            // 
            // tableCell130
            // 
            this.tableCell130.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")});
            this.tableCell130.Name = "tableCell130";
            this.tableCell130.StyleName = "GroupData2";
            this.tableCell130.Weight = 14061772D;
            // 
            // table66
            // 
            this.table66.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table66.Name = "table66";
            this.table66.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow66});
            this.table66.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow66
            // 
            this.tableRow66.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell131,
            this.tableCell132});
            this.tableRow66.Name = "tableRow66";
            this.tableRow66.Weight = 1D;
            // 
            // tableCell131
            // 
            this.tableCell131.Name = "tableCell131";
            this.tableCell131.StyleName = "GroupCaption2";
            this.tableCell131.Text = " ID CREATION TIME";
            this.tableCell131.Weight = 0.12912963019476997D;
            // 
            // tableCell132
            // 
            this.tableCell132.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell132.Name = "tableCell132";
            this.tableCell132.StyleName = "GroupData2";
            this.tableCell132.Weight = 0.870870361328125D;
            // 
            // table67
            // 
            this.table67.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table67.Name = "table67";
            this.table67.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow67});
            this.table67.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow67
            // 
            this.tableRow67.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell133,
            this.tableCell134});
            this.tableRow67.Name = "tableRow67";
            this.tableRow67.Weight = 1D;
            // 
            // tableCell133
            // 
            this.tableCell133.Name = "tableCell133";
            this.tableCell133.StyleName = "GroupCaption2";
            this.tableCell133.Text = " ID INCREMENT";
            this.tableCell133.Weight = 1539077.375D;
            // 
            // tableCell134
            // 
            this.tableCell134.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell134.Name = "tableCell134";
            this.tableCell134.StyleName = "GroupData2";
            this.tableCell134.Weight = 13206522D;
            // 
            // table68
            // 
            this.table68.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table68.Name = "table68";
            this.table68.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow68});
            this.table68.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow68
            // 
            this.tableRow68.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell135,
            this.tableCell136});
            this.tableRow68.Name = "tableRow68";
            this.tableRow68.Weight = 1D;
            // 
            // tableCell135
            // 
            this.tableCell135.Name = "tableCell135";
            this.tableCell135.StyleName = "GroupCaption2";
            this.tableCell135.Text = " ID PID";
            this.tableCell135.Weight = 736077.3125D;
            // 
            // tableCell136
            // 
            this.tableCell136.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell136.Name = "tableCell136";
            this.tableCell136.StyleName = "GroupData2";
            this.tableCell136.Weight = 14009522D;
            // 
            // table69
            // 
            this.table69.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table69.Name = "table69";
            this.table69.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow69});
            this.table69.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow69
            // 
            this.tableRow69.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell137,
            this.tableCell138});
            this.tableRow69.Name = "tableRow69";
            this.tableRow69.Weight = 1D;
            // 
            // tableCell137
            // 
            this.tableCell137.Name = "tableCell137";
            this.tableCell137.StyleName = "GroupCaption2";
            this.tableCell137.Text = " ID MACHINE";
            this.tableCell137.Weight = 0.0881066640218099D;
            // 
            // tableCell138
            // 
            this.tableCell138.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell138.Name = "tableCell138";
            this.tableCell138.StyleName = "GroupData2";
            this.tableCell138.Weight = 0.91189337836371531D;
            // 
            // table70
            // 
            this.table70.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table70.Name = "table70";
            this.table70.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow70});
            this.table70.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow70
            // 
            this.tableRow70.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell139,
            this.tableCell140});
            this.tableRow70.Name = "tableRow70";
            this.tableRow70.Weight = 1D;
            // 
            // tableCell139
            // 
            this.tableCell139.Name = "tableCell139";
            this.tableCell139.StyleName = "GroupCaption2";
            this.tableCell139.Text = " ID TIMESTAMP";
            this.tableCell139.Weight = 1528627.375D;
            // 
            // tableCell140
            // 
            this.tableCell140.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell140.Name = "tableCell140";
            this.tableCell140.StyleName = "GroupData2";
            this.tableCell140.Weight = 13216972D;
            // 
            // label6
            // 
            this.label6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label6.Name = "label6";
            this.label6.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label6.StyleName = "GroupFooterBackground3";
            this.label6.StylePriority.UseBorders = false;
            // 
            // GroupHeader71
            // 
            this.GroupHeader71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table71});
            this.GroupHeader71.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader71.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader71.HeightF = 27F;
            this.GroupHeader71.Level = 1;
            this.GroupHeader71.Name = "GroupHeader71";
            // 
            // GroupHeader72
            // 
            this.GroupHeader72.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table72});
            this.GroupHeader72.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader72.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader72.HeightF = 27F;
            this.GroupHeader72.Level = 2;
            this.GroupHeader72.Name = "GroupHeader72";
            // 
            // GroupHeader73
            // 
            this.GroupHeader73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table73});
            this.GroupHeader73.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader73.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader73.HeightF = 27F;
            this.GroupHeader73.Level = 3;
            this.GroupHeader73.Name = "GroupHeader73";
            // 
            // GroupHeader74
            // 
            this.GroupHeader74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table74});
            this.GroupHeader74.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader74.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader74.HeightF = 27F;
            this.GroupHeader74.Level = 4;
            this.GroupHeader74.Name = "GroupHeader74";
            // 
            // GroupHeader75
            // 
            this.GroupHeader75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table75});
            this.GroupHeader75.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader75.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader75.HeightF = 27F;
            this.GroupHeader75.Level = 5;
            this.GroupHeader75.Name = "GroupHeader75";
            // 
            // GroupHeader76
            // 
            this.GroupHeader76.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table76});
            this.GroupHeader76.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader76.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader76.HeightF = 27F;
            this.GroupHeader76.Level = 6;
            this.GroupHeader76.Name = "GroupHeader76";
            // 
            // GroupHeader77
            // 
            this.GroupHeader77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table77});
            this.GroupHeader77.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader77.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader77.HeightF = 27F;
            this.GroupHeader77.Level = 7;
            this.GroupHeader77.Name = "GroupHeader77";
            // 
            // GroupHeader78
            // 
            this.GroupHeader78.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table78});
            this.GroupHeader78.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader78.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader78.HeightF = 27F;
            this.GroupHeader78.Level = 8;
            this.GroupHeader78.Name = "GroupHeader78";
            // 
            // GroupHeader79
            // 
            this.GroupHeader79.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table79});
            this.GroupHeader79.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader79.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader79.HeightF = 27F;
            this.GroupHeader79.Level = 9;
            this.GroupHeader79.Name = "GroupHeader79";
            // 
            // GroupHeader80
            // 
            this.GroupHeader80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table80});
            this.GroupHeader80.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader80.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader80.HeightF = 27F;
            this.GroupHeader80.Level = 10;
            this.GroupHeader80.Name = "GroupHeader80";
            // 
            // GroupHeader81
            // 
            this.GroupHeader81.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table81});
            this.GroupHeader81.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("UserComment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader81.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader81.HeightF = 27F;
            this.GroupHeader81.Level = 11;
            this.GroupHeader81.Name = "GroupHeader81";
            // 
            // GroupHeader82
            // 
            this.GroupHeader82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table82});
            this.GroupHeader82.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader82.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader82.HeightF = 27F;
            this.GroupHeader82.Level = 12;
            this.GroupHeader82.Name = "GroupHeader82";
            // 
            // GroupHeader83
            // 
            this.GroupHeader83.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table83});
            this.GroupHeader83.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader83.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader83.HeightF = 27F;
            this.GroupHeader83.Level = 13;
            this.GroupHeader83.Name = "GroupHeader83";
            // 
            // GroupHeader84
            // 
            this.GroupHeader84.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table84});
            this.GroupHeader84.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader84.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader84.HeightF = 27F;
            this.GroupHeader84.Level = 14;
            this.GroupHeader84.Name = "GroupHeader84";
            // 
            // GroupHeader85
            // 
            this.GroupHeader85.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table85});
            this.GroupHeader85.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader85.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader85.HeightF = 27F;
            this.GroupHeader85.Level = 15;
            this.GroupHeader85.Name = "GroupHeader85";
            // 
            // GroupHeader86
            // 
            this.GroupHeader86.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table86});
            this.GroupHeader86.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader86.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader86.HeightF = 27F;
            this.GroupHeader86.Level = 16;
            this.GroupHeader86.Name = "GroupHeader86";
            // 
            // Detail6
            // 
            this.Detail6.HeightF = 0F;
            this.Detail6.Name = "Detail6";
            // 
            // GroupFooter6
            // 
            this.GroupFooter6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label7});
            this.GroupFooter6.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter6.HeightF = 6F;
            this.GroupFooter6.Name = "GroupFooter6";
            // 
            // table71
            // 
            this.table71.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table71.Name = "table71";
            this.table71.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow71});
            this.table71.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow71
            // 
            this.tableRow71.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell141,
            this.tableCell142});
            this.tableRow71.Name = "tableRow71";
            this.tableRow71.Weight = 1D;
            // 
            // tableCell141
            // 
            this.tableCell141.Name = "tableCell141";
            this.tableCell141.StyleName = "GroupCaption2";
            this.tableCell141.Text = "SHOP ITEM CREATION TIME";
            this.tableCell141.Weight = 0.18289030287000868D;
            // 
            // tableCell142
            // 
            this.tableCell142.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.CreationTime]")});
            this.tableCell142.Name = "tableCell142";
            this.tableCell142.StyleName = "GroupData2";
            this.tableCell142.Weight = 0.81710971408420141D;
            // 
            // table72
            // 
            this.table72.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table72.Name = "table72";
            this.table72.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow72});
            this.table72.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow72
            // 
            this.tableRow72.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell143,
            this.tableCell144});
            this.tableRow72.Name = "tableRow72";
            this.tableRow72.Weight = 1D;
            // 
            // tableCell143
            // 
            this.tableCell143.Name = "tableCell143";
            this.tableCell143.StyleName = "GroupCaption2";
            this.tableCell143.Text = "SHOP ITEM INCREMENT";
            this.tableCell143.Weight = 0.15813602023654513D;
            // 
            // tableCell144
            // 
            this.tableCell144.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Increment]")});
            this.tableCell144.Name = "tableCell144";
            this.tableCell144.StyleName = "GroupData2";
            this.tableCell144.Weight = 0.841864013671875D;
            // 
            // table73
            // 
            this.table73.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table73.Name = "table73";
            this.table73.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow73});
            this.table73.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow73
            // 
            this.tableRow73.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell145,
            this.tableCell146});
            this.tableRow73.Name = "tableRow73";
            this.tableRow73.Weight = 1D;
            // 
            // tableCell145
            // 
            this.tableCell145.Name = "tableCell145";
            this.tableCell145.StyleName = "GroupCaption2";
            this.tableCell145.Text = "SHOP ITEM PID";
            this.tableCell145.Weight = 0.10367910597059461D;
            // 
            // tableCell146
            // 
            this.tableCell146.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Pid]")});
            this.tableCell146.Name = "tableCell146";
            this.tableCell146.StyleName = "GroupData2";
            this.tableCell146.Weight = 0.8963209364149306D;
            // 
            // table74
            // 
            this.table74.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table74.Name = "table74";
            this.table74.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow74});
            this.table74.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow74
            // 
            this.tableRow74.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell147,
            this.tableCell148});
            this.tableRow74.Name = "tableRow74";
            this.tableRow74.Weight = 1D;
            // 
            // tableCell147
            // 
            this.tableCell147.Name = "tableCell147";
            this.tableCell147.StyleName = "GroupCaption2";
            this.tableCell147.Text = "SHOP ITEM MACHINE";
            this.tableCell147.Weight = 0.14186732821994358D;
            // 
            // tableCell148
            // 
            this.tableCell148.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Machine]")});
            this.tableCell148.Name = "tableCell148";
            this.tableCell148.StyleName = "GroupData2";
            this.tableCell148.Weight = 0.85813266330295135D;
            // 
            // table75
            // 
            this.table75.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table75.Name = "table75";
            this.table75.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow75});
            this.table75.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow75
            // 
            this.tableRow75.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell149,
            this.tableCell150});
            this.tableRow75.Name = "tableRow75";
            this.tableRow75.Weight = 1D;
            // 
            // tableCell149
            // 
            this.tableCell149.Name = "tableCell149";
            this.tableCell149.StyleName = "GroupCaption2";
            this.tableCell149.Text = "SHOP ITEM TIMESTAMP";
            this.tableCell149.Weight = 0.15742733425564237D;
            // 
            // tableCell150
            // 
            this.tableCell150.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Timestamp]")});
            this.tableCell150.Name = "tableCell150";
            this.tableCell150.StyleName = "GroupData2";
            this.tableCell150.Weight = 0.84257269965277781D;
            // 
            // table76
            // 
            this.table76.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table76.Name = "table76";
            this.table76.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow76});
            this.table76.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow76
            // 
            this.tableRow76.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell151,
            this.tableCell152});
            this.tableRow76.Name = "tableRow76";
            this.tableRow76.Weight = 1D;
            // 
            // tableCell151
            // 
            this.tableCell151.Name = "tableCell151";
            this.tableCell151.StyleName = "GroupCaption2";
            this.tableCell151.Text = "USER CREATION TIME";
            this.tableCell151.Weight = 0.14823306613498263D;
            // 
            // tableCell152
            // 
            this.tableCell152.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.CreationTime]")});
            this.tableCell152.Name = "tableCell152";
            this.tableCell152.StyleName = "GroupData2";
            this.tableCell152.Weight = 0.85176689995659727D;
            // 
            // table77
            // 
            this.table77.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table77.Name = "table77";
            this.table77.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow77});
            this.table77.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow77
            // 
            this.tableRow77.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell153,
            this.tableCell154});
            this.tableRow77.Name = "tableRow77";
            this.tableRow77.Weight = 1D;
            // 
            // tableCell153
            // 
            this.tableCell153.Name = "tableCell153";
            this.tableCell153.StyleName = "GroupCaption2";
            this.tableCell153.Text = "USER INCREMENT";
            this.tableCell153.Weight = 0.12347879197862413D;
            // 
            // tableCell154
            // 
            this.tableCell154.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Increment]")});
            this.tableCell154.Name = "tableCell154";
            this.tableCell154.StyleName = "GroupData2";
            this.tableCell154.Weight = 0.87652119954427088D;
            // 
            // table78
            // 
            this.table78.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table78.Name = "table78";
            this.table78.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow78});
            this.table78.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow78
            // 
            this.tableRow78.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell155,
            this.tableCell156});
            this.tableRow78.Name = "tableRow78";
            this.tableRow78.Weight = 1D;
            // 
            // tableCell155
            // 
            this.tableCell155.Name = "tableCell155";
            this.tableCell155.StyleName = "GroupCaption2";
            this.tableCell155.Text = "USER PID";
            this.tableCell155.Weight = 0.06902187771267361D;
            // 
            // tableCell156
            // 
            this.tableCell156.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Pid]")});
            this.tableCell156.Name = "tableCell156";
            this.tableCell156.StyleName = "GroupData2";
            this.tableCell156.Weight = 0.93097812228732635D;
            // 
            // table79
            // 
            this.table79.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table79.Name = "table79";
            this.table79.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow79});
            this.table79.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow79
            // 
            this.tableRow79.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell157,
            this.tableCell158});
            this.tableRow79.Name = "tableRow79";
            this.tableRow79.Weight = 1D;
            // 
            // tableCell157
            // 
            this.tableCell157.Name = "tableCell157";
            this.tableCell157.StyleName = "GroupCaption2";
            this.tableCell157.Text = "USER MACHINE";
            this.tableCell157.Weight = 1580877.375D;
            // 
            // tableCell158
            // 
            this.tableCell158.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Machine]")});
            this.tableCell158.Name = "tableCell158";
            this.tableCell158.StyleName = "GroupData2";
            this.tableCell158.Weight = 13164722D;
            // 
            // table80
            // 
            this.table80.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table80.Name = "table80";
            this.table80.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow80});
            this.table80.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow80
            // 
            this.tableRow80.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell159,
            this.tableCell160});
            this.tableRow80.Name = "tableRow80";
            this.tableRow80.Weight = 1D;
            // 
            // tableCell159
            // 
            this.tableCell159.Name = "tableCell159";
            this.tableCell159.StyleName = "GroupCaption2";
            this.tableCell159.Text = "USER TIMESTAMP";
            this.tableCell159.Weight = 0.12277010599772135D;
            // 
            // tableCell160
            // 
            this.tableCell160.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Timestamp]")});
            this.tableCell160.Name = "tableCell160";
            this.tableCell160.StyleName = "GroupData2";
            this.tableCell160.Weight = 0.87722988552517356D;
            // 
            // table81
            // 
            this.table81.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table81.Name = "table81";
            this.table81.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow81});
            this.table81.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow81
            // 
            this.tableRow81.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell161,
            this.tableCell162});
            this.tableRow81.Name = "tableRow81";
            this.tableRow81.Weight = 1D;
            // 
            // tableCell161
            // 
            this.tableCell161.Name = "tableCell161";
            this.tableCell161.StyleName = "GroupCaption2";
            this.tableCell161.Text = "USER COMMENT";
            this.tableCell161.Weight = 0.11356961568196615D;
            // 
            // tableCell162
            // 
            this.tableCell162.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UserComment]")});
            this.tableCell162.Name = "tableCell162";
            this.tableCell162.StyleName = "GroupData2";
            this.tableCell162.Weight = 0.88643039279513891D;
            // 
            // table82
            // 
            this.table82.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table82.Name = "table82";
            this.table82.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow82});
            this.table82.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow82
            // 
            this.tableRow82.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell163,
            this.tableCell164});
            this.tableRow82.Name = "tableRow82";
            this.tableRow82.Weight = 1D;
            // 
            // tableCell163
            // 
            this.tableCell163.Name = "tableCell163";
            this.tableCell163.StyleName = "GroupCaption2";
            this.tableCell163.Text = " ID CREATION TIME";
            this.tableCell163.Weight = 0.12912963019476997D;
            // 
            // tableCell164
            // 
            this.tableCell164.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell164.Name = "tableCell164";
            this.tableCell164.StyleName = "GroupData2";
            this.tableCell164.Weight = 0.870870361328125D;
            // 
            // table83
            // 
            this.table83.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table83.Name = "table83";
            this.table83.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow83});
            this.table83.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow83
            // 
            this.tableRow83.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell165,
            this.tableCell166});
            this.tableRow83.Name = "tableRow83";
            this.tableRow83.Weight = 1D;
            // 
            // tableCell165
            // 
            this.tableCell165.Name = "tableCell165";
            this.tableCell165.StyleName = "GroupCaption2";
            this.tableCell165.Text = " ID INCREMENT";
            this.tableCell165.Weight = 1539077.375D;
            // 
            // tableCell166
            // 
            this.tableCell166.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell166.Name = "tableCell166";
            this.tableCell166.StyleName = "GroupData2";
            this.tableCell166.Weight = 13206522D;
            // 
            // table84
            // 
            this.table84.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table84.Name = "table84";
            this.table84.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow84});
            this.table84.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow84
            // 
            this.tableRow84.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell167,
            this.tableCell168});
            this.tableRow84.Name = "tableRow84";
            this.tableRow84.Weight = 1D;
            // 
            // tableCell167
            // 
            this.tableCell167.Name = "tableCell167";
            this.tableCell167.StyleName = "GroupCaption2";
            this.tableCell167.Text = " ID PID";
            this.tableCell167.Weight = 736077.3125D;
            // 
            // tableCell168
            // 
            this.tableCell168.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell168.Name = "tableCell168";
            this.tableCell168.StyleName = "GroupData2";
            this.tableCell168.Weight = 14009522D;
            // 
            // table85
            // 
            this.table85.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table85.Name = "table85";
            this.table85.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow85});
            this.table85.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow85
            // 
            this.tableRow85.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell169,
            this.tableCell170});
            this.tableRow85.Name = "tableRow85";
            this.tableRow85.Weight = 1D;
            // 
            // tableCell169
            // 
            this.tableCell169.Name = "tableCell169";
            this.tableCell169.StyleName = "GroupCaption2";
            this.tableCell169.Text = " ID MACHINE";
            this.tableCell169.Weight = 0.0881066640218099D;
            // 
            // tableCell170
            // 
            this.tableCell170.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell170.Name = "tableCell170";
            this.tableCell170.StyleName = "GroupData2";
            this.tableCell170.Weight = 0.91189337836371531D;
            // 
            // table86
            // 
            this.table86.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table86.Name = "table86";
            this.table86.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow86});
            this.table86.SizeF = new System.Drawing.SizeF(900F, 25F);
            // 
            // tableRow86
            // 
            this.tableRow86.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell171,
            this.tableCell172});
            this.tableRow86.Name = "tableRow86";
            this.tableRow86.Weight = 1D;
            // 
            // tableCell171
            // 
            this.tableCell171.Name = "tableCell171";
            this.tableCell171.StyleName = "GroupCaption2";
            this.tableCell171.Text = " ID TIMESTAMP";
            this.tableCell171.Weight = 1528627.375D;
            // 
            // tableCell172
            // 
            this.tableCell172.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell172.Name = "tableCell172";
            this.tableCell172.StyleName = "GroupData2";
            this.tableCell172.Weight = 13216972D;
            // 
            // label7
            // 
            this.label7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label7.Name = "label7";
            this.label7.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label7.StyleName = "GroupFooterBackground3";
            this.label7.StylePriority.UseBorders = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // GroupCaption2
            // 
            this.GroupCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.GroupCaption2.BorderColor = System.Drawing.Color.White;
            this.GroupCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption2.BorderWidth = 2F;
            this.GroupCaption2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupCaption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption2.Name = "GroupCaption2";
            this.GroupCaption2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData2
            // 
            this.GroupData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.GroupData2.BorderColor = System.Drawing.Color.White;
            this.GroupData2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData2.BorderWidth = 2F;
            this.GroupData2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupData2.ForeColor = System.Drawing.Color.White;
            this.GroupData2.Name = "GroupData2";
            this.GroupData2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.DetailReport,
            this.DetailReport1,
            this.DetailReport2,
            this.DetailReport3,
            this.DetailReport4,
            this.DetailReport5});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.mongoDBDataSource1});
            this.DataSource = this.mongoDBDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption2,
            this.GroupData2,
            this.GroupFooterBackground3,
            this.PageInfo});
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.XRTable table1;
        private DevExpress.XtraReports.UI.XRTableRow tableRow1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell1;
        private DevExpress.XtraReports.UI.XRTableCell tableCell2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader3;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader4;
        private DevExpress.XtraReports.UI.XRTable table4;
        private DevExpress.XtraReports.UI.XRTableRow tableRow4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader5;
        private DevExpress.XtraReports.UI.XRTable table5;
        private DevExpress.XtraReports.UI.XRTableRow tableRow5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader6;
        private DevExpress.XtraReports.UI.XRTable table6;
        private DevExpress.XtraReports.UI.XRTableRow tableRow6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader7;
        private DevExpress.XtraReports.UI.XRTable table7;
        private DevExpress.XtraReports.UI.XRTableRow tableRow7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader8;
        private DevExpress.XtraReports.UI.XRTable table8;
        private DevExpress.XtraReports.UI.XRTableRow tableRow8;
        private DevExpress.XtraReports.UI.XRTableCell tableCell15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell16;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader9;
        private DevExpress.XtraReports.UI.XRTable table9;
        private DevExpress.XtraReports.UI.XRTableRow tableRow9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell18;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader10;
        private DevExpress.XtraReports.UI.XRTable table10;
        private DevExpress.XtraReports.UI.XRTableRow tableRow10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell20;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader11;
        private DevExpress.XtraReports.UI.XRTable table11;
        private DevExpress.XtraReports.UI.XRTableRow tableRow11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell22;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader12;
        private DevExpress.XtraReports.UI.XRTable table12;
        private DevExpress.XtraReports.UI.XRTableRow tableRow12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell24;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.DataAccess.MongoDB.MongoDBDataSource mongoDBDataSource1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader13;
        private DevExpress.XtraReports.UI.XRTable table13;
        private DevExpress.XtraReports.UI.XRTableRow tableRow13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell26;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader14;
        private DevExpress.XtraReports.UI.XRTable table14;
        private DevExpress.XtraReports.UI.XRTableRow tableRow14;
        private DevExpress.XtraReports.UI.XRTableCell tableCell27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell28;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader15;
        private DevExpress.XtraReports.UI.XRTable table15;
        private DevExpress.XtraReports.UI.XRTableRow tableRow15;
        private DevExpress.XtraReports.UI.XRTableCell tableCell29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell30;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader16;
        private DevExpress.XtraReports.UI.XRTable table16;
        private DevExpress.XtraReports.UI.XRTableRow tableRow16;
        private DevExpress.XtraReports.UI.XRTableCell tableCell31;
        private DevExpress.XtraReports.UI.XRTableCell tableCell32;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader17;
        private DevExpress.XtraReports.UI.XRTable table17;
        private DevExpress.XtraReports.UI.XRTableRow tableRow17;
        private DevExpress.XtraReports.UI.XRTableCell tableCell33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell34;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader18;
        private DevExpress.XtraReports.UI.XRTable table18;
        private DevExpress.XtraReports.UI.XRTableRow tableRow18;
        private DevExpress.XtraReports.UI.XRTableCell tableCell35;
        private DevExpress.XtraReports.UI.XRTableCell tableCell36;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader19;
        private DevExpress.XtraReports.UI.XRTable table19;
        private DevExpress.XtraReports.UI.XRTableRow tableRow19;
        private DevExpress.XtraReports.UI.XRTableCell tableCell37;
        private DevExpress.XtraReports.UI.XRTableCell tableCell38;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader20;
        private DevExpress.XtraReports.UI.XRTable table20;
        private DevExpress.XtraReports.UI.XRTableRow tableRow20;
        private DevExpress.XtraReports.UI.XRTableCell tableCell39;
        private DevExpress.XtraReports.UI.XRTableCell tableCell40;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader21;
        private DevExpress.XtraReports.UI.XRTable table21;
        private DevExpress.XtraReports.UI.XRTableRow tableRow21;
        private DevExpress.XtraReports.UI.XRTableCell tableCell41;
        private DevExpress.XtraReports.UI.XRTableCell tableCell42;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader22;
        private DevExpress.XtraReports.UI.XRTable table22;
        private DevExpress.XtraReports.UI.XRTableRow tableRow22;
        private DevExpress.XtraReports.UI.XRTableCell tableCell43;
        private DevExpress.XtraReports.UI.XRTableCell tableCell44;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader23;
        private DevExpress.XtraReports.UI.XRTable table23;
        private DevExpress.XtraReports.UI.XRTableRow tableRow23;
        private DevExpress.XtraReports.UI.XRTableCell tableCell45;
        private DevExpress.XtraReports.UI.XRTableCell tableCell46;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader24;
        private DevExpress.XtraReports.UI.XRTable table24;
        private DevExpress.XtraReports.UI.XRTableRow tableRow24;
        private DevExpress.XtraReports.UI.XRTableCell tableCell47;
        private DevExpress.XtraReports.UI.XRTableCell tableCell48;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader25;
        private DevExpress.XtraReports.UI.XRTable table25;
        private DevExpress.XtraReports.UI.XRTableRow tableRow25;
        private DevExpress.XtraReports.UI.XRTableCell tableCell49;
        private DevExpress.XtraReports.UI.XRTableCell tableCell50;
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader26;
        private DevExpress.XtraReports.UI.XRTable table26;
        private DevExpress.XtraReports.UI.XRTableRow tableRow26;
        private DevExpress.XtraReports.UI.XRTableCell tableCell51;
        private DevExpress.XtraReports.UI.XRTableCell tableCell52;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader27;
        private DevExpress.XtraReports.UI.XRTable table27;
        private DevExpress.XtraReports.UI.XRTableRow tableRow27;
        private DevExpress.XtraReports.UI.XRTableCell tableCell53;
        private DevExpress.XtraReports.UI.XRTableCell tableCell54;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader28;
        private DevExpress.XtraReports.UI.XRTable table28;
        private DevExpress.XtraReports.UI.XRTableRow tableRow28;
        private DevExpress.XtraReports.UI.XRTableCell tableCell55;
        private DevExpress.XtraReports.UI.XRTableCell tableCell56;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader29;
        private DevExpress.XtraReports.UI.XRTable table29;
        private DevExpress.XtraReports.UI.XRTableRow tableRow29;
        private DevExpress.XtraReports.UI.XRTableCell tableCell57;
        private DevExpress.XtraReports.UI.XRTableCell tableCell58;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader30;
        private DevExpress.XtraReports.UI.XRTable table30;
        private DevExpress.XtraReports.UI.XRTableRow tableRow30;
        private DevExpress.XtraReports.UI.XRTableCell tableCell59;
        private DevExpress.XtraReports.UI.XRTableCell tableCell60;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader31;
        private DevExpress.XtraReports.UI.XRTable table31;
        private DevExpress.XtraReports.UI.XRTableRow tableRow31;
        private DevExpress.XtraReports.UI.XRTableCell tableCell61;
        private DevExpress.XtraReports.UI.XRTableCell tableCell62;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader32;
        private DevExpress.XtraReports.UI.XRTable table32;
        private DevExpress.XtraReports.UI.XRTableRow tableRow32;
        private DevExpress.XtraReports.UI.XRTableCell tableCell63;
        private DevExpress.XtraReports.UI.XRTableCell tableCell64;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader33;
        private DevExpress.XtraReports.UI.XRTable table33;
        private DevExpress.XtraReports.UI.XRTableRow tableRow33;
        private DevExpress.XtraReports.UI.XRTableCell tableCell65;
        private DevExpress.XtraReports.UI.XRTableCell tableCell66;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader34;
        private DevExpress.XtraReports.UI.XRTable table34;
        private DevExpress.XtraReports.UI.XRTableRow tableRow34;
        private DevExpress.XtraReports.UI.XRTableCell tableCell67;
        private DevExpress.XtraReports.UI.XRTableCell tableCell68;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader35;
        private DevExpress.XtraReports.UI.XRTable table35;
        private DevExpress.XtraReports.UI.XRTableRow tableRow35;
        private DevExpress.XtraReports.UI.XRTableCell tableCell69;
        private DevExpress.XtraReports.UI.XRTableCell tableCell70;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader36;
        private DevExpress.XtraReports.UI.XRTable table36;
        private DevExpress.XtraReports.UI.XRTableRow tableRow36;
        private DevExpress.XtraReports.UI.XRTableCell tableCell71;
        private DevExpress.XtraReports.UI.XRTableCell tableCell72;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader37;
        private DevExpress.XtraReports.UI.XRTable table37;
        private DevExpress.XtraReports.UI.XRTableRow tableRow37;
        private DevExpress.XtraReports.UI.XRTableCell tableCell73;
        private DevExpress.XtraReports.UI.XRTableCell tableCell74;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader38;
        private DevExpress.XtraReports.UI.XRTable table38;
        private DevExpress.XtraReports.UI.XRTableRow tableRow38;
        private DevExpress.XtraReports.UI.XRTableCell tableCell75;
        private DevExpress.XtraReports.UI.XRTableCell tableCell76;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader39;
        private DevExpress.XtraReports.UI.XRTable table39;
        private DevExpress.XtraReports.UI.XRTableRow tableRow39;
        private DevExpress.XtraReports.UI.XRTableCell tableCell77;
        private DevExpress.XtraReports.UI.XRTableCell tableCell78;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader40;
        private DevExpress.XtraReports.UI.XRTable table40;
        private DevExpress.XtraReports.UI.XRTableRow tableRow40;
        private DevExpress.XtraReports.UI.XRTableCell tableCell79;
        private DevExpress.XtraReports.UI.XRTableCell tableCell80;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader41;
        private DevExpress.XtraReports.UI.XRTable table41;
        private DevExpress.XtraReports.UI.XRTableRow tableRow41;
        private DevExpress.XtraReports.UI.XRTableCell tableCell81;
        private DevExpress.XtraReports.UI.XRTableCell tableCell82;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader42;
        private DevExpress.XtraReports.UI.XRTable table42;
        private DevExpress.XtraReports.UI.XRTableRow tableRow42;
        private DevExpress.XtraReports.UI.XRTableCell tableCell83;
        private DevExpress.XtraReports.UI.XRTableCell tableCell84;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader43;
        private DevExpress.XtraReports.UI.XRTable table43;
        private DevExpress.XtraReports.UI.XRTableRow tableRow43;
        private DevExpress.XtraReports.UI.XRTableCell tableCell85;
        private DevExpress.XtraReports.UI.XRTableCell tableCell86;
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter3;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport3;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader44;
        private DevExpress.XtraReports.UI.XRTable table44;
        private DevExpress.XtraReports.UI.XRTableRow tableRow44;
        private DevExpress.XtraReports.UI.XRTableCell tableCell87;
        private DevExpress.XtraReports.UI.XRTableCell tableCell88;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader45;
        private DevExpress.XtraReports.UI.XRTable table45;
        private DevExpress.XtraReports.UI.XRTableRow tableRow45;
        private DevExpress.XtraReports.UI.XRTableCell tableCell89;
        private DevExpress.XtraReports.UI.XRTableCell tableCell90;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader46;
        private DevExpress.XtraReports.UI.XRTable table46;
        private DevExpress.XtraReports.UI.XRTableRow tableRow46;
        private DevExpress.XtraReports.UI.XRTableCell tableCell91;
        private DevExpress.XtraReports.UI.XRTableCell tableCell92;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader47;
        private DevExpress.XtraReports.UI.XRTable table47;
        private DevExpress.XtraReports.UI.XRTableRow tableRow47;
        private DevExpress.XtraReports.UI.XRTableCell tableCell93;
        private DevExpress.XtraReports.UI.XRTableCell tableCell94;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader48;
        private DevExpress.XtraReports.UI.XRTable table48;
        private DevExpress.XtraReports.UI.XRTableRow tableRow48;
        private DevExpress.XtraReports.UI.XRTableCell tableCell95;
        private DevExpress.XtraReports.UI.XRTableCell tableCell96;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader49;
        private DevExpress.XtraReports.UI.XRTable table49;
        private DevExpress.XtraReports.UI.XRTableRow tableRow49;
        private DevExpress.XtraReports.UI.XRTableCell tableCell97;
        private DevExpress.XtraReports.UI.XRTableCell tableCell98;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader50;
        private DevExpress.XtraReports.UI.XRTable table50;
        private DevExpress.XtraReports.UI.XRTableRow tableRow50;
        private DevExpress.XtraReports.UI.XRTableCell tableCell99;
        private DevExpress.XtraReports.UI.XRTableCell tableCell100;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader51;
        private DevExpress.XtraReports.UI.XRTable table51;
        private DevExpress.XtraReports.UI.XRTableRow tableRow51;
        private DevExpress.XtraReports.UI.XRTableCell tableCell101;
        private DevExpress.XtraReports.UI.XRTableCell tableCell102;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader52;
        private DevExpress.XtraReports.UI.XRTable table52;
        private DevExpress.XtraReports.UI.XRTableRow tableRow52;
        private DevExpress.XtraReports.UI.XRTableCell tableCell103;
        private DevExpress.XtraReports.UI.XRTableCell tableCell104;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader53;
        private DevExpress.XtraReports.UI.XRTable table53;
        private DevExpress.XtraReports.UI.XRTableRow tableRow53;
        private DevExpress.XtraReports.UI.XRTableCell tableCell105;
        private DevExpress.XtraReports.UI.XRTableCell tableCell106;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader54;
        private DevExpress.XtraReports.UI.XRTable table54;
        private DevExpress.XtraReports.UI.XRTableRow tableRow54;
        private DevExpress.XtraReports.UI.XRTableCell tableCell107;
        private DevExpress.XtraReports.UI.XRTableCell tableCell108;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader55;
        private DevExpress.XtraReports.UI.XRTable table55;
        private DevExpress.XtraReports.UI.XRTableRow tableRow55;
        private DevExpress.XtraReports.UI.XRTableCell tableCell109;
        private DevExpress.XtraReports.UI.XRTableCell tableCell110;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader56;
        private DevExpress.XtraReports.UI.XRTable table56;
        private DevExpress.XtraReports.UI.XRTableRow tableRow56;
        private DevExpress.XtraReports.UI.XRTableCell tableCell111;
        private DevExpress.XtraReports.UI.XRTableCell tableCell112;
        private DevExpress.XtraReports.UI.DetailBand Detail4;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter4;
        private DevExpress.XtraReports.UI.XRLabel label5;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport4;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader57;
        private DevExpress.XtraReports.UI.XRTable table57;
        private DevExpress.XtraReports.UI.XRTableRow tableRow57;
        private DevExpress.XtraReports.UI.XRTableCell tableCell113;
        private DevExpress.XtraReports.UI.XRTableCell tableCell114;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader58;
        private DevExpress.XtraReports.UI.XRTable table58;
        private DevExpress.XtraReports.UI.XRTableRow tableRow58;
        private DevExpress.XtraReports.UI.XRTableCell tableCell115;
        private DevExpress.XtraReports.UI.XRTableCell tableCell116;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader59;
        private DevExpress.XtraReports.UI.XRTable table59;
        private DevExpress.XtraReports.UI.XRTableRow tableRow59;
        private DevExpress.XtraReports.UI.XRTableCell tableCell117;
        private DevExpress.XtraReports.UI.XRTableCell tableCell118;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader60;
        private DevExpress.XtraReports.UI.XRTable table60;
        private DevExpress.XtraReports.UI.XRTableRow tableRow60;
        private DevExpress.XtraReports.UI.XRTableCell tableCell119;
        private DevExpress.XtraReports.UI.XRTableCell tableCell120;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader61;
        private DevExpress.XtraReports.UI.XRTable table61;
        private DevExpress.XtraReports.UI.XRTableRow tableRow61;
        private DevExpress.XtraReports.UI.XRTableCell tableCell121;
        private DevExpress.XtraReports.UI.XRTableCell tableCell122;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader62;
        private DevExpress.XtraReports.UI.XRTable table62;
        private DevExpress.XtraReports.UI.XRTableRow tableRow62;
        private DevExpress.XtraReports.UI.XRTableCell tableCell123;
        private DevExpress.XtraReports.UI.XRTableCell tableCell124;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader63;
        private DevExpress.XtraReports.UI.XRTable table63;
        private DevExpress.XtraReports.UI.XRTableRow tableRow63;
        private DevExpress.XtraReports.UI.XRTableCell tableCell125;
        private DevExpress.XtraReports.UI.XRTableCell tableCell126;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader64;
        private DevExpress.XtraReports.UI.XRTable table64;
        private DevExpress.XtraReports.UI.XRTableRow tableRow64;
        private DevExpress.XtraReports.UI.XRTableCell tableCell127;
        private DevExpress.XtraReports.UI.XRTableCell tableCell128;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader65;
        private DevExpress.XtraReports.UI.XRTable table65;
        private DevExpress.XtraReports.UI.XRTableRow tableRow65;
        private DevExpress.XtraReports.UI.XRTableCell tableCell129;
        private DevExpress.XtraReports.UI.XRTableCell tableCell130;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader66;
        private DevExpress.XtraReports.UI.XRTable table66;
        private DevExpress.XtraReports.UI.XRTableRow tableRow66;
        private DevExpress.XtraReports.UI.XRTableCell tableCell131;
        private DevExpress.XtraReports.UI.XRTableCell tableCell132;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader67;
        private DevExpress.XtraReports.UI.XRTable table67;
        private DevExpress.XtraReports.UI.XRTableRow tableRow67;
        private DevExpress.XtraReports.UI.XRTableCell tableCell133;
        private DevExpress.XtraReports.UI.XRTableCell tableCell134;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader68;
        private DevExpress.XtraReports.UI.XRTable table68;
        private DevExpress.XtraReports.UI.XRTableRow tableRow68;
        private DevExpress.XtraReports.UI.XRTableCell tableCell135;
        private DevExpress.XtraReports.UI.XRTableCell tableCell136;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader69;
        private DevExpress.XtraReports.UI.XRTable table69;
        private DevExpress.XtraReports.UI.XRTableRow tableRow69;
        private DevExpress.XtraReports.UI.XRTableCell tableCell137;
        private DevExpress.XtraReports.UI.XRTableCell tableCell138;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader70;
        private DevExpress.XtraReports.UI.XRTable table70;
        private DevExpress.XtraReports.UI.XRTableRow tableRow70;
        private DevExpress.XtraReports.UI.XRTableCell tableCell139;
        private DevExpress.XtraReports.UI.XRTableCell tableCell140;
        private DevExpress.XtraReports.UI.DetailBand Detail5;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter5;
        private DevExpress.XtraReports.UI.XRLabel label6;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader71;
        private DevExpress.XtraReports.UI.XRTable table71;
        private DevExpress.XtraReports.UI.XRTableRow tableRow71;
        private DevExpress.XtraReports.UI.XRTableCell tableCell141;
        private DevExpress.XtraReports.UI.XRTableCell tableCell142;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader72;
        private DevExpress.XtraReports.UI.XRTable table72;
        private DevExpress.XtraReports.UI.XRTableRow tableRow72;
        private DevExpress.XtraReports.UI.XRTableCell tableCell143;
        private DevExpress.XtraReports.UI.XRTableCell tableCell144;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader73;
        private DevExpress.XtraReports.UI.XRTable table73;
        private DevExpress.XtraReports.UI.XRTableRow tableRow73;
        private DevExpress.XtraReports.UI.XRTableCell tableCell145;
        private DevExpress.XtraReports.UI.XRTableCell tableCell146;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader74;
        private DevExpress.XtraReports.UI.XRTable table74;
        private DevExpress.XtraReports.UI.XRTableRow tableRow74;
        private DevExpress.XtraReports.UI.XRTableCell tableCell147;
        private DevExpress.XtraReports.UI.XRTableCell tableCell148;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader75;
        private DevExpress.XtraReports.UI.XRTable table75;
        private DevExpress.XtraReports.UI.XRTableRow tableRow75;
        private DevExpress.XtraReports.UI.XRTableCell tableCell149;
        private DevExpress.XtraReports.UI.XRTableCell tableCell150;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader76;
        private DevExpress.XtraReports.UI.XRTable table76;
        private DevExpress.XtraReports.UI.XRTableRow tableRow76;
        private DevExpress.XtraReports.UI.XRTableCell tableCell151;
        private DevExpress.XtraReports.UI.XRTableCell tableCell152;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader77;
        private DevExpress.XtraReports.UI.XRTable table77;
        private DevExpress.XtraReports.UI.XRTableRow tableRow77;
        private DevExpress.XtraReports.UI.XRTableCell tableCell153;
        private DevExpress.XtraReports.UI.XRTableCell tableCell154;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader78;
        private DevExpress.XtraReports.UI.XRTable table78;
        private DevExpress.XtraReports.UI.XRTableRow tableRow78;
        private DevExpress.XtraReports.UI.XRTableCell tableCell155;
        private DevExpress.XtraReports.UI.XRTableCell tableCell156;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader79;
        private DevExpress.XtraReports.UI.XRTable table79;
        private DevExpress.XtraReports.UI.XRTableRow tableRow79;
        private DevExpress.XtraReports.UI.XRTableCell tableCell157;
        private DevExpress.XtraReports.UI.XRTableCell tableCell158;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader80;
        private DevExpress.XtraReports.UI.XRTable table80;
        private DevExpress.XtraReports.UI.XRTableRow tableRow80;
        private DevExpress.XtraReports.UI.XRTableCell tableCell159;
        private DevExpress.XtraReports.UI.XRTableCell tableCell160;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader81;
        private DevExpress.XtraReports.UI.XRTable table81;
        private DevExpress.XtraReports.UI.XRTableRow tableRow81;
        private DevExpress.XtraReports.UI.XRTableCell tableCell161;
        private DevExpress.XtraReports.UI.XRTableCell tableCell162;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader82;
        private DevExpress.XtraReports.UI.XRTable table82;
        private DevExpress.XtraReports.UI.XRTableRow tableRow82;
        private DevExpress.XtraReports.UI.XRTableCell tableCell163;
        private DevExpress.XtraReports.UI.XRTableCell tableCell164;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader83;
        private DevExpress.XtraReports.UI.XRTable table83;
        private DevExpress.XtraReports.UI.XRTableRow tableRow83;
        private DevExpress.XtraReports.UI.XRTableCell tableCell165;
        private DevExpress.XtraReports.UI.XRTableCell tableCell166;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader84;
        private DevExpress.XtraReports.UI.XRTable table84;
        private DevExpress.XtraReports.UI.XRTableRow tableRow84;
        private DevExpress.XtraReports.UI.XRTableCell tableCell167;
        private DevExpress.XtraReports.UI.XRTableCell tableCell168;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader85;
        private DevExpress.XtraReports.UI.XRTable table85;
        private DevExpress.XtraReports.UI.XRTableRow tableRow85;
        private DevExpress.XtraReports.UI.XRTableCell tableCell169;
        private DevExpress.XtraReports.UI.XRTableCell tableCell170;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader86;
        private DevExpress.XtraReports.UI.XRTable table86;
        private DevExpress.XtraReports.UI.XRTableRow tableRow86;
        private DevExpress.XtraReports.UI.XRTableCell tableCell171;
        private DevExpress.XtraReports.UI.XRTableCell tableCell172;
        private DevExpress.XtraReports.UI.DetailBand Detail6;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter6;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption2;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData2;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    }
}
