<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GymWorkout.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Gym Workout Videos</title>
    <%--reset screen size to mobile--%>
    <meta name="viewport" content="width=device-width, initial-scale=1" /> 
    <%--stylesheet to enhance display --%>
    <link rel="stylesheet" href="resources/main.css" type="text/css" />
    <link href="resources/animate.css" rel="stylesheet" />
</head>
<body>
    
    <form id="form1" runat="server">
        <%-- insert Ajax to avoid flickering in IE --%>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
        <p class="pText">click on the muscle groups for videos and instructions, or click on the head and hands to reset the screen.</p>    
    </div>
        <%--import dummy image --%>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate> 
        <asp:ImageMap ID="ImageMap1" ImageUrl="~\images\imgAnatomy.jpg" runat="server"
            Height="500px" Width="468px" HotSpotMode="PostBack" OnClick="ImageMap1_Click">
          
        <%--set circle hotspots onto the dummy --%>

            <%--set circle hotspots onto hands and head *** PostBackValue="x" for Reset screen***   --%>
            <asp:CircleHotSpot X="82" Y="279" Radius="15" HotSpotMode="PostBack" PostBackValue="x" />
            <asp:CircleHotSpot X="175" Y="279" Radius="15" HotSpotMode="PostBack" PostBackValue="x" />
            <asp:CircleHotSpot X="291" Y="268" Radius="15" HotSpotMode="PostBack" PostBackValue="x" />
            <asp:CircleHotSpot X="384" Y="268" Radius="15" HotSpotMode="PostBack" PostBackValue="x" />
            <asp:CircleHotSpot X="130" Y="70" Radius="15" HotSpotMode="PostBack" PostBackValue="x" />
            <asp:CircleHotSpot X="340" Y="70" Radius="15" HotSpotMode="PostBack" PostBackValue="x" />


            <%--set circle hotspots onto biceps --%>
            <asp:CircleHotSpot X="90" Y="165" Radius="15" HotSpotMode="PostBack" PostBackValue="lB" />
            <asp:CircleHotSpot X="165" Y="165" Radius="15" HotSpotMode="PostBack" PostBackValue="rB" />
            <%--set circle hotspots onto chest --%>
            <asp:CircleHotSpot X="110" Y="145" Radius="15" HotSpotMode="PostBack" PostBackValue="lC" />
            <asp:CircleHotSpot X="135" Y="145" Radius="15" HotSpotMode="PostBack" PostBackValue="rC" />
             <%--set retangle hotspot onto abs --%>
            <asp:RectangleHotSpot Top="170" Right="140" Bottom="250" Left="113"  HotSpotMode="PostBack" PostBackValue="aB" />
            <%--set retangle hotspot onto squat --%>
            <asp:RectangleHotSpot Top="255" Right="120" Bottom="340" Left="95"  HotSpotMode="PostBack" PostBackValue="lQ" />
            <asp:RectangleHotSpot Top="253" Right="163" Bottom="339" Left="139"  HotSpotMode="PostBack" PostBackValue="rQ" />

        
        </asp:ImageMap>
        </ContentTemplate>
        </asp:UpdatePanel>
        <%--placeholder for instructions --%>  
        <asp:UpdatePanel ID="UpdatPanel1" runat="server">
            <ContentTemplate> 
                <asp:Panel cssClass="wow bounceInDown" ID="pnlTextMap" runat="server" text=""></asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <%--placeholder for video --%>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate> 
                <asp:Panel ID="pnlImageMap" runat="server" Height="244px" Width="362px" CssClass="imageFloat" ></asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
        <script src="vendors/wow.min.js"></script>
        <script>new WOW().init();</script>
    </form>
</body>
</html>
