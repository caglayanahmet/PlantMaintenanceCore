#pragma checksum "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e71cc4e63b1da798a34f045c71881f01ce18ac8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Machine_Index), @"mvc.1.0.view", @"/Views/Machine/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\_ViewImports.cshtml"
using PlantMaintenanceCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\_ViewImports.cshtml"
using PlantMaintenanceCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e71cc4e63b1da798a34f045c71881f01ce18ac8", @"/Views/Machine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b24579b6fae0907fd73060f5780441c4596bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Machine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantMaintenanceCore.Models.ViewModels.DisplayMachineViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
  
    ViewData["Title"] = "Machine List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1>");
#nullable restore
#line 8 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        <a class=""btn btn-info"" href=""/Machine/Edit/"" style=""float:right; margin-bottom:30px;"">Add New</a>
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Plant</th>
                    <th>Machine Name</th>
                    <th>Description</th>
                    <th");
            BeginWriteAttribute("hidden", " hidden=\"", 605, "\"", 614, 0);
            EndWriteAttribute();
            WriteLiteral(">Status</th>\r\n                    <th style=\"width: 150px\">Action</th>\r\n\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                 foreach (var item in Model.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                       Write(item.Plant);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                       Write(item.MachineName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td");
            BeginWriteAttribute("hidden", " hidden=\"", 1072, "\"", 1081, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                                  Write(item.IsActive==true?"Active":"Passive");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1215, "\"", 1245, 3);
            WriteAttributeValue("", 1222, "/Machine/Edit/", 1222, 14, true);
#nullable restore
#line 32 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
WriteAttributeValue("", 1236, item.Id, 1236, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1244, "/", 1244, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"float:right;\">Edit</a>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1331, "\"", 1363, 3);
            WriteAttributeValue("", 1338, "/Machine/Delete/", 1338, 16, true);
#nullable restore
#line 33 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
WriteAttributeValue("", 1354, item.Id, 1354, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1362, "/", 1362, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"float:right;\">Delete</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Machine\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantMaintenanceCore.Models.ViewModels.DisplayMachineViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
