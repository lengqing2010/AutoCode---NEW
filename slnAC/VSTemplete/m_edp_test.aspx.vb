Imports System.Data
Imports System.Text
Imports System.IO
Imports EMAB = Itis.ApplicationBlocks.ExceptionManagement.UnTrappedExceptionManager
Imports MyMethod = System.Reflection.MethodBase
Partial Class m_edp_test
    Inherits System.Web.UI.Page

    Public BC As New MEdpTestBC
    ''' <summary>
    ''' PAGE LOAD
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        Me.lblMsg.Text = ""
        If Not IsPostBack Then
            '明細設定
            MsInit()
            Me.tbxedpNo.Attributes.Item("itType") = "nvarchar"
            Me.tbxedpNo.Attributes.Item("itLength") = "100"
            Me.tbxedpNo.Attributes.Item("itName") = "EDP NUMBER"
            Me.tbxedpMei.Attributes.Item("itType") = "nvarchar"
            Me.tbxedpMei.Attributes.Item("itLength") = "400"
            Me.tbxedpMei.Attributes.Item("itName") = "EDP 名"
            Me.tbxedpExp.Attributes.Item("itType") = "nvarchar"
            Me.tbxedpExp.Attributes.Item("itLength") = "2000"
            Me.tbxedpExp.Attributes.Item("itName") = "EDP 説明"
            Me.tbxidx.Attributes.Item("itType") = "int"
            Me.tbxidx.Attributes.Item("itLength") = "4"
            Me.tbxidx.Attributes.Item("itName") = "INDEX"
            Me.tbxstatus.Attributes.Item("itType") = "nchar"
            Me.tbxstatus.Attributes.Item("itLength") = "2"
            Me.tbxstatus.Attributes.Item("itName") = "ステータス       "
            Me.tbxstatus2.Attributes.Item("itType") = "nchar"
            Me.tbxstatus2.Attributes.Item("itLength") = "3"
            Me.tbxstatus2.Attributes.Item("itName") = "ステータス２"
            Me.tbxstatus3.Attributes.Item("itType") = "decimal"
            Me.tbxstatus3.Attributes.Item("itLength") = "3,2"
            Me.tbxstatus3.Attributes.Item("itName") = "ステータス３"
        End If

    End Sub
    ''' <summary>
    ''' 明細設定
    ''' </summary>
    Public Sub MsInit()
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
        MyMethod.GetCurrentMethod.Name)
        '明細設定
        Dim dt As DataTable = GetMsData()
        Me.gvMs.DataSource = dt
        Me.gvMs.DataBind()

    End Sub

    ''' <summary>
    ''' 検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnSelect_Click(sender As Object, e As System.EventArgs) Handles btnSelect.Click
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        MsInit()
    End Sub

    ''' <summary>
    ''' 明細データ取得
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetMsData() As Data.DataTable

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
        MyMethod.GetCurrentMethod.Name)
        Return BC.SelMEdpTest(tbxedpNo_key.Text)

    End Function

    ''' <summary>
    ''' 更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnUpdate_Click(sender As Object, e As System.EventArgs) Handles btnUpdate.Click

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        BC.UpdMEdpTest(hidedpNo.Text, tbxedpNo.Text, tbxedpMei.Text, tbxedpExp.Text, Convert.ToInt32(tbxidx.Text), tbxstatus.Text, tbxstatus2.Text, tbxstatus3.Text)
        MsInit()

    End Sub
    ''' <summary>
    ''' 登録
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnInsert_Click(sender As Object, e As System.EventArgs) Handles btnInsert.Click

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        BC.InsMEdpTest(tbxedpNo.Text, tbxedpMei.Text, tbxedpExp.Text, tbxidx.Text, tbxstatus.Text, tbxstatus2.Text, tbxstatus3.Text)
        MsInit()

    End Sub

    ''' <summary>
    ''' 削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub btnDelete_Click(sender As Object, e As System.EventArgs) Handles btnDelete.Click

        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(Request.ApplicationPath & "." & MyClass.GetType.BaseType.FullName & "." & _
                               MyMethod.GetCurrentMethod.Name)

        BC.DelMEdpTest(hidedpNo.Text)
        MsInit()
    End Sub

End Class
