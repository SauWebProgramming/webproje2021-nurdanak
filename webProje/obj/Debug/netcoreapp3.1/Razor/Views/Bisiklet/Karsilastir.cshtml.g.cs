#pragma checksum "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b3f080e76bf0a01c560e12709e6e400856ac3b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bisiklet_Karsilastir), @"mvc.1.0.view", @"/Views/Bisiklet/Karsilastir.cshtml")]
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
#line 1 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\_ViewImports.cshtml"
using webProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\_ViewImports.cshtml"
using webProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b3f080e76bf0a01c560e12709e6e400856ac3b3", @"/Views/Bisiklet/Karsilastir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"716cf960496013852bce6d2c9ccb91fbf808c73d", @"/Views/_ViewImports.cshtml")]
    public class Views_Bisiklet_Karsilastir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<webProje.Models.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bisiklet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bisiklet.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "KarsCikar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
  
    ViewData["Title"] = @localizer["Title"];

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3f080e76bf0a01c560e12709e6e400856ac3b36418", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b3f080e76bf0a01c560e12709e6e400856ac3b36680", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b3f080e76bf0a01c560e12709e6e400856ac3b37858", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3f080e76bf0a01c560e12709e6e400856ac3b39744", async() => {
                WriteLiteral("\r\n    <h1>\r\n        ");
#nullable restore
#line 17 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
   Write(localizer["liste"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </h1>\r\n    <h6>\r\n        ");
#nullable restore
#line 20 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
   Write(localizer["siralama"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </h6>\r\n    <table id=\"myTable\" class=\"border-dark\">\r\n        <tr>\r\n            <!--When a header is clicked, run the sortTable function, with a parameter, 0 for sorting by names, 1 for sorting by country:-->\r\n            <th onclick=\"sortTable(0)\">");
#nullable restore
#line 25 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["fotograf"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(1)\">");
#nullable restore
#line 26 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["marka"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(2)\">");
#nullable restore
#line 27 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["jantcapi"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(3)\">");
#nullable restore
#line 28 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["materyal"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(4)\">");
#nullable restore
#line 29 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["vitessayisi"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(5)\">");
#nullable restore
#line 30 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["kullanimalani"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(6)\">");
#nullable restore
#line 31 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["frenturu"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n            <th onclick=\"sortTable(7)\">");
#nullable restore
#line 32 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                  Write(localizer["suspansiyon"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
          
            var request = Convert.ToString(Context.Connection.RemoteIpAddress);
            var Kars = Model.KarsilastirmaVM.Where(x => x.KullaniciIp == (request));
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
         foreach (var bisiklet in Kars)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1b3f080e76bf0a01c560e12709e6e400856ac3b313899", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1622, "~/", 1622, 2, true);
#nullable restore
#line 43 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
AddHtmlAttributeValue("", 1624, bisiklet.BisikletId, 1624, 20, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1644, "-.png", 1644, 5, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(localizer[bisiklet.Marka]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
                                          Write(bisiklet.Model);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(bisiklet.JantCapi);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(localizer[bisiklet.Materyal]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(bisiklet.VitesSayisi);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(localizer[bisiklet.KullanimAlani]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(localizer[bisiklet.FrenTuru]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 64 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
               Write(localizer[bisiklet.SuspansiyonTuru]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b3f080e76bf0a01c560e12709e6e400856ac3b318224", async() => {
                    WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <input type=\"hidden\" class=\"form-control\" name=\"KarsId\"");
                    BeginWriteAttribute("value", " value=\"", 2597, "\"", 2621, 1);
#nullable restore
#line 69 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
WriteAttributeValue("", 2605, bisiklet.KarsId, 2605, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                        </div>\r\n                        <input type=\"submit\" style=\"background-color: #470520; color:aliceblue\" class=\"btn\"");
                    BeginWriteAttribute("value", " value=\"", 2766, "\"", 2793, 1);
#nullable restore
#line 71 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"
WriteAttributeValue("", 2774, localizer["cikar"], 2774, 19, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Jarvi\Desktop\webProje\webProje\Views\Bisiklet\Karsilastir.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function sortTable(n) {
        var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
        table = document.getElementById(""myTable"");
        switching = true;
        //Set the sorting direction to ascending:
        dir = ""asc"";
        /*Make a loop that will continue until
        no switching has been done:*/
        while (switching) {
            //start by saying: no switching is done:
            switching = false;
            rows = table.rows;
            /*Loop through all table rows (except the
            first, which contains table headers):*/
            for (i = 1; i < (rows.length - 1); i++) {
                //start by saying there should be no switching:
                shouldSwitch = false;
                /*Get the two elements you want to compare,
                one from current row and one from the next:*/
                x = rows[i].getElementsByTagName(""TD"")[n];
                y = rows[i + 1].getElementsByTagName(""TD"")[n];");
            WriteLiteral(@"
                /*check if the two rows should switch place,
                based on the direction, asc or desc:*/
                if (dir == ""asc"") {
                    if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                        //if so, mark as a switch and break the loop:
                        shouldSwitch = true;
                        break;
                    }
                } else if (dir == ""desc"") {
                    if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                        //if so, mark as a switch and break the loop:
                        shouldSwitch = true;
                        break;
                    }
                }
            }
            if (shouldSwitch) {
                /*If a switch has been marked, make the switch
                and mark that a switch has been done:*/
                rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                switching = true;
                //Ea");
            WriteLiteral(@"ch time a switch is done, increase this count by 1:
                switchcount++;
            } else {
                /*If no switching has been done AND the direction is ""asc"",
                set the direction to ""desc"" and run the while loop again.*/
                if (switchcount == 0 && dir == ""asc"") {
                    dir = ""desc"";
                    switching = true;
                }
            }
        }
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<webProje.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
