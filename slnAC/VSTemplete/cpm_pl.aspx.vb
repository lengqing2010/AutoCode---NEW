Imports System.Data
Imports System.Text
Imports System.IO
Imports EMAB = Itis.ApplicationBlocks.ExceptionManagement.UnTrappedExceptionManager
Imports MyMethod = System.Reflection.MethodBase
Partial Class cpm_pl
    Inherits System.Web.UI.Page

   Public BC AS NEW CpmPlBC
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
Me.tbxleagueName.Attributes.Item("itType") = "nvarchar"
Me.tbxleagueName.Attributes.Item("itLength") = "50"
Me.tbxleagueName.Attributes.Item("itName") = "league_name"
Me.tbxgameIdx.Attributes.Item("itType") = "int"
Me.tbxgameIdx.Attributes.Item("itLength") = "4"
Me.tbxgameIdx.Attributes.Item("itName") = "game_idx"
Me.tbxcompanyName.Attributes.Item("itType") = "nvarchar"
Me.tbxcompanyName.Attributes.Item("itLength") = "50"
Me.tbxcompanyName.Attributes.Item("itName") = "company_name"
Me.tbxstEdFlg.Attributes.Item("itType") = "nchar"
Me.tbxstEdFlg.Attributes.Item("itLength") = "1"
Me.tbxstEdFlg.Attributes.Item("itName") = "st_ed_flg"
Me.tbxplWin.Attributes.Item("itType") = "decimal"
Me.tbxplWin.Attributes.Item("itLength") = "9"
Me.tbxplWin.Attributes.Item("itName") = "pl_win"
Me.tbxplDraw.Attributes.Item("itType") = "decimal"
Me.tbxplDraw.Attributes.Item("itLength") = "9"
Me.tbxplDraw.Attributes.Item("itName") = "pl_draw"
Me.tbxplLoss.Attributes.Item("itType") = "decimal"
Me.tbxplLoss.Attributes.Item("itLength") = "9"
Me.tbxplLoss.Attributes.Item("itName") = "pl_loss"
        End If

    End Sub
    ''' <summary>
    ''' 明細設定
    ''' </summary>
    public Sub MsInit()
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
       Return BC.SelCpmPl(tbxleagueName_key.Text, tbxgameIdx_key.Text, tbxcompanyName_key.Text, tbxstEdFlg_key.Text)

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

       BC.UpdCpmPl(hidleagueName.Text, Convert.ToInt32(hidgameIdx.Text), hidcompanyName.Text, hidstEdFlg.Text,tbxleagueName.Text, Convert.ToInt32(tbxgameIdx.Text), tbxcompanyName.Text, tbxstEdFlg.Text, tbxplWin.Text, tbxplDraw.Text, tbxplLoss.Text)
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

       BC.InsCpmPl(tbxleagueName.Text, tbxgameIdx.Text, tbxcompanyName.Text, tbxstEdFlg.Text, tbxplWin.Text, tbxplDraw.Text, tbxplLoss.Text)
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

       BC.DelCpmPl(hidleagueName.Text, hidgameIdx.Text, hidcompanyName.Text, hidstEdFlg.Text)
        MsInit()
    End Sub

End Class
