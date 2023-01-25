namespace A01.Envanter.WindowsApp.Raporlar
{
    partial class BilgisayarListe
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
            this.dgwListele = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwListele
            // 
            this.dgwListele.Location = new System.Drawing.Point(12, 25);
            this.dgwListele.MainView = this.gridView1;
            this.dgwListele.Name = "dgwListele";
            this.dgwListele.Size = new System.Drawing.Size(1348, 533);
            this.dgwListele.TabIndex = 0;
            this.dgwListele.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgwListele;
            this.gridView1.Name = "gridView1";
            // 
            // BilgisayarListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 603);
            this.Controls.Add(this.dgwListele);
            this.Name = "BilgisayarListe";
            this.Text = "BilgisayarListe";
            this.Load += new System.EventHandler(this.BilgisayarListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgwListele;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}