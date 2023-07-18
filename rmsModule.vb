﻿Imports System.Drawing.Imaging
Imports System.Windows.Forms.VisualStyles

Module rmsModule

    Public Sub resetButtonColor()
        Dim defaultForeColor As Color = ColorTranslator.FromHtml("#f5f5f5")
        Dim defaultBackColor As Color = ColorTranslator.FromHtml("#1e272e")

        Dim buttons As Button() = {
            rmsDashboard.btnReservations,
            rmsDashboard.btnInventory,
            rmsDashboard.btnTGuides,
            rmsDashboard.btnCustomers,
            rmsDashboard.btnNotif,
            rmsDashboard.btnTransacHist,
            rmsDashboard.btnRules
        }
        For Each btn In buttons
            btn.ForeColor = defaultForeColor
            btn.BackColor = defaultBackColor
        Next
    End Sub

    Public Sub clearLoginForm()
        rmsLogin.tboxUsername.Clear()
        rmsLogin.tboxPassword.Clear()
        rmsLogin.tboxRFID.Clear()
    End Sub

End Module
