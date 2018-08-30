<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBoxPath = New System.Windows.Forms.TextBox()
        Me.ButtonCon = New System.Windows.Forms.Button()
        Me.TextBoxInfo = New System.Windows.Forms.TextBox()
        Me.TextBoxNid = New System.Windows.Forms.TextBox()
        Me.TextBoxBlock = New System.Windows.Forms.TextBox()
        Me.ButtonCal = New System.Windows.Forms.Button()
        Me.TextBoxKey = New System.Windows.Forms.TextBox()
        Me.ComboBoxFun = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBoxOutPut = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListViewOutPut = New System.Windows.Forms.ListView()
        Me.ColumnHeaderID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderBlock = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderInfo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBoxPath)
        Me.Panel1.Controls.Add(Me.ButtonCon)
        Me.Panel1.Controls.Add(Me.TextBoxInfo)
        Me.Panel1.Controls.Add(Me.TextBoxNid)
        Me.Panel1.Controls.Add(Me.TextBoxBlock)
        Me.Panel1.Controls.Add(Me.ButtonCal)
        Me.Panel1.Controls.Add(Me.TextBoxKey)
        Me.Panel1.Controls.Add(Me.ComboBoxFun)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 100)
        Me.Panel1.TabIndex = 0
        '
        'TextBoxPath
        '
        Me.TextBoxPath.Location = New System.Drawing.Point(442, 7)
        Me.TextBoxPath.Name = "TextBoxPath"
        Me.TextBoxPath.Size = New System.Drawing.Size(131, 26)
        Me.TextBoxPath.TabIndex = 8
        Me.TextBoxPath.Text = "{这里放Database_web的链接}/"
        '
        'ButtonCon
        '
        Me.ButtonCon.Location = New System.Drawing.Point(190, 70)
        Me.ButtonCon.Name = "ButtonCon"
        Me.ButtonCon.Size = New System.Drawing.Size(49, 26)
        Me.ButtonCon.TabIndex = 7
        Me.ButtonCon.Text = "连接"
        Me.ButtonCon.UseVisualStyleBackColor = True
        '
        'TextBoxInfo
        '
        Me.TextBoxInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxInfo.Location = New System.Drawing.Point(245, 38)
        Me.TextBoxInfo.Multiline = True
        Me.TextBoxInfo.Name = "TextBoxInfo"
        Me.TextBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxInfo.Size = New System.Drawing.Size(328, 58)
        Me.TextBoxInfo.TabIndex = 6
        '
        'TextBoxNid
        '
        Me.TextBoxNid.Location = New System.Drawing.Point(79, 70)
        Me.TextBoxNid.Name = "TextBoxNid"
        Me.TextBoxNid.Size = New System.Drawing.Size(105, 26)
        Me.TextBoxNid.TabIndex = 5
        '
        'TextBoxBlock
        '
        Me.TextBoxBlock.Location = New System.Drawing.Point(79, 38)
        Me.TextBoxBlock.Name = "TextBoxBlock"
        Me.TextBoxBlock.Size = New System.Drawing.Size(105, 26)
        Me.TextBoxBlock.TabIndex = 4
        '
        'ButtonCal
        '
        Me.ButtonCal.Location = New System.Drawing.Point(135, 6)
        Me.ButtonCal.Name = "ButtonCal"
        Me.ButtonCal.Size = New System.Drawing.Size(49, 26)
        Me.ButtonCal.TabIndex = 3
        Me.ButtonCal.Text = "计算"
        Me.ButtonCal.UseVisualStyleBackColor = True
        '
        'TextBoxKey
        '
        Me.TextBoxKey.Location = New System.Drawing.Point(79, 6)
        Me.TextBoxKey.Name = "TextBoxKey"
        Me.TextBoxKey.Size = New System.Drawing.Size(50, 26)
        Me.TextBoxKey.TabIndex = 2
        '
        'ComboBoxFun
        '
        Me.ComboBoxFun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFun.FormattingEnabled = True
        Me.ComboBoxFun.Items.AddRange(New Object() {"ReadAll", "ReadAllbyBlock", "Read", "Input", "Modify", "Append", "Delete", "DeleteID", "MaxID", "temporaty"})
        Me.ComboBoxFun.Location = New System.Drawing.Point(245, 7)
        Me.ComboBoxFun.Name = "ComboBoxFun"
        Me.ComboBoxFun.Size = New System.Drawing.Size(130, 24)
        Me.ComboBoxFun.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 80)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Key   :               Fun  :                  Path :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Block :               Inf" &
    "o :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nid   :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(585, 248)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBoxOutPut)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(577, 218)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "LPS输出"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TextBoxOutPut
        '
        Me.TextBoxOutPut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxOutPut.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxOutPut.Multiline = True
        Me.TextBoxOutPut.Name = "TextBoxOutPut"
        Me.TextBoxOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxOutPut.Size = New System.Drawing.Size(571, 212)
        Me.TextBoxOutPut.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ListViewOutPut)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(577, 218)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "表格"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ListViewOutPut
        '
        Me.ListViewOutPut.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderID, Me.ColumnHeaderBlock, Me.ColumnHeaderNid, Me.ColumnHeaderInfo})
        Me.ListViewOutPut.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewOutPut.FullRowSelect = True
        Me.ListViewOutPut.GridLines = True
        Me.ListViewOutPut.Location = New System.Drawing.Point(3, 3)
        Me.ListViewOutPut.MultiSelect = False
        Me.ListViewOutPut.Name = "ListViewOutPut"
        Me.ListViewOutPut.Size = New System.Drawing.Size(571, 212)
        Me.ListViewOutPut.TabIndex = 0
        Me.ListViewOutPut.UseCompatibleStateImageBehavior = False
        Me.ListViewOutPut.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderID
        '
        Me.ColumnHeaderID.Text = "ID"
        Me.ColumnHeaderID.Width = 50
        '
        'ColumnHeaderBlock
        '
        Me.ColumnHeaderBlock.Text = "Block"
        '
        'ColumnHeaderNid
        '
        Me.ColumnHeaderNid.Text = "Nid"
        '
        'ColumnHeaderInfo
        '
        Me.ColumnHeaderInfo.Text = "Info"
        Me.ColumnHeaderInfo.Width = 388
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 348)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMain"
        Me.Text = "数据库连接"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxOutPut As TextBox
    Friend WithEvents ListViewOutPut As ListView
    Friend WithEvents ColumnHeaderID As ColumnHeader
    Friend WithEvents ColumnHeaderBlock As ColumnHeader
    Friend WithEvents ColumnHeaderNid As ColumnHeader
    Friend WithEvents ColumnHeaderInfo As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxFun As ComboBox
    Friend WithEvents ButtonCal As Button
    Friend WithEvents TextBoxKey As TextBox
    Friend WithEvents TextBoxInfo As TextBox
    Friend WithEvents TextBoxNid As TextBox
    Friend WithEvents TextBoxBlock As TextBox
    Friend WithEvents ButtonCon As Button
    Friend WithEvents TextBoxPath As TextBox
End Class
