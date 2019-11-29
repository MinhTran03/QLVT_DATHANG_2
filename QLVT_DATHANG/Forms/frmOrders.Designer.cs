﻿namespace QLVT_DATHANG.Forms
{
   partial class frmOrders
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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
         this.bmPN = new DevExpress.XtraBars.BarManager(this.components);
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
         this.taDDH = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
         this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
         this.gcOrder = new DevExpress.XtraGrid.GridControl();
         this.cmsOrderDetail = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.btnAddOrderDetail = new System.Windows.Forms.ToolStripMenuItem();
         this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.sccOrder = new DevExpress.XtraEditors.SplitContainerControl();
         this.gbOrder = new DevExpress.XtraEditors.GroupControl();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.lkeDepot = new DevExpress.XtraEditors.LookUpEdit();
         this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
         this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
         this.txtOrderId = new DevExpress.XtraEditors.TextEdit();
         this.txtProvider = new DevExpress.XtraEditors.TextEdit();
         this.lkeEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
         this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
         this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
         this.gbOrderDetail = new DevExpress.XtraEditors.GroupControl();
         this.gcOrderDetail = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.TENVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.taCTDDH = new QLVT_DATHANG.DataSetTableAdapters.CTDDHTableAdapter();
         this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.taVT = new QLVT_DATHANG.DataSetTableAdapters.VattuTableAdapter();
         this.taKho = new QLVT_DATHANG.DataSetTableAdapters.DSKHOTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
         this.cmsOrderDetail.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sccOrder)).BeginInit();
         this.sccOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).BeginInit();
         this.gbOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtProvider.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).BeginInit();
         this.gbOrderDetail.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // bmPN
         // 
         this.bmPN.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
         this.bmPN.DockControls.Add(this.barDockControlTop);
         this.bmPN.DockControls.Add(this.barDockControlBottom);
         this.bmPN.DockControls.Add(this.barDockControlLeft);
         this.bmPN.DockControls.Add(this.barDockControlRight);
         this.bmPN.Form = this;
         this.bmPN.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnSave,
            this.btnRefresh,
            this.btnExit,
            this.btnCancelEdit});
         this.bmPN.MainMenu = this.bar2;
         this.bmPN.MaxItemId = 30;
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // btnAdd
         // 
         this.btnAdd.Caption = "THÊM";
         this.btnAdd.Id = 0;
         this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
         // 
         // btnRefresh
         // 
         this.btnRefresh.Caption = "LÀM MỚI";
         this.btnRefresh.Id = 5;
         this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
         // 
         // btnSave
         // 
         this.btnSave.Caption = "GHI";
         this.btnSave.Enabled = false;
         this.btnSave.Id = 3;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Enabled = false;
         this.btnCancelEdit.Id = 7;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelEdit_ItemClick);
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 6;
         this.btnExit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.btnExit.Name = "btnExit";
         this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.bmPN;
         this.barDockControlTop.Size = new System.Drawing.Size(987, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 456);
         this.barDockControlBottom.Manager = this.bmPN;
         this.barDockControlBottom.Size = new System.Drawing.Size(987, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmPN;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(987, 24);
         this.barDockControlRight.Manager = this.bmPN;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bdsDDH
         // 
         this.bdsDDH.DataMember = "DatHang";
         this.bdsDDH.DataSource = this.dataSet;
         // 
         // taDDH
         // 
         this.taDDH.ClearBeforeFill = true;
         // 
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.ChiNhanhTableAdapter = null;
         this.tableAdapterManager.CTDDHTableAdapter = null;
         this.tableAdapterManager.CTPNTableAdapter = null;
         this.tableAdapterManager.CTPXTableAdapter = null;
         this.tableAdapterManager.DatHangTableAdapter = this.taDDH;
         this.tableAdapterManager.KhoTableAdapter = null;
         this.tableAdapterManager.NhanVienTableAdapter = null;
         this.tableAdapterManager.PhieuNhapTableAdapter = null;
         this.tableAdapterManager.PhieuXuatTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.VattuTableAdapter = null;
         // 
         // gcOrder
         // 
         this.gcOrder.ContextMenuStrip = this.cmsOrderDetail;
         this.gcOrder.DataSource = this.bdsDDH;
         this.gcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gcOrder.Location = new System.Drawing.Point(0, 54);
         this.gcOrder.LookAndFeel.SkinName = "DevExpress Dark Style";
         this.gcOrder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
         this.gcOrder.MainView = this.gvOrder;
         this.gcOrder.MenuManager = this.bmPN;
         this.gcOrder.Name = "gcOrder";
         this.gcOrder.Size = new System.Drawing.Size(987, 233);
         this.gcOrder.TabIndex = 1;
         this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrder});
         // 
         // cmsOrderDetail
         // 
         this.cmsOrderDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddOrderDetail});
         this.cmsOrderDetail.Name = "cmsOrderDetail";
         this.cmsOrderDetail.Size = new System.Drawing.Size(172, 26);
         // 
         // btnAddOrderDetail
         // 
         this.btnAddOrderDetail.Image = global::QLVT_DATHANG.Properties.Resources.icons8_plus_math_16;
         this.btnAddOrderDetail.Name = "btnAddOrderDetail";
         this.btnAddOrderDetail.Size = new System.Drawing.Size(171, 22);
         this.btnAddOrderDetail.Text = "Thêm chi tiết DDH";
         this.btnAddOrderDetail.Click += new System.EventHandler(this.btnAddOrderDetail_Click);
         // 
         // gvOrder
         // 
         this.gvOrder.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.HeaderPanel.Options.UseFont = true;
         this.gvOrder.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.Row.Options.UseFont = true;
         this.gvOrder.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.SelectedRow.Options.UseFont = true;
         this.gvOrder.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.ViewCaption.Options.UseFont = true;
         this.gvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
         this.gvOrder.GridControl = this.gcOrder;
         this.gvOrder.Name = "gvOrder";
         this.gvOrder.OptionsBehavior.Editable = false;
         this.gvOrder.OptionsView.ShowGroupPanel = false;
         this.gvOrder.OptionsView.ShowViewCaption = true;
         this.gvOrder.ViewCaption = "Danh sách Đơn Đặt Hàng";
         // 
         // colMasoDDH
         // 
         this.colMasoDDH.Caption = "MÃ SỐ ĐƠN ĐẶT HÀNG";
         this.colMasoDDH.FieldName = "MasoDDH";
         this.colMasoDDH.Name = "colMasoDDH";
         this.colMasoDDH.Visible = true;
         this.colMasoDDH.VisibleIndex = 0;
         // 
         // colNGAY
         // 
         this.colNGAY.Caption = "NGÀY ĐẶT";
         this.colNGAY.FieldName = "NGAY";
         this.colNGAY.Name = "colNGAY";
         this.colNGAY.Visible = true;
         this.colNGAY.VisibleIndex = 1;
         // 
         // colNhaCC
         // 
         this.colNhaCC.Caption = "NHÀ CUNG CẤP";
         this.colNhaCC.FieldName = "NhaCC";
         this.colNhaCC.Name = "colNhaCC";
         this.colNhaCC.Visible = true;
         this.colNhaCC.VisibleIndex = 2;
         // 
         // colMANV
         // 
         this.colMANV.Caption = "MÃ NHÂN VIÊN";
         this.colMANV.FieldName = "MANV";
         this.colMANV.Name = "colMANV";
         this.colMANV.Visible = true;
         this.colMANV.VisibleIndex = 3;
         // 
         // colMAKHO
         // 
         this.colMAKHO.Caption = "MÃ KHO";
         this.colMAKHO.FieldName = "MAKHO";
         this.colMAKHO.Name = "colMAKHO";
         this.colMAKHO.Visible = true;
         this.colMAKHO.VisibleIndex = 4;
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitterControl1.Location = new System.Drawing.Point(0, 287);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(987, 5);
         this.splitterControl1.TabIndex = 2;
         this.splitterControl1.TabStop = false;
         // 
         // sccOrder
         // 
         this.sccOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.sccOrder.Location = new System.Drawing.Point(0, 292);
         this.sccOrder.Name = "sccOrder";
         this.sccOrder.Panel1.Controls.Add(this.gbOrder);
         this.sccOrder.Panel1.Text = "Panel1";
         this.sccOrder.Panel2.Controls.Add(this.gbOrderDetail);
         this.sccOrder.Panel2.Text = "Panel2";
         this.sccOrder.Size = new System.Drawing.Size(987, 164);
         this.sccOrder.SplitterPosition = 494;
         this.sccOrder.TabIndex = 7;
         // 
         // gbOrder
         // 
         this.gbOrder.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbOrder.AppearanceCaption.Options.UseFont = true;
         this.gbOrder.Controls.Add(this.label5);
         this.gbOrder.Controls.Add(this.label4);
         this.gbOrder.Controls.Add(this.label3);
         this.gbOrder.Controls.Add(this.label2);
         this.gbOrder.Controls.Add(this.label1);
         this.gbOrder.Controls.Add(this.lkeDepot);
         this.gbOrder.Controls.Add(this.pictureEdit1);
         this.gbOrder.Controls.Add(this.txtOrderId);
         this.gbOrder.Controls.Add(this.txtProvider);
         this.gbOrder.Controls.Add(this.lkeEmployee);
         this.gbOrder.Controls.Add(this.dtpOrderDate);
         this.gbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbOrder.Location = new System.Drawing.Point(0, 0);
         this.gbOrder.Name = "gbOrder";
         this.gbOrder.Size = new System.Drawing.Size(494, 164);
         this.gbOrder.TabIndex = 0;
         this.gbOrder.Text = "Thông tin Đơn Đặt Hàng";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(166, 141);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(31, 15);
         this.label5.TabIndex = 15;
         this.label5.Text = "Kho:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(166, 113);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(84, 15);
         this.label4.TabIndex = 14;
         this.label4.Text = "Nhân viên đặt:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(166, 85);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(58, 15);
         this.label3.TabIndex = 13;
         this.label3.Text = "Ngày đặt:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(166, 57);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(84, 15);
         this.label2.TabIndex = 12;
         this.label2.Text = "Nhà cung cấp:";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(166, 29);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(116, 15);
         this.label1.TabIndex = 11;
         this.label1.Text = "Mã số đơn đặt hàng:";
         // 
         // lkeDepot
         // 
         this.lkeDepot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MAKHO", true));
         this.lkeDepot.Location = new System.Drawing.Point(287, 136);
         this.lkeDepot.MenuManager = this.bmPN;
         this.lkeDepot.Name = "lkeDepot";
         this.lkeDepot.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lkeDepot.Properties.Appearance.Options.UseFont = true;
         this.lkeDepot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.lkeDepot.Properties.DataSource = this.bdsKho;
         this.lkeDepot.Properties.DisplayMember = "TENKHO";
         this.lkeDepot.Properties.NullText = "";
         this.lkeDepot.Properties.ValueMember = "MAKHO";
         this.lkeDepot.Size = new System.Drawing.Size(202, 22);
         this.lkeDepot.TabIndex = 10;
         // 
         // bdsKho
         // 
         this.bdsKho.DataMember = "DSKHO";
         this.bdsKho.DataSource = this.dataSet;
         // 
         // pictureEdit1
         // 
         this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Left;
         this.pictureEdit1.EditValue = global::QLVT_DATHANG.Properties.Resources._162_512;
         this.pictureEdit1.Location = new System.Drawing.Point(2, 22);
         this.pictureEdit1.Name = "pictureEdit1";
         this.pictureEdit1.Properties.AllowFocused = false;
         this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
         this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
         this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
         this.pictureEdit1.Size = new System.Drawing.Size(158, 140);
         this.pictureEdit1.TabIndex = 8;
         // 
         // txtOrderId
         // 
         this.txtOrderId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MasoDDH", true));
         this.txtOrderId.Location = new System.Drawing.Point(287, 24);
         this.txtOrderId.MenuManager = this.bmPN;
         this.txtOrderId.Name = "txtOrderId";
         this.txtOrderId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtOrderId.Properties.Appearance.Options.UseFont = true;
         this.txtOrderId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtOrderId.Properties.MaxLength = 8;
         this.txtOrderId.Size = new System.Drawing.Size(202, 22);
         this.txtOrderId.TabIndex = 1;
         // 
         // txtProvider
         // 
         this.txtProvider.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NhaCC", true));
         this.txtProvider.Location = new System.Drawing.Point(287, 52);
         this.txtProvider.MenuManager = this.bmPN;
         this.txtProvider.Name = "txtProvider";
         this.txtProvider.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtProvider.Properties.Appearance.Options.UseFont = true;
         this.txtProvider.Size = new System.Drawing.Size(202, 22);
         this.txtProvider.TabIndex = 3;
         // 
         // lkeEmployee
         // 
         this.lkeEmployee.CausesValidation = false;
         this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MANV", true));
         this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "MANV", true));
         this.lkeEmployee.Location = new System.Drawing.Point(287, 108);
         this.lkeEmployee.MenuManager = this.bmPN;
         this.lkeEmployee.Name = "lkeEmployee";
         this.lkeEmployee.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
         this.lkeEmployee.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lkeEmployee.Properties.Appearance.Options.UseFont = true;
         this.lkeEmployee.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
         this.lkeEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
         this.lkeEmployee.Properties.DataSource = this.bdsDSNV;
         this.lkeEmployee.Properties.DisplayMember = "HOTEN";
         this.lkeEmployee.Properties.NullText = "";
         this.lkeEmployee.Properties.PopupView = this.searchLookUpEdit1View;
         this.lkeEmployee.Properties.ReadOnly = true;
         this.lkeEmployee.Properties.ValueMember = "MANV";
         this.lkeEmployee.Size = new System.Drawing.Size(202, 22);
         this.lkeEmployee.TabIndex = 7;
         // 
         // bdsDSNV
         // 
         this.bdsDSNV.DataMember = "DSNV";
         this.bdsDSNV.DataSource = this.dataSet;
         // 
         // searchLookUpEdit1View
         // 
         this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
         this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
         this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
         this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
         // 
         // dtpOrderDate
         // 
         this.dtpOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAY", true));
         this.dtpOrderDate.EditValue = null;
         this.dtpOrderDate.Location = new System.Drawing.Point(287, 80);
         this.dtpOrderDate.MenuManager = this.bmPN;
         this.dtpOrderDate.Name = "dtpOrderDate";
         this.dtpOrderDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtpOrderDate.Properties.Appearance.Options.UseFont = true;
         this.dtpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpOrderDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.dtpOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpOrderDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
         this.dtpOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpOrderDate.Properties.Mask.EditMask = "dd/MM/yyyy";
         this.dtpOrderDate.Properties.ReadOnly = true;
         this.dtpOrderDate.Size = new System.Drawing.Size(202, 22);
         this.dtpOrderDate.TabIndex = 5;
         // 
         // gbOrderDetail
         // 
         this.gbOrderDetail.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbOrderDetail.AppearanceCaption.Options.UseFont = true;
         this.gbOrderDetail.CaptionImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_edit_property_16;
         this.gbOrderDetail.CaptionLocation = DevExpress.Utils.Locations.Top;
         this.gbOrderDetail.Controls.Add(this.gcOrderDetail);
         this.gbOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbOrderDetail.Location = new System.Drawing.Point(0, 0);
         this.gbOrderDetail.Name = "gbOrderDetail";
         this.gbOrderDetail.Size = new System.Drawing.Size(488, 164);
         this.gbOrderDetail.TabIndex = 0;
         this.gbOrderDetail.Text = "Chi tiết Đơn Đặt Hàng";
         // 
         // gcOrderDetail
         // 
         this.gcOrderDetail.AllowUserToAddRows = false;
         this.gcOrderDetail.AllowUserToDeleteRows = false;
         this.gcOrderDetail.AutoGenerateColumns = false;
         this.gcOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.gcOrderDetail.BackgroundColor = System.Drawing.Color.White;
         this.gcOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.gcOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gcOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.gcOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gcOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TENVT,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.gcOrderDetail.DataSource = this.bdsCTDDH;
         dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
         dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
         dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
         dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.gcOrderDetail.DefaultCellStyle = dataGridViewCellStyle6;
         this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrderDetail.EnableHeadersVisualStyles = false;
         this.gcOrderDetail.GridColor = System.Drawing.Color.Silver;
         this.gcOrderDetail.Location = new System.Drawing.Point(2, 23);
         this.gcOrderDetail.Name = "gcOrderDetail";
         this.gcOrderDetail.ReadOnly = true;
         this.gcOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gcOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
         this.gcOrderDetail.RowHeadersVisible = false;
         this.gcOrderDetail.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.gcOrderDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gcOrderDetail.Size = new System.Drawing.Size(484, 139);
         this.gcOrderDetail.TabIndex = 0;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridViewTextBoxColumn1.FillWeight = 121.8274F;
         this.dataGridViewTextBoxColumn1.HeaderText = "MÃ SỐ ĐƠN ĐẶT HÀNG";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         this.dataGridViewTextBoxColumn1.ReadOnly = true;
         // 
         // TENVT
         // 
         this.TENVT.DataPropertyName = "MAVT";
         this.TENVT.DataSource = this.bdsVT;
         dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TENVT.DefaultCellStyle = dataGridViewCellStyle3;
         this.TENVT.DisplayMember = "TENVT";
         this.TENVT.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
         this.TENVT.HeaderText = "TÊN VẬT TƯ";
         this.TENVT.Name = "TENVT";
         this.TENVT.ReadOnly = true;
         this.TENVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.TENVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.TENVT.ValueMember = "MAVT";
         // 
         // bdsVT
         // 
         this.bdsVT.DataMember = "Vattu";
         this.bdsVT.DataSource = this.dataSet;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
         dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
         this.dataGridViewTextBoxColumn3.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn3.HeaderText = "SỐ LƯỢNG";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
         dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle5.Format = "C0";
         dataGridViewCellStyle5.NullValue = null;
         this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
         this.dataGridViewTextBoxColumn4.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn4.HeaderText = "ĐƠN GIÁ";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.ReadOnly = true;
         // 
         // bdsCTDDH
         // 
         this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
         this.bdsCTDDH.DataSource = this.bdsDDH;
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(987, 30);
         this.pnPickDepartment.TabIndex = 0;
         this.pnPickDepartment.Visible = false;
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.Location = new System.Drawing.Point(12, 8);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(92, 15);
         this.labelControl1.TabIndex = 0;
         this.labelControl1.Text = "Chọn Chi Nhánh:";
         // 
         // cboDeployment
         // 
         this.cboDeployment.BackColor = System.Drawing.SystemColors.Window;
         this.cboDeployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDeployment.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.cboDeployment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboDeployment.FormattingEnabled = true;
         this.cboDeployment.Location = new System.Drawing.Point(110, 4);
         this.cboDeployment.Name = "cboDeployment";
         this.cboDeployment.Size = new System.Drawing.Size(193, 23);
         this.cboDeployment.TabIndex = 1;
         // 
         // taCTDDH
         // 
         this.taCTDDH.ClearBeforeFill = true;
         // 
         // taDSNV
         // 
         this.taDSNV.ClearBeforeFill = true;
         // 
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // taVT
         // 
         this.taVT.ClearBeforeFill = true;
         // 
         // taKho
         // 
         this.taKho.ClearBeforeFill = true;
         // 
         // frmOrders
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(987, 456);
         this.Controls.Add(this.gcOrder);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.sccOrder);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmOrders";
         this.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrders_FormClosing);
         this.Load += new System.EventHandler(this.frmOrders_Load);
         this.Resize += new System.EventHandler(this.frmOrders_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
         this.cmsOrderDetail.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sccOrder)).EndInit();
         this.sccOrder.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).EndInit();
         this.gbOrder.ResumeLayout(false);
         this.gbOrder.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtProvider.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).EndInit();
         this.gbOrderDetail.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager bmPN;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnRefresh;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private System.Windows.Forms.BindingSource bdsDDH;
      private DataSet dataSet;
      private DataSetTableAdapters.DatHangTableAdapter taDDH;
      private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private DevExpress.XtraGrid.GridControl gcOrder;
      private DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraEditors.SplitContainerControl sccOrder;
      private DevExpress.XtraEditors.GroupControl gbOrder;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DataSetTableAdapters.CTDDHTableAdapter taCTDDH;
      private System.Windows.Forms.DataGridView gcOrderDetail;
      private DevExpress.XtraEditors.TextEdit txtOrderId;
      private DevExpress.XtraEditors.DateEdit dtpOrderDate;
      private DevExpress.XtraEditors.TextEdit txtProvider;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private DevExpress.XtraEditors.GroupControl gbOrderDetail;
      private DevExpress.XtraEditors.SearchLookUpEdit lkeEmployee;
      private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private System.Windows.Forms.ContextMenuStrip cmsOrderDetail;
      private System.Windows.Forms.ToolStripMenuItem btnAddOrderDetail;
      private System.Windows.Forms.BindingSource bdsCTDDH;
      private DevExpress.XtraEditors.PictureEdit pictureEdit1;
      private System.Windows.Forms.BindingSource bdsVT;
      private DataSetTableAdapters.VattuTableAdapter taVT;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewComboBoxColumn TENVT;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
      private System.Windows.Forms.BindingSource bdsKho;
      private DataSetTableAdapters.DSKHOTableAdapter taKho;
      private DevExpress.XtraEditors.LookUpEdit lkeDepot;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
   }
}