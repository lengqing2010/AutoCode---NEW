<%@ Page Language="VB" AutoEventWireup="false" CodeFile="cpm_pl.aspx.vb" Inherits="cpm_pl" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="tmp.css" rel="stylesheet" type="text/css" />
    <title>cpm_pl</title>
<script language="javascript" type="text/javascript" src="js/jquery-1.4.1.min.js"></script>
<script language="javascript" type="text/javascript" src="JidouTemp.js"></script>
</head>
<body>
<form id="form1" runat="server">
  <div>
      <div class='title_div'>cpm_pl</div>
      <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
  <hr />
      <table class='' cellpadding="0" cellspacing="0">
          <tr>
          <td>
              league_name : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxleagueName_key" class="" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          </tr>
          <tr>
          <td>
              game_idx : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxgameIdx_key" class="" runat="server" style="width:64px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          </tr>
          <tr>
          <td>
              company_name : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxcompanyName_key" class="" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          </tr>
          <tr>
          <td>
              st_ed_flg : &nbsp;
          </td>
          <td>
              <asp:TextBox ID="tbxstEdFlg_key" class="" runat="server" style="width:20px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          </tr>
      </table>
 <br /> <hr />
        <asp:Button ID="btnSelect" runat="server" Text="Select" CssClass="jq_sel" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="jq_upd" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" CssClass="jq_ins" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="jq_del" />
 <br /> <hr />
      <table class='ms_title' style="width:1000px" cellpadding="0" cellspacing="0">
          <tr>
              <td style="width:210px;">
                  league_name
              </td>
              <td style="width:74px;">
                  game_idx
              </td>
              <td style="width:210px;">
                  company_name
              </td>
              <td style="width:30px;">
                  st_ed_flg
              </td>
              <td style="width:154px;">
                  pl_win
              </td>
              <td style="width:154px;">
                  pl_draw
              </td>
              <td style="">
                  pl_loss
              </td>
          </tr>
          <tr>
          <td style="width:210px;">
              <asp:TextBox ID="tbxleagueName" class="jq_league_name_ipt" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td style="width:74px;">
              <asp:TextBox ID="tbxgameIdx" class="jq_game_idx_ipt" runat="server" style="width:64px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td style="width:210px;">
              <asp:TextBox ID="tbxcompanyName" class="jq_company_name_ipt" runat="server" style="width:200px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td style="width:30px;">
              <asp:TextBox ID="tbxstEdFlg" class="jq_st_ed_flg_ipt" runat="server" style="width:20px;background-color: #FFAA00;"></asp:TextBox>
          </td>
          <td style="width:154px;">
              <asp:TextBox ID="tbxplWin" class="jq_pl_win_ipt" runat="server" style="width:144px;"></asp:TextBox>
          </td>
          <td style="width:154px;">
              <asp:TextBox ID="tbxplDraw" class="jq_pl_draw_ipt" runat="server" style="width:144px;"></asp:TextBox>
          </td>
          <td style="">
              <asp:TextBox ID="tbxplLoss" class="jq_pl_loss_ipt" runat="server" style="width:144px;"></asp:TextBox>
          </td>
          </tr>
      </table>
<div id="divGvw" class='jq_ms_div' runat ="server" style="overflow:auto ; height:294px;margin-left:0px; width:1020px; margin-top :0px; border-collapse :collapse ;">
   <asp:GridView CssClass ="jq_ms" Width="1000px"  runat="server" ID="gvMs" EnableTheming="True" ShowHeader="False" AutoGenerateColumns="False" BorderColor="black" CellPadding="0" CellSpacing ="0" style=" margin-top :-1px; " TabIndex="-1" >
      <Columns>
          <asp:TemplateField><ItemTemplate ><%#Eval("league_name")%></ItemTemplate><ItemStyle Height="20px" Width="210px" HorizontalAlign="Left" CssClass="jq_league_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("game_idx")%></ItemTemplate><ItemStyle Height="20px" Width="74px" HorizontalAlign="Left" CssClass="jq_game_idx" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("company_name")%></ItemTemplate><ItemStyle Height="20px" Width="210px" HorizontalAlign="Left" CssClass="jq_company_name" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("st_ed_flg")%></ItemTemplate><ItemStyle Height="20px" Width="30px" HorizontalAlign="Left" CssClass="jq_st_ed_flg" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("pl_win")%></ItemTemplate><ItemStyle Height="20px" Width="154px" HorizontalAlign="Left" CssClass="jq_pl_win" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("pl_draw")%></ItemTemplate><ItemStyle Height="20px" Width="154px" HorizontalAlign="Left" CssClass="jq_pl_draw" /></asp:TemplateField>
          <asp:TemplateField><ItemTemplate ><%#Eval("pl_loss")%></ItemTemplate><ItemStyle Height="20px"  HorizontalAlign="Left" CssClass="jq_pl_loss" /></asp:TemplateField>
      </Columns>
   </asp:GridView>
</div>
<asp:TextBox ID="hidleagueName" runat="server" class="jq_league_name_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidgameIdx" runat="server" class="jq_game_idx_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidcompanyName" runat="server" class="jq_company_name_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidstEdFlg" runat="server" class="jq_st_ed_flg_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidplWin" runat="server" class="jq_pl_win_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidplDraw" runat="server" class="jq_pl_draw_ipt" style=" visibility:hidden;"></asp:TextBox>
<asp:TextBox ID="hidplLoss" runat="server" class="jq_pl_loss_ipt" style=" visibility:hidden;"></asp:TextBox>
    </div>
    </form>
</body>
</html>
