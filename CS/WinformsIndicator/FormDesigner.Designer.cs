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
            this.dashboardDesigner = new DevExpress.DashboardWin.DashboardDesigner();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer
            // 
            this.dashboardDesigner.Dashboard = new Dashboard1();
            this.dashboardDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardDesigner.Location = new System.Drawing.Point(0, 0);
            this.dashboardDesigner.Name = "dashboardViewer";
            this.dashboardDesigner.Size = new System.Drawing.Size(800, 450);
            this.dashboardDesigner.TabIndex = 0;
            //this.dashboardViewer.CustomDashboardItemControlCreating += DashboardViewer_CustomDashboardItemControlCreating;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dashboardDesigner);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner)).EndInit();
            this.ResumeLayout(false);

        }

        private DashboardDesigner dashboardDesigner;

        #endregion
    }
}

