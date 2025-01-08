Partial Class CategoryButton
    Inherits Guna.UI.WinForms.GunaButton

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()
        Me.AnimationHoverSpeed = 0.07!
        Me.AnimationSpeed = 0.03!
        Me.BaseColor = System.Drawing.Color.White
        Me.BorderColor = System.Drawing.SystemColors.Control
        Me.BorderSize = 3
        Me.DialogResult = System.Windows.Forms.DialogResult.None
        Me.FocusedColor = System.Drawing.Color.Empty
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Image = Nothing
        Me.ImageSize = New System.Drawing.Size(20, 20)
        Me.OnHoverBaseColor = Colors.brand
        Me.OnHoverBorderColor = System.Drawing.SystemColors.Control
        Me.OnHoverForeColor = System.Drawing.Color.White
        Me.OnHoverImage = Nothing
        Me.OnPressedColor = System.Drawing.Color.Black
        Me.Size = New System.Drawing.Size(140, 40)
        Me.TextAlign = System.Windows.Forms.HorizontalAlignment.Center

    End Sub

    'Component overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

End Class
