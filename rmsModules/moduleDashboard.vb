Imports MongoDB.Bson
Imports MongoDB.Driver
Imports System.Globalization

Module moduleDashboard

    Public Sub resetButtonColor()
        Dim defaultForeColor As Color = ColorTranslator.FromHtml("#f5f5f5")
        Dim defaultBackColor As Color = ColorTranslator.FromHtml("#1e272e")
        Dim buttons As Button() = {
            rmsDashboard.btnReservations,
            rmsDashboard.btnTrails,
            rmsDashboard.btnInventory,
            rmsDashboard.btnTGuides,
            rmsDashboard.btnCustomers,
            rmsDashboard.btnNotif,
            rmsDashboard.btnOverview,
            rmsDashboard.btnRules
        }
        'rmsDashboard.btnAdminSettings
        For Each btn In buttons
            btn.ForeColor = defaultForeColor
            btn.BackColor = defaultBackColor
        Next
    End Sub

    Public Sub activeButtonColor(sender As Object, e As EventArgs)
        Dim activeBtn As Button = CType(sender, Button)
        activeBtn.ForeColor = ColorTranslator.FromHtml("#151515")
        activeBtn.BackColor = ColorTranslator.FromHtml("#ffc048")
    End Sub


End Module