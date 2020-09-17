#pragma checksum "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "289a42ebf780993204467bfd5de32fbecc413804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Breakdown_Edit), @"mvc.1.0.view", @"/Views/Breakdown/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"289a42ebf780993204467bfd5de32fbecc413804", @"/Views/Breakdown/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b24579b6fae0907fd73060f5780441c4596bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Breakdown_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantMaintenanceCore.Models.ViewModels.EditBreakdownViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
  
    ViewData["Title"] = "Edit Breakdowns";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
 using (Html.BeginForm("Save", "Breakdown", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.PlantId,"Plant Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.DropDownListFor(x => x.PlantId, Model.Plants,"Select a Plant", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.PlantId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 15 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.MachineId,"Machine Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.DropDownListFor(x => x.MachineId, Model.Machines, "Select a Machine", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.MachineId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 19 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.BreakdownTypeId,"Breakdown Type"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 20 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.DropDownListFor(x => x.BreakdownTypeId, Model.BreakdownTypes, "Select a BreakdownType", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.BreakdownTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 23 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control",@placeholder="Enter an explicit definition of the breakdown" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 25 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 27 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.DeclareTime,"Declare Time"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 28 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.TextBoxFor(x => x.DeclareTime, "{0:yyyy-MM-dd}", new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.DeclareTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 31 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.PersonnelRequestingId,"Requesting Personnel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.DropDownListFor(x => x.PersonnelRequestingId, Model.PersonnelsRequesting, "Select a Personnel", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 33 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.PersonnelRequestingId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 35 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.PersonnelMaintenanceId,"Maintenance Personnel"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 36 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.DropDownListFor(x => x.PersonnelMaintenanceId, Model.PersonnelsRequesting, "Select a Personnel", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.PersonnelMaintenanceId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 39 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.DoneTime,"Completion Time"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.TextBoxFor(x => x.DoneTime, "{0:yyyy-MM-dd}", new { @class = "form-control", type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 41 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.DoneTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 43 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.LabelFor(x => x.Urgency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 44 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.DropDownListFor(x => x.Urgency, Model.Urgencies, "Select an Urgency", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 45 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.Urgency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"custom-radio\" style=\"margin-top: 25px;margin-bottom: 15px\">\r\n        <label>\r\n            ");
#nullable restore
#line 51 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsDone, true, new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Done\r\n        </label>\r\n        <label>\r\n            ");
#nullable restore
#line 54 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsDone, false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Waiting\r\n        </label>\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"custom-radio\" style=\"margin-top: 25px;margin-bottom: 15px\">\r\n        <label>\r\n            ");
#nullable restore
#line 60 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsActive, true, new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Active\r\n        </label>\r\n        <label>\r\n            ");
#nullable restore
#line 63 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsActive, false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Passive\r\n        </label>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 67 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\Breakdown\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "289a42ebf780993204467bfd5de32fbecc41380415293", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "289a42ebf780993204467bfd5de32fbecc41380416393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantMaintenanceCore.Models.ViewModels.EditBreakdownViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
