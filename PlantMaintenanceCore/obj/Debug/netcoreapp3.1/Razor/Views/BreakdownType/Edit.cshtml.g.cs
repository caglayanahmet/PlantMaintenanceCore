#pragma checksum "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c6c327f097ed18ef0fb3049a2fa1f9fee98166a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BreakdownType_Edit), @"mvc.1.0.view", @"/Views/BreakdownType/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c6c327f097ed18ef0fb3049a2fa1f9fee98166a", @"/Views/BreakdownType/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2b24579b6fae0907fd73060f5780441c4596bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_BreakdownType_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlantMaintenanceCore.Models.ViewModels.BreakdownTypeViewModel>
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
#line 2 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
 using (Html.BeginForm("Save", "BreakdownType", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 11 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
   Write(Html.LabelFor(x => x.BreakdownTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
   Write(Html.TextBoxFor(x => x.BreakdownTypeName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.BreakdownTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n        ");
#nullable restore
#line 15 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
   Write(Html.LabelFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
   Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
   Write(Html.ValidationMessageFor(x => x.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <br />\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"custom-radio\" style=\"margin-top: 25px; margin-bottom: 15px\">\r\n        <label>\r\n            ");
#nullable restore
#line 23 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsActive, true, new { @checked = "checked" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Active\r\n        </label>\r\n        <label>\r\n            ");
#nullable restore
#line 26 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
       Write(Html.RadioButtonFor(m => m.IsActive, false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Passive\r\n        </label>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-info\">Save</button>\r\n");
#nullable restore
#line 30 "C:\Users\Ahmet C\Desktop\git\PlantMaintenanceCore\PlantMaintenanceCore\Views\BreakdownType\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c6c327f097ed18ef0fb3049a2fa1f9fee98166a7879", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c6c327f097ed18ef0fb3049a2fa1f9fee98166a8978", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlantMaintenanceCore.Models.ViewModels.BreakdownTypeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
