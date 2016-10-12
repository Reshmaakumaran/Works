<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileComparer._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function selcompare(list) {
            //to highlight empty line
            if (list == 'Empty') {
                var span = "<span style='color:transparent;background-color:yellow'>" + list + "</span><br>";
                document.getElementById("divleftResult").innerHTML += span;

            }
            else {
            //to highlight diffrences
                var span = "<span style='background-color:red'>" + list + "</span><br>";
                document.getElementById("divleftResult").innerHTML += span;
            }
        }

        function selcompareR(listR) {

            //to highlight empty line
            if (listR == 'Empty') {
                var span = "<span style='color:transperent;background-color:yellow'>" + listR + "</span><br>";
                document.getElementById("divrighttResult").innerHTML += span;

            }
            else {
                //to highlight diffrences
                var input = document.getElementById("divrighttResult").innerHTML;
                var span = "<span style='background-color:green'>" + listR + "</span><br>";
                document.getElementById("divrighttResult").innerHTML += span;
            }

        }
    </script>
    <style type="text/css">
        #TextArea1
        {
            height: 254px;
            width: 612px;
        }
        #TextArea2
        {
            width: 544px;
            height: 322px;
        }
    </style>
</head>
<body style="height: 447px; width: 1308px">
    <form id="form1" runat="server">
    <div style="height: 49px">
        <asp:Label ID="Label1" runat="server" Text="Difference Checker" Style="text-align: center;
            padding-left: 550px"></asp:Label></div>
    <div>
        <textarea id="txtleftContent" cols="30" rows="1000" name="S1" style="height: 322px;
            width: 633px" runat="server"> </textarea><textarea id="txtrightContent" cols="30"
                rows="1000" style="height: 322px; width: 633px; margin-left: 15px;" runat="server"></textarea>
        <p style="width: 1298px">
            <asp:Button ID="btnfileCompare" runat="server" Text="Compare" Style="margin-left: 621px"
                OnClick="btnfileCompare_Click" />
        </p>
    </div>
    <div id="divleftResult" style="height: 272px; width: 614px; float: left; border-style: double;
        overflow: auto" runat="server">
    </div>
    <div id="divrighttResult" style="height: 272px; width: 644px; float: right; border-style: double;
        overflow: auto" runat="server">
    </div>
    </form>
</body>
</html>
