Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles

Module rmsModule

    Public Sub resetButtonColor()
        rmsDashboard.btnReservations.ForeColor = ColorTranslator.FromHtml("#151515")
        rmsDashboard.btnInventory.ForeColor = ColorTranslator.FromHtml("#151515")
        rmsDashboard.btnTGuides.ForeColor = ColorTranslator.FromHtml("#151515")
        rmsDashboard.btnCustomers.ForeColor = ColorTranslator.FromHtml("#151515")
        rmsDashboard.btnNotif.ForeColor = ColorTranslator.FromHtml("#151515")
        rmsDashboard.btnTransacHist.ForeColor = ColorTranslator.FromHtml("#151515")
        rmsDashboard.btnRules.ForeColor = ColorTranslator.FromHtml("#151515")

        rmsDashboard.btnReservations.BackColor = ColorTranslator.FromHtml("#f5f5f5")
        rmsDashboard.btnInventory.BackColor = ColorTranslator.FromHtml("#f5f5f5")
        rmsDashboard.btnTGuides.BackColor = ColorTranslator.FromHtml("#f5f5f5")
        rmsDashboard.btnCustomers.BackColor = ColorTranslator.FromHtml("#f5f5f5")
        rmsDashboard.btnNotif.BackColor = ColorTranslator.FromHtml("#f5f5f5")
        rmsDashboard.btnTransacHist.BackColor = ColorTranslator.FromHtml("#f5f5f5")
        rmsDashboard.btnRules.BackColor = ColorTranslator.FromHtml("#f5f5f5")
    End Sub

End Module
