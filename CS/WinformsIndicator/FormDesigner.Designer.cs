using DevExpress.DashboardCommon.Native;
using DevExpress.DashboardWin;

namespace WinForm {
    partial class FormDesigner {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Dashboard = new Dashboard1();
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(800, 450);
            this.dashboardViewer.TabIndex = 0;
            //this.dashboardViewer.CustomDashboardItemControlCreating += DashboardViewer_CustomDashboardItemControlCreating;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashboardViewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            this.ResumeLayout(false);

        }

        private DashboardDesigner dashboardViewer;

        #endregion
    }
}

