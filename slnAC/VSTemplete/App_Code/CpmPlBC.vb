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

Public Class CpmPlBC
Public DA AS NEW CpmPlDA

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

Public Function SelCpmPl(Byval leagueName_key AS String, _
           Byval gameIdx_key AS String, _
           Byval companyName_key AS String, _
           Byval stEdFlg_key AS String) As Data.DataTable
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           leagueName_key, _
           gameIdx_key, _
           companyName_key, _
           stEdFlg_key)
    'SQLコメント
    Return DA.SelCpmPl( _
           leagueName_key, _
           gameIdx_key, _
           companyName_key, _
           stEdFlg_key)
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

Public Function UpdCpmPl(Byval leagueName_key AS String, _
           Byval gameIdx_key AS String, _
           Byval companyName_key AS String, _
           Byval stEdFlg_key AS String, _
           Byval leagueName AS String, _
           Byval gameIdx AS String, _
           Byval companyName AS String, _
           Byval stEdFlg AS String, _
           Byval plWin AS String, _
           Byval plDraw AS String, _
           Byval plLoss AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
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
    Return DA.UpdCpmPl( _
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

Public Function InsCpmPl(Byval leagueName AS String, _
           Byval gameIdx AS String, _
           Byval companyName AS String, _
           Byval stEdFlg AS String, _
           Byval plWin AS String, _
           Byval plDraw AS String, _
           Byval plLoss AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           leagueName, _
           gameIdx, _
           companyName, _
           stEdFlg, _
           plWin, _
           plDraw, _
           plLoss)
    'SQLコメント
    '--**テーブル： : cpm_pl
    Return DA.InsCpmPl( _
           leagueName, _
           gameIdx, _
           companyName, _
           stEdFlg, _
           plWin, _
           plDraw, _
           plLoss)

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

Public Function DelCpmPl(Byval leagueName_key AS String, _
           Byval gameIdx_key AS String, _
           Byval companyName_key AS String, _
           Byval stEdFlg_key AS String) As Boolean
    'EMAB障害対応情報の格納処理
    EMAB.AddMethodEntrance(MyClass.GetType.FullName & "." & MyMethod.GetCurrentMethod.Name , _
           leagueName_key, _
           gameIdx_key, _
           companyName_key, _
           stEdFlg_key)
    'SQLコメント
    '--**テーブル： : cpm_pl
    Return DA.DelCpmPl( _
           leagueName_key, _
           gameIdx_key, _
           companyName_key, _
           stEdFlg_key)


End Function

End Class
