namespace Bixbu_UI
{
    partial class Report
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
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode1 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("UserShop", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode2 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode3 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode4 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Item", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode5 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalSuccessfulOrders", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode6 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalRefunds", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode7 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalViews", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery2 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode8 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("CartAndOrder", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode9 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode10 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Item", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode11 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode12 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Quantity", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode13 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Price", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery3 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode14 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("productPurchases", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode15 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode16 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("orderId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode17 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("cutomerId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode18 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ownerId", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode19 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("isDeliverd", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode20 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("isRefund", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<bool>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery4 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode21 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ShopItem", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode22 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode23 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Name", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode24 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Description", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode25 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("TotalComments", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<long>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode26 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Price", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode27 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Pics", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode28 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("publish", false);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode29 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("FirstName", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode30 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("LastName", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode31 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Email", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode32 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Pic", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode33 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("loveThisProduct", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(System.Nullable<int>));
            DevExpress.DataAccess.MongoDB.MongoDBQuery mongoDBQuery5 = new DevExpress.DataAccess.MongoDB.MongoDBQuery();
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode34 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("Comment", true);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode35 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("_id", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode36 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("UserComment", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.Property, typeof(string));
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode37 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("User", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            DevExpress.DataAccess.MongoDB.MongoDBSchemaNode mongoDBSchemaNode38 = new DevExpress.DataAccess.MongoDB.MongoDBSchemaNode("ShopItem", true, DevExpress.DataAccess.MongoDB.MongoDBNodeType.ObjectID);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table1 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader3 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader4 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table4 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader5 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table5 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader6 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table6 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader7 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table7 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader8 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table8 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader9 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table9 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.label2 = new DevExpress.XtraReports.UI.XRLabel();
            this.mongoDBDataSource1 = new DevExpress.DataAccess.MongoDB.MongoDBDataSource(this.components);
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader10 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table10 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader11 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table11 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader12 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table12 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader13 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table13 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader14 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table14 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader15 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table15 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader16 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table16 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader17 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table17 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader18 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table18 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow18 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader19 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table19 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow19 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader20 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table20 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow20 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader21 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table21 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow21 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader22 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table22 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow22 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.label3 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport2 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader23 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table23 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow23 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader24 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table24 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow24 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader25 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table25 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow25 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader26 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table26 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow26 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader27 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table27 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow27 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader28 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table28 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow28 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader29 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table29 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow29 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader30 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table30 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow30 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader31 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table31 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow31 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader32 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table32 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow32 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader33 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table33 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow33 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader34 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table34 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow34 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader35 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table35 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader36 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table36 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow36 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader37 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table37 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader38 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table38 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader39 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table39 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader40 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table40 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail3 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter3 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.label4 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport5 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader66 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table67 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow67 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell131 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader67 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table68 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow68 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader68 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table69 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow69 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader69 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table70 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow70 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader70 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table71 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow71 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader71 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table72 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow72 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell142 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader72 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table73 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow73 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell143 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader73 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table74 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow74 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell145 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader74 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table75 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow75 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader75 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table76 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow76 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader76 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table77 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow77 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader77 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table78 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow78 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell153 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell154 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader78 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table79 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow79 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell155 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell156 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader79 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table80 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow80 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell157 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell158 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail6 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter6 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.label7 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport6 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.GroupHeader80 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table81 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow81 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell159 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell160 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader81 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table82 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow82 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell161 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell162 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader82 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table83 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow83 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell163 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell164 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader83 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table84 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow84 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell165 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell166 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader84 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table85 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow85 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell167 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell168 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader85 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table86 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow86 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell169 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell170 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader86 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table87 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow87 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell171 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell172 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader87 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table88 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow88 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell173 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell174 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader88 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table89 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow89 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell175 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell176 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader89 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table90 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow90 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell177 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell178 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader90 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table91 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow91 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell179 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell180 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader91 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table92 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow92 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell181 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell182 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader92 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table93 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow93 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell183 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell184 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader93 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table94 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow94 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell185 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell186 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader94 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table95 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow95 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell187 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell188 = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeader95 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.table96 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow96 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell189 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell190 = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail7 = new DevExpress.XtraReports.UI.DetailBand();
            this.GroupFooter7 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.label8 = new DevExpress.XtraReports.UI.XRLabel();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData2 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
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
            ((System.ComponentModel.ISupportInitialize)(this.table87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table89)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table91)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table92)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table93)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table94)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table96)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // topMarginBand1
            // 
            this.topMarginBand1.Name = "topMarginBand1";
            this.topMarginBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.topMarginBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // bottomMarginBand1
            // 
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            this.bottomMarginBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.bottomMarginBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(450F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(450F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.pageInfo2.SizeF = new System.Drawing.SizeF(450F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label1.SizeF = new System.Drawing.SizeF(900F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "Bixby";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // detailBand1
            // 
            this.detailBand1.HeightF = 0F;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.detailBand1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
            this.Detail1,
            this.GroupFooter1});
            this.DetailReport.DataMember = "UserShop";
            this.DetailReport.DataSource = this.mongoDBDataSource1;
            this.DetailReport.Expanded = false;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            this.DetailReport.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailReport.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader1.HeightF = 27F;
            this.GroupHeader1.Level = 1;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table1
            // 
            this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table1.Name = "table1";
            this.table1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
            this.table1.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow1
            // 
            this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
            this.tableRow1.Name = "tableRow1";
            this.tableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow1.Weight = 1D;
            // 
            // tableCell1
            // 
            this.tableCell1.Name = "tableCell1";
            this.tableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell1.StyleName = "GroupCaption2";
            this.tableCell1.Text = "ITEM INCREMENT";
            this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell1.Weight = 0.11851799011230468D;
            // 
            // tableCell2
            // 
            this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Increment]")});
            this.tableCell2.Name = "tableCell2";
            this.tableCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell2.StyleName = "GroupData2";
            this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell2.Weight = 0.8814820014105903D;
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader2.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 27F;
            this.GroupHeader2.Level = 2;
            this.GroupHeader2.Name = "GroupHeader2";
            this.GroupHeader2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table2.Name = "table2";
            this.table2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell3.StyleName = "GroupCaption2";
            this.tableCell3.Text = "ITEM PID";
            this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell3.Weight = 0.064061075846354162D;
            // 
            // tableCell4
            // 
            this.tableCell4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Pid]")});
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell4.StyleName = "GroupData2";
            this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell4.Weight = 0.93593892415364588D;
            // 
            // GroupHeader3
            // 
            this.GroupHeader3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.GroupHeader3.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader3.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader3.HeightF = 27F;
            this.GroupHeader3.Level = 3;
            this.GroupHeader3.Name = "GroupHeader3";
            this.GroupHeader3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table3.Name = "table3";
            this.table3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell5,
            this.tableCell6});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow3.Weight = 1D;
            // 
            // tableCell5
            // 
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell5.StyleName = "GroupCaption2";
            this.tableCell5.Text = "ITEM MACHINE";
            this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell5.Weight = 1507727.375D;
            // 
            // tableCell6
            // 
            this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Machine]")});
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell6.StyleName = "GroupData2";
            this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell6.Weight = 13237872D;
            // 
            // GroupHeader4
            // 
            this.GroupHeader4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table4});
            this.GroupHeader4.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader4.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader4.HeightF = 27F;
            this.GroupHeader4.Level = 4;
            this.GroupHeader4.Name = "GroupHeader4";
            this.GroupHeader4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table4
            // 
            this.table4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table4.Name = "table4";
            this.table4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
            this.table4.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow4
            // 
            this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell7,
            this.tableCell8});
            this.tableRow4.Name = "tableRow4";
            this.tableRow4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow4.Weight = 1D;
            // 
            // tableCell7
            // 
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell7.StyleName = "GroupCaption2";
            this.tableCell7.Text = "ITEM TIMESTAMP";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell7.Weight = 0.11780930413140191D;
            // 
            // tableCell8
            // 
            this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Timestamp]")});
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell8.StyleName = "GroupData2";
            this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell8.Weight = 0.88219068739149309D;
            // 
            // GroupHeader5
            // 
            this.GroupHeader5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table5});
            this.GroupHeader5.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader5.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader5.HeightF = 27F;
            this.GroupHeader5.Level = 5;
            this.GroupHeader5.Name = "GroupHeader5";
            this.GroupHeader5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table5
            // 
            this.table5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table5.Name = "table5";
            this.table5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow5});
            this.table5.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow5
            // 
            this.tableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10});
            this.tableRow5.Name = "tableRow5";
            this.tableRow5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow5.Weight = 1D;
            // 
            // tableCell9
            // 
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell9.StyleName = "GroupCaption2";
            this.tableCell9.Text = "USER";
            this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell9.Weight = 0.044261385599772135D;
            // 
            // tableCell10
            // 
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User]")});
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell10.StyleName = "GroupData2";
            this.tableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell10.Weight = 0.9557386610243056D;
            // 
            // GroupHeader6
            // 
            this.GroupHeader6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table6});
            this.GroupHeader6.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader6.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader6.HeightF = 27F;
            this.GroupHeader6.Level = 6;
            this.GroupHeader6.Name = "GroupHeader6";
            this.GroupHeader6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table6
            // 
            this.table6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table6.Name = "table6";
            this.table6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow6});
            this.table6.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow6
            // 
            this.tableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell11,
            this.tableCell12});
            this.tableRow6.Name = "tableRow6";
            this.tableRow6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow6.Weight = 1D;
            // 
            // tableCell11
            // 
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell11.StyleName = "GroupCaption2";
            this.tableCell11.Text = "ITEM CREATION TIME";
            this.tableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell11.Weight = 0.14327226426866319D;
            // 
            // tableCell12
            // 
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.CreationTime]")});
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell12.StyleName = "GroupData2";
            this.tableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell12.Weight = 0.85672770182291669D;
            // 
            // GroupHeader7
            // 
            this.GroupHeader7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table7});
            this.GroupHeader7.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TotalViews", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader7.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader7.HeightF = 27F;
            this.GroupHeader7.Level = 7;
            this.GroupHeader7.Name = "GroupHeader7";
            this.GroupHeader7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table7
            // 
            this.table7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table7.Name = "table7";
            this.table7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow7});
            this.table7.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow7
            // 
            this.tableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell13,
            this.tableCell14});
            this.tableRow7.Name = "tableRow7";
            this.tableRow7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow7.Weight = 1D;
            // 
            // tableCell13
            // 
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell13.StyleName = "GroupCaption2";
            this.tableCell13.Text = "TOTAL VIEWS";
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell13.Weight = 0.09588356018066406D;
            // 
            // tableCell14
            // 
            this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalViews]")});
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell14.StyleName = "GroupData2";
            this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell14.Weight = 0.90411648220486107D;
            // 
            // GroupHeader8
            // 
            this.GroupHeader8.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table8});
            this.GroupHeader8.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TotalRefunds", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader8.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader8.HeightF = 27F;
            this.GroupHeader8.Level = 8;
            this.GroupHeader8.Name = "GroupHeader8";
            this.GroupHeader8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table8
            // 
            this.table8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table8.Name = "table8";
            this.table8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow8});
            this.table8.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow8
            // 
            this.tableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell15,
            this.tableCell16});
            this.tableRow8.Name = "tableRow8";
            this.tableRow8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow8.Weight = 1D;
            // 
            // tableCell15
            // 
            this.tableCell15.Name = "tableCell15";
            this.tableCell15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell15.StyleName = "GroupCaption2";
            this.tableCell15.Text = "TOTAL REFUNDS";
            this.tableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell15.Weight = 0.11639193216959635D;
            // 
            // tableCell16
            // 
            this.tableCell16.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalRefunds]")});
            this.tableCell16.Name = "tableCell16";
            this.tableCell16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell16.StyleName = "GroupData2";
            this.tableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell16.Weight = 0.88360805935329856D;
            // 
            // GroupHeader9
            // 
            this.GroupHeader9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table9});
            this.GroupHeader9.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TotalSuccessfulOrders", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader9.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader9.HeightF = 27F;
            this.GroupHeader9.Level = 9;
            this.GroupHeader9.Name = "GroupHeader9";
            this.GroupHeader9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table9
            // 
            this.table9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table9.Name = "table9";
            this.table9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow9});
            this.table9.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow9
            // 
            this.tableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell17,
            this.tableCell18});
            this.tableRow9.Name = "tableRow9";
            this.tableRow9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow9.Weight = 1D;
            // 
            // tableCell17
            // 
            this.tableCell17.Name = "tableCell17";
            this.tableCell17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell17.StyleName = "GroupCaption2";
            this.tableCell17.Text = "TOTAL SUCCESSFUL ORDERS";
            this.tableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell17.Weight = 0.19915898640950522D;
            // 
            // tableCell18
            // 
            this.tableCell18.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalSuccessfulOrders]")});
            this.tableCell18.Name = "tableCell18";
            this.tableCell18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell18.StyleName = "GroupData2";
            this.tableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell18.Weight = 0.80084099663628472D;
            // 
            // Detail1
            // 
            this.Detail1.HeightF = 0F;
            this.Detail1.Name = "Detail1";
            this.Detail1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label2});
            this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter1.HeightF = 6F;
            this.GroupFooter1.Name = "GroupFooter1";
            this.GroupFooter1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label2
            // 
            this.label2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label2.Name = "label2";
            this.label2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label2.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label2.StyleName = "GroupFooterBackground3";
            this.label2.StylePriority.UseBorders = false;
            this.label2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // mongoDBDataSource1
            // 
            this.mongoDBDataSource1.ConnectionName = "BixByApp";
            this.mongoDBDataSource1.Name = "mongoDBDataSource1";
            mongoDBQuery1.ActualName = "UserShop";
            mongoDBQuery1.Alias = null;
            mongoDBQuery1.CollectionName = "UserShop";
            mongoDBQuery1.DatabaseName = "BixByApp";
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode2);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode3);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode4);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode5);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode6);
            mongoDBSchemaNode1.Nodes.Add(mongoDBSchemaNode7);
            mongoDBQuery1.Schema = mongoDBSchemaNode1;
            mongoDBQuery2.ActualName = "CartAndOrder";
            mongoDBQuery2.Alias = null;
            mongoDBQuery2.CollectionName = "CartAndOrder";
            mongoDBQuery2.DatabaseName = "BixByApp";
            mongoDBSchemaNode8.Nodes.Add(mongoDBSchemaNode9);
            mongoDBSchemaNode8.Nodes.Add(mongoDBSchemaNode10);
            mongoDBSchemaNode8.Nodes.Add(mongoDBSchemaNode11);
            mongoDBSchemaNode8.Nodes.Add(mongoDBSchemaNode12);
            mongoDBSchemaNode8.Nodes.Add(mongoDBSchemaNode13);
            mongoDBQuery2.Schema = mongoDBSchemaNode8;
            mongoDBQuery3.ActualName = "productPurchases";
            mongoDBQuery3.Alias = null;
            mongoDBQuery3.CollectionName = "productPurchases";
            mongoDBQuery3.DatabaseName = "BixByApp";
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode15);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode16);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode17);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode18);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode19);
            mongoDBSchemaNode14.Nodes.Add(mongoDBSchemaNode20);
            mongoDBQuery3.Schema = mongoDBSchemaNode14;
            mongoDBQuery4.ActualName = "ShopItem";
            mongoDBQuery4.Alias = null;
            mongoDBQuery4.CollectionName = "ShopItem";
            mongoDBQuery4.DatabaseName = "BixByApp";
            mongoDBSchemaNode28.Nodes.Add(mongoDBSchemaNode29);
            mongoDBSchemaNode28.Nodes.Add(mongoDBSchemaNode30);
            mongoDBSchemaNode28.Nodes.Add(mongoDBSchemaNode31);
            mongoDBSchemaNode28.Nodes.Add(mongoDBSchemaNode32);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode22);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode23);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode24);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode25);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode26);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode27);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode28);
            mongoDBSchemaNode21.Nodes.Add(mongoDBSchemaNode33);
            mongoDBQuery4.Schema = mongoDBSchemaNode21;
            mongoDBQuery5.ActualName = "Comment";
            mongoDBQuery5.Alias = null;
            mongoDBQuery5.CollectionName = "Comment";
            mongoDBQuery5.DatabaseName = "BixByApp";
            mongoDBSchemaNode34.Nodes.Add(mongoDBSchemaNode35);
            mongoDBSchemaNode34.Nodes.Add(mongoDBSchemaNode36);
            mongoDBSchemaNode34.Nodes.Add(mongoDBSchemaNode37);
            mongoDBSchemaNode34.Nodes.Add(mongoDBSchemaNode38);
            mongoDBQuery5.Schema = mongoDBSchemaNode34;
            this.mongoDBDataSource1.Queries.AddRange(new DevExpress.DataAccess.MongoDB.MongoDBQuery[] {
            mongoDBQuery1,
            mongoDBQuery2,
            mongoDBQuery3,
            mongoDBQuery4,
            mongoDBQuery5});
            this.mongoDBDataSource1.ResultSchemaSerializable = resources.GetString("mongoDBDataSource1.ResultSchemaSerializable");
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader10,
            this.GroupHeader11,
            this.GroupHeader12,
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
            this.Detail2,
            this.GroupFooter2});
            this.DetailReport1.DataMember = "CartAndOrder";
            this.DetailReport1.DataSource = this.mongoDBDataSource1;
            this.DetailReport1.Expanded = false;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            this.DetailReport1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailReport1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader10
            // 
            this.GroupHeader10.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table10});
            this.GroupHeader10.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader10.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader10.HeightF = 27F;
            this.GroupHeader10.Level = 1;
            this.GroupHeader10.Name = "GroupHeader10";
            this.GroupHeader10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table10
            // 
            this.table10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table10.Name = "table10";
            this.table10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow10});
            this.table10.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow10
            // 
            this.tableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell19,
            this.tableCell20});
            this.tableRow10.Name = "tableRow10";
            this.tableRow10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow10.Weight = 1D;
            // 
            // tableCell19
            // 
            this.tableCell19.Name = "tableCell19";
            this.tableCell19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell19.StyleName = "GroupCaption2";
            this.tableCell19.Text = "ITEM CREATION TIME";
            this.tableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell19.Weight = 0.14327226426866319D;
            // 
            // tableCell20
            // 
            this.tableCell20.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.CreationTime]")});
            this.tableCell20.Name = "tableCell20";
            this.tableCell20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell20.StyleName = "GroupData2";
            this.tableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell20.Weight = 0.85672770182291669D;
            // 
            // GroupHeader11
            // 
            this.GroupHeader11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table11});
            this.GroupHeader11.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader11.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader11.HeightF = 27F;
            this.GroupHeader11.Level = 2;
            this.GroupHeader11.Name = "GroupHeader11";
            this.GroupHeader11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table11
            // 
            this.table11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table11.Name = "table11";
            this.table11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow11});
            this.table11.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow11
            // 
            this.tableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell21,
            this.tableCell22});
            this.tableRow11.Name = "tableRow11";
            this.tableRow11.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow11.Weight = 1D;
            // 
            // tableCell21
            // 
            this.tableCell21.Name = "tableCell21";
            this.tableCell21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell21.StyleName = "GroupCaption2";
            this.tableCell21.Text = "ITEM INCREMENT";
            this.tableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell21.Weight = 0.11851799011230468D;
            // 
            // tableCell22
            // 
            this.tableCell22.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Increment]")});
            this.tableCell22.Name = "tableCell22";
            this.tableCell22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell22.StyleName = "GroupData2";
            this.tableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell22.Weight = 0.8814820014105903D;
            // 
            // GroupHeader12
            // 
            this.GroupHeader12.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table12});
            this.GroupHeader12.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader12.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader12.HeightF = 27F;
            this.GroupHeader12.Level = 3;
            this.GroupHeader12.Name = "GroupHeader12";
            this.GroupHeader12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table12
            // 
            this.table12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table12.Name = "table12";
            this.table12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow12});
            this.table12.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow12
            // 
            this.tableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell23,
            this.tableCell24});
            this.tableRow12.Name = "tableRow12";
            this.tableRow12.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow12.Weight = 1D;
            // 
            // tableCell23
            // 
            this.tableCell23.Name = "tableCell23";
            this.tableCell23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell23.StyleName = "GroupCaption2";
            this.tableCell23.Text = "ITEM PID";
            this.tableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell23.Weight = 0.064061075846354162D;
            // 
            // tableCell24
            // 
            this.tableCell24.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Pid]")});
            this.tableCell24.Name = "tableCell24";
            this.tableCell24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell24.StyleName = "GroupData2";
            this.tableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell24.Weight = 0.93593892415364588D;
            // 
            // GroupHeader13
            // 
            this.GroupHeader13.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table13});
            this.GroupHeader13.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader13.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader13.HeightF = 27F;
            this.GroupHeader13.Level = 4;
            this.GroupHeader13.Name = "GroupHeader13";
            this.GroupHeader13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table13
            // 
            this.table13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table13.Name = "table13";
            this.table13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow13});
            this.table13.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow13
            // 
            this.tableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell25,
            this.tableCell26});
            this.tableRow13.Name = "tableRow13";
            this.tableRow13.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow13.Weight = 1D;
            // 
            // tableCell25
            // 
            this.tableCell25.Name = "tableCell25";
            this.tableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell25.StyleName = "GroupCaption2";
            this.tableCell25.Text = "ITEM MACHINE";
            this.tableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell25.Weight = 1507727.375D;
            // 
            // tableCell26
            // 
            this.tableCell26.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Machine]")});
            this.tableCell26.Name = "tableCell26";
            this.tableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell26.StyleName = "GroupData2";
            this.tableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell26.Weight = 13237872D;
            // 
            // GroupHeader14
            // 
            this.GroupHeader14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table14});
            this.GroupHeader14.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Item.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader14.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader14.HeightF = 27F;
            this.GroupHeader14.Level = 5;
            this.GroupHeader14.Name = "GroupHeader14";
            this.GroupHeader14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table14
            // 
            this.table14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table14.Name = "table14";
            this.table14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow14});
            this.table14.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow14
            // 
            this.tableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell27,
            this.tableCell28});
            this.tableRow14.Name = "tableRow14";
            this.tableRow14.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow14.Weight = 1D;
            // 
            // tableCell27
            // 
            this.tableCell27.Name = "tableCell27";
            this.tableCell27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell27.StyleName = "GroupCaption2";
            this.tableCell27.Text = "ITEM TIMESTAMP";
            this.tableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell27.Weight = 0.11780930413140191D;
            // 
            // tableCell28
            // 
            this.tableCell28.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Item.Timestamp]")});
            this.tableCell28.Name = "tableCell28";
            this.tableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell28.StyleName = "GroupData2";
            this.tableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell28.Weight = 0.88219068739149309D;
            // 
            // GroupHeader15
            // 
            this.GroupHeader15.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table15});
            this.GroupHeader15.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader15.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader15.HeightF = 27F;
            this.GroupHeader15.Level = 6;
            this.GroupHeader15.Name = "GroupHeader15";
            this.GroupHeader15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table15
            // 
            this.table15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table15.Name = "table15";
            this.table15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow15});
            this.table15.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow15
            // 
            this.tableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell29,
            this.tableCell30});
            this.tableRow15.Name = "tableRow15";
            this.tableRow15.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow15.Weight = 1D;
            // 
            // tableCell29
            // 
            this.tableCell29.Name = "tableCell29";
            this.tableCell29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell29.StyleName = "GroupCaption2";
            this.tableCell29.Text = " ID INCREMENT";
            this.tableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell29.Weight = 1539077.375D;
            // 
            // tableCell30
            // 
            this.tableCell30.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell30.Name = "tableCell30";
            this.tableCell30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell30.StyleName = "GroupData2";
            this.tableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell30.Weight = 13206522D;
            // 
            // GroupHeader16
            // 
            this.GroupHeader16.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table16});
            this.GroupHeader16.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader16.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader16.HeightF = 27F;
            this.GroupHeader16.Level = 7;
            this.GroupHeader16.Name = "GroupHeader16";
            this.GroupHeader16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table16
            // 
            this.table16.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table16.Name = "table16";
            this.table16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table16.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow16});
            this.table16.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow16
            // 
            this.tableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell31,
            this.tableCell32});
            this.tableRow16.Name = "tableRow16";
            this.tableRow16.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow16.Weight = 1D;
            // 
            // tableCell31
            // 
            this.tableCell31.Name = "tableCell31";
            this.tableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell31.StyleName = "GroupCaption2";
            this.tableCell31.Text = " ID PID";
            this.tableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell31.Weight = 736077.3125D;
            // 
            // tableCell32
            // 
            this.tableCell32.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell32.Name = "tableCell32";
            this.tableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell32.StyleName = "GroupData2";
            this.tableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell32.Weight = 14009522D;
            // 
            // GroupHeader17
            // 
            this.GroupHeader17.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table17});
            this.GroupHeader17.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader17.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader17.HeightF = 27F;
            this.GroupHeader17.Level = 8;
            this.GroupHeader17.Name = "GroupHeader17";
            this.GroupHeader17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table17
            // 
            this.table17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table17.Name = "table17";
            this.table17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table17.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow17});
            this.table17.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow17
            // 
            this.tableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell33,
            this.tableCell34});
            this.tableRow17.Name = "tableRow17";
            this.tableRow17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow17.Weight = 1D;
            // 
            // tableCell33
            // 
            this.tableCell33.Name = "tableCell33";
            this.tableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell33.StyleName = "GroupCaption2";
            this.tableCell33.Text = " ID MACHINE";
            this.tableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell33.Weight = 0.0881066640218099D;
            // 
            // tableCell34
            // 
            this.tableCell34.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell34.Name = "tableCell34";
            this.tableCell34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell34.StyleName = "GroupData2";
            this.tableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell34.Weight = 0.91189337836371531D;
            // 
            // GroupHeader18
            // 
            this.GroupHeader18.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table18});
            this.GroupHeader18.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader18.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader18.HeightF = 27F;
            this.GroupHeader18.Level = 9;
            this.GroupHeader18.Name = "GroupHeader18";
            this.GroupHeader18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table18
            // 
            this.table18.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table18.Name = "table18";
            this.table18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table18.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow18});
            this.table18.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow18
            // 
            this.tableRow18.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell35,
            this.tableCell36});
            this.tableRow18.Name = "tableRow18";
            this.tableRow18.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow18.Weight = 1D;
            // 
            // tableCell35
            // 
            this.tableCell35.Name = "tableCell35";
            this.tableCell35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell35.StyleName = "GroupCaption2";
            this.tableCell35.Text = " ID TIMESTAMP";
            this.tableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell35.Weight = 1528627.375D;
            // 
            // tableCell36
            // 
            this.tableCell36.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell36.Name = "tableCell36";
            this.tableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell36.StyleName = "GroupData2";
            this.tableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell36.Weight = 13216972D;
            // 
            // GroupHeader19
            // 
            this.GroupHeader19.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table19});
            this.GroupHeader19.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader19.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader19.HeightF = 27F;
            this.GroupHeader19.Level = 10;
            this.GroupHeader19.Name = "GroupHeader19";
            this.GroupHeader19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table19
            // 
            this.table19.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table19.Name = "table19";
            this.table19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table19.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow19});
            this.table19.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow19
            // 
            this.tableRow19.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell37,
            this.tableCell38});
            this.tableRow19.Name = "tableRow19";
            this.tableRow19.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow19.Weight = 1D;
            // 
            // tableCell37
            // 
            this.tableCell37.Name = "tableCell37";
            this.tableCell37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell37.StyleName = "GroupCaption2";
            this.tableCell37.Text = " ID CREATION TIME";
            this.tableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell37.Weight = 0.12912963019476997D;
            // 
            // tableCell38
            // 
            this.tableCell38.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell38.Name = "tableCell38";
            this.tableCell38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell38.StyleName = "GroupData2";
            this.tableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell38.Weight = 0.870870361328125D;
            // 
            // GroupHeader20
            // 
            this.GroupHeader20.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table20});
            this.GroupHeader20.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Price", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader20.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader20.HeightF = 27F;
            this.GroupHeader20.Level = 11;
            this.GroupHeader20.Name = "GroupHeader20";
            this.GroupHeader20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table20
            // 
            this.table20.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table20.Name = "table20";
            this.table20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table20.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow20});
            this.table20.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow20
            // 
            this.tableRow20.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell39,
            this.tableCell40});
            this.tableRow20.Name = "tableRow20";
            this.tableRow20.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow20.Weight = 1D;
            // 
            // tableCell39
            // 
            this.tableCell39.Name = "tableCell39";
            this.tableCell39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell39.StyleName = "GroupCaption2";
            this.tableCell39.Text = "PRICE";
            this.tableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell39.Weight = 0.047798597547743057D;
            // 
            // tableCell40
            // 
            this.tableCell40.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")});
            this.tableCell40.Name = "tableCell40";
            this.tableCell40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell40.StyleName = "GroupData2";
            this.tableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell40.Weight = 0.95220140245225693D;
            // 
            // GroupHeader21
            // 
            this.GroupHeader21.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table21});
            this.GroupHeader21.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Quantity", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader21.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader21.HeightF = 27F;
            this.GroupHeader21.Level = 12;
            this.GroupHeader21.Name = "GroupHeader21";
            this.GroupHeader21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table21
            // 
            this.table21.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table21.Name = "table21";
            this.table21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table21.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow21});
            this.table21.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow21
            // 
            this.tableRow21.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell41,
            this.tableCell42});
            this.tableRow21.Name = "tableRow21";
            this.tableRow21.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow21.Weight = 1D;
            // 
            // tableCell41
            // 
            this.tableCell41.Name = "tableCell41";
            this.tableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell41.StyleName = "GroupCaption2";
            this.tableCell41.Text = "QUANTITY";
            this.tableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell41.Weight = 1090552.375D;
            // 
            // tableCell42
            // 
            this.tableCell42.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity]")});
            this.tableCell42.Name = "tableCell42";
            this.tableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell42.StyleName = "GroupData2";
            this.tableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell42.Weight = 13655047D;
            // 
            // GroupHeader22
            // 
            this.GroupHeader22.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table22});
            this.GroupHeader22.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader22.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader22.HeightF = 27F;
            this.GroupHeader22.Level = 13;
            this.GroupHeader22.Name = "GroupHeader22";
            this.GroupHeader22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table22
            // 
            this.table22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table22.Name = "table22";
            this.table22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table22.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow22});
            this.table22.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow22
            // 
            this.tableRow22.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell43,
            this.tableCell44});
            this.tableRow22.Name = "tableRow22";
            this.tableRow22.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow22.Weight = 1D;
            // 
            // tableCell43
            // 
            this.tableCell43.Name = "tableCell43";
            this.tableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell43.StyleName = "GroupCaption2";
            this.tableCell43.Text = "USER";
            this.tableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell43.Weight = 0.044261385599772135D;
            // 
            // tableCell44
            // 
            this.tableCell44.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User]")});
            this.tableCell44.Name = "tableCell44";
            this.tableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell44.StyleName = "GroupData2";
            this.tableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell44.Weight = 0.9557386610243056D;
            // 
            // Detail2
            // 
            this.Detail2.HeightF = 0F;
            this.Detail2.Name = "Detail2";
            this.Detail2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label3});
            this.GroupFooter2.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter2.HeightF = 6F;
            this.GroupFooter2.Name = "GroupFooter2";
            this.GroupFooter2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label3
            // 
            this.label3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label3.Name = "label3";
            this.label3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label3.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label3.StyleName = "GroupFooterBackground3";
            this.label3.StylePriority.UseBorders = false;
            this.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport2
            // 
            this.DetailReport2.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader23,
            this.GroupHeader24,
            this.GroupHeader25,
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
            this.Detail3,
            this.GroupFooter3});
            this.DetailReport2.DataMember = "productPurchases";
            this.DetailReport2.DataSource = this.mongoDBDataSource1;
            this.DetailReport2.Expanded = false;
            this.DetailReport2.Level = 2;
            this.DetailReport2.Name = "DetailReport2";
            this.DetailReport2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailReport2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader23
            // 
            this.GroupHeader23.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table23});
            this.GroupHeader23.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader23.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader23.HeightF = 27F;
            this.GroupHeader23.Level = 1;
            this.GroupHeader23.Name = "GroupHeader23";
            this.GroupHeader23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table23
            // 
            this.table23.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table23.Name = "table23";
            this.table23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table23.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow23});
            this.table23.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow23
            // 
            this.tableRow23.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell45,
            this.tableCell46});
            this.tableRow23.Name = "tableRow23";
            this.tableRow23.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow23.Weight = 1D;
            // 
            // tableCell45
            // 
            this.tableCell45.Name = "tableCell45";
            this.tableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell45.StyleName = "GroupCaption2";
            this.tableCell45.Text = " ID PID";
            this.tableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell45.Weight = 736077.3125D;
            // 
            // tableCell46
            // 
            this.tableCell46.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell46.Name = "tableCell46";
            this.tableCell46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell46.StyleName = "GroupData2";
            this.tableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell46.Weight = 14009522D;
            // 
            // GroupHeader24
            // 
            this.GroupHeader24.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table24});
            this.GroupHeader24.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader24.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader24.HeightF = 27F;
            this.GroupHeader24.Level = 2;
            this.GroupHeader24.Name = "GroupHeader24";
            this.GroupHeader24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table24
            // 
            this.table24.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table24.Name = "table24";
            this.table24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table24.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow24});
            this.table24.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow24
            // 
            this.tableRow24.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell47,
            this.tableCell48});
            this.tableRow24.Name = "tableRow24";
            this.tableRow24.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow24.Weight = 1D;
            // 
            // tableCell47
            // 
            this.tableCell47.Name = "tableCell47";
            this.tableCell47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell47.StyleName = "GroupCaption2";
            this.tableCell47.Text = " ID MACHINE";
            this.tableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell47.Weight = 0.0881066640218099D;
            // 
            // tableCell48
            // 
            this.tableCell48.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell48.Name = "tableCell48";
            this.tableCell48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell48.StyleName = "GroupData2";
            this.tableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell48.Weight = 0.91189337836371531D;
            // 
            // GroupHeader25
            // 
            this.GroupHeader25.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table25});
            this.GroupHeader25.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader25.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader25.HeightF = 27F;
            this.GroupHeader25.Level = 3;
            this.GroupHeader25.Name = "GroupHeader25";
            this.GroupHeader25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table25
            // 
            this.table25.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table25.Name = "table25";
            this.table25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table25.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow25});
            this.table25.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow25
            // 
            this.tableRow25.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell49,
            this.tableCell50});
            this.tableRow25.Name = "tableRow25";
            this.tableRow25.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow25.Weight = 1D;
            // 
            // tableCell49
            // 
            this.tableCell49.Name = "tableCell49";
            this.tableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell49.StyleName = "GroupCaption2";
            this.tableCell49.Text = " ID TIMESTAMP";
            this.tableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell49.Weight = 1528627.375D;
            // 
            // tableCell50
            // 
            this.tableCell50.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell50.Name = "tableCell50";
            this.tableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell50.StyleName = "GroupData2";
            this.tableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell50.Weight = 13216972D;
            // 
            // GroupHeader26
            // 
            this.GroupHeader26.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table26});
            this.GroupHeader26.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader26.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader26.HeightF = 27F;
            this.GroupHeader26.Level = 4;
            this.GroupHeader26.Name = "GroupHeader26";
            this.GroupHeader26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table26
            // 
            this.table26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table26.Name = "table26";
            this.table26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table26.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow26});
            this.table26.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow26
            // 
            this.tableRow26.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell51,
            this.tableCell52});
            this.tableRow26.Name = "tableRow26";
            this.tableRow26.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow26.Weight = 1D;
            // 
            // tableCell51
            // 
            this.tableCell51.Name = "tableCell51";
            this.tableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell51.StyleName = "GroupCaption2";
            this.tableCell51.Text = "CUTOMER ID CREATION TIME";
            this.tableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell51.Weight = 0.19348949856228298D;
            // 
            // tableCell52
            // 
            this.tableCell52.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.CreationTime]")});
            this.tableCell52.Name = "tableCell52";
            this.tableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell52.StyleName = "GroupData2";
            this.tableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell52.Weight = 0.80651048448350693D;
            // 
            // GroupHeader27
            // 
            this.GroupHeader27.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table27});
            this.GroupHeader27.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader27.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader27.HeightF = 27F;
            this.GroupHeader27.Level = 5;
            this.GroupHeader27.Name = "GroupHeader27";
            this.GroupHeader27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table27
            // 
            this.table27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table27.Name = "table27";
            this.table27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table27.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow27});
            this.table27.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow27
            // 
            this.tableRow27.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell53,
            this.tableCell54});
            this.tableRow27.Name = "tableRow27";
            this.tableRow27.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow27.Weight = 1D;
            // 
            // tableCell53
            // 
            this.tableCell53.Name = "tableCell53";
            this.tableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell53.StyleName = "GroupCaption2";
            this.tableCell53.Text = "CUTOMER ID INCREMENT";
            this.tableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell53.Weight = 0.16873523288302952D;
            // 
            // tableCell54
            // 
            this.tableCell54.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Increment]")});
            this.tableCell54.Name = "tableCell54";
            this.tableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell54.StyleName = "GroupData2";
            this.tableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell54.Weight = 0.83126478407118054D;
            // 
            // GroupHeader28
            // 
            this.GroupHeader28.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table28});
            this.GroupHeader28.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader28.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader28.HeightF = 27F;
            this.GroupHeader28.Level = 6;
            this.GroupHeader28.Name = "GroupHeader28";
            this.GroupHeader28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table28
            // 
            this.table28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table28.Name = "table28";
            this.table28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table28.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow28});
            this.table28.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow28
            // 
            this.tableRow28.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell55,
            this.tableCell56});
            this.tableRow28.Name = "tableRow28";
            this.tableRow28.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow28.Weight = 1D;
            // 
            // tableCell55
            // 
            this.tableCell55.Name = "tableCell55";
            this.tableCell55.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell55.StyleName = "GroupCaption2";
            this.tableCell55.Text = "CUTOMER ID PID";
            this.tableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell55.Weight = 0.11427830166286893D;
            // 
            // tableCell56
            // 
            this.tableCell56.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Pid]")});
            this.tableCell56.Name = "tableCell56";
            this.tableCell56.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell56.StyleName = "GroupData2";
            this.tableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell56.Weight = 0.88572170681423612D;
            // 
            // GroupHeader29
            // 
            this.GroupHeader29.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table29});
            this.GroupHeader29.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader29.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader29.HeightF = 27F;
            this.GroupHeader29.Level = 7;
            this.GroupHeader29.Name = "GroupHeader29";
            this.GroupHeader29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table29
            // 
            this.table29.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table29.Name = "table29";
            this.table29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table29.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow29});
            this.table29.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow29
            // 
            this.tableRow29.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell57,
            this.tableCell58});
            this.tableRow29.Name = "tableRow29";
            this.tableRow29.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow29.Weight = 1D;
            // 
            // tableCell57
            // 
            this.tableCell57.Name = "tableCell57";
            this.tableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell57.StyleName = "GroupCaption2";
            this.tableCell57.Text = "CUTOMER ID MACHINE";
            this.tableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell57.Weight = 0.15246653238932292D;
            // 
            // tableCell58
            // 
            this.tableCell58.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Machine]")});
            this.tableCell58.Name = "tableCell58";
            this.tableCell58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell58.StyleName = "GroupData2";
            this.tableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell58.Weight = 0.84753350151909723D;
            // 
            // GroupHeader30
            // 
            this.GroupHeader30.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table30});
            this.GroupHeader30.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("cutomerId.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader30.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader30.HeightF = 27F;
            this.GroupHeader30.Level = 8;
            this.GroupHeader30.Name = "GroupHeader30";
            this.GroupHeader30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table30
            // 
            this.table30.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table30.Name = "table30";
            this.table30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table30.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow30});
            this.table30.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow30
            // 
            this.tableRow30.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell59,
            this.tableCell60});
            this.tableRow30.Name = "tableRow30";
            this.tableRow30.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow30.Weight = 1D;
            // 
            // tableCell59
            // 
            this.tableCell59.Name = "tableCell59";
            this.tableCell59.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell59.StyleName = "GroupCaption2";
            this.tableCell59.Text = "CUTOMER ID TIMESTAMP";
            this.tableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell59.Weight = 0.16802654690212673D;
            // 
            // tableCell60
            // 
            this.tableCell60.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[cutomerId.Timestamp]")});
            this.tableCell60.Name = "tableCell60";
            this.tableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell60.StyleName = "GroupData2";
            this.tableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell60.Weight = 0.83197347005208333D;
            // 
            // GroupHeader31
            // 
            this.GroupHeader31.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table31});
            this.GroupHeader31.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader31.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader31.HeightF = 27F;
            this.GroupHeader31.Level = 9;
            this.GroupHeader31.Name = "GroupHeader31";
            this.GroupHeader31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table31
            // 
            this.table31.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table31.Name = "table31";
            this.table31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table31.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow31});
            this.table31.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow31
            // 
            this.tableRow31.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell61,
            this.tableCell62});
            this.tableRow31.Name = "tableRow31";
            this.tableRow31.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow31.Weight = 1D;
            // 
            // tableCell61
            // 
            this.tableCell61.Name = "tableCell61";
            this.tableCell61.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell61.StyleName = "GroupCaption2";
            this.tableCell61.Text = "ORDER ID CREATION TIME";
            this.tableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell61.Weight = 0.17510718451605903D;
            // 
            // tableCell62
            // 
            this.tableCell62.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.CreationTime]")});
            this.tableCell62.Name = "tableCell62";
            this.tableCell62.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell62.StyleName = "GroupData2";
            this.tableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell62.Weight = 0.82489284939236107D;
            // 
            // GroupHeader32
            // 
            this.GroupHeader32.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table32});
            this.GroupHeader32.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader32.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader32.HeightF = 27F;
            this.GroupHeader32.Level = 10;
            this.GroupHeader32.Name = "GroupHeader32";
            this.GroupHeader32.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table32
            // 
            this.table32.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table32.Name = "table32";
            this.table32.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table32.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow32});
            this.table32.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow32
            // 
            this.tableRow32.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell63,
            this.tableCell64});
            this.tableRow32.Name = "tableRow32";
            this.tableRow32.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow32.Weight = 1D;
            // 
            // tableCell63
            // 
            this.tableCell63.Name = "tableCell63";
            this.tableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell63.StyleName = "GroupCaption2";
            this.tableCell63.Text = "ORDER ID INCREMENT";
            this.tableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell63.Weight = 0.15035290188259548D;
            // 
            // tableCell64
            // 
            this.tableCell64.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Increment]")});
            this.tableCell64.Name = "tableCell64";
            this.tableCell64.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell64.StyleName = "GroupData2";
            this.tableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell64.Weight = 0.84964708116319443D;
            // 
            // GroupHeader33
            // 
            this.GroupHeader33.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table33});
            this.GroupHeader33.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader33.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader33.HeightF = 27F;
            this.GroupHeader33.Level = 11;
            this.GroupHeader33.Name = "GroupHeader33";
            this.GroupHeader33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table33
            // 
            this.table33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table33.Name = "table33";
            this.table33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table33.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow33});
            this.table33.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow33
            // 
            this.tableRow33.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell65,
            this.tableCell66});
            this.tableRow33.Name = "tableRow33";
            this.tableRow33.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow33.Weight = 1D;
            // 
            // tableCell65
            // 
            this.tableCell65.Name = "tableCell65";
            this.tableCell65.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell65.StyleName = "GroupCaption2";
            this.tableCell65.Text = "ORDER ID MACHINE";
            this.tableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell65.Weight = 0.13408420986599393D;
            // 
            // tableCell66
            // 
            this.tableCell66.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Machine]")});
            this.tableCell66.Name = "tableCell66";
            this.tableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell66.StyleName = "GroupData2";
            this.tableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell66.Weight = 0.86591579861111112D;
            // 
            // GroupHeader34
            // 
            this.GroupHeader34.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table34});
            this.GroupHeader34.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader34.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader34.HeightF = 27F;
            this.GroupHeader34.Level = 12;
            this.GroupHeader34.Name = "GroupHeader34";
            this.GroupHeader34.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table34
            // 
            this.table34.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table34.Name = "table34";
            this.table34.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table34.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow34});
            this.table34.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow34
            // 
            this.tableRow34.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell67,
            this.tableCell68});
            this.tableRow34.Name = "tableRow34";
            this.tableRow34.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow34.Weight = 1D;
            // 
            // tableCell67
            // 
            this.tableCell67.Name = "tableCell67";
            this.tableCell67.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell67.StyleName = "GroupCaption2";
            this.tableCell67.Text = " ID CREATION TIME";
            this.tableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell67.Weight = 0.12912963019476997D;
            // 
            // tableCell68
            // 
            this.tableCell68.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell68.Name = "tableCell68";
            this.tableCell68.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell68.StyleName = "GroupData2";
            this.tableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell68.Weight = 0.870870361328125D;
            // 
            // GroupHeader35
            // 
            this.GroupHeader35.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table35});
            this.GroupHeader35.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader35.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader35.HeightF = 27F;
            this.GroupHeader35.Level = 13;
            this.GroupHeader35.Name = "GroupHeader35";
            this.GroupHeader35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table35
            // 
            this.table35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table35.Name = "table35";
            this.table35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table35.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow35});
            this.table35.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow35
            // 
            this.tableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell69,
            this.tableCell70});
            this.tableRow35.Name = "tableRow35";
            this.tableRow35.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow35.Weight = 1D;
            // 
            // tableCell69
            // 
            this.tableCell69.Name = "tableCell69";
            this.tableCell69.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell69.StyleName = "GroupCaption2";
            this.tableCell69.Text = " ID INCREMENT";
            this.tableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell69.Weight = 1539077.375D;
            // 
            // tableCell70
            // 
            this.tableCell70.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell70.Name = "tableCell70";
            this.tableCell70.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell70.StyleName = "GroupData2";
            this.tableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell70.Weight = 13206522D;
            // 
            // GroupHeader36
            // 
            this.GroupHeader36.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table36});
            this.GroupHeader36.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader36.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader36.HeightF = 27F;
            this.GroupHeader36.Level = 14;
            this.GroupHeader36.Name = "GroupHeader36";
            this.GroupHeader36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table36
            // 
            this.table36.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table36.Name = "table36";
            this.table36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table36.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow36});
            this.table36.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow36
            // 
            this.tableRow36.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell71,
            this.tableCell72});
            this.tableRow36.Name = "tableRow36";
            this.tableRow36.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow36.Weight = 1D;
            // 
            // tableCell71
            // 
            this.tableCell71.Name = "tableCell71";
            this.tableCell71.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell71.StyleName = "GroupCaption2";
            this.tableCell71.Text = "ORDER ID TIMESTAMP";
            this.tableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell71.Weight = 0.14964421590169272D;
            // 
            // tableCell72
            // 
            this.tableCell72.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Timestamp]")});
            this.tableCell72.Name = "tableCell72";
            this.tableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell72.StyleName = "GroupData2";
            this.tableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell72.Weight = 0.85035576714409722D;
            // 
            // GroupHeader37
            // 
            this.GroupHeader37.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table37});
            this.GroupHeader37.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("orderId.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader37.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader37.HeightF = 27F;
            this.GroupHeader37.Level = 15;
            this.GroupHeader37.Name = "GroupHeader37";
            this.GroupHeader37.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table37
            // 
            this.table37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table37.Name = "table37";
            this.table37.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table37.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow37});
            this.table37.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow37
            // 
            this.tableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell73,
            this.tableCell74});
            this.tableRow37.Name = "tableRow37";
            this.tableRow37.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow37.Weight = 1D;
            // 
            // tableCell73
            // 
            this.tableCell73.Name = "tableCell73";
            this.tableCell73.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell73.StyleName = "GroupCaption2";
            this.tableCell73.Text = "ORDER ID PID";
            this.tableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell73.Weight = 0.09589599609375D;
            // 
            // tableCell74
            // 
            this.tableCell74.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[orderId.Pid]")});
            this.tableCell74.Name = "tableCell74";
            this.tableCell74.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell74.StyleName = "GroupData2";
            this.tableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell74.Weight = 0.90410400390625D;
            // 
            // GroupHeader38
            // 
            this.GroupHeader38.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table38});
            this.GroupHeader38.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ownerId", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader38.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader38.HeightF = 27F;
            this.GroupHeader38.Level = 16;
            this.GroupHeader38.Name = "GroupHeader38";
            this.GroupHeader38.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table38
            // 
            this.table38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table38.Name = "table38";
            this.table38.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table38.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow38});
            this.table38.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow38
            // 
            this.tableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell75,
            this.tableCell76});
            this.tableRow38.Name = "tableRow38";
            this.tableRow38.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow38.Weight = 1D;
            // 
            // tableCell75
            // 
            this.tableCell75.Name = "tableCell75";
            this.tableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell75.StyleName = "GroupCaption2";
            this.tableCell75.Text = "OWNER ID";
            this.tableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell75.Weight = 1090552.375D;
            // 
            // tableCell76
            // 
            this.tableCell76.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ownerId]")});
            this.tableCell76.Name = "tableCell76";
            this.tableCell76.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell76.StyleName = "GroupData2";
            this.tableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell76.Weight = 13655047D;
            // 
            // GroupHeader39
            // 
            this.GroupHeader39.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table39});
            this.GroupHeader39.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("isDeliverd", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader39.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader39.HeightF = 27F;
            this.GroupHeader39.Level = 17;
            this.GroupHeader39.Name = "GroupHeader39";
            this.GroupHeader39.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table39
            // 
            this.table39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table39.Name = "table39";
            this.table39.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table39.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow39});
            this.table39.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow39
            // 
            this.tableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell77,
            this.tableCell78});
            this.tableRow39.Name = "tableRow39";
            this.tableRow39.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow39.Weight = 1D;
            // 
            // tableCell77
            // 
            this.tableCell77.Name = "tableCell77";
            this.tableCell77.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell77.StyleName = "GroupCaption2";
            this.tableCell77.Text = "IS DELIVERD";
            this.tableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell77.Weight = 0.08882778591579861D;
            // 
            // tableCell78
            // 
            this.tableCell78.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[isDeliverd]")});
            this.tableCell78.Name = "tableCell78";
            this.tableCell78.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell78.StyleName = "GroupData2";
            this.tableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell78.Weight = 0.91117221408420135D;
            // 
            // GroupHeader40
            // 
            this.GroupHeader40.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table40});
            this.GroupHeader40.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("isRefund", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader40.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader40.HeightF = 27F;
            this.GroupHeader40.Level = 18;
            this.GroupHeader40.Name = "GroupHeader40";
            this.GroupHeader40.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table40
            // 
            this.table40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table40.Name = "table40";
            this.table40.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table40.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow40});
            this.table40.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow40
            // 
            this.tableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell79,
            this.tableCell80});
            this.tableRow40.Name = "tableRow40";
            this.tableRow40.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow40.Weight = 1D;
            // 
            // tableCell79
            // 
            this.tableCell79.Name = "tableCell79";
            this.tableCell79.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell79.StyleName = "GroupCaption2";
            this.tableCell79.Text = "IS REFUND";
            this.tableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell79.Weight = 1142802.375D;
            // 
            // tableCell80
            // 
            this.tableCell80.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[isRefund]")});
            this.tableCell80.Name = "tableCell80";
            this.tableCell80.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell80.StyleName = "GroupData2";
            this.tableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell80.Weight = 13602797D;
            // 
            // Detail3
            // 
            this.Detail3.HeightF = 0F;
            this.Detail3.Name = "Detail3";
            this.Detail3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooter3
            // 
            this.GroupFooter3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label4});
            this.GroupFooter3.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter3.HeightF = 6F;
            this.GroupFooter3.Name = "GroupFooter3";
            this.GroupFooter3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label4
            // 
            this.label4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label4.Name = "label4";
            this.label4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label4.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label4.StyleName = "GroupFooterBackground3";
            this.label4.StylePriority.UseBorders = false;
            this.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport5
            // 
            this.DetailReport5.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader66,
            this.GroupHeader67,
            this.GroupHeader68,
            this.GroupHeader69,
            this.GroupHeader70,
            this.GroupHeader71,
            this.GroupHeader72,
            this.GroupHeader73,
            this.GroupHeader74,
            this.GroupHeader75,
            this.GroupHeader76,
            this.GroupHeader77,
            this.GroupHeader78,
            this.GroupHeader79,
            this.Detail6,
            this.GroupFooter6});
            this.DetailReport5.DataMember = "ShopItem";
            this.DetailReport5.DataSource = this.mongoDBDataSource1;
            this.DetailReport5.Level = 3;
            this.DetailReport5.Name = "DetailReport5";
            this.DetailReport5.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailReport5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader66
            // 
            this.GroupHeader66.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table67});
            this.GroupHeader66.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("loveThisProduct", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader66.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader66.HeightF = 27F;
            this.GroupHeader66.Level = 1;
            this.GroupHeader66.Name = "GroupHeader66";
            this.GroupHeader66.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table67
            // 
            this.table67.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table67.Name = "table67";
            this.table67.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table67.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow67});
            this.table67.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow67
            // 
            this.tableRow67.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell131,
            this.tableCell132});
            this.tableRow67.Name = "tableRow67";
            this.tableRow67.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow67.Weight = 1D;
            // 
            // tableCell131
            // 
            this.tableCell131.Name = "tableCell131";
            this.tableCell131.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell131.StyleName = "GroupCaption2";
            this.tableCell131.Text = "LOVE THIS PRODUCT";
            this.tableCell131.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell131.Weight = 0.14257600572374132D;
            // 
            // tableCell132
            // 
            this.tableCell132.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[loveThisProduct]")});
            this.tableCell132.Name = "tableCell132";
            this.tableCell132.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell132.StyleName = "GroupData2";
            this.tableCell132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell132.Weight = 0.85742397732204856D;
            // 
            // GroupHeader67
            // 
            this.GroupHeader67.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table68});
            this.GroupHeader67.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.Pic", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader67.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader67.HeightF = 27F;
            this.GroupHeader67.Level = 2;
            this.GroupHeader67.Name = "GroupHeader67";
            this.GroupHeader67.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table68
            // 
            this.table68.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table68.Name = "table68";
            this.table68.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table68.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow68});
            this.table68.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow68
            // 
            this.tableRow68.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell133,
            this.tableCell134});
            this.tableRow68.Name = "tableRow68";
            this.tableRow68.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow68.Weight = 1D;
            // 
            // tableCell133
            // 
            this.tableCell133.Name = "tableCell133";
            this.tableCell133.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell133.StyleName = "GroupCaption2";
            this.tableCell133.Text = "PUBLISH PIC";
            this.tableCell133.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell133.Weight = 1320177.375D;
            // 
            // tableCell134
            // 
            this.tableCell134.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.Pic]")});
            this.tableCell134.Name = "tableCell134";
            this.tableCell134.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell134.StyleName = "GroupData2";
            this.tableCell134.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell134.Weight = 13425422D;
            // 
            // GroupHeader68
            // 
            this.GroupHeader68.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table69});
            this.GroupHeader68.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.Email", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader68.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader68.HeightF = 27F;
            this.GroupHeader68.Level = 3;
            this.GroupHeader68.Name = "GroupHeader68";
            this.GroupHeader68.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table69
            // 
            this.table69.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table69.Name = "table69";
            this.table69.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table69.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow69});
            this.table69.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow69
            // 
            this.tableRow69.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell135,
            this.tableCell136});
            this.tableRow69.Name = "tableRow69";
            this.tableRow69.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow69.Weight = 1D;
            // 
            // tableCell135
            // 
            this.tableCell135.Name = "tableCell135";
            this.tableCell135.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell135.StyleName = "GroupCaption2";
            this.tableCell135.Text = "PUBLISH EMAIL";
            this.tableCell135.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell135.Weight = 0.1079125722249349D;
            // 
            // tableCell136
            // 
            this.tableCell136.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.Email]")});
            this.tableCell136.Name = "tableCell136";
            this.tableCell136.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell136.StyleName = "GroupData2";
            this.tableCell136.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell136.Weight = 0.89208747016059031D;
            // 
            // GroupHeader69
            // 
            this.GroupHeader69.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table70});
            this.GroupHeader69.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader69.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader69.HeightF = 27F;
            this.GroupHeader69.Level = 4;
            this.GroupHeader69.Name = "GroupHeader69";
            this.GroupHeader69.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table70
            // 
            this.table70.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table70.Name = "table70";
            this.table70.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table70.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow70});
            this.table70.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow70
            // 
            this.tableRow70.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell137,
            this.tableCell138});
            this.tableRow70.Name = "tableRow70";
            this.tableRow70.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow70.Weight = 1D;
            // 
            // tableCell137
            // 
            this.tableCell137.Name = "tableCell137";
            this.tableCell137.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell137.StyleName = "GroupCaption2";
            this.tableCell137.Text = "PUBLISH LAST NAME";
            this.tableCell137.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell137.Weight = 0.14256980048285589D;
            // 
            // tableCell138
            // 
            this.tableCell138.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.LastName]")});
            this.tableCell138.Name = "tableCell138";
            this.tableCell138.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell138.StyleName = "GroupData2";
            this.tableCell138.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell138.Weight = 0.8574302164713542D;
            // 
            // GroupHeader70
            // 
            this.GroupHeader70.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table71});
            this.GroupHeader70.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("publish.FirstName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader70.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader70.HeightF = 27F;
            this.GroupHeader70.Level = 5;
            this.GroupHeader70.Name = "GroupHeader70";
            this.GroupHeader70.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table71
            // 
            this.table71.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table71.Name = "table71";
            this.table71.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table71.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow71});
            this.table71.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow71
            // 
            this.tableRow71.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell139,
            this.tableCell140});
            this.tableRow71.Name = "tableRow71";
            this.tableRow71.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow71.Weight = 1D;
            // 
            // tableCell139
            // 
            this.tableCell139.Name = "tableCell139";
            this.tableCell139.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell139.StyleName = "GroupCaption2";
            this.tableCell139.Text = "PUBLISH FIRST NAME";
            this.tableCell139.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell139.Weight = 0.14610700819227432D;
            // 
            // tableCell140
            // 
            this.tableCell140.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[publish.FirstName]")});
            this.tableCell140.Name = "tableCell140";
            this.tableCell140.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell140.StyleName = "GroupData2";
            this.tableCell140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell140.Weight = 0.85389295789930553D;
            // 
            // GroupHeader71
            // 
            this.GroupHeader71.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table72});
            this.GroupHeader71.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Price", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader71.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader71.HeightF = 27F;
            this.GroupHeader71.Level = 6;
            this.GroupHeader71.Name = "GroupHeader71";
            this.GroupHeader71.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table72
            // 
            this.table72.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table72.Name = "table72";
            this.table72.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table72.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow72});
            this.table72.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow72
            // 
            this.tableRow72.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell141,
            this.tableCell142});
            this.tableRow72.Name = "tableRow72";
            this.tableRow72.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow72.Weight = 1D;
            // 
            // tableCell141
            // 
            this.tableCell141.Name = "tableCell141";
            this.tableCell141.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell141.StyleName = "GroupCaption2";
            this.tableCell141.Text = "PRICE";
            this.tableCell141.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell141.Weight = 0.047798597547743057D;
            // 
            // tableCell142
            // 
            this.tableCell142.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Price]")});
            this.tableCell142.Name = "tableCell142";
            this.tableCell142.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell142.StyleName = "GroupData2";
            this.tableCell142.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell142.Weight = 0.95220140245225693D;
            // 
            // GroupHeader72
            // 
            this.GroupHeader72.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table73});
            this.GroupHeader72.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TotalComments", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader72.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader72.HeightF = 27F;
            this.GroupHeader72.Level = 7;
            this.GroupHeader72.Name = "GroupHeader72";
            this.GroupHeader72.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table73
            // 
            this.table73.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table73.Name = "table73";
            this.table73.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table73.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow73});
            this.table73.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow73
            // 
            this.tableRow73.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell143,
            this.tableCell144});
            this.tableRow73.Name = "tableRow73";
            this.tableRow73.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow73.Weight = 1D;
            // 
            // tableCell143
            // 
            this.tableCell143.Name = "tableCell143";
            this.tableCell143.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell143.StyleName = "GroupCaption2";
            this.tableCell143.Text = "TOTAL COMMENTS";
            this.tableCell143.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell143.Weight = 0.12911719428168403D;
            // 
            // tableCell144
            // 
            this.tableCell144.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TotalComments]")});
            this.tableCell144.Name = "tableCell144";
            this.tableCell144.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell144.StyleName = "GroupData2";
            this.tableCell144.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell144.Weight = 0.87088283962673607D;
            // 
            // GroupHeader73
            // 
            this.GroupHeader73.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table74});
            this.GroupHeader73.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Description", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader73.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader73.HeightF = 27F;
            this.GroupHeader73.Level = 8;
            this.GroupHeader73.Name = "GroupHeader73";
            this.GroupHeader73.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table74
            // 
            this.table74.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table74.Name = "table74";
            this.table74.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table74.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow74});
            this.table74.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow74
            // 
            this.tableRow74.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell145,
            this.tableCell146});
            this.tableRow74.Name = "tableRow74";
            this.tableRow74.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow74.Weight = 1D;
            // 
            // tableCell145
            // 
            this.tableCell145.Name = "tableCell145";
            this.tableCell145.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell145.StyleName = "GroupCaption2";
            this.tableCell145.Text = "DESCRIPTION";
            this.tableCell145.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell145.Weight = 0.09589599609375D;
            // 
            // tableCell146
            // 
            this.tableCell146.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.tableCell146.Name = "tableCell146";
            this.tableCell146.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell146.StyleName = "GroupData2";
            this.tableCell146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell146.Weight = 0.90410400390625D;
            // 
            // GroupHeader74
            // 
            this.GroupHeader74.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table75});
            this.GroupHeader74.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Name", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader74.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader74.HeightF = 27F;
            this.GroupHeader74.Level = 9;
            this.GroupHeader74.Name = "GroupHeader74";
            this.GroupHeader74.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table75
            // 
            this.table75.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table75.Name = "table75";
            this.table75.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table75.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow75});
            this.table75.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow75
            // 
            this.tableRow75.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell147,
            this.tableCell148});
            this.tableRow75.Name = "tableRow75";
            this.tableRow75.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow75.Weight = 1D;
            // 
            // tableCell147
            // 
            this.tableCell147.Name = "tableCell147";
            this.tableCell147.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell147.StyleName = "GroupCaption2";
            this.tableCell147.Text = "NAME";
            this.tableCell147.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell147.Weight = 683827.375D;
            // 
            // tableCell148
            // 
            this.tableCell148.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Name]")});
            this.tableCell148.Name = "tableCell148";
            this.tableCell148.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell148.StyleName = "GroupData2";
            this.tableCell148.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell148.Weight = 14061772D;
            // 
            // GroupHeader75
            // 
            this.GroupHeader75.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table76});
            this.GroupHeader75.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader75.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader75.HeightF = 27F;
            this.GroupHeader75.Level = 10;
            this.GroupHeader75.Name = "GroupHeader75";
            this.GroupHeader75.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table76
            // 
            this.table76.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table76.Name = "table76";
            this.table76.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table76.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow76});
            this.table76.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow76
            // 
            this.tableRow76.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell149,
            this.tableCell150});
            this.tableRow76.Name = "tableRow76";
            this.tableRow76.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow76.Weight = 1D;
            // 
            // tableCell149
            // 
            this.tableCell149.Name = "tableCell149";
            this.tableCell149.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell149.StyleName = "GroupCaption2";
            this.tableCell149.Text = " ID CREATION TIME";
            this.tableCell149.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell149.Weight = 0.12912963019476997D;
            // 
            // tableCell150
            // 
            this.tableCell150.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell150.Name = "tableCell150";
            this.tableCell150.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell150.StyleName = "GroupData2";
            this.tableCell150.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell150.Weight = 0.870870361328125D;
            // 
            // GroupHeader76
            // 
            this.GroupHeader76.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table77});
            this.GroupHeader76.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader76.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader76.HeightF = 27F;
            this.GroupHeader76.Level = 11;
            this.GroupHeader76.Name = "GroupHeader76";
            this.GroupHeader76.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table77
            // 
            this.table77.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table77.Name = "table77";
            this.table77.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table77.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow77});
            this.table77.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow77
            // 
            this.tableRow77.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell151,
            this.tableCell152});
            this.tableRow77.Name = "tableRow77";
            this.tableRow77.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow77.Weight = 1D;
            // 
            // tableCell151
            // 
            this.tableCell151.Name = "tableCell151";
            this.tableCell151.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell151.StyleName = "GroupCaption2";
            this.tableCell151.Text = " ID INCREMENT";
            this.tableCell151.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell151.Weight = 1539077.375D;
            // 
            // tableCell152
            // 
            this.tableCell152.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell152.Name = "tableCell152";
            this.tableCell152.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell152.StyleName = "GroupData2";
            this.tableCell152.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell152.Weight = 13206522D;
            // 
            // GroupHeader77
            // 
            this.GroupHeader77.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table78});
            this.GroupHeader77.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader77.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader77.HeightF = 27F;
            this.GroupHeader77.Level = 12;
            this.GroupHeader77.Name = "GroupHeader77";
            this.GroupHeader77.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table78
            // 
            this.table78.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table78.Name = "table78";
            this.table78.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table78.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow78});
            this.table78.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow78
            // 
            this.tableRow78.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell153,
            this.tableCell154});
            this.tableRow78.Name = "tableRow78";
            this.tableRow78.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow78.Weight = 1D;
            // 
            // tableCell153
            // 
            this.tableCell153.Name = "tableCell153";
            this.tableCell153.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell153.StyleName = "GroupCaption2";
            this.tableCell153.Text = " ID PID";
            this.tableCell153.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell153.Weight = 736077.3125D;
            // 
            // tableCell154
            // 
            this.tableCell154.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell154.Name = "tableCell154";
            this.tableCell154.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell154.StyleName = "GroupData2";
            this.tableCell154.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell154.Weight = 14009522D;
            // 
            // GroupHeader78
            // 
            this.GroupHeader78.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table79});
            this.GroupHeader78.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader78.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader78.HeightF = 27F;
            this.GroupHeader78.Level = 13;
            this.GroupHeader78.Name = "GroupHeader78";
            this.GroupHeader78.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table79
            // 
            this.table79.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table79.Name = "table79";
            this.table79.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table79.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow79});
            this.table79.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow79
            // 
            this.tableRow79.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell155,
            this.tableCell156});
            this.tableRow79.Name = "tableRow79";
            this.tableRow79.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow79.Weight = 1D;
            // 
            // tableCell155
            // 
            this.tableCell155.Name = "tableCell155";
            this.tableCell155.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell155.StyleName = "GroupCaption2";
            this.tableCell155.Text = " ID MACHINE";
            this.tableCell155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell155.Weight = 0.0881066640218099D;
            // 
            // tableCell156
            // 
            this.tableCell156.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell156.Name = "tableCell156";
            this.tableCell156.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell156.StyleName = "GroupData2";
            this.tableCell156.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell156.Weight = 0.91189337836371531D;
            // 
            // GroupHeader79
            // 
            this.GroupHeader79.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table80});
            this.GroupHeader79.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader79.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader79.HeightF = 27F;
            this.GroupHeader79.Level = 14;
            this.GroupHeader79.Name = "GroupHeader79";
            this.GroupHeader79.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table80
            // 
            this.table80.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table80.Name = "table80";
            this.table80.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table80.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow80});
            this.table80.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow80
            // 
            this.tableRow80.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell157,
            this.tableCell158});
            this.tableRow80.Name = "tableRow80";
            this.tableRow80.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow80.Weight = 1D;
            // 
            // tableCell157
            // 
            this.tableCell157.Name = "tableCell157";
            this.tableCell157.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell157.StyleName = "GroupCaption2";
            this.tableCell157.Text = " ID TIMESTAMP";
            this.tableCell157.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell157.Weight = 1528627.375D;
            // 
            // tableCell158
            // 
            this.tableCell158.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell158.Name = "tableCell158";
            this.tableCell158.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell158.StyleName = "GroupData2";
            this.tableCell158.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell158.Weight = 13216972D;
            // 
            // Detail6
            // 
            this.Detail6.HeightF = 0F;
            this.Detail6.Name = "Detail6";
            this.Detail6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooter6
            // 
            this.GroupFooter6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label7});
            this.GroupFooter6.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter6.HeightF = 6F;
            this.GroupFooter6.Name = "GroupFooter6";
            this.GroupFooter6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label7
            // 
            this.label7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label7.Name = "label7";
            this.label7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label7.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label7.StyleName = "GroupFooterBackground3";
            this.label7.StylePriority.UseBorders = false;
            this.label7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // DetailReport6
            // 
            this.DetailReport6.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader80,
            this.GroupHeader81,
            this.GroupHeader82,
            this.GroupHeader83,
            this.GroupHeader84,
            this.GroupHeader85,
            this.GroupHeader86,
            this.GroupHeader87,
            this.GroupHeader88,
            this.GroupHeader89,
            this.GroupHeader90,
            this.GroupHeader91,
            this.GroupHeader92,
            this.GroupHeader93,
            this.GroupHeader94,
            this.GroupHeader95,
            this.Detail7,
            this.GroupFooter7});
            this.DetailReport6.DataMember = "Comment";
            this.DetailReport6.DataSource = this.mongoDBDataSource1;
            this.DetailReport6.Level = 4;
            this.DetailReport6.Name = "DetailReport6";
            this.DetailReport6.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.DetailReport6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupHeader80
            // 
            this.GroupHeader80.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table81});
            this.GroupHeader80.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader80.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader80.HeightF = 27F;
            this.GroupHeader80.Level = 1;
            this.GroupHeader80.Name = "GroupHeader80";
            this.GroupHeader80.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table81
            // 
            this.table81.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table81.Name = "table81";
            this.table81.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table81.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow81});
            this.table81.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow81
            // 
            this.tableRow81.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell159,
            this.tableCell160});
            this.tableRow81.Name = "tableRow81";
            this.tableRow81.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow81.Weight = 1D;
            // 
            // tableCell159
            // 
            this.tableCell159.Name = "tableCell159";
            this.tableCell159.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell159.StyleName = "GroupCaption2";
            this.tableCell159.Text = "SHOP ITEM CREATION TIME";
            this.tableCell159.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell159.Weight = 0.18289030287000868D;
            // 
            // tableCell160
            // 
            this.tableCell160.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.CreationTime]")});
            this.tableCell160.Name = "tableCell160";
            this.tableCell160.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell160.StyleName = "GroupData2";
            this.tableCell160.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell160.Weight = 0.81710971408420141D;
            // 
            // GroupHeader81
            // 
            this.GroupHeader81.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table82});
            this.GroupHeader81.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader81.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader81.HeightF = 27F;
            this.GroupHeader81.Level = 2;
            this.GroupHeader81.Name = "GroupHeader81";
            this.GroupHeader81.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table82
            // 
            this.table82.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table82.Name = "table82";
            this.table82.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table82.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow82});
            this.table82.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow82
            // 
            this.tableRow82.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell161,
            this.tableCell162});
            this.tableRow82.Name = "tableRow82";
            this.tableRow82.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow82.Weight = 1D;
            // 
            // tableCell161
            // 
            this.tableCell161.Name = "tableCell161";
            this.tableCell161.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell161.StyleName = "GroupCaption2";
            this.tableCell161.Text = "SHOP ITEM INCREMENT";
            this.tableCell161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell161.Weight = 0.15813602023654513D;
            // 
            // tableCell162
            // 
            this.tableCell162.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Increment]")});
            this.tableCell162.Name = "tableCell162";
            this.tableCell162.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell162.StyleName = "GroupData2";
            this.tableCell162.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell162.Weight = 0.841864013671875D;
            // 
            // GroupHeader82
            // 
            this.GroupHeader82.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table83});
            this.GroupHeader82.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader82.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader82.HeightF = 27F;
            this.GroupHeader82.Level = 3;
            this.GroupHeader82.Name = "GroupHeader82";
            this.GroupHeader82.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table83
            // 
            this.table83.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table83.Name = "table83";
            this.table83.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table83.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow83});
            this.table83.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow83
            // 
            this.tableRow83.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell163,
            this.tableCell164});
            this.tableRow83.Name = "tableRow83";
            this.tableRow83.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow83.Weight = 1D;
            // 
            // tableCell163
            // 
            this.tableCell163.Name = "tableCell163";
            this.tableCell163.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell163.StyleName = "GroupCaption2";
            this.tableCell163.Text = "SHOP ITEM PID";
            this.tableCell163.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell163.Weight = 0.10367910597059461D;
            // 
            // tableCell164
            // 
            this.tableCell164.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Pid]")});
            this.tableCell164.Name = "tableCell164";
            this.tableCell164.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell164.StyleName = "GroupData2";
            this.tableCell164.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell164.Weight = 0.8963209364149306D;
            // 
            // GroupHeader83
            // 
            this.GroupHeader83.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table84});
            this.GroupHeader83.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader83.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader83.HeightF = 27F;
            this.GroupHeader83.Level = 4;
            this.GroupHeader83.Name = "GroupHeader83";
            this.GroupHeader83.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table84
            // 
            this.table84.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table84.Name = "table84";
            this.table84.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table84.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow84});
            this.table84.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow84
            // 
            this.tableRow84.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell165,
            this.tableCell166});
            this.tableRow84.Name = "tableRow84";
            this.tableRow84.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow84.Weight = 1D;
            // 
            // tableCell165
            // 
            this.tableCell165.Name = "tableCell165";
            this.tableCell165.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell165.StyleName = "GroupCaption2";
            this.tableCell165.Text = "SHOP ITEM MACHINE";
            this.tableCell165.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell165.Weight = 0.14186732821994358D;
            // 
            // tableCell166
            // 
            this.tableCell166.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Machine]")});
            this.tableCell166.Name = "tableCell166";
            this.tableCell166.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell166.StyleName = "GroupData2";
            this.tableCell166.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell166.Weight = 0.85813266330295135D;
            // 
            // GroupHeader84
            // 
            this.GroupHeader84.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table85});
            this.GroupHeader84.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ShopItem.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader84.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader84.HeightF = 27F;
            this.GroupHeader84.Level = 5;
            this.GroupHeader84.Name = "GroupHeader84";
            this.GroupHeader84.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table85
            // 
            this.table85.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table85.Name = "table85";
            this.table85.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table85.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow85});
            this.table85.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow85
            // 
            this.tableRow85.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell167,
            this.tableCell168});
            this.tableRow85.Name = "tableRow85";
            this.tableRow85.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow85.Weight = 1D;
            // 
            // tableCell167
            // 
            this.tableCell167.Name = "tableCell167";
            this.tableCell167.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell167.StyleName = "GroupCaption2";
            this.tableCell167.Text = "SHOP ITEM TIMESTAMP";
            this.tableCell167.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell167.Weight = 0.15742733425564237D;
            // 
            // tableCell168
            // 
            this.tableCell168.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[ShopItem.Timestamp]")});
            this.tableCell168.Name = "tableCell168";
            this.tableCell168.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell168.StyleName = "GroupData2";
            this.tableCell168.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell168.Weight = 0.84257269965277781D;
            // 
            // GroupHeader85
            // 
            this.GroupHeader85.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table86});
            this.GroupHeader85.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader85.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader85.HeightF = 27F;
            this.GroupHeader85.Level = 6;
            this.GroupHeader85.Name = "GroupHeader85";
            this.GroupHeader85.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table86
            // 
            this.table86.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table86.Name = "table86";
            this.table86.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table86.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow86});
            this.table86.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow86
            // 
            this.tableRow86.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell169,
            this.tableCell170});
            this.tableRow86.Name = "tableRow86";
            this.tableRow86.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow86.Weight = 1D;
            // 
            // tableCell169
            // 
            this.tableCell169.Name = "tableCell169";
            this.tableCell169.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell169.StyleName = "GroupCaption2";
            this.tableCell169.Text = "USER CREATION TIME";
            this.tableCell169.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell169.Weight = 0.14823306613498263D;
            // 
            // tableCell170
            // 
            this.tableCell170.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.CreationTime]")});
            this.tableCell170.Name = "tableCell170";
            this.tableCell170.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell170.StyleName = "GroupData2";
            this.tableCell170.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell170.Weight = 0.85176689995659727D;
            // 
            // GroupHeader86
            // 
            this.GroupHeader86.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table87});
            this.GroupHeader86.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader86.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader86.HeightF = 27F;
            this.GroupHeader86.Level = 7;
            this.GroupHeader86.Name = "GroupHeader86";
            this.GroupHeader86.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table87
            // 
            this.table87.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table87.Name = "table87";
            this.table87.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table87.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow87});
            this.table87.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow87
            // 
            this.tableRow87.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell171,
            this.tableCell172});
            this.tableRow87.Name = "tableRow87";
            this.tableRow87.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow87.Weight = 1D;
            // 
            // tableCell171
            // 
            this.tableCell171.Name = "tableCell171";
            this.tableCell171.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell171.StyleName = "GroupCaption2";
            this.tableCell171.Text = "USER INCREMENT";
            this.tableCell171.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell171.Weight = 0.12347879197862413D;
            // 
            // tableCell172
            // 
            this.tableCell172.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Increment]")});
            this.tableCell172.Name = "tableCell172";
            this.tableCell172.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell172.StyleName = "GroupData2";
            this.tableCell172.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell172.Weight = 0.87652119954427088D;
            // 
            // GroupHeader87
            // 
            this.GroupHeader87.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table88});
            this.GroupHeader87.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader87.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader87.HeightF = 27F;
            this.GroupHeader87.Level = 8;
            this.GroupHeader87.Name = "GroupHeader87";
            this.GroupHeader87.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table88
            // 
            this.table88.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table88.Name = "table88";
            this.table88.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table88.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow88});
            this.table88.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow88
            // 
            this.tableRow88.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell173,
            this.tableCell174});
            this.tableRow88.Name = "tableRow88";
            this.tableRow88.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow88.Weight = 1D;
            // 
            // tableCell173
            // 
            this.tableCell173.Name = "tableCell173";
            this.tableCell173.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell173.StyleName = "GroupCaption2";
            this.tableCell173.Text = "USER PID";
            this.tableCell173.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell173.Weight = 0.06902187771267361D;
            // 
            // tableCell174
            // 
            this.tableCell174.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Pid]")});
            this.tableCell174.Name = "tableCell174";
            this.tableCell174.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell174.StyleName = "GroupData2";
            this.tableCell174.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell174.Weight = 0.93097812228732635D;
            // 
            // GroupHeader88
            // 
            this.GroupHeader88.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table89});
            this.GroupHeader88.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader88.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader88.HeightF = 27F;
            this.GroupHeader88.Level = 9;
            this.GroupHeader88.Name = "GroupHeader88";
            this.GroupHeader88.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table89
            // 
            this.table89.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table89.Name = "table89";
            this.table89.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table89.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow89});
            this.table89.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow89
            // 
            this.tableRow89.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell175,
            this.tableCell176});
            this.tableRow89.Name = "tableRow89";
            this.tableRow89.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow89.Weight = 1D;
            // 
            // tableCell175
            // 
            this.tableCell175.Name = "tableCell175";
            this.tableCell175.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell175.StyleName = "GroupCaption2";
            this.tableCell175.Text = "USER MACHINE";
            this.tableCell175.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell175.Weight = 1580877.375D;
            // 
            // tableCell176
            // 
            this.tableCell176.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Machine]")});
            this.tableCell176.Name = "tableCell176";
            this.tableCell176.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell176.StyleName = "GroupData2";
            this.tableCell176.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell176.Weight = 13164722D;
            // 
            // GroupHeader89
            // 
            this.GroupHeader89.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table90});
            this.GroupHeader89.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("User.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader89.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader89.HeightF = 27F;
            this.GroupHeader89.Level = 10;
            this.GroupHeader89.Name = "GroupHeader89";
            this.GroupHeader89.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table90
            // 
            this.table90.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table90.Name = "table90";
            this.table90.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table90.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow90});
            this.table90.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow90
            // 
            this.tableRow90.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell177,
            this.tableCell178});
            this.tableRow90.Name = "tableRow90";
            this.tableRow90.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow90.Weight = 1D;
            // 
            // tableCell177
            // 
            this.tableCell177.Name = "tableCell177";
            this.tableCell177.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell177.StyleName = "GroupCaption2";
            this.tableCell177.Text = "USER TIMESTAMP";
            this.tableCell177.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell177.Weight = 0.12277010599772135D;
            // 
            // tableCell178
            // 
            this.tableCell178.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[User.Timestamp]")});
            this.tableCell178.Name = "tableCell178";
            this.tableCell178.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell178.StyleName = "GroupData2";
            this.tableCell178.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell178.Weight = 0.87722988552517356D;
            // 
            // GroupHeader90
            // 
            this.GroupHeader90.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table91});
            this.GroupHeader90.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("UserComment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader90.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader90.HeightF = 27F;
            this.GroupHeader90.Level = 11;
            this.GroupHeader90.Name = "GroupHeader90";
            this.GroupHeader90.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table91
            // 
            this.table91.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table91.Name = "table91";
            this.table91.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table91.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow91});
            this.table91.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow91
            // 
            this.tableRow91.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell179,
            this.tableCell180});
            this.tableRow91.Name = "tableRow91";
            this.tableRow91.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow91.Weight = 1D;
            // 
            // tableCell179
            // 
            this.tableCell179.Name = "tableCell179";
            this.tableCell179.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell179.StyleName = "GroupCaption2";
            this.tableCell179.Text = "USER COMMENT";
            this.tableCell179.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell179.Weight = 0.11356961568196615D;
            // 
            // tableCell180
            // 
            this.tableCell180.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[UserComment]")});
            this.tableCell180.Name = "tableCell180";
            this.tableCell180.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell180.StyleName = "GroupData2";
            this.tableCell180.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell180.Weight = 0.88643039279513891D;
            // 
            // GroupHeader91
            // 
            this.GroupHeader91.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table92});
            this.GroupHeader91.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.CreationTime", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader91.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader91.HeightF = 27F;
            this.GroupHeader91.Level = 12;
            this.GroupHeader91.Name = "GroupHeader91";
            this.GroupHeader91.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table92
            // 
            this.table92.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table92.Name = "table92";
            this.table92.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table92.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow92});
            this.table92.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow92
            // 
            this.tableRow92.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell181,
            this.tableCell182});
            this.tableRow92.Name = "tableRow92";
            this.tableRow92.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow92.Weight = 1D;
            // 
            // tableCell181
            // 
            this.tableCell181.Name = "tableCell181";
            this.tableCell181.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell181.StyleName = "GroupCaption2";
            this.tableCell181.Text = " ID CREATION TIME";
            this.tableCell181.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell181.Weight = 0.12912963019476997D;
            // 
            // tableCell182
            // 
            this.tableCell182.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.CreationTime]")});
            this.tableCell182.Name = "tableCell182";
            this.tableCell182.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell182.StyleName = "GroupData2";
            this.tableCell182.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell182.Weight = 0.870870361328125D;
            // 
            // GroupHeader92
            // 
            this.GroupHeader92.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table93});
            this.GroupHeader92.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Increment", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader92.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader92.HeightF = 27F;
            this.GroupHeader92.Level = 13;
            this.GroupHeader92.Name = "GroupHeader92";
            this.GroupHeader92.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table93
            // 
            this.table93.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table93.Name = "table93";
            this.table93.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table93.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow93});
            this.table93.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow93
            // 
            this.tableRow93.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell183,
            this.tableCell184});
            this.tableRow93.Name = "tableRow93";
            this.tableRow93.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow93.Weight = 1D;
            // 
            // tableCell183
            // 
            this.tableCell183.Name = "tableCell183";
            this.tableCell183.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell183.StyleName = "GroupCaption2";
            this.tableCell183.Text = " ID INCREMENT";
            this.tableCell183.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell183.Weight = 1539077.375D;
            // 
            // tableCell184
            // 
            this.tableCell184.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Increment]")});
            this.tableCell184.Name = "tableCell184";
            this.tableCell184.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell184.StyleName = "GroupData2";
            this.tableCell184.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell184.Weight = 13206522D;
            // 
            // GroupHeader93
            // 
            this.GroupHeader93.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table94});
            this.GroupHeader93.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Pid", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader93.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader93.HeightF = 27F;
            this.GroupHeader93.Level = 14;
            this.GroupHeader93.Name = "GroupHeader93";
            this.GroupHeader93.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table94
            // 
            this.table94.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table94.Name = "table94";
            this.table94.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table94.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow94});
            this.table94.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow94
            // 
            this.tableRow94.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell185,
            this.tableCell186});
            this.tableRow94.Name = "tableRow94";
            this.tableRow94.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow94.Weight = 1D;
            // 
            // tableCell185
            // 
            this.tableCell185.Name = "tableCell185";
            this.tableCell185.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell185.StyleName = "GroupCaption2";
            this.tableCell185.Text = " ID PID";
            this.tableCell185.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell185.Weight = 736077.3125D;
            // 
            // tableCell186
            // 
            this.tableCell186.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Pid]")});
            this.tableCell186.Name = "tableCell186";
            this.tableCell186.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell186.StyleName = "GroupData2";
            this.tableCell186.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell186.Weight = 14009522D;
            // 
            // GroupHeader94
            // 
            this.GroupHeader94.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table95});
            this.GroupHeader94.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Machine", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader94.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader94.HeightF = 27F;
            this.GroupHeader94.Level = 15;
            this.GroupHeader94.Name = "GroupHeader94";
            this.GroupHeader94.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table95
            // 
            this.table95.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table95.Name = "table95";
            this.table95.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table95.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow95});
            this.table95.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow95
            // 
            this.tableRow95.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell187,
            this.tableCell188});
            this.tableRow95.Name = "tableRow95";
            this.tableRow95.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow95.Weight = 1D;
            // 
            // tableCell187
            // 
            this.tableCell187.Name = "tableCell187";
            this.tableCell187.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell187.StyleName = "GroupCaption2";
            this.tableCell187.Text = " ID MACHINE";
            this.tableCell187.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell187.Weight = 0.0881066640218099D;
            // 
            // tableCell188
            // 
            this.tableCell188.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Machine]")});
            this.tableCell188.Name = "tableCell188";
            this.tableCell188.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell188.StyleName = "GroupData2";
            this.tableCell188.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell188.Weight = 0.91189337836371531D;
            // 
            // GroupHeader95
            // 
            this.GroupHeader95.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table96});
            this.GroupHeader95.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("_id.Timestamp", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader95.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader95.HeightF = 27F;
            this.GroupHeader95.Level = 16;
            this.GroupHeader95.Name = "GroupHeader95";
            this.GroupHeader95.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupHeader95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // table96
            // 
            this.table96.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
            this.table96.Name = "table96";
            this.table96.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.table96.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow96});
            this.table96.SizeF = new System.Drawing.SizeF(900F, 25F);
            this.table96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tableRow96
            // 
            this.tableRow96.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell189,
            this.tableCell190});
            this.tableRow96.Name = "tableRow96";
            this.tableRow96.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.tableRow96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableRow96.Weight = 1D;
            // 
            // tableCell189
            // 
            this.tableCell189.Name = "tableCell189";
            this.tableCell189.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell189.StyleName = "GroupCaption2";
            this.tableCell189.Text = " ID TIMESTAMP";
            this.tableCell189.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell189.Weight = 1528627.375D;
            // 
            // tableCell190
            // 
            this.tableCell190.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[_id.Timestamp]")});
            this.tableCell190.Name = "tableCell190";
            this.tableCell190.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.tableCell190.StyleName = "GroupData2";
            this.tableCell190.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tableCell190.Weight = 13216972D;
            // 
            // Detail7
            // 
            this.Detail7.HeightF = 0F;
            this.Detail7.Name = "Detail7";
            this.Detail7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // GroupFooter7
            // 
            this.GroupFooter7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label8});
            this.GroupFooter7.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
            this.GroupFooter7.HeightF = 6F;
            this.GroupFooter7.Name = "GroupFooter7";
            this.GroupFooter7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.GroupFooter7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // label8
            // 
            this.label8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label8.Name = "label8";
            this.label8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.label8.SizeF = new System.Drawing.SizeF(900F, 2.08F);
            this.label8.StyleName = "GroupFooterBackground3";
            this.label8.StylePriority.UseBorders = false;
            this.label8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Title.Name = "Title";
            // 
            // GroupCaption2
            // 
            this.GroupCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.GroupCaption2.BorderColor = System.Drawing.Color.White;
            this.GroupCaption2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.GroupCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption2.BorderWidth = 2F;
            this.GroupCaption2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupCaption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption2.Name = "GroupCaption2";
            // 
            // GroupData2
            // 
            this.GroupData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.GroupData2.BorderColor = System.Drawing.Color.White;
            this.GroupData2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.GroupData2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData2.BorderWidth = 2F;
            this.GroupData2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupData2.ForeColor = System.Drawing.Color.White;
            this.GroupData2.Name = "GroupData2";
            // 
            // DetailCaption2
            // 
            this.DetailCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.DetailCaption2.BorderColor = System.Drawing.Color.White;
            this.DetailCaption2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.DetailCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption2.BorderWidth = 2F;
            this.DetailCaption2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption2.ForeColor = System.Drawing.Color.White;
            this.DetailCaption2.Name = "DetailCaption2";
            // 
            // DetailData2
            // 
            this.DetailData2.BackColor = System.Drawing.Color.Transparent;
            this.DetailData2.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData2.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.DetailData2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData2.BorderWidth = 2F;
            this.DetailData2.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData2.ForeColor = System.Drawing.Color.Black;
            this.DetailData2.Name = "DetailData2";
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            // 
            // PageInfo
            // 
            this.PageInfo.BackColor = System.Drawing.Color.Transparent;
            this.PageInfo.BorderColor = System.Drawing.Color.Black;
            this.PageInfo.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.PageInfo.BorderWidth = 1F;
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PageInfo.Name = "PageInfo";
            // 
            // Report
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.bottomMarginBand1,
            this.ReportHeader,
            this.detailBand1,
            this.DetailReport,
            this.DetailReport1,
            this.DetailReport2,
            this.DetailReport5,
            this.DetailReport6});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.mongoDBDataSource1});
            this.DataSource = this.mongoDBDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Landscape = true;
            this.Margins = new DevExpress.Drawing.DXMargins(98F, 100F, 100F, 100F);
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption2,
            this.GroupData2,
            this.DetailCaption2,
            this.DetailData2,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
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
            ((System.ComponentModel.ISupportInitialize)(this.table87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table89)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table91)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table92)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table93)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table94)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table96)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand topMarginBand1;
        private DevExpress.XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand detailBand1;
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
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
        private DevExpress.XtraReports.UI.XRLabel label2;
        private DevExpress.DataAccess.MongoDB.MongoDBDataSource mongoDBDataSource1;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport1;
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
        private DevExpress.XtraReports.UI.DetailBand Detail2;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRLabel label3;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport2;
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
        private DevExpress.XtraReports.UI.DetailBand Detail3;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter3;
        private DevExpress.XtraReports.UI.XRLabel label4;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport5;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader66;
        private DevExpress.XtraReports.UI.XRTable table67;
        private DevExpress.XtraReports.UI.XRTableRow tableRow67;
        private DevExpress.XtraReports.UI.XRTableCell tableCell131;
        private DevExpress.XtraReports.UI.XRTableCell tableCell132;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader67;
        private DevExpress.XtraReports.UI.XRTable table68;
        private DevExpress.XtraReports.UI.XRTableRow tableRow68;
        private DevExpress.XtraReports.UI.XRTableCell tableCell133;
        private DevExpress.XtraReports.UI.XRTableCell tableCell134;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader68;
        private DevExpress.XtraReports.UI.XRTable table69;
        private DevExpress.XtraReports.UI.XRTableRow tableRow69;
        private DevExpress.XtraReports.UI.XRTableCell tableCell135;
        private DevExpress.XtraReports.UI.XRTableCell tableCell136;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader69;
        private DevExpress.XtraReports.UI.XRTable table70;
        private DevExpress.XtraReports.UI.XRTableRow tableRow70;
        private DevExpress.XtraReports.UI.XRTableCell tableCell137;
        private DevExpress.XtraReports.UI.XRTableCell tableCell138;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader70;
        private DevExpress.XtraReports.UI.XRTable table71;
        private DevExpress.XtraReports.UI.XRTableRow tableRow71;
        private DevExpress.XtraReports.UI.XRTableCell tableCell139;
        private DevExpress.XtraReports.UI.XRTableCell tableCell140;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader71;
        private DevExpress.XtraReports.UI.XRTable table72;
        private DevExpress.XtraReports.UI.XRTableRow tableRow72;
        private DevExpress.XtraReports.UI.XRTableCell tableCell141;
        private DevExpress.XtraReports.UI.XRTableCell tableCell142;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader72;
        private DevExpress.XtraReports.UI.XRTable table73;
        private DevExpress.XtraReports.UI.XRTableRow tableRow73;
        private DevExpress.XtraReports.UI.XRTableCell tableCell143;
        private DevExpress.XtraReports.UI.XRTableCell tableCell144;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader73;
        private DevExpress.XtraReports.UI.XRTable table74;
        private DevExpress.XtraReports.UI.XRTableRow tableRow74;
        private DevExpress.XtraReports.UI.XRTableCell tableCell145;
        private DevExpress.XtraReports.UI.XRTableCell tableCell146;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader74;
        private DevExpress.XtraReports.UI.XRTable table75;
        private DevExpress.XtraReports.UI.XRTableRow tableRow75;
        private DevExpress.XtraReports.UI.XRTableCell tableCell147;
        private DevExpress.XtraReports.UI.XRTableCell tableCell148;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader75;
        private DevExpress.XtraReports.UI.XRTable table76;
        private DevExpress.XtraReports.UI.XRTableRow tableRow76;
        private DevExpress.XtraReports.UI.XRTableCell tableCell149;
        private DevExpress.XtraReports.UI.XRTableCell tableCell150;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader76;
        private DevExpress.XtraReports.UI.XRTable table77;
        private DevExpress.XtraReports.UI.XRTableRow tableRow77;
        private DevExpress.XtraReports.UI.XRTableCell tableCell151;
        private DevExpress.XtraReports.UI.XRTableCell tableCell152;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader77;
        private DevExpress.XtraReports.UI.XRTable table78;
        private DevExpress.XtraReports.UI.XRTableRow tableRow78;
        private DevExpress.XtraReports.UI.XRTableCell tableCell153;
        private DevExpress.XtraReports.UI.XRTableCell tableCell154;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader78;
        private DevExpress.XtraReports.UI.XRTable table79;
        private DevExpress.XtraReports.UI.XRTableRow tableRow79;
        private DevExpress.XtraReports.UI.XRTableCell tableCell155;
        private DevExpress.XtraReports.UI.XRTableCell tableCell156;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader79;
        private DevExpress.XtraReports.UI.XRTable table80;
        private DevExpress.XtraReports.UI.XRTableRow tableRow80;
        private DevExpress.XtraReports.UI.XRTableCell tableCell157;
        private DevExpress.XtraReports.UI.XRTableCell tableCell158;
        private DevExpress.XtraReports.UI.DetailBand Detail6;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter6;
        private DevExpress.XtraReports.UI.XRLabel label7;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport6;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader80;
        private DevExpress.XtraReports.UI.XRTable table81;
        private DevExpress.XtraReports.UI.XRTableRow tableRow81;
        private DevExpress.XtraReports.UI.XRTableCell tableCell159;
        private DevExpress.XtraReports.UI.XRTableCell tableCell160;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader81;
        private DevExpress.XtraReports.UI.XRTable table82;
        private DevExpress.XtraReports.UI.XRTableRow tableRow82;
        private DevExpress.XtraReports.UI.XRTableCell tableCell161;
        private DevExpress.XtraReports.UI.XRTableCell tableCell162;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader82;
        private DevExpress.XtraReports.UI.XRTable table83;
        private DevExpress.XtraReports.UI.XRTableRow tableRow83;
        private DevExpress.XtraReports.UI.XRTableCell tableCell163;
        private DevExpress.XtraReports.UI.XRTableCell tableCell164;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader83;
        private DevExpress.XtraReports.UI.XRTable table84;
        private DevExpress.XtraReports.UI.XRTableRow tableRow84;
        private DevExpress.XtraReports.UI.XRTableCell tableCell165;
        private DevExpress.XtraReports.UI.XRTableCell tableCell166;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader84;
        private DevExpress.XtraReports.UI.XRTable table85;
        private DevExpress.XtraReports.UI.XRTableRow tableRow85;
        private DevExpress.XtraReports.UI.XRTableCell tableCell167;
        private DevExpress.XtraReports.UI.XRTableCell tableCell168;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader85;
        private DevExpress.XtraReports.UI.XRTable table86;
        private DevExpress.XtraReports.UI.XRTableRow tableRow86;
        private DevExpress.XtraReports.UI.XRTableCell tableCell169;
        private DevExpress.XtraReports.UI.XRTableCell tableCell170;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader86;
        private DevExpress.XtraReports.UI.XRTable table87;
        private DevExpress.XtraReports.UI.XRTableRow tableRow87;
        private DevExpress.XtraReports.UI.XRTableCell tableCell171;
        private DevExpress.XtraReports.UI.XRTableCell tableCell172;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader87;
        private DevExpress.XtraReports.UI.XRTable table88;
        private DevExpress.XtraReports.UI.XRTableRow tableRow88;
        private DevExpress.XtraReports.UI.XRTableCell tableCell173;
        private DevExpress.XtraReports.UI.XRTableCell tableCell174;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader88;
        private DevExpress.XtraReports.UI.XRTable table89;
        private DevExpress.XtraReports.UI.XRTableRow tableRow89;
        private DevExpress.XtraReports.UI.XRTableCell tableCell175;
        private DevExpress.XtraReports.UI.XRTableCell tableCell176;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader89;
        private DevExpress.XtraReports.UI.XRTable table90;
        private DevExpress.XtraReports.UI.XRTableRow tableRow90;
        private DevExpress.XtraReports.UI.XRTableCell tableCell177;
        private DevExpress.XtraReports.UI.XRTableCell tableCell178;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader90;
        private DevExpress.XtraReports.UI.XRTable table91;
        private DevExpress.XtraReports.UI.XRTableRow tableRow91;
        private DevExpress.XtraReports.UI.XRTableCell tableCell179;
        private DevExpress.XtraReports.UI.XRTableCell tableCell180;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader91;
        private DevExpress.XtraReports.UI.XRTable table92;
        private DevExpress.XtraReports.UI.XRTableRow tableRow92;
        private DevExpress.XtraReports.UI.XRTableCell tableCell181;
        private DevExpress.XtraReports.UI.XRTableCell tableCell182;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader92;
        private DevExpress.XtraReports.UI.XRTable table93;
        private DevExpress.XtraReports.UI.XRTableRow tableRow93;
        private DevExpress.XtraReports.UI.XRTableCell tableCell183;
        private DevExpress.XtraReports.UI.XRTableCell tableCell184;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader93;
        private DevExpress.XtraReports.UI.XRTable table94;
        private DevExpress.XtraReports.UI.XRTableRow tableRow94;
        private DevExpress.XtraReports.UI.XRTableCell tableCell185;
        private DevExpress.XtraReports.UI.XRTableCell tableCell186;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader94;
        private DevExpress.XtraReports.UI.XRTable table95;
        private DevExpress.XtraReports.UI.XRTableRow tableRow95;
        private DevExpress.XtraReports.UI.XRTableCell tableCell187;
        private DevExpress.XtraReports.UI.XRTableCell tableCell188;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader95;
        private DevExpress.XtraReports.UI.XRTable table96;
        private DevExpress.XtraReports.UI.XRTableRow tableRow96;
        private DevExpress.XtraReports.UI.XRTableCell tableCell189;
        private DevExpress.XtraReports.UI.XRTableCell tableCell190;
        private DevExpress.XtraReports.UI.DetailBand Detail7;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter7;
        private DevExpress.XtraReports.UI.XRLabel label8;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption2;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData2;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption2;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData2;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    }
}
