#pragma checksum "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35e52292a22fe2fdf7e5ad1f4bf86535604c8dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin1_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin1/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin1/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin1_Views_Home_Index))]
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
#line 1 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\_ViewImports.cshtml"
using NaturalCosmetics;

#line default
#line hidden
#line 2 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\_ViewImports.cshtml"
using NaturalCosmetics.Models;

#line default
#line hidden
#line 3 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\_ViewImports.cshtml"
using NaturalCosmetics.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35e52292a22fe2fdf7e5ad1f4bf86535604c8dc9", @"/Areas/Admin1/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6af8b44933eefa1897bfcdf9a4024708a0fc60d", @"/Areas/Admin1/Views/_ViewImports.cshtml")]
    public class Areas_Admin1_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NaturalCosmetics.Areas.Admin1.Models.ListIdentityUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link btn-no-effect btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
  
    var i = 0;
    var ListRole = ViewBag.ListRole;

#line default
#line hidden
            BeginContext(123, 13, true);
            WriteLiteral("\r\n<h2>Count: ");
            EndContext();
            BeginContext(137, 22, false);
#line 7 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
      Write(Model.ListUser.Count());

#line default
#line hidden
            EndContext();
            BeginContext(159, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
            EndContext();
            BeginContext(168, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61d93bba2afa4cf3b6aaa7b11b7eaab7", async() => {
                BeginContext(265, 15, true);
                WriteLiteral("Create new User");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(284, 233, true);
            WriteLiteral("\r\n\r\n<table class=\"table table-striped table-hover \">\r\n    <thead>\r\n        <tr>\r\n            <th>ID</th>\r\n            <th>Email</th>\r\n           <th>Role</th>\r\n            <th>Action</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
            EndContext();
#line 22 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
         foreach (var user in Model.ListUser)
        {

#line default
#line hidden
            BeginContext(575, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(615, 3, false);
#line 25 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
                Write(++i);

#line default
#line hidden
            EndContext();
            BeginContext(619, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(647, 10, false);
#line 26 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
               Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(657, 26, true);
            WriteLiteral("</td>\r\n               <td>");
            EndContext();
            BeginContext(684, 16, false);
#line 27 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
              Write(ListRole[i-1][0]);

#line default
#line hidden
            EndContext();
            BeginContext(700, 73, true);
            WriteLiteral("</td>\r\n                <td>\r\n\r\n                    \r\n                    ");
            EndContext();
            BeginContext(773, 163, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f548731b0193486bbf45e14a92dff80c", async() => {
                BeginContext(905, 27, true);
                WriteLiteral("<span class=\"ti-pencil\" /> ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
                                                                                                                                  WriteLiteral(user.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(936, 119, true);
            WriteLiteral("\r\n                    |\r\n                    <button class=\"btn btn-link btn-no-effect btn-danger deleteBtn \" data-id=\"");
            EndContext();
            BeginContext(1056, 7, false);
#line 33 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
                                                                                         Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1063, 83, true);
            WriteLiteral("\"> <span class=\"ti-trash\" /></button>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 37 "E:\1\NaturalCosmetics\NaturalCosmetics\NaturalCosmetics\Areas\Admin1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1157, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1199, 618, true);
                WriteLiteral(@"
    <script>

        $("".deleteBtn"").click((e) => {
            const id = $(e.target).data(""id"");
            if (!confirm(""Are you sure to delete?""))
                return;

            $.ajax({
                url: '/Admin1/Home/' + id,
                type: 'DELETE',
                success: () => {
                    const target = $(""#cake-"" + id);
                    $(target).fadeOut(500, () => $(target).remove());
                },
                error: (e) => {
                    alert(""Somthing Went Wrong"", e);
                }
            });
        });

    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NaturalCosmetics.Areas.Admin1.Models.ListIdentityUser> Html { get; private set; }
    }
}
#pragma warning restore 1591