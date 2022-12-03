<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="trying.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="./style/main.css" />
    <style type="text/css">
        .panel {
            margin-top: 0px;
        }

        .btn {
            background:#FFCC00;
            color: black;
            font-family: 'Century Gothic';
            font-size: 2.5em;
            border: 1px solid black;
            border-radius: 8px;
            cursor: pointer;
        }

        .button:hover {
    
    border-radius: 10px;
    font-size: 1.8em;
        }

        .name {
            font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
            font-size: 1em;
            color:crimson;
        }

        .display {
            background-color: #FFAA55;
            color: white;
            border: 2px solid #FF8000;
            border-radius: 4px;
            padding: .5em;
            margin: .2% auto;
            width: 100%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="header" style="margin: 0px 5px 0px 0px; padding: 15px; font-family: 'Century Gothic'; font-size: 30px; font-weight: bold; font-style: normal; font-variant: normal; text-transform: uppercase; color: #FFFFFF; letter-spacing: .2em; background-color: #A23D43; height: 57px; display: block; text-decoration: none; width: 100%;">
    
        <p style="width: 612px; height: 52px; margin-left: 200px">
    
        Welcome To My Ugly SIte

        </p>


             


    </div>

        <div class="mid">

            <div id="name">

            <asp:Label ID="display"  runat="server" CssClass="display"></asp:Label>

            </div>

            <asp:TextBox ID="content" runat="server" Height="43px" Width="441px" Font-Names="Century Gothic" Font-Size="14pt" CssClass="name"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Click ME" Width="125px" OnClick="Button1_Click" BackColor="#163F54" BorderStyle="None" Font-Bold="True" Font-Names="Century Gothic" Font-Size="14pt" ForeColor="White" Height="49px" />
            <br /> <br />
        

        </div>

        <div class="counter">
            

            <div id="number">
                <asp:Label ID="no" Text="0" runat="server"></asp:Label>
            </div>

            <div id="btn">
                <asp:Button Text="Click" OnClick="increment" runat="server" CssClass="btn" Height="66px" Width="100%" />
            </div>

        </div>

    </form>
    </body>
</html>

