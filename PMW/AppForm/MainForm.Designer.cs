
namespace PMW.AppForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.AdminAccordian = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MiantanaceAccordian = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.MachineryButton = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.NewMachineryIDButton = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.ListMachineryButton = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.AdminAccordian,
            this.MiantanaceAccordian});
            this.accordionControl1.Location = new System.Drawing.Point(540, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(260, 450);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // AdminAccordian
            // 
            this.AdminAccordian.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.AdminAccordian.Name = "AdminAccordian";
            this.AdminAccordian.Text = "مدیریت نرم افزار";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // MiantanaceAccordian
            // 
            this.MiantanaceAccordian.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.MachineryButton});
            this.MiantanaceAccordian.Expanded = true;
            this.MiantanaceAccordian.Name = "MiantanaceAccordian";
            this.MiantanaceAccordian.Text = "نگهداری تعمیرات";
            // 
            // MachineryButton
            // 
            this.MachineryButton.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.NewMachineryIDButton,
            this.ListMachineryButton,
            this.accordionControlElement5});
            this.MachineryButton.Expanded = true;
            this.MachineryButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MachineryButton.ImageOptions.Image")));
            this.MachineryButton.Name = "MachineryButton";
            this.MachineryButton.Text = "ماشین آلات";
            // 
            // NewMachineryIDButton
            // 
            this.NewMachineryIDButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NewMachineryIDButton.ImageOptions.Image")));
            this.NewMachineryIDButton.Name = "NewMachineryIDButton";
            this.NewMachineryIDButton.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.NewMachineryIDButton.Tag = ((short)(211));
            this.NewMachineryIDButton.Text = "شناسنامه جدید";
            this.NewMachineryIDButton.Click += new System.EventHandler(this.NewMachineryIDButton_Click);
            // 
            // ListMachineryButton
            // 
            this.ListMachineryButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement2.ImageOptions.Image")));
            this.ListMachineryButton.Name = "ListMachineryButton";
            this.ListMachineryButton.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.ListMachineryButton.Text = "لیست ماشین آلات";
            this.ListMachineryButton.Click += new System.EventHandler(this.ListMachineryButton_Click);
            // 
            // accordionControlElement5
            // 
            this.accordionControlElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement5.ImageOptions.Image")));
            this.accordionControlElement5.Name = "accordionControlElement5";
            this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement5.Text = "بازنگری و ابطال";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accordionControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement AdminAccordian;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MiantanaceAccordian;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement MachineryButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement NewMachineryIDButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement ListMachineryButton;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
    }
}