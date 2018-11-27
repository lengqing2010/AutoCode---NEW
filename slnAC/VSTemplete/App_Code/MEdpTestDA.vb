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

Public Class MEdpTestDA

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を検索する
    ''' </summary>
    '''<param name="edpNo_key">EDP NUMBER</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function SelMEdpTest(ByVal edpNo_key As String) As Data.DataTable
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               edpNo_key)
        'SQLコメント
        '--**テーブル：EDP情報 : m_edp_test
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("SELECT")
        sb.AppendLine("edp_no")                                                        'EDP NUMBER
        sb.AppendLine(", edp_mei")                                                     'EDP 名
        sb.AppendLine(", edp_exp")                                                     'EDP 説明
        sb.AppendLine(", idx")                                                         'INDEX
        sb.AppendLine(", status")                                                      'ステータス       
        sb.AppendLine(", status2")                                                     'ステータス２
        sb.AppendLine(", status3")                                                     'ステータス３

        sb.AppendLine("FROM m_edp_test")
        sb.AppendLine("WHERE 1=1")
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP NUMBER
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 100, edpNo_key))

        Dim dsInfo As New Data.DataSet
        FillDataset(DataAccessManager.Connection, CommandType.Text, sb.ToString(), dsInfo, "m_edp_test", paramList.ToArray)

        Return dsInfo.Tables("m_edp_test")

    End Function

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を更新する
    ''' </summary>
    '''<param name="edpNo_key">EDP NUMBER</param>
    '''<param name="edpNo">EDP NUMBER</param>
    '''<param name="edpMei">EDP 名</param>
    '''<param name="edpExp">EDP 説明</param>
    '''<param name="idx">INDEX</param>
    '''<param name="status">ステータス       </param>
    '''<param name="status2">ステータス２</param>
    '''<param name="status3">ステータス３</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function UpdMEdpTest(ByVal edpNo_key As String, _
               ByVal edpNo As String, _
               ByVal edpMei As String, _
               ByVal edpExp As String, _
               ByVal idx As String, _
               ByVal status As String, _
               ByVal status2 As String, _
               ByVal status3 As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               edpNo_key, _
               edpNo, _
               edpMei, _
               edpExp, _
               idx, _
               status, _
               status2, _
               status3)
        'SQLコメント
        '--**テーブル：EDP情報 : m_edp_test
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("UPDATE m_edp_test")
        sb.AppendLine("SET")
        sb.AppendLine("edp_no=@edp_no")                                                'EDP NUMBER
        sb.AppendLine(", edp_mei=@edp_mei")                                            'EDP 名
        sb.AppendLine(", edp_exp=@edp_exp")                                            'EDP 説明
        sb.AppendLine(", idx=@idx")                                                    'INDEX
        sb.AppendLine(", status=@status")                                              'ステータス       
        sb.AppendLine(", status2=@status2")                                            'ステータス２
        sb.AppendLine(", status3=@status3")                                            'ステータス３

        sb.AppendLine("FROM m_edp_test")
        sb.AppendLine("WHERE 1=1")
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP NUMBER
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 100, edpNo_key))

        paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 100, edpNo))
        paramList.Add(MakeParam("@edp_mei", SqlDbType.nvarchar, 400, edpMei))
        paramList.Add(MakeParam("@edp_exp", SqlDbType.nvarchar, 2000, edpExp))
        paramList.Add(MakeParam("@idx", SqlDbType.Int, 4, idx))
        paramList.Add(MakeParam("@status", SqlDbType.nchar, 2, status))
        paramList.Add(MakeParam("@status2", SqlDbType.nchar, 3, status2))
        paramList.Add(MakeParam("@status3", SqlDbType.Decimal, 3, status3))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を登録する
    ''' </summary>
    '''<param name="edpNo">EDP NUMBER</param>
    '''<param name="edpMei">EDP 名</param>
    '''<param name="edpExp">EDP 説明</param>
    '''<param name="idx">INDEX</param>
    '''<param name="status">ステータス       </param>
    '''<param name="status2">ステータス２</param>
    '''<param name="status3">ステータス３</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function InsMEdpTest(ByVal edpNo As String, _
               ByVal edpMei As String, _
               ByVal edpExp As String, _
               ByVal idx As String, _
               ByVal status As String, _
               ByVal status2 As String, _
               ByVal status3 As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               edpNo, _
               edpMei, _
               edpExp, _
               idx, _
               status, _
               status2, _
               status3)
        'SQLコメント
        '--**テーブル：EDP情報 : m_edp_test
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("INSERT INTO  m_edp_test")
        sb.AppendLine("(")
        sb.AppendLine("edp_no")                                                        'EDP NUMBER
        sb.AppendLine(", edp_mei")                                                     'EDP 名
        sb.AppendLine(", edp_exp")                                                     'EDP 説明
        sb.AppendLine(", idx")                                                         'INDEX
        sb.AppendLine(", status")                                                      'ステータス       
        sb.AppendLine(", status2")                                                     'ステータス２
        sb.AppendLine(", status3")                                                     'ステータス３

        sb.AppendLine(")")
        sb.AppendLine("VALUES(")
        sb.AppendLine("@edp_no")                                                       'EDP NUMBER
        sb.AppendLine(", @edp_mei")                                                    'EDP 名
        sb.AppendLine(", @edp_exp")                                                    'EDP 説明
        sb.AppendLine(", @idx")                                                        'INDEX
        sb.AppendLine(", @status")                                                     'ステータス       
        sb.AppendLine(", @status2")                                                    'ステータス２
        sb.AppendLine(", @status3")                                                    'ステータス３

        sb.AppendLine(")")
        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@edp_no", SqlDbType.nvarchar, 100, edpNo))
        paramList.Add(MakeParam("@edp_mei", SqlDbType.nvarchar, 400, edpMei))
        paramList.Add(MakeParam("@edp_exp", SqlDbType.nvarchar, 2000, edpExp))
        paramList.Add(MakeParam("@idx", SqlDbType.Int, 4, idx))
        paramList.Add(MakeParam("@status", SqlDbType.nchar, 2, status))
        paramList.Add(MakeParam("@status2", SqlDbType.nchar, 3, status2))
        paramList.Add(MakeParam("@status3", SqlDbType.Decimal, 3, status3))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

    ''' <summary>
    ''' aaaa
    ''' EDP情報情報を削除する
    ''' </summary>
    '''<param name="edpNo_key">EDP NUMBER</param>
    ''' <returns>EDP情報情報</returns>
    ''' <remarks></remarks>
    ''' <history>
    ''' <para>2018/11/20  李松涛さん 新規作成 </para>
    ''' </history>

    Public Function DelMEdpTest(ByVal edpNo_key As String) As Boolean
        'EMAB障害対応情報の格納処理
        EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name, _
               edpNo_key)
        'SQLコメント
        '--**テーブル：EDP情報 : m_edp_test
        Dim sb As New StringBuilder
        'SQL文
        sb.AppendLine("DELETE FROM m_edp_test")
        sb.AppendLine("WHERE 1=1")
        If edpNo_key <> "" Then
            sb.AppendLine("AND edp_no=@edp_no_key")   'EDP NUMBER
        End If

        'バラメタ格納
        Dim paramList As New List(Of SqlParameter)
        paramList.Add(MakeParam("@edp_no_key", SqlDbType.nvarchar, 100, edpNo_key))


        SQLHelper.ExecuteNonQuery(DataAccessManager.Connection, CommandType.Text, sb.ToString(), paramList.ToArray)

        Return True

    End Function

End Class
