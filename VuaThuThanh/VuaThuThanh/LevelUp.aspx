﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LevelUp.aspx.cs" Inherits="VuaThuThanh.LevelUp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="Ext.net" Namespace="Ext.Net" TagPrefix="ext" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="Form1" runat="server">
    <ext:ResourceManager ID="ResourceManager1" runat="server" />
    <ext:Viewport ID="Viewport1" runat="server" Layout="FitLayout">
        <Items>
            <ext:Panel ID="Panel1" runat="server" Layout="FitLayout" Header="false" Border="false"
                BodyPadding="15">
                <Items>
                    <ext:Window ID="WindowLogin" runat="server" Layout="FitLayout" BodyPadding="5" Closable="false"
                        Resizable="false" Draggable="false" Modal="true" Title="Vua Thủ Thành">
                        <Items>
                            <ext:ComboBox ID="txtProfile" runat="server" Editable="false" EmptyText="Chọn Profile"
                                FieldLabel="Profile" LabelWidth="40">
                                <Items>
                                    <ext:ListItem Text="Tin" Value="tin" />
                                    <ext:ListItem Text="Thi" Value="thi" />
                                </Items>
                                <SelectedItems>
                                    <ext:ListItem Text="Tin" Value="tin" />
                                </SelectedItems>
                            </ext:ComboBox>
                        </Items>
                        <Buttons>
                            <ext:Button ID="Button1" runat="server" Text="Login" Icon="Accept">
                                <DirectEvents>
                                    <Click OnEvent="btnLogin_Click">
                                        <EventMask ShowMask="true" Msg="Đang đăng nhập" MinDelay="500" />
                                    </Click>
                                </DirectEvents>
                            </ext:Button>
                        </Buttons>
                    </ext:Window>
                </Items>
            </ext:Panel>
        </Items>
    </ext:Viewport>
    </form>
</body>
</html>
