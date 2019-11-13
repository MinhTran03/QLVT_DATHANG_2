﻿namespace QLVT_DATHANG.Forms
{
   partial class frmMain
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
         this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
         this.bsiMaNV = new DevExpress.XtraBars.BarStaticItem();
         this.bsiHoTenNV = new DevExpress.XtraBars.BarStaticItem();
         this.bsiNhom = new DevExpress.XtraBars.BarStaticItem();
         this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
         this.btnPN = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.btnDepot = new DevExpress.XtraBars.BarButtonItem();
         this.btnOrder = new DevExpress.XtraBars.BarButtonItem();
         this.btnRegister = new DevExpress.XtraBars.BarButtonItem();
         this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
         this.rbpCategory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
         this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
         this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
         this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
         this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // ribbonControl1
         // 
         this.ribbonControl1.ExpandCollapseItem.Id = 0;
         this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnNhanVien,
            this.bsiMaNV,
            this.bsiHoTenNV,
            this.bsiNhom,
            this.btnVatTu,
            this.btnPN,
            this.barButtonItem1,
            this.btnDepot,
            this.btnOrder,
            this.btnRegister});
         this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
         this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
         this.ribbonControl1.MaxItemId = 12;
         this.ribbonControl1.Name = "ribbonControl1";
         this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
         this.ribbonControl1.Size = new System.Drawing.Size(722, 143);
         this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
         // 
         // btnNhanVien
         // 
         this.btnNhanVien.Caption = "Nhân Viên";
         this.btnNhanVien.Hint = "Quản lý nhân viên";
         this.btnNhanVien.Id = 1;
         this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
         this.btnNhanVien.Name = "btnNhanVien";
         this.btnNhanVien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
         this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
         // 
         // bsiMaNV
         // 
         this.bsiMaNV.Caption = "MANV";
         this.bsiMaNV.Id = 2;
         this.bsiMaNV.Name = "bsiMaNV";
         // 
         // bsiHoTenNV
         // 
         this.bsiHoTenNV.Caption = "HOTENNV";
         this.bsiHoTenNV.Id = 3;
         this.bsiHoTenNV.Name = "bsiHoTenNV";
         // 
         // bsiNhom
         // 
         this.bsiNhom.Caption = "NHOM";
         this.bsiNhom.Id = 4;
         this.bsiNhom.Name = "bsiNhom";
         // 
         // btnVatTu
         // 
         this.btnVatTu.Caption = "Vật Tư";
         this.btnVatTu.Hint = "Quản Lý Vật Tư";
         this.btnVatTu.Id = 5;
         this.btnVatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.Image")));
         this.btnVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.LargeImage")));
         this.btnVatTu.Name = "btnVatTu";
         this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
         // 
         // btnPN
         // 
         this.btnPN.Caption = "Phiếu Xuất";
         this.btnPN.Id = 6;
         this.btnPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPN.ImageOptions.SvgImage")));
         this.btnPN.Name = "btnPN";
         this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPN_ItemClick);
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "Phiếu Nhập";
         this.barButtonItem1.Id = 7;
         this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
         this.barButtonItem1.Name = "barButtonItem1";
         this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
         // 
         // btnDepot
         // 
         this.btnDepot.Caption = "Kho";
         this.btnDepot.Id = 8;
         this.btnDepot.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDepot.ImageOptions.SvgImage")));
         this.btnDepot.Name = "btnDepot";
         this.btnDepot.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnDepot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDepot_ItemClick);
         // 
         // btnOrder
         // 
         this.btnOrder.Caption = "Đặt Hàng";
         this.btnOrder.Id = 10;
         this.btnOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrder.ImageOptions.SvgImage")));
         this.btnOrder.Name = "btnOrder";
         this.btnOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrder_ItemClick);
         // 
         // btnRegister
         // 
         this.btnRegister.Caption = "Đăng Ký Tài Khoản";
         this.btnRegister.Id = 11;
         this.btnRegister.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRegister.ImageOptions.SvgImage")));
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegister_ItemClick);
         // 
         // ribbonPage1
         // 
         this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpCategory});
         this.ribbonPage1.Name = "ribbonPage1";
         this.ribbonPage1.Text = "TRANG CHÍNH";
         // 
         // rbpCategory
         // 
         this.rbpCategory.ItemLinks.Add(this.btnNhanVien);
         this.rbpCategory.ItemLinks.Add(this.btnVatTu);
         this.rbpCategory.ItemLinks.Add(this.btnDepot);
         this.rbpCategory.ItemLinks.Add(this.btnRegister);
         this.rbpCategory.Name = "rbpCategory";
         this.rbpCategory.Text = "DANH MỤC";
         // 
         // ribbonPage2
         // 
         this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
         this.ribbonPage2.Name = "ribbonPage2";
         this.ribbonPage2.Text = "ĐẶT HÀNG";
         // 
         // ribbonPageGroup1
         // 
         this.ribbonPageGroup1.ItemLinks.Add(this.btnOrder);
         this.ribbonPageGroup1.ItemLinks.Add(this.btnPN);
         this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
         this.ribbonPageGroup1.Name = "ribbonPageGroup1";
         this.ribbonPageGroup1.Text = "LẬP PHIẾU";
         // 
         // ribbonStatusBar1
         // 
         this.ribbonStatusBar1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ribbonStatusBar1.ItemLinks.Add(this.bsiMaNV);
         this.ribbonStatusBar1.ItemLinks.Add(this.bsiHoTenNV);
         this.ribbonStatusBar1.ItemLinks.Add(this.bsiNhom);
         this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 422);
         this.ribbonStatusBar1.Name = "ribbonStatusBar1";
         this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
         this.ribbonStatusBar1.Size = new System.Drawing.Size(722, 31);
         // 
         // xtraTabbedMdiManager1
         // 
         this.xtraTabbedMdiManager1.MdiParent = this;
         // 
         // frmMain
         // 
         this.Appearance.Options.UseFont = true;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(722, 453);
         this.Controls.Add(this.ribbonStatusBar1);
         this.Controls.Add(this.ribbonControl1);
         this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.IsMdiContainer = true;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmMain";
         this.Ribbon = this.ribbonControl1;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.StatusBar = this.ribbonStatusBar1;
         this.Text = "QUẢN LÝ VẬT TƯ ĐẶT HÀNG";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.Load += new System.EventHandler(this.frmMain_Load);
         ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
      private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpCategory;
      private DevExpress.XtraBars.BarButtonItem btnNhanVien;
      private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
      private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
      private DevExpress.XtraBars.BarStaticItem bsiMaNV;
      private DevExpress.XtraBars.BarStaticItem bsiHoTenNV;
      private DevExpress.XtraBars.BarStaticItem bsiNhom;
      private DevExpress.XtraBars.BarButtonItem btnVatTu;
      private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
      private DevExpress.XtraBars.BarButtonItem btnPN;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      private DevExpress.XtraBars.BarButtonItem btnDepot;
      private DevExpress.XtraBars.BarButtonItem btnOrder;
      private DevExpress.XtraBars.BarButtonItem btnRegister;
   }
}
