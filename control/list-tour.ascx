<%@ Control Language="C#" AutoEventWireup="true" CodeFile="list-tour.ascx.cs" Inherits="tour" %>

<%@ OutputCache Duration="864000" VaryByParam="*" %>
    <asp:Repeater ID="RepDetails" runat="server"    >
<HeaderTemplate>
    

   <div id="archives-3" class="widget widget_archive"><h4 class="widgettitle"><span>Best Trip</span></h4>
       <div class="widgetcontent">  
       <ul>
</HeaderTemplate>

<ItemTemplate>


												
		<li>								
		<asp:hyperlink ID="title"  runat="server" Text='<%# Eval("trip_name") %>' NavigateUrl='<%#  Eval("trip_name") %>' >         
            </asp:hyperlink>
            </li>	


</ItemTemplate>



<FooterTemplate>

    </ul>
    </div>
    </div>

</FooterTemplate>

            </asp:Repeater>
             
 
 
 
