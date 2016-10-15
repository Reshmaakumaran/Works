<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FileComparer._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function selcompare(count) {
            var inputl = document.getElementById("txtleftContent");
            var inputr = document.getElementById("txtrightContent");
            var listl = inputl.innerText.split('\n');
            var listr = inputr.innerText.split('\n');
            var span = '';

            for (i = 0; i < count; i++) {
                if (listl[i] == null || listl[i].trim() == '') {
                    listl[i] = 'Empty';
                }

                if (listr[i] == null || listr[i].trim() == '') {
                    listr[i] = 'Empty';
                }
                if (listl[i].toString().trim() != listr[i].toString().trim()) {
                    //for left textarea
                    if (listl[i] == 'Empty') {
                        //to highlight empty line
                        span = "<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px;'>" + listl[i] + "</span><br>";
                        document.getElementById("divleftResult").innerHTML += span;
                    }
                    else {
                        span = "<span style='background-color:pink;border-color:white;border-style: solid;border-width: 1px;'>" + listl[i] + "</span><br>";
                        document.getElementById("divleftResult").innerHTML += span;
                    }
                    //for right textarea
                    if (listr[i] == 'Empty') {

                        //to highlight empty line
                        span = "<span style='color:transparent;background-color:grey;border-color:white;border-style: solid;border-width: 1px;'>" + listr[i] + "</span><br>";
                        document.getElementById("divrighttResult").innerHTML += span;
                    }
                    else {
                        span = "<span style='background-color:gold;border-color:white;border-style: solid;border-width: 1px;'>" + listr[i] + "</span><br>";
                        document.getElementById("divrighttResult").innerHTML += span;
                    }
                }
                else {
                    if (listl[i] == 'Empty' && listr[i] == 'Empty') {
                        span = "<span> </span><br>";
                        document.getElementById("divrighttResult").innerHTML += span;
                        span = "<span> </span><br>";
                        document.getElementById("divleftResult").innerHTML += span;
                    }
                    else {

                        divleftResult.innerHTML += "<span>" + listl[i] + "</span><br>";
                        divrighttResult.innerHTML += "<span>" + listr[i] + "</span><br>";
                    }
                }
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
