<%@ Control Language="C#" AutoEventWireup="true" CodeFile="list-best.ascx.cs" Inherits="tour" %>

<%@ OutputCache Duration="864000" VaryByParam="*" %>
    <asp:Repeater ID="RepDetails" runat="server"    >
<HeaderTemplate>
    

   <div id="archives-3" class="widget widget_archive"><h4 class="widgettitle"><span>Best Attractions</span></h4>
       <div class="widgetcontent">  
       <ul>
</HeaderTemplate>

<ItemTemplate>


												
		<li>								
		

                
<asp:HyperLink ID="title" runat="server" Text='<%# Eval("biz_name") %>' NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "biz_name", "https://www.indiacitytrip.com/place-details.aspx?Name={0}") %>' ></asp:HyperLink> 

            </li>	


</ItemTemplate>



<FooterTemplate>

    </ul>
    </div>
    </div>

      <div align="right" class="xoxo blogroll"><a href="https://www.indiacitytrip.com/sitemap.aspx" >Full List</a></div> 	
</FooterTemplate>

            </asp:Repeater>
             
 
 
 
