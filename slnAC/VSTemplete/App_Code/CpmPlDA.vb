Imports EMAB = Itis.ApplicationBlocks.ExceptionManagement.UnTrappedExceptionManager
Imports MyMethod = System.Reflection.MethodBase
Imports Itis.ApplicationBlocks.Data.SQLHelper
Imports Itis.ApplicationBlocks.Data
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Transactions
Imports System.Configuration.ConfigurationSettings
Imports System.Collections.Generic

Public Class CpmPlDA

    ''' <summary>
    ''' 
    ''' 情報を検索する
    ''' </summary>
    '''<param name="leagueName_key">league_name</param>
'''<param name="gameIdx_key">game_idx</param>
'''<param name="companyName_key">company_name</param>
'''<param name="stEdFlg_key">st_ed_flg</param>
    ''' <returns>情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelCpmPl(ByVal leagueName_key As String, _
           ByVal gameIdx_key As String, _
           ByVal companyName_key As String, _
           ByVal stEdFlg_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               leagueName_key, _
               gameIdx_key, _
               companyName_key, _
               stEdFlg_key)
        'SQLコメント
        '--**テーブル： : cpm_pl
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("league_name")                                                   'league_name
        sb.AppendLine(", game_idx")                                                    'game_idx
        sb.AppendLine(", company_name")                                                'company_name
        sb.AppendLine(", st_ed_flg")                                                   'st_ed_flg
        sb.AppendLine(", pl_win")                                                      'pl_win
        sb.AppendLine(", pl_draw")                                                     'pl_draw
        sb.AppendLine(", pl_loss")                                                     'pl_loss

        sb.AppendLine("FROM cpm_pl")
        sb.AppendLine("WHERE 1=1")
        If leagueName_key <> "" Then
            sb.AppendLine("AND league_name=@league_name_key")   'league_name
        End If
        If gameIdx_key <> "" Then
            sb.AppendLine("AND game_idx=@game_idx_key")   'game_idx
        End If
        If companyName_key <> "" Then
            sb.AppendLine("AND company_name=@company_name_key")   'company_name
        End If
        If stEdFlg_key <> "" Then
            sb.AppendLine("AND st_ed_flg=@st_ed_flg_key")   'st_ed_flg
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@league_name_key", SqlDbType.nvarchar, 50, leagueName_key))
        paramList.Add(MakeParam("@game_idx_key", SqlDbType.Int, 4, GetIntValue(gameIdx_key)))
        paramList.Add(MakeParam("@company_name_key", SqlDbType.nvarchar, 50, companyName_key))
        paramList.Add(MakeParam("@st_ed_flg_key", SqlDbType.nchar, 1, stEdFlg_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "cpm_pl", paramList.ToArray)

        Return dsInfo.Tables("cpm_pl")

    End Function

    ''' <summary>
    ''' 
    ''' 情報を更新する
    ''' </summary>
    '''<param name="leagueName_key">league_name</param>
    '''<param name="gameIdx_key">game_idx</param>
    '''<param name="companyName_key">company_name</param>
    '''<param name="stEdFlg_key">st_ed_flg</param>
    '''<param name="leagueName">league_name</param>
    '''<param name="gameIdx">game_idx</param>
    '''<param name="companyName">company_name</param>
    '''<param name="stEdFlg">st_ed_flg</param>
    '''<param name="plWin">pl_win</param>
    '''<param name="plDraw">pl_draw</param>
    '''<param name="plLoss">pl_loss</param>
    ''' <returns>情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function UpdCpmPl(ByVal leagueName_key As String, _
               ByVal gameIdx_key As String, _
               ByVal companyName_key As String, _
               ByVal stEdFlg_key As String, _
               ByVal leagueName As String, _
               ByVal gameIdx As String, _
               ByVal companyName As String, _
               ByVal stEdFlg As String, _
               ByVal plWin As String, _
               ByVal plDraw As String, _
               ByVal plLoss As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               leagueName_key, _
               gameIdx_key, _
               companyName_key, _
               stEdFlg_key, _
               leagueName, _
               gameIdx, _
               companyName, _
               stEdFlg, _
               plWin, _
               plDraw, _
               plLoss)
        'SQLコメント
        '--**テーブル： : cpm_pl
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("UPDATE cpm_pl")
        sb.AppendLine("SET")
        sb.AppendLine("league_name=@league_name")   'league_name
        sb.AppendLine(", game_idx=@game_idx")   'game_idx
        sb.AppendLine(", company_name=@company_name")   'company_name
        sb.AppendLine(", st_ed_flg=@st_ed_flg")   'st_ed_flg
        sb.AppendLine(", pl_win=@pl_win")                                              'pl_win
        sb.AppendLine(", pl_draw=@pl_draw")                                            'pl_draw
        sb.AppendLine(", pl_loss=@pl_loss")                                            'pl_loss

        sb.AppendLine("FROM cpm_pl")
        sb.AppendLine("WHERE 1=1")
        If leagueName_key <> "" Then
            sb.AppendLine("AND league_name=@league_name_key")   'league_name
        End If
        If gameIdx_key <> "" Then
            sb.AppendLine("AND game_idx=@game_idx_key")   'game_idx
        End If
        If companyName_key <> "" Then
            sb.AppendLine("AND company_name=@company_name_key")   'company_name
        End If
        If stEdFlg_key <> "" Then
            sb.AppendLine("AND st_ed_flg=@st_ed_flg_key")   'st_ed_flg
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@league_name_key", SqlDbType.nvarchar, 50, leagueName_key))
        paramList.Add(MakeParam("@game_idx_key", SqlDbType.Int, 4, GetIntValue(gameIdx_key)))
        paramList.Add(MakeParam("@company_name_key", SqlDbType.nvarchar, 50, companyName_key))
        paramList.Add(MakeParam("@st_ed_flg_key", SqlDbType.nchar, 1, stEdFlg_key))

        paramList.Add(MakeParam("@league_name", SqlDbType.nvarchar, 50, leagueName))
        paramList.Add(MakeParam("@game_idx", SqlDbType.Int, 4, GetIntValue(gameIdx)))
        paramList.Add(MakeParam("@company_name", SqlDbType.nvarchar, 50, companyName))
        paramList.Add(MakeParam("@st_ed_flg", SqlDbType.nchar, 1, stEdFlg))
        paramList.Add(MakeParam("@pl_win", SqlDbType.Decimal, 9, plWin))
        paramList.Add(MakeParam("@pl_draw", SqlDbType.Decimal, 9, plDraw))
        paramList.Add(MakeParam("@pl_loss", SqlDbType.Decimal, 9, plLoss))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 
    ''' 情報を登録する
    ''' </summary>
    '''<param name="leagueName">league_name</param>
    '''<param name="gameIdx">game_idx</param>
    '''<param name="companyName">company_name</param>
    '''<param name="stEdFlg">st_ed_flg</param>
    '''<param name="plWin">pl_win</param>
    '''<param name="plDraw">pl_draw</param>
    '''<param name="plLoss">pl_loss</param>
    ''' <returns>情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function InsCpmPl(ByVal leagueName As String, _
               ByVal gameIdx As String, _
               ByVal companyName As String, _
               ByVal stEdFlg As String, _
               ByVal plWin As String, _
               ByVal plDraw As String, _
               ByVal plLoss As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               leagueName, _
               gameIdx, _
               companyName, _
               stEdFlg, _
               plWin, _
               plDraw, _
               plLoss)
        'SQLコメント
        '--**テーブル： : cpm_pl
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("INSERT INTO  cpm_pl")
        sb.AppendLine("(")
        sb.AppendLine("league_name")                                                   'league_name
        sb.AppendLine(", game_idx")                                                    'game_idx
        sb.AppendLine(", company_name")                                                'company_name
        sb.AppendLine(", st_ed_flg")                                                   'st_ed_flg
        sb.AppendLine(", pl_win")                                                      'pl_win
        sb.AppendLine(", pl_draw")                                                     'pl_draw
        sb.AppendLine(", pl_loss")                                                     'pl_loss

        sb.AppendLine(")")
        sb.AppendLine("VALUES(")
        sb.AppendLine("@league_name")                                                  'league_name
        sb.AppendLine(", @game_idx")                                                   'game_idx
        sb.AppendLine(", @company_name")                                               'company_name
        sb.AppendLine(", @st_ed_flg")                                                  'st_ed_flg
        sb.AppendLine(", @pl_win")                                                     'pl_win
        sb.AppendLine(", @pl_draw")                                                    'pl_draw
        sb.AppendLine(", @pl_loss")                                                    'pl_loss

        sb.AppendLine(")")
        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@league_name", SqlDbType.nvarchar, 50, leagueName))
        paramList.Add(MakeParam("@game_idx", SqlDbType.Int, 4, GetIntValue(gameIdx)))
        paramList.Add(MakeParam("@company_name", SqlDbType.nvarchar, 50, companyName))
        paramList.Add(MakeParam("@st_ed_flg", SqlDbType.nchar, 1, stEdFlg))
        paramList.Add(MakeParam("@pl_win", SqlDbType.Decimal, 9, plWin))
        paramList.Add(MakeParam("@pl_draw", SqlDbType.Decimal, 9, plDraw))
        paramList.Add(MakeParam("@pl_loss", SqlDbType.Decimal, 9, plLoss))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' 
    ''' 情報を削除する
    ''' </summary>
    '''<param name="leagueName_key">league_name</param>
    '''<param name="gameIdx_key">game_idx</param>
    '''<param name="companyName_key">company_name</param>
    '''<param name="stEdFlg_key">st_ed_flg</param>
    ''' <returns>情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function DelCpmPl(ByVal leagueName_key As String, _
               ByVal gameIdx_key As String, _
               ByVal companyName_key As String, _
               ByVal stEdFlg_key As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               leagueName_key, _
               gameIdx_key, _
               companyName_key, _
               stEdFlg_key)
        'SQLコメント
        '--**テーブル： : cpm_pl
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("DELETE FROM cpm_pl")
        sb.AppendLine("WHERE 1=1")
        If leagueName_key <> "" Then
            sb.AppendLine("AND league_name=@league_name_key")   'league_name
        End If
        If gameIdx_key <> "" Then
            sb.AppendLine("AND game_idx=@game_idx_key")   'game_idx
        End If
        If companyName_key <> "" Then
            sb.AppendLine("AND company_name=@company_name_key")   'company_name
        End If
        If stEdFlg_key <> "" Then
            sb.AppendLine("AND st_ed_flg=@st_ed_flg_key")   'st_ed_flg
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@league_name_key", SqlDbType.nvarchar, 50, leagueName_key))
        paramList.Add(MakeParam("@game_idx_key", SqlDbType.Int, 4, GetIntValue(gameIdx_key)))
        paramList.Add(MakeParam("@company_name_key", SqlDbType.nvarchar, 50, companyName_key))
        paramList.Add(MakeParam("@st_ed_flg_key", SqlDbType.nchar, 1, stEdFlg_key))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' GetIntValue
    ''' </summary>
    ''' <param name="v"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetIntValue(ByVal v As Object) As Object
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name)
        If v Is DBNull.Value Or v.ToString = "" Then
            Return DBNull.Value

        Else
            Return Convert.ToInt32(v)
        End If

    End Function

End Class
